using System;
using System.Collections.ObjectModel;
namespace iBucketList
{
    public static class AppState
    {

        public static PersistedList<Goal> Goals = new PersistedList<Goal>("goals");

    }
}
