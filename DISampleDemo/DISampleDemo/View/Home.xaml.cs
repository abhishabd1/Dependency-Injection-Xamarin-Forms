using DISampleDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DISampleDemo.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : ContentPage
	{
		public Home ()
		{
			InitializeComponent ();
            // BindingContext = new StudentViewModel();
            try
            {
                BindingContext = App.Locator.StudentViewModel;

            }
            catch(Exception ex)
            {
                
            }

        }
	}
}