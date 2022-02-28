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
//using System.Diagnostics;

namespace HelloWorld
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        float? operande1;
        float? operande2;
        Boolean p1_is_float=false;
        Boolean p2_is_float = false;
        int aftercomma1=1;
        int aftercomma2=1;
        string operation;

        private void button_Click(string inputValue)
        {
            //DEBUG INIT
            /*Trace.Listeners.Add(new TextWriterTraceListener("calculdbg.txt"));
            Trace.AutoFlush = true;
            Trace.Indent();*/
            //Trace.WriteLine("Entering Main");
            // example writing to console  Console.WriteLine("Hello World");
            /*input values 123456789+/*-=.
             done CA CL */

            Boolean isNumeric;
            isNumeric = int.TryParse(inputValue, out _);
            int operandeEnsaisie = 0;

            float resultat;
            
            //################################################################################### CA
            if (inputValue == "CA")
            {
                operande1 = null;
                p1_is_float = false;
                operande2 = null;
                p2_is_float = false;
                operation = null;
                resultTextBox.Text = null;
                aftercomma1 = 1;
                aftercomma2 = 1;
                return;
            }

            //################################################################################### CL
            else if (inputValue == "CL")
            {
                if (operande2 != null)
                {
                    operande2 = null;
                    p2_is_float = false;
                    aftercomma2 = 1;
                }
                else if (!string.IsNullOrEmpty(operation))
                {
                    operation = null;
                }
                else if (operande1 != null)
                {
                    operande1 = null;
                    p1_is_float = false;
                    aftercomma1 = 1;
                }

                resultTextBox.Text = operande1.ToString() + " " + operation + " " + operande2.ToString();
                return;
            }


            //################################################################################### 0123456789
            else if (isNumeric)
            {

                if (string.IsNullOrEmpty(operation))//operande1
                {
                    //MessageBox.Show("Saisie operande 1");
                    operandeEnsaisie = 1;

                    //maj operande1 if numeric input value
                    
                     if (operande1 == null && !p1_is_float)
                    {
                        operande1 = int.Parse(inputValue);
                    }
                    else {
                        if (!p1_is_float)

                        {
                            if (operande1.Value >= 0)
                                operande1 = operande1.Value * 10 + int.Parse(inputValue);
                            else
                                operande1 = operande1.Value * 10 - int.Parse(inputValue);
                        }

                        else
                        {
                            if (operande1 == null) operande1 = 0;
                            aftercomma1 = aftercomma1*10 + int.Parse(inputValue);//19
                            if (operande1.Value>=0)
                            operande1 = 
                                    (float)Math.Truncate((decimal)operande1.Value) //0
                                + (float)Math.Pow(10 , -aftercomma1.ToString().Length+1)//0.1
                                *(
                                (float)aftercomma1 //19
                                - (float)Math.Pow(10, aftercomma1.ToString().Length-1)
                                );//10
                            else//negatif
                                operande1 =
                                     (float)Math.Truncate((decimal)operande1.Value) //-787
                                - (float)Math.Pow(10, -aftercomma1.ToString().Length + 1)//0.1
                                * (
                                (float)aftercomma1 //12
                                - (float)Math.Pow(10, aftercomma1.ToString().Length - 1)
                                );
                            //-787ipuut2 =-787 - 0.2 =-787- 1.2+1
                            //0+0.1*19-10 //  1.9-10=-8.9
                            //0+0.1*19-
                            //787 + 0.aftercomm =787 + 1.222 -1 = 787 + 0.001 *1222 -1000= 10^-3 *aftercomma- 10^3=10^-len *after comma
                        }

                    }
                }
                else//operande2
                {
                    //MessageBox.Show("Saisie operande2");
                    operandeEnsaisie = 2;
                    //maj operande2 if numeric input value
                    if (operande2 == null && !p2_is_float)
                    {
                        operande2 = int.Parse(inputValue);
                    }
                    else
                    {
                        if (!p2_is_float)
                        {
                            if (operande2.Value >= 0)
                                operande2 = operande2.Value * 10 + int.Parse(inputValue);
                            else
                                operande2 = operande2.Value * 10 - int.Parse(inputValue);
                        }
                        else
                        {
                            if (operande2 == null) operande2 = 0;
                            aftercomma2 = aftercomma2 * 10 + int.Parse(inputValue);
                            if (operande2.Value >= 0)
                                operande2 =
                                    (float)Math.Truncate((decimal)operande2.Value) //0
                                + (float)Math.Pow(10, -aftercomma2.ToString().Length + 1)//0.1
                                * (
                                (float)aftercomma2 //19
                                - (float)Math.Pow(10, aftercomma2.ToString().Length - 1)
                                );//10
                            else//negatif
                                operande2 =
                                     (float)Math.Truncate((decimal)operande2.Value) //-787
                                - (float)Math.Pow(10, -aftercomma2.ToString().Length + 1)//0.1
                                * (
                                (float)aftercomma2 //12
                                - (float)Math.Pow(10, aftercomma2.ToString().Length - 1)
                                );
                        }

                    }
                    //Trace.WriteLine("It is numeric or dot");
                }
                resultTextBox.Text = operande1.ToString() + " " + operation + " " + operande2.ToString();
            }
            else if (inputValue == "/" || inputValue == "X" || inputValue == "-" || inputValue == "+")
            {
                if (operande1 != null && operande2 == null)
                {
                    operation = inputValue;
                }
                resultTextBox.Text = operande1.ToString() + " " + operation + " " + operande2.ToString();
            }


            //################################################################################### =

            else if (inputValue == "=" && operande1 != null && operande2 != null && !string.IsNullOrEmpty(operation))
            {
                if (operation == "+")
                {
                    resultat = operande1.Value + operande2.Value;
                }
                else if (operation == "-")
                {
                    resultat = operande1.Value - operande2.Value;
                }
                else if (operation == "X")
                {
                    resultat = operande1.Value * operande2.Value;
                }
                else
                {
                    if (operande2.Value == 0)
                    {
                        MessageBox.Show("IMPOSSIBLE");
                        operande1 = null;
                        p1_is_float = false;
                        operande2 = null;
                        p2_is_float = false;
                        operation = null;
                        resultTextBox.Text = null;
                        aftercomma1 = 0;
                        aftercomma2 = 0;
                        return;
                    }
                    else
                        resultat = (float)operande1.Value / (float)operande2.Value;
                }
                resultTextBox.Text += " = " + resultat.ToString("0.0000").TrimEnd(new Char[] { '0' }).TrimEnd(new Char[] { ',' });
                operande1 = null;
                p1_is_float = false;
                operande2 = null;
                p2_is_float = false;
                operation = null;

            }
            //################################################################################### IS
            else if (inputValue == "IS")
            {
                if (operation != null && operande2 != null)
                {
                    operande2 = -operande2.Value;
                    resultTextBox.Text = operande1.ToString() + " " + operation + " " + operande2.ToString();
                }
                else if (operande1 != null)
                {
                    operande1 = -operande1.Value;
                    resultTextBox.Text = operande1.ToString() + " " + operation + " " + operande2.ToString();
                }
            }


            //################################################################################### .
            else if (inputValue == ".")
            {
                if (operation != null && operande2 != null)
                {
                    p2_is_float = true;
                    
                }
                else
                {
                    p1_is_float = true;
                }
            }


            //DEBUG FINISH
            //Trace.Unindent();
            //Trace.Flush();
        }//buttonclick
        private void equals_button_clic(object sender, RoutedEventArgs e)
        {


            button_Click("=");
            
        }

        private void buttonCA_Click(object sender, RoutedEventArgs e)
        {
            button_Click("CA");
        }

        private void buttonCL_Click(object sender, RoutedEventArgs e)
        {
            button_Click("CL");
        }

        private void buttonInverseSign_Click(object sender, RoutedEventArgs e)
        {
            button_Click("IS");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            button_Click("1");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            button_Click("2");
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            button_Click("3");
        }

        private void buttonplus_Click(object sender, RoutedEventArgs e)
        {
            button_Click("+");
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            button_Click("4");
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            button_Click("5");
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            button_Click("6");
        }

        private void buttonmines_Click(object sender, RoutedEventArgs e)
        {
            button_Click("-");
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            button_Click("7");
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            button_Click("8");
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            button_Click("9");
        }

        private void buttonX_Click(object sender, RoutedEventArgs e)
        {
            button_Click("X");
        }

        private void buttondot_Click(object sender, RoutedEventArgs e)
        {
            button_Click(".");
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            button_Click("0");
        }

        private void buttondevisison_Click(object sender, RoutedEventArgs e)
        {
            button_Click("/");
        }
    }
}
