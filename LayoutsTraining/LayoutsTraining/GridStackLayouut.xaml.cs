﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutsTraining
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridStackLayouut : ContentPage
    {
        public GridStackLayouut()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridLayout());
        }
    }
}