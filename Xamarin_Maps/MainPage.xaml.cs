using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Xamarin_Maps
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void ButtonOpen(object sender, EventArgs e)
        {
            if (!double.TryParse(EntryLatitude.Text, out double lat))
                return;
            if (!double.TryParse(EntryLongitude.Text, out double lng))
                return;
            Map.OpenAsync(lat, lng, new MapLaunchOptions
            {

                Name = Name_USER.Text,
                NavigationMode = NavigationMode.Driving


            });
        }

      
    }

}
