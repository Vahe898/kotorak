using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace kotorak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetComboBoxItems();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ham1.Text = "";
            hayt1.Text = "";
            ham2.Text = "";
            hayt2.Text = "";
            ham3.Text = "";
            hayt3.Text = "";
        }

        
        public void SetComboBoxItems()
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");

        }

        private void Do_Click(object sender, RoutedEventArgs e)
        {
            
            int intham1 = int.Parse(ham1.Text);
            int intham2 = int.Parse(ham2.Text);
            int inthayt1 = int.Parse(hayt1.Text);
            int inthayt2 = int.Parse(hayt2.Text);
            int intham3 = 0;
            int inthayt3 = 0;
            int krchatum = 0;
            //int inthayt3 = int.Parse(hayt3.Text);
            //int intham3 = int.Parse(ham3.Text);

            var a = comboBox1.Text;
            switch (a)
            {
                case "+":
                    //int inthayt3 = int.Parse(hayt3.Text);
                    //int intham3 = int.Parse(ham3.Text);
                    //int intham3 = 0;
                    //int inthayt3 = 0;
                    //int krchatum = 0;
                    for (int i = 1; i <= inthayt2 * inthayt1; i++)
                    {
                        if(i%inthayt1 ==0 && i%inthayt2 == 0)
                        {
                            inthayt3 = i;
                            intham3 = inthayt3 / inthayt1 * intham1 + inthayt3 / inthayt2 * intham2;
                            break;
                        }
                    }
                    if (inthayt3 > intham3)
                    {
                         krchatum = inthayt3;
                    }
                    else
                    {
                        krchatum = intham3;
                    }
                    for(int i = 1; i <= krchatum; i++)
                    {
                        if(intham3%i ==0 && inthayt3%i == 0)
                        {
                            intham3 = intham3 / i;
                            inthayt3 = inthayt3 / i;
                        }
                    }
                    ham3.Text = intham3.ToString();
                    hayt3.Text = inthayt3.ToString();
                    break;
                case "-":
                    for (int i = 1; i <= inthayt2 * inthayt1; i++)
                    {
                        if (i % inthayt1 == 0 && i % inthayt2 == 0)
                        {
                            inthayt3 = i;
                            intham3 = inthayt3 / inthayt1 * intham1 - inthayt3 / inthayt2 * intham2;
                            if(intham3 == 0)
                            {
                                inthayt3 = 0;
                            }
                            break;
                        }
                    }
                    if (inthayt3 > intham3)
                    {
                        krchatum = inthayt3;
                    }
                    else
                    {
                        krchatum = intham3;
                    }
                    for (int i = 1; i <= krchatum; i++)
                    {
                        if (intham3 % i == 0 && inthayt3 % i == 0)
                        {
                            intham3 = intham3 / i;
                            inthayt3 = inthayt3 / i;
                        }
                    }
                    ham3.Text = intham3.ToString();
                    hayt3.Text = inthayt3.ToString();
                    break;
                case "*":
                    inthayt3 = inthayt1 * inthayt2;
                    intham3 = intham1 * intham2;
                    
                    if (inthayt3 > intham3)
                    {
                        krchatum = inthayt3;
                    }
                    else
                    {
                        krchatum = intham3;
                    }
                    for (int i = 1; i <= krchatum; i++)
                    {
                        if (intham3 % i == 0 && inthayt3 % i == 0)
                        {
                            intham3 = intham3 / i;
                            inthayt3 = inthayt3 / i;
                        }
                    }
                    if (inthayt3 == 0)
                    {
                        ham3.Text = "error";
                        hayt3.Text = "error";
                    }
                    else if (intham3 == 0)
                         {
                        intham3 = 0;
                        inthayt3 = 1;
                        ham3.Text = intham3.ToString();
                        hayt3.Text = inthayt3.ToString();
                         }                  
                    else
                    {
                        ham3.Text = intham3.ToString();
                        hayt3.Text = inthayt3.ToString();
                    }           
                    break;
                case "/":
                    inthayt3 = inthayt1 * intham2;
                    intham3 = intham1 * inthayt2;
                    if (inthayt3 > intham3)
                    {
                        krchatum = inthayt3;
                    }
                    else
                    {
                        krchatum = intham3;
                    }
                    for (int i = 1; i <= krchatum; i++)
                    {
                        if (intham3 % i == 0 && inthayt3 % i == 0)
                        {
                            intham3 = intham3 / i;
                            inthayt3 = inthayt3 / i;
                        }
                    }
                    if(intham2 ==0|| inthayt2 ==0|| inthayt1 == 0)
                    {
                        ham3.Text = "error";
                        hayt3.Text = "error";

                    }
                    else if (intham3 == 0)
                    {
                        intham3 = 0;
                        inthayt3 = 1;
                        ham3.Text = intham3.ToString();
                        hayt3.Text = inthayt3.ToString();
                    }
                    else
                    {
                        ham3.Text = intham3.ToString();
                        hayt3.Text = inthayt3.ToString();
                    }
                    break;

                default:
                    break;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}