﻿using System;
using Xamarin.Forms;

namespace iBucketList
{
    public partial class AddGoal : ContentPage
    {
        public AddGoal()
        {
            InitializeComponent();
        }

        async void OnDismissButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }

        async void CreateGoal(object sender, EventArgs args)
        {
            Goal goal = new Goal()
            {
                title = this.goalNameText.Text,
                description = this.goalDescriptionText.Text,
                deadline = this.goaldeadlineText.Date
            };
<<<<<<< HEAD
            AppState.goals.Add(goal);
=======

            await AppState.Goals.AddAsync(goal);
>>>>>>> origin/master
            await Navigation.PopModalAsync();
        }

    }
}


//corresponds to the modal
//describing the pop-up