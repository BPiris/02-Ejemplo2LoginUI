using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _02_Ejemplo2Login.Vistas
{
    public class LoginApp: ContentPage
    {
        public LoginApp ()
        {
            var etiqueta = new Label
            {
                Text = "Acceso a la plataforma",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Italic,
                TextColor = Color.Aqua
            };

            var inputUsuario = new Entry
            {
                Placeholder = "Introduzca su usuario"
            };

            var inputPassword = new Entry
            {
                Placeholder = "Introduzca su password"
            };

            var etiquetaBorde = new Frame
            {
                OutlineColor = Color.Purple,
                Content = etiqueta
            };

            var btnLogin = new Button
            {
                Text = "Enviar"                
            };

            btnLogin.Clicked += (sender, args) =>
            {
                DisplayAlert("Boom1", "Boom2", "Exploto");
            };

            var cajaBordeInput = new Frame
            {
                Content = new StackLayout
                {
                    Children = { inputUsuario, inputPassword }
                }
            };

            var imagen = new Image
            {
                Aspect = Aspect.AspectFill
            };

            imagen.Source = "https://3.bp.blogspot.com/_UqUwVPikChs/R-C-tHbATUI/AAAAAAAAC_A/CrGGzjyLi14/s320/wyvern-luke-tuxwalker-1944.png";

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children =
                {
                    imagen,etiquetaBorde, cajaBordeInput, btnLogin
                }
            };
        }
    }
}
