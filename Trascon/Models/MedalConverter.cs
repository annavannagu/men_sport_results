using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Trascon
{
    public class MedalConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int imageIndex;
            if (int.TryParse(value.ToString(), out imageIndex))
            {
                switch(imageIndex)
                {
                    case 0: return "Images/None.png";
                    case 1: return "Images/Bronze.png";                        
                    case 2: return "Images/Silver.png";                        
                    case 3: return "Images/Gold.png";
                }                
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
