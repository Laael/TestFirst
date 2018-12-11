using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFirst.ViewModels;
using Xamarin.Forms;

namespace TestFirst.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPageViewModel ViewModel
        {
            get
            {
                return BindingContext as MainPageViewModel;
            }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
         {
            var x = e.Item as ImageCell;
            ViewModel.DoCellClicked(x);
         }
    }
}