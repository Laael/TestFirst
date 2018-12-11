using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TestFirst.Helpers;
using System.Linq;

namespace TestFirst.Services
{
    public static class UserContext
    {
        public static IEnumerable<ImageCell> Images
        {
            get
            {
                if(_Images.ToList().Count > 0)
                { 
                    return _Images;
                }
                else
                {
                    Console.WriteLine(Constants.CollectionIsEmpty);
                    return new ObservableCollection<ImageCell>();
                }
            }
            set
            {
                _Images = value;
            }
        }
        private static IEnumerable<ImageCell> _Images { get; set; }
        public static ImageCell SelectedCell { get; set; }
       
    }
}
