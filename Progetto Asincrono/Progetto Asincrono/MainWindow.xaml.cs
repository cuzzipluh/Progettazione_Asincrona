using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Progetto_Asincrono
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string lettere_alfabeto;
        string _frase;
        string LunghezzaParola;
        public MainWindow()
        {
            InitializeComponent();
            generaNumeri();
        }

        private async void generaNumeri()
        {
             string[] alfa = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            {
                int Tmp = 0;
                while (true)
                {
                    Tmp++;
                    if (Tmp >= 25)
                    {
                        Tmp = 0;
                    }
                    await Task.Delay(100);
                    lettere_alfabeto = alfa[Tmp];
                    lblAlfabeto.Content = lettere_alfabeto;
                }


            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LunghezzaParola = Txblunghezza.Text;
            _frase += lettere_alfabeto;
            lblfrase.Content = _frase;

            if (int.TryParse(Txblunghezza.Text, out int lunghezzaTarget))
            {
                if (_frase.Length >= lunghezzaTarget)
                {
                    AggiungiAllaLista(_frase);

                }
                
            }
        }

        private void AggiungiAllaLista(string parola)
        {
            lstParole.Items.Add(parola);

            _frase = "";
            lblfrase.Content = _frase;
        }

       
    }
}