using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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
    /// Interaction logic for NewMan.xaml
    /// </summary>
    public partial class NewMan : Window, INotifyPropertyChanged
    {
        public NewMan()
        {
           InitializeComponent();
        }

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        private string _responseName = "";
        public string ResponseName
        {
            get { return _responseName; }
            set {
                if (value == _responseName) return;
                _responseName = value;
                OnPropertyChanged(nameof(ResponseName));
            }
        }

        private int _responseGroup;
        public int ResponseGroup
        {
            get { return _responseGroup; }
            set {
                if (value == _responseGroup) return;
                _responseGroup = value;
                OnPropertyChanged(nameof(ResponseGroup));
                }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }

    public class GroupRangeRule : ValidationRule
    {
        private int _min;
        private int _max;

        public GroupRangeRule()
        {
        }

        public int Min
        {
            get { return _min; }
            set { _min = value; }
        }

        public int Max
        {
            get { return _max; }
            set { _max = value; }
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int group = 0;

            try
            {
                if (((string)value).Length > 0)
                    group = Int32.Parse((String)value);
            }
            catch (Exception)
            {
                return new ValidationResult(false, "Номер группы должен быть числом");
            }

            if ((group < Min) || (group > Max))
            {
                return new ValidationResult(false,
                  "Пожалуйста введите номер группы в диапазоне: " + Min + " - " + Max + ".");
            }
            else
            {
                return new ValidationResult(true, null);
            }
        }
    }
}
