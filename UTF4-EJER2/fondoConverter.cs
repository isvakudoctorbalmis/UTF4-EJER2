using System;
using System.Globalization;
using System.Windows.Data;

namespace UTF4_EJER2
{
    public class fondoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {             
            
            string color="";
            if ((bool)value)
            {
                color = "PaleGreen";
            }
            else
                color = "IndianRed";

            return color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
