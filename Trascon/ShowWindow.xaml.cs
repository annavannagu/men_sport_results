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

namespace Trascon
{
    /// <summary>
    /// Interaction logic for ShowWindow.xaml
    /// </summary>
    public partial class ShowWindow : Window
    {
        public ShowWindow()
        {
            InitializeComponent();            
        }

        private void CollectionViewSource_Filter6(object sender, FilterEventArgs e)
        {
            Man man = e.Item as Man;
            if (man != null)
            {
                if (man.Group == 6)
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }

        private void CollectionViewSource_Filter7(object sender, FilterEventArgs e)
        {
            Man man = e.Item as Man;
            if (man != null)
            {
                if (man.Group == 7)
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }

        private void CollectionViewSource_Filter8(object sender, FilterEventArgs e)
        {
            Man man = e.Item as Man;
            if (man != null)
            {
                if (man.Group == 8)
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }

        private void CollectionViewSource_Filter9(object sender, FilterEventArgs e)
        {
            Man man = e.Item as Man;
            if (man != null)
            {
                if (man.Group == 9)
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }

        private void CollectionViewSource_Filter10(object sender, FilterEventArgs e)
        {
            Man man = e.Item as Man;
            if (man != null)
            {
                if (man.Group == 10)
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }

        private void CollectionViewSource_Filter11(object sender, FilterEventArgs e)
        {
            Man man = e.Item as Man;
            if (man != null)
            {
                if (man.Group == 11)
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }

        private void CollectionViewSource_Filter(object sender, FilterEventArgs e)
        {
            List<Man> man = e.Item as List<Man>;
            if (man != null)
            {
                //if (man.IndexOf() == 11)
                //{
                //    e.Accepted = true;
                //}
                //else
                //{
                //    e.Accepted = false;
                //}
            }
        }
    }
}
