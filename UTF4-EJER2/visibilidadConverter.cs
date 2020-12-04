using System;

using System.Globalization;

using System.Windows.Data;

namespace UTF4_EJER2
{
    public class visibilidadConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            string visibiladad = "";
            if ((bool)value)
            {
                visibiladad = "Visible";
            }
            else
                visibiladad = "Collapsed";

            return visibiladad;


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
