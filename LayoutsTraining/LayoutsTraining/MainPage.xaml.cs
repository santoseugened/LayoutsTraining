﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutsTraining
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Login_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayout());
        }
    }
}
