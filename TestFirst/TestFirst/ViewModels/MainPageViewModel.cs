using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestFirst.Services;
using Xamarin.Forms;

namespace TestFirst.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public IEnumerable<ImageCell> Images
        {
            get => UserContext.Images;
            set
            {
                UserContext.Images = value;
            }
        }

        public DelegateCommand<ImageCell> ItemClicked
        {
            get;
            private set;
        }
        
        public Command RefreshCommand { get; set; }

        public bool Refreshing
        {
            get => _Refreshing;
            set
            {
                _Refreshing = value;
                RaisePropertyChanged(nameof(Refreshing));
            }
        }
        private bool _Refreshing { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            RefreshCommand = new Command(Refresh);
            ItemClicked = new DelegateCommand<ImageCell>(DoCellClicked);
            Title = "List";
            GetImages();
        }

        public async void DoCellClicked(ImageCell cell)
        {
            UserContext.SelectedCell = cell;
            await NavigationService.NavigateAsync("DetailPage");
        }


        public void GetImages()
        {
            Console.WriteLine("________Loading_________");
            ServerContext.GetImages();
            RaisePropertyChanged(nameof(Images));
        }
       
        public void Refresh()
        {
            GetImages();
            Refreshing = false;
        }

    }
}
