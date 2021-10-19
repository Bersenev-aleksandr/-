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

namespace Калькулятор_зп
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtOkl_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            txtOkl.Text = "";
            TxtKof.Text = "";
            TxtOtrabDni.Text = "";
            TxtPrem.Text = "";
            TxtRabDni.Text = "";
        }

        private void BtnRasch_Click(object sender, RoutedEventArgs e)
        {
            int O = Convert.ToInt32(txtOkl.Text);
            int P = Convert.ToInt32(TxtPrem.Text);
            int K = Convert.ToInt32(TxtKof.Text);
            int R = Convert.ToInt32(TxtRabDni.Text);
            int Ot = Convert.ToInt32(TxtOtrabDni.Text);
            double fullZP = O * K * Ot /(R + P);
            double NDFL = fullZP * 0.13;
            double Zpruk = fullZP - NDFL;
            Vivod taskWindow = new Vivod();
            taskWindow.lbl_fullzp.Content = Convert.ToString(fullZP);
            taskWindow.lbl_NDFL.Content = Convert.ToString(NDFL);
            taskWindow.lbl_Zpruk.Content = Convert.ToString(Zpruk);
            taskWindow.Show();
        }
    }
}
