using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema2_CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NombreTextBox.Tag = MensajeAyuda1TextBlock;
            ApellidoTextBox.Tag = MensajeAyuda2TextBlock;
        }

        private void TextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.F1)
            {
                TextBlock texto = (TextBlock)(sender as TextBox).Tag;
                if (texto.Visibility == Visibility.Hidden)
                    texto.Visibility = Visibility.Visible;
                else
                    texto.Visibility = Visibility.Hidden;
            }
        }

        private void EdadTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.F2)
            {
                if (int.TryParse((sender as TextBox).Text, out _))
                    MensajeEdadTextblock.Text = "";
                else
                    MensajeEdadTextblock.Text = "Edad incorrecta";
            }
        }
    }
}
