using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using System.Globalization;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x416

namespace CalculadoraUWP
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        decimal val1 = 0, val2 = 0;
        string operation = "";
        

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text += 1;
        }

        private void button_Copiar_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text += 2;
        }

        private void button_Copiar1_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text += 3;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text += 4;
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text += 5;
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text += 6;
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text += 7;
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text += 8;
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text += 9;
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text += 0;
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            if (ResultBox.Text != "")
            {
                val1 = decimal.Parse(ResultBox.Text, CultureInfo.InvariantCulture);
                ResultBox.Text = "";
                operation = "Add";
                OperationType.Text = "Operação: Adição (+)";
            } else
            {
                ShowErrorDialog("Coloque um valor antes");
            }
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            if (ResultBox.Text != "")
            {
                val1 = decimal.Parse(ResultBox.Text, CultureInfo.InvariantCulture);
                ResultBox.Text = "";
                operation = "Min";
                OperationType.Text = "Operação: Subtração (-)";
            }
            else
            {
                ShowErrorDialog("Coloque um valor antes");
            }
        }

        private void ButtonMult_Click(object sender, RoutedEventArgs e)
        {
            if (ResultBox.Text != "")
            {
                val1 = decimal.Parse(ResultBox.Text, CultureInfo.InvariantCulture);
                ResultBox.Text = "";
                operation = "Mult";
                OperationType.Text = "Operação: Multiplicação (*)";
            }
            else
            {
                ShowErrorDialog("Coloque um valor antes");
            }
        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            if (ResultBox.Text != "")
            {
                val1 = decimal.Parse(ResultBox.Text, CultureInfo.InvariantCulture);
                ResultBox.Text = "";
                operation = "Div";
                OperationType.Text = "Operação: Divisão (/)";
            }
            else
            {
                ShowErrorDialog("Coloque um valor antes");
            }
        }

        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text = "";
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text = "";
            OperationType.Text = "";
            val1 = 0;
            val2 = 0;
        }
        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            val2 = decimal.Parse(ResultBox.Text, CultureInfo.InvariantCulture);

            switch (operation)
            {
                case "Add":
                    ResultBox.Text = Convert.ToString(val1 + val2);
                    break;
                case "Sub":
                    ResultBox.Text = Convert.ToString(val1 - val2);
                    break;
                case "Mult":
                    ResultBox.Text = Convert.ToString(val1 * val2);
                    break;
                case "Div":
                    if (val2 == 0)
                    {
                        ShowErrorDialog("Erro: Divisão por Zero");
                        ResultBox.Text = "";
                        OperationType.Text = "";
                        val1 = 0;
                        val2 = 0;
                    } else
                    {
                        ResultBox.Text = Convert.ToString(val1 / val2);
                    }
                    break;
                default: ShowErrorDialog("Operação invalida");
                    break;

            }
        }

        async void ShowErrorDialog(string message)
        {
            var dialog = new MessageDialog(message, "Erro");
            await dialog.ShowAsync();
        }
    }

}
