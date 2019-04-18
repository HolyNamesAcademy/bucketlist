using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace iBucketList
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Goal> Goals { get; set; }

        public MainPage()
        {
            InitializeComponent();


            this.GoalsList.ItemsSource = AppState.Goals.InnerList;
        }

        async void ShowAddGoalPopup(object sender, SelectedItemChangedEventArgs e)
        {
            var detailPage = new AddGoal();
            await Navigation.PushModalAsync(detailPage);
        }

        public void TapToDelete(object sender, ItemTappedEventArgs args)
        {
            AppState.Goals.InnerList.Remove((Goal)args.Item);
        }
    }

}

