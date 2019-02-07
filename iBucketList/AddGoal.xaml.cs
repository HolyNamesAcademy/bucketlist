using System;
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
    }
}

//corresponds to the modal
//describing the pop-up

