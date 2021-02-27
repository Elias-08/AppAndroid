using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAndroid
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

        private void OnClick(object sender, EventArgs e)
        {
            var button = sender as Button;

            //Aunque se puede hacer de esta manera en propiedades Adjuntas, no es buena practica
            //Algunas como el grid ya tienen propiedad GetValue y SetValue

            //var column = (int)button.GetValue(Grid.ColumnProperty);

            //if (column==0)
            //{
            //    button.SetValue(Grid.ColumnProperty, 1);
            //}
            //else
            //{
            //    button.SetValue(Grid.ColumnProperty, 0);
            //}

            if (Grid.GetColumn(button)==0)
            {
                Grid.SetColumn(button, 1);
            }
            else
            {
                Grid.SetColumn(button, 0);

            }

            //es mejor utilizar los getters/setters de las propiedades adjuntas.
        }
    }
}