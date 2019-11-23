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

namespace FlatPayment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Fee Fee { get; set; } = new Fee();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Pay(object sender, RoutedEventArgs e)
        {
            if(iinTextBox.Text == string.Empty)
            {
                MessageBox.Show("Введите ИИН!");
            }
            else if(phoneTextBox.Text == string.Empty)
            {
                MessageBox.Show("Введите номер телефона!");
            }
            else if (streetTextBox.Text == string.Empty)
            {
                MessageBox.Show("Введите название улицы!");
            }
            else if (houseTextBox.Text == string.Empty)
            {
                MessageBox.Show("Введите номер дома!");
            }
            else if (flatTextBox.Text == string.Empty)
            {
                MessageBox.Show("Введите номер квартиры!");
            }
            else if (paymentTextBox.Text == string.Empty || Convert.ToInt32(paymentTextBox.Text) <= 0)
            {
                MessageBox.Show("Введите корректную сумму платежа!");
            }
            
            using (var context = new Context())
            {
                context.Fees.Add(Fee);
                context.SaveChanges();
            }
        }

        private void FeeTypeComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Fee.FeeType = (FeeType)feeTypeComboBox.SelectedIndex;
        }
    }
}
