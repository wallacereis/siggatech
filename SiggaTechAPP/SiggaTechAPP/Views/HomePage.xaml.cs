﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SiggaTechAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private void RefreshView_Refreshing(object sender, System.EventArgs e)
        {

        }
    }
}