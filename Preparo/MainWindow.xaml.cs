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

namespace Preparo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Pessoa> pessoa = new List<Pessoa>();
        public MainWindow()
        {
            InitializeComponent();

            pessoa.Add(new Pessoa { FirstName = "Rodrigo", LastName = "Bianchini"});
            pessoa.Add(new Pessoa { FirstName = "Ana", LastName = "Gantois" });


        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Successfully Logged In as {userNameText.Text}");
        }

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Successfully Registered");
        }
    }
}
