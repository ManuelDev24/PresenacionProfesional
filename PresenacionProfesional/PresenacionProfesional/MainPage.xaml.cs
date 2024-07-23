using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace PresenacionProfesional
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnveryoutube_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://www.youtube.com/@bobesponjaespanol", BrowserLaunchMode.SystemPreferred);
        }

        private async void btnverlinkedin_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://www.linkedin.com/feed/", BrowserLaunchMode.SystemPreferred);
        }

        private async void btnvertwitter_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://x.com/SpongeBob", BrowserLaunchMode.SystemPreferred);
        }

        private async void btnverinstagrams_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://www.instagram.com/bob.sponge_/", BrowserLaunchMode.SystemPreferred);
        }

        private async void btnverfacebook_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://www.facebook.com/bobleponge/?brand_redir=42798291365", BrowserLaunchMode.SystemPreferred);
        }
    }
}
