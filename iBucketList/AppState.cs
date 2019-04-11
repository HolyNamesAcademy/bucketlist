using System;
using System.Collections.ObjectModel;
namespace iBucketList
{
    public static class AppState
    {
<<<<<<< HEAD:iBucketList.Core/AppState.cs
        public static ObservableCollection<Goal> goals = new ObservableCollection<Goal>();
=======
        public static PersistedList<Goal> Goals = new PersistedList<Goal>("goals");
>>>>>>> origin/master:iBucketList/AppState.cs
    }
}
