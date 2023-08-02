using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace WebsiteInner.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private string _websiteSource;

        public string WebsiteSource
        {
            get { return _websiteSource; }
            set
            {
                _websiteSource = value;
                OnPropertyChanged();
            }
        }

        public MainPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            WebsiteSource = "file:///android_asset/hostit/index.html";
        }
    }
}
