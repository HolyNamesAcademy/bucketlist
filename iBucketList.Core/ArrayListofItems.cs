
using System;
using System.Collections;
using System.Collections.Generic;
namespace iBucketList
{
    public class ArrayListofItems
    {
        List<Goal> goals;
        public ArrayListofItems()
        {
            goals = new List<Goal>();
        }

        public void AddGoal(Goal newGoal)
        {
            goals.Add(newGoal);
        }

        public void RemoveGoal(Goal oldGoal)
        {
            goals.Remove(oldGoal);
        }

        public List<Goal> GetAllGoals()
        {
            return goals;
        }
    }
}
