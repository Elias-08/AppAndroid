using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppAndroid
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Al inicializar este componente que esta en el lenguaje Xaml le cambio el color desde aca
            lblPrincipal.TextColor = Color.Blue;
            var x = lblPrincipal.Width;
        }

        private void OnClick(object sender, EventArgs e)
        {
            //En esta condicional con Getvalueobtengo el valor o color de lbl y con set value le mando un nuevo color
            if ((Color) lblPrincipal.GetValue(Label.TextColorProperty)== Color.Blue)
            {
                lblPrincipal.SetValue(Label.TextColorProperty, Color.Red);
            }
            else if((Color)lblPrincipal.GetValue(Label.TextColorProperty) == Color.Red)
            {
                lblPrincipal.SetValue(Label.TextColorProperty, Color.Aqua);
            } 
            else if ((Color)lblPrincipal.GetValue(Label.TextColorProperty) == Color.Aqua)
            {
                lblPrincipal.SetValue(Label.TextColorProperty, Color.BlueViolet);
            }
            else if ((Color)lblPrincipal.GetValue(Label.TextColorProperty) == Color.BlueViolet)
            {
                lblPrincipal.SetValue(Label.TextColorProperty, Color.Gold);

            }
            else if ((Color)lblPrincipal.GetValue(Label.TextColorProperty) == Color.Gold)
            {
                lblPrincipal.SetValue(Label.TextColorProperty, Color.Blue);
            }

        }

        //Este metodo me sirve para navegar a mi otra pagina
        async void OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }


        //Este es una manera de invocar un Metodo, Tambien desde el constructor 
        //se  puede llamar el nombre de Objeto EJ: Boton.Clicked += y el nombre del Evento, asi no llamarlo desde XAML
        private void Hora(object sender, EventArgs e)
        {
            lblSencundario.TextColor = Color.Black;
            lblSencundario.Text = "La Hora y fecha es : " + DateTime.Now.ToString();
        }
    }
}
