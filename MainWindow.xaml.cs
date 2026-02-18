using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Conversion_Moneda_Prueba
{
    public partial class MainWindow : Window
    {

        // Programa hecho: Alex Hatton, Matricula: 100672673, INF5120---17/2/26 

        // Diccionario que almacena las monedas y sus tasas de cambio relativas al dólar (USD)
        private Dictionary <string, double> tasas = new Dictionary <string, double>
        {
            { "USD - Dólar",         1.0     },
            { "EUR - Euro",          0.85    },
            { "DOP - Peso dominicano", 61.26 },
            { "MXN - Peso mexicano", 17.5    },
            { "COP - Peso colombiano", 3666  },
            { "ARS - Peso argentino", 1450   },
            { "CLP - Peso chileno",  875     },
            { "PEN - Sol peruano",   3.35    },
            { "BRL - Real brasileño", 5.3    },
            { "GBP - Libra esterlina", 1.36  },
            { "JPY - Yen japonés",   156     }
        };

        public MainWindow()
        {
            InitializeComponent();

            // Cargamos las monedas en los ComboBox al iniciar la aplicación
            CargarMonedas();
        }

        // Método que llena ambos ComboBox con las monedas del diccionario
        private void CargarMonedas()
        {
            // Obtenemos las claves del diccionario como lista
            var lista = new List<string>(tasas.Keys);

            // Asignamos la misma lista a ambos ComboBox
            Pais_Origen.ItemsSource = lista;
            Pais_Destino.ItemsSource = lista;
        }

        // Se ejecuta al presionar el botón "Convertir"
        private void Conversion_Moneda_Click(object sender, RoutedEventArgs e)
        {
            // Si alguno de los ComboBox no tiene selección, no hacemos nada
            if (Pais_Origen.SelectedItem == null || Pais_Destino.SelectedItem == null)
                return;

            // Si el texto ingresado no es un número válido, no hacemos nada
            if (!double.TryParse(Cantidad_Origen.Text, out double cantidad))
                return;

            // Obtenemos las monedas seleccionadas por el usuario
            string origen = Pais_Origen.SelectedItem!.ToString()!;
            string destino = Pais_Destino.SelectedItem!.ToString()!;

            double resultado = (cantidad / tasas[origen]) * tasas[destino];

            // Panel para mostrar el resultado de forma ordenada en el Label
            var panel = new StackPanel { Margin = new Thickness(10) };

            // Se muestra la cantidad ingresada con su moneda de origen
            panel.Children.Add(new TextBlock
            {
                Text = $"{cantidad:N2} {origen}",
                FontSize = 15,
                Margin = new Thickness(0, 0, 0, 10),
                FontWeight = FontWeights.Bold,
                Foreground = Brushes.DarkGreen
            });

            panel.Children.Add(new TextBlock
            {
                Text = "▼",
                FontSize = 16,
                Margin = new Thickness(0, 0, 0, 10)
            });

            // Se muestra la cantidad convertida de la moneda de destino
            panel.Children.Add(new TextBlock
            {
                Text = $"{resultado:N2} {destino}",
                FontSize = 15,
                FontWeight = FontWeights.Bold,
                Foreground = Brushes.DarkGreen
            });

            // Asignamos el panel al Label de resultado para mostrarlo en pantalla
            Resultado_Conversion.Content = panel;
        }

        // Evento del ComboBox de origen: limpia el resultado si el usuario cambia la moneda
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Resultado_Conversion?.Content = "";
        }

        // Evento del ComboBox de destino: limpia el resultado si el usuario cambia la moneda
        private void Conversion_Pais_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Resultado_Conversion?.Content = "";
        }
    }
}