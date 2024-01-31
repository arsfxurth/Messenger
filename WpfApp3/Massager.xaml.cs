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
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Massager.xaml
    /// </summary>
    public partial class Massager : Window
    {
        public Massager()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            users user1 = new users("Биба", "123", "123");
            users user2 = new users("Боба", "456","456");
            user1.Messages.Add(Mes.Text);
            ya.Text += user1.Name + "\n";
            ya.Text += Mes.Text + "\n\n\n\n";
            Mes.Text = "";
        }
    }
}
