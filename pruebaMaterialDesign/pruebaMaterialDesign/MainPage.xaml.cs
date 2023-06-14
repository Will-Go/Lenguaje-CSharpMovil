using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pruebaMaterialDesign
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Producto> productos;
        public MainPage()
        {
            InitializeComponent();
            productos = new ObservableCollection<Producto>();

            productos.Add(new Producto("Carne", "https://images.vexels.com/media/users/3/257686/isolated/preview/31e8ec7bac8a2badc650686ca699697b-comida-de-filete-de-carne-de-vaca.png"));

            productos.Add(new Producto("Naranja", "https://images.vexels.com/media/users/3/143191/isolated/preview/925871db899c05172adae868b7ca93c0-icono-de-color-naranja.png"));

            listas.ItemsSource = productos;


        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string nombre = await DisplayPromptAsync("Question", "Escribe el nombre del producto", keyboard:Keyboard.Text);
            productos.Add(new Producto(nombre, "https://img.freepik.com/premium-vector/paper-bag-with-food-grocery-delivery-concept-vector-illustration-cartoon-style_650087-41.jpg"));
        }
    }
}
