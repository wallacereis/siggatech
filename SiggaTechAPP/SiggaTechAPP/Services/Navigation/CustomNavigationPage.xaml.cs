﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SiggaTechAPP.Services.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomNavigationPage : NavigationPage
    {
        public CustomNavigationPage()
        {
            InitializeComponent();
        }

        public CustomNavigationPage(Page root) : base(root)
        {
            InitializeComponent();
        }
    }
}