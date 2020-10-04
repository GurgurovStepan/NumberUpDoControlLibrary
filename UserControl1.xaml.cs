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

namespace NumberUpDoControlLibrary
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            field.Text = logic.Value.ToString();
        }

        Logics logic = new Logics();
        private void up_Click(object sender, RoutedEventArgs e)
        {
           int temp = logic.UpValue;
            field.Text = temp.ToString();
        }

        private void down_Click(object sender, RoutedEventArgs e)
        {
            int temp = logic.DownValue;
            field.Text = temp.ToString();
        }
    }
}
