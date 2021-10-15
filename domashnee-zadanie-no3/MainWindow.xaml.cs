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

namespace domashnee_zadanie_no3
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            List<char> alphavit = new List<char> { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ', 'э', 'ю', 'я' };
            List<char> alphavit2 = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string a = tbInput.Text;
            string result = a.ToString();
            string newresult = "";
            //надо понять, слово на русском или на английском
            if (alphavit2.Contains(result[0])) 
                newresult = Atbash(alphavit2, result, newresult);
            else
                newresult = Atbash(alphavit, result, newresult);
            tbOutput.Text = newresult;

        }

        private static string Atbash(List<char> alphavit, string result, string newresult)
        {
            for (int i = 0; i < result.Length; i++)
            {

                int k = 0;
                int reg = 0;//флаг для регистра
                if (char.IsUpper(result, i))
                {
                    reg++;

                }

                string K = result[i].ToString().ToLower();

                while ((result[i].ToString()).ToLower() != alphavit[k].ToString())
                {
                    k++;
                }
                if (reg > 0)
                    newresult += (alphavit[alphavit.Count - k - 1].ToString()).ToUpper();
                else
                {
                    newresult += alphavit[alphavit.Count - k - 1];

                }

            }

            return newresult;
        }


    }
}
