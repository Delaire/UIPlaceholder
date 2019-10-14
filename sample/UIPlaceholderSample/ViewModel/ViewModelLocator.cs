using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIPlaceholderSample.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {

            SimpleIoc.Default.Register<MainPageViewModel>();
        }
    }
}
