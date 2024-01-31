using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static SqlConnection conn;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            conn = new SqlConnection(@"Data Source=3205EC02\SQLEXPRESS; Initial Catalog = Usersx; Integrated Security= SSPI;");
            conn.Open();
            users user1 = new users("Биба", "123", "123");
            users user2 = new users("Боба", "456", "456");
            if (user1.Login == Loginx.Text && user1.Password == Passwordx.Text)
            {
                

                Massager massager = new Massager();
                massager.Show();
                Close();
            }
            else if (user2.Login == Loginx.Text && user2.Password == Passwordx.Text)
            {
                Massager massager = new Massager();
                massager.Show();
                Close();
            }
            else
            {
                error.Text = "Ошибка";
            }
            
        }
    }
}
