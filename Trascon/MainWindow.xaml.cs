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
using System.Collections.ObjectModel;

namespace Trascon
{
    
    public partial class MainWindow : Window
    {
        MainVM mainVM = new MainVM();

        public MainWindow()
        {
            InitializeComponent();
            
            this.DataContext = mainVM;
            ShowWindow showWindow = new ShowWindow
            {
                DataContext = this.DataContext
            };
            showWindow.Show();

            this.Closed += MainWindow_Closed;
        }

        private void MainWindow_Closed(object sender, EventArgs e)
        {
            // закрытие всех окон
            Application.Current.Shutdown();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            //подсчет медали и сохранение в XML
            Man man = cboMen.SelectedItem as Man;
            man.Medal= man.WhichMedal(man);
            mainVM.SaveToXML();
        }        
    }
}
