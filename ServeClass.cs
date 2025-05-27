using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace DST
{
    static class ServeClass
    {
        public static byte precisionResults { set; get; } = 3;
        public static byte precisionVCF { set; get; } = 4;
        public static byte precisionDensity { set; get; } = 4;
        public static byte precisionPercent { set; get; } = 2;
        public static byte precisionTemp { set; get; } = 2;

        /// <summary>
        /// Из Double в String + аргумент: количество знаков после запятой в расчётах.
        /// </summary>
        public static string Dbl_Str_InResult(this double x)
        {
            return string.Format("{0:f" + precisionResults + "}", Check_Infinity_NaN(x));
        }

        /// <summary>
        /// VCF. Из Double в String + аргумент: количество знаков после запятой.
        /// </summary>
        public static string Dbl_Str_VCF_AP(this double x)
        {
            return string.Format("{0:f" + precisionVCF + "}", Check_Infinity_NaN(x));
        }

        /// <summary>
        /// ПЛОТНОСТЬ. Из Double в String + аргумент: количество знаков после запятой.
        /// </summary>
        public static string Dbl_Str_D_AP(this double x)
        {
            return string.Format("{0:f" + precisionDensity + "}", Check_Infinity_NaN(x));
        }

        /// <summary>
        ///  ПРОЦЕНТЫ. Из Double в String + аргумент: количество знаков после запятой.
        /// </summary>
        public static string Dbl_Str_Percent_AP(this double x)
        {
            return string.Format("{0:f" + precisionPercent + "}", Check_Infinity_NaN(x)) + "%";
        }

        /// <summary>
        ///  ТЕМПЕРАТУРА. Из Double в String + аргумент: количество знаков после запятой.
        /// </summary>
        public static string DoubleToStringForTempWithSetPrecision(this double x)
        {
            return string.Format("{0:f" + precisionTemp + "}", Check_Infinity_NaN(x));
        }

        /// <summary>
        /// Из String в Double
        /// </summary>
        public static double StringToDouble(this string strValue)
        {
            double.TryParse(strValue, out double value);
            return Check_Infinity_NaN(value);
        }

        /// <summary>
        /// Из String в Int
        /// </summary>
        public static int String_Int(this string s)
        {
            int.TryParse(s, out int value);
            return value;
        }

        /// <summary>
        /// Проверка числа на БЕСКОНЕЧНОСТЬ и ЯВЛЯЕТСЯ ЛИ ЧИСЛОМ.
        /// </summary>
        public static double Check_Infinity_NaN(this double check_value)
        {
            if (!double.IsInfinity(check_value) && !double.IsNaN(check_value))
                return check_value;
            else
                return 0D;

        }

        #region Функции Key_Char, Key_Char_Plus, Key_Char_Int
        //Определяет знак десятичного разделителя используемый системой       
        private static readonly char NumberDecimalSeparator = 
            Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

        public static void InputDoubleOnlyPositive(object sender, KeyPressEventArgs e)
        {
            if (isCharDigitOrControl(e))
                return;
            else if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = NumberDecimalSeparator;
                if ((sender as TextBox).Text.IndexOf(NumberDecimalSeparator) != -1)
                    e.Handled = true;
                else
                    return;
            }
            else
                e.Handled = true;
        }

        public static void InputDoubleWithNegative(object sender, KeyPressEventArgs e)
        {
            if (isCharDigitOrControl(e))
                return;
            else if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = NumberDecimalSeparator;
                if ((sender as TextBox).Text.IndexOf(NumberDecimalSeparator) != -1)
                    e.Handled = true;
                else
                    return;
            }
            else if (e.KeyChar == '-')
            {
                if ((sender as TextBox).Text.IndexOf('-') != -1)
                    e.Handled = true;
                else
                    return;
            }
            else
                e.Handled = true;
        }
        //Ввод только целочисленных значений.
        public static void InputOnlyInt(KeyPressEventArgs e)
        {
            if (isCharDigitOrControl(e))
                return;
            else
                e.Handled = true;
        }
        private static bool isCharDigitOrControl(KeyPressEventArgs e)
        {
            return Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar);
        }
        #endregion

        // Определяет каким будет цвет текста содержимого TextBox (+красный и 0- синий) 
        public static void ChangeTextColor(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.StringToDouble() > 0.0)
                (sender as TextBox).ForeColor = Color.FromArgb(255, 128, 128); //красный
            else
                (sender as TextBox).ForeColor = Color.FromArgb(120, 150, 255); //синий
        }
    }
}
