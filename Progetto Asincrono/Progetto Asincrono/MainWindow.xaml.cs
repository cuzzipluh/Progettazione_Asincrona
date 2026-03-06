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

namespace Progetto_Asincrono
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            generaNumeri();


        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async Task generaNumeri()
        {
             string[] alfa = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string lettere_alfabeto;
            {
                int Tmp = 0;
                while (true)
                {
                    Tmp++;
                    if (Tmp >= 25)
                    {
                        Tmp = 26;
                    }
                    await Task.Delay(100);
                    lettere_alfabeto = alfa[Tmp];
                    lblAlfabeto.Content = lettere_alfabeto;
                }


            }
        }



    }
}