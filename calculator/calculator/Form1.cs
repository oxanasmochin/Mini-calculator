using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        Calculator MyCalc;
        string input = ""; // Matematiska utryck som innehåller tal tillsamans med öperatörer
        float n = 0f; //start värde av ackumulator
        char tecken; // tecken +,-,*,/
        float result = 0f; // samla resultat
      

        private void button1_Click(object sender, EventArgs e)
        {    /* om på skärmen står 0 då när man trycker på knappen 1 då på skrämen ser man "1",
             men om skärmen har en annan tal exempel "2" då när man trycker på "1" på skärmen visas 21 */

            if (tbscreen.Text == "0") 
            {
                tbscreen.Text = "1";
            }
            else
            {
                tbscreen.Text = tbscreen.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbscreen.Text == "0")
            {
                tbscreen.Text = "2";

            }
            else
            {
                tbscreen.Text = tbscreen.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbscreen.Text == "0")
            {
                tbscreen.Text = "3";

            }
            else
            {
                tbscreen.Text = tbscreen.Text + "3";
            }
        }

        private void tbscreen_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbscreen.Text == "0")
            {
                tbscreen.Text = "4";

            }
            else
            {
                tbscreen.Text = tbscreen.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tbscreen.Text == "0")
            {
                tbscreen.Text = "5";

            }
            else
            {
                tbscreen.Text = tbscreen.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tbscreen.Text == "0")
            {
                tbscreen.Text = "6";

            }
            else
            {
                tbscreen.Text = tbscreen.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tbscreen.Text == "0")
            {
                tbscreen.Text = "7";

            }
            else
            {
                tbscreen.Text = tbscreen.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tbscreen.Text == "0")
            {
                tbscreen.Text = "8";

            }
            else
            {
                tbscreen.Text = tbscreen.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tbscreen.Text == "0")
            {
                tbscreen.Text = "9";

            }
            else
            {
                tbscreen.Text = tbscreen.Text + "9";
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (tbscreen.Text == "0")
            {
                tbscreen.Text = "0";

            }
            else
            {
                tbscreen.Text = tbscreen.Text + "0";
            }
        }

        private void bSum_Click(object sender, EventArgs e)
        {
            tbscreen.Text = tbscreen.Text + "+";

        }

        private void bMul_Click(object sender, EventArgs e)
        {
            tbscreen.Text = tbscreen.Text + "*";

        }

        private void bSub_Click(object sender, EventArgs e)
        {
            tbscreen.Text = tbscreen.Text + "-";
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            tbscreen.Text = tbscreen.Text + "/";
        }

        private void bEqual_Click(object sender, EventArgs e)
        {   /*Först vill jag extrahera tal från strängen. Jag skappade en float vecktor som ska innehålla numrar som vi har mattat i vår mini räknare*/

            input = tbscreen.Text;
            string[] numbersArray = input.Split('+', '-','*','/'); // en ny vecktor av typ sträng med tal skapades efter jag delade input när det finns öperatörer +,-,*,/ 

            float[] SplitedNumbers = new float[numbersArray.Length]; //konvertarar alla tal av typ sträng i ett ny vektor SplitedNumbers av typ float

            for (int i = 0; i < numbersArray.Length; i++)
            {
                SplitedNumbers[i] = float.Parse(numbersArray[i]);
            }

            /*Nästa steg är att extrahera öperatörer + - * / från input sträng och lägga dem i ett ny lista oper av typ char. 
            Detta gör jag genom itterera genom input vektor. Om en element i input innerhåller en av öperatör tecken då lägga man öperatörer i lista oper*/

            string operatorTecken = "+-*/";
            List<char> oper = new List<char>();

            for (int j = 0; j < input.Length; j++)
            {
                if (operatorTecken.Contains(input[j]))
                 {
                    oper.Add(input[j]);
                }
            }

            /* Här börjar jag att räkna med hjälp av klassen Calculator. Först startat jag ackumulators värde som är den första nummer i vecktor SplittedNumbers, 
            och instansiera MyCalc objekt. Därefter itererar jag genom vektor av numrar (SplitedNumbers) med position 1 och genom öperatörer (oper).
             Eftersom vektor av tal är alltid store än vecktor av öperatörer med 1. Därför när man har tal på position 1 det motsvarar tecken på position 0 (i-1).
            På detta sätt kan jag se vilket tal som motsvarar vilken operatör. */

            n = SplitedNumbers[0];
            MyCalc = new Calculator(n);
            for (int i=1; i<SplitedNumbers.Length;i++) //vi börjar med i=1, så vi se 
            {
                tecken = oper[i - 1];
                n = SplitedNumbers[i];

                if (tecken=='+')  //Om öperatör är + då ska man summera den nummer som motsvarar position av +
                {
                    MyCalc.Sum(n);
                }
                if (tecken == '-')
                {
                    MyCalc.Sub(n);
                  
                }
                if (tecken == '*')
                {
                    MyCalc.Mul(n);
                }
                if (tecken == '/')
                {
                    MyCalc.Div(n);
                }

                result = MyCalc.execute();
            }

            tbscreen.Text="= "+result.ToString();

        }

        private void bReset_Click(object sender, EventArgs e)
        {
           tbscreen.Text=MyCalc.Reset().ToString();
        }
    }
}



        
     
