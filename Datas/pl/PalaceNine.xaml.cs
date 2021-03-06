﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PTSSRU.Datas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PalaceNine : ContentPage
    {
        public PalaceNine()
        {
            InitializeComponent();
        }
        private async void Gogo(object sender, EventArgs e)
        {
            var result = await DisplayAlert("ไปอาคารศศิพงษ์ประไพ", "คุณต้องการดำเนินการต่อหรือไม่", "Ok", "Cancel");
            if (result == true) // if it's equal to Ok
            {
                if (Device.RuntimePlatform == Device.iOS)
                {
                    // https://developer.apple.com/library/ios/featuredarticles/iPhoneURLScheme_Reference/MapLinks/MapLinks.html
                    await Launcher.OpenAsync("http://maps.apple.com/?saddr&daddr=13.77688664894465,100.50833784595605");
                }
                else if (Device.RuntimePlatform == Device.Android)
                {


                    // opens the Maps app directly
                    await Launcher.OpenAsync("http://maps.google.com/?saddr&daddr=13.77688664894465,100.50833784595605");
                }
            }
            else
            {
                return;
            }
            

        }
    }
}