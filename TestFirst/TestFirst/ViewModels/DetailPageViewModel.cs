using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using TestFirst.Services;

namespace TestFirst.ViewModels
{
	public class DetailPageViewModel : ViewModelBase
	{
        public ImageCell SelectedImage
        {
            get => UserContext.SelectedCell;
            set => UserContext.SelectedCell = value;
        }

        public DetailPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }
	}
}
