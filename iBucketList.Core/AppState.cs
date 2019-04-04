using System;
using System.Collections.ObjectModel;
namespace iBucketList
{
    public static class AppState
    {
        public static ObservableCollection<Goal> goals = new ObservableCollection<Goal>();
    }
}
