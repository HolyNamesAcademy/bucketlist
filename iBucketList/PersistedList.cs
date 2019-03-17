using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace iBucketList
{
    public class PersistedList<T>
    {
        public ObservableCollection<T> InnerList { get; }

        private readonly string key;

        public PersistedList(string key)
        {
            this.key = key;

            if (App.Current.Properties.TryGetValue(this.key, out object value) && value is string json)
            {
                this.InnerList = JsonConvert.DeserializeObject<ObservableCollection<T>>(json);
            }
            else
            {
                this.InnerList = new ObservableCollection<T>();
            }
        }

        public async Task AddAsync(T item)
        {
            this.InnerList.Add(item);
            await this.SaveChanges();
        }

        public async Task RemoveAsync(T item)
        {
            this.InnerList.Remove(item);
            await this.SaveChanges();
        }

        private async Task SaveChanges()
        {
            string json = JsonConvert.SerializeObject(this.InnerList);
            App.Current.Properties[this.key] = json;

            await App.Current.SavePropertiesAsync();
        }
    }
}
