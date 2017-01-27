using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace project2_Daigle
{ 
    public partial class Form1 : Form
    {
        private const int HIGHEST = 37;
        private int[] total = new int[HIGHEST];
        private int currentVal;
        public Form1()
        {
            InitializeComponent();
        }


        //RNG button event handler 
        //not really used for this project but was useful for debugging
        private void button1_Click(object sender, EventArgs e)
        {
            int high = 10;
            int low = 0;
            int seed;

            if (textBox_seed.Text == "")
            {
                listbox_rngs.Items.Add(new aRandomNumberGenerator(low, high + 1));
            }
            else if (textBox_seed.Text == "0")
            {
                seed = int.Parse(textBox_seed.Text);
                listbox_rngs.Items.Add(new aRandomNumberGenerator(low, high + 1));
            }
            else if (int.TryParse(textBox_seed.Text, out seed))
            {
                listbox_rngs.Items.Add(new aRandomNumberGenerator(low, high + 1, seed));
                
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for the seed!");

            }
        }

        /// <summary>
        /// event handler for selecting items in listbox
        /// </summary>
        private void listbox_rngs_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            //clear the chart before starting new one
            chart_histo.Series["Series1"].Points.Clear();
            //gets the currently selectred random number generator 
            aRandomNumberGenerator currentRNG = (aRandomNumberGenerator) listbox_rngs.SelectedItem;

            if (currentRNG.ToString() == "Coin")
            {
                timer2.Enabled = false;
                timer3.Enabled = false;
                textBox_rngVal.Text = currentRNG.Next().ToString();
                int highVal = currentRNG.High;
                for (int j = 0; j <= highVal; j++)
                {
                    total[j] = 0;
                }
                
                timer1.Enabled = true;
                textBox_high.Text = currentRNG.High.ToString();
                textBox_low.Text = currentRNG.Low.ToString();
            }
            else if (currentRNG.ToString() == "Die")
            {
                timer1.Enabled = false;
                timer3.Enabled = false;
                textBox_rngVal.Text = currentRNG.Next().ToString();
                int highVal = currentRNG.High;
                for (int j = 0; j <= highVal; j++)
                {
                    total[j] = 0;
                }
                timer2.Enabled = true;
                textBox_high.Text = currentRNG.High.ToString();
                textBox_low.Text = currentRNG.Low.ToString();
            }
            else //if Gaussian 
            {
                timer1.Enabled = false; 
                timer2.Enabled = false;
                textBox_rngVal.Text = currentRNG.Next().ToString();
                int highVal = currentRNG.High;
                for (int j = 0; j <= highVal; j++)
                {
                    total[j] = 0;
                }
                timer3.Enabled = true;
                textBox_high.Text = currentRNG.High.ToString();
                textBox_low.Text = currentRNG.Low.ToString();
            }
            
        }

        //adds a coin to the list
        private void button_coin_Click(object sender, EventArgs e)
        {
            int seed;

            if (textBox_seed.Text == "")
            {
                listbox_rngs.Items.Add(new aCoin());
            }
            else if (textBox_seed.Text == "0")
            {
                seed = int.Parse(textBox_seed.Text);
                listbox_rngs.Items.Add(new aCoin());
            }
            else if (int.TryParse(textBox_seed.Text, out seed))
            {
                listbox_rngs.Items.Add(new aCoin(seed));
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for the seed!");
            }
        }

        //stops all timers 
        private void button_stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
        }

        //timer used for flipping coins
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            aRandomNumberGenerator currentRNG = (aRandomNumberGenerator) listbox_rngs.SelectedItem;
            currentVal = currentRNG.Next();
            total[currentVal]++; 
            textBox_rngVal.Text = currentRNG.Next().ToString();
            int highVal = currentRNG.High;
            for (int j = 0; j <= highVal; j++)
            {
               
                chart_histo.Series["Series1"].Points.AddXY(currentVal, total[currentVal]);
                
            }  
        }

        //timer used for rolling dice
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            aRandomNumberGenerator currentRNG = (aRandomNumberGenerator) listbox_rngs.SelectedItem;
            currentVal = currentRNG.Next();
            total[currentVal]++; 
            textBox_rngVal.Text = currentRNG.Next().ToString();
            int highVal = currentRNG.High;
            for (int j = 0; j <= highVal; j++)
            {
               
                chart_histo.Series["Series1"].Points.AddXY(currentVal, total[currentVal]);
                
            }
        }

        //adds a dice to the list
        private void button_die_Click(object sender, EventArgs e)
        {
            int seed;

            if (textBox_seed.Text == "")
            {
                listbox_rngs.Items.Add(new aDie());
            }
            else if (textBox_seed.Text == "0")
            {
                seed = int.Parse(textBox_seed.Text);
                listbox_rngs.Items.Add(new aDie());
            }
            else if (int.TryParse(textBox_seed.Text, out seed))
            {
                listbox_rngs.Items.Add(new aDie(seed));
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for the seed!");
            }
        }

        //adds a gaussian to the list
        private void button_gaussian_Click(object sender, EventArgs e)
        {
            int seed;

            if (textBox_seed.Text == "")
            {
                listbox_rngs.Items.Add(new aGaussian());
            }
            else if (textBox_seed.Text == "0")
            {
                seed = int.Parse(textBox_seed.Text);
                listbox_rngs.Items.Add(new aGaussian());
            }
            else if (int.TryParse(textBox_seed.Text, out seed))
            {
                listbox_rngs.Items.Add(new aGaussian(seed));
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for the seed!");
            }
        }

        //timer that controls gaussian rolls
        private void timer3_Tick(object sender, EventArgs e)
        {
            aRandomNumberGenerator currentRNG = (aRandomNumberGenerator)listbox_rngs.SelectedItem;
            currentVal = currentRNG.Next();
            total[currentVal]++;
            textBox_rngVal.Text = currentRNG.Next().ToString();
            int highVal = currentRNG.High;
            for (int j = 0; j <= highVal; j++)
            {
                if (j == currentVal)
                {
                    chart_histo.Series["Series1"].Points.AddXY(j, total[currentVal]);
                }
                else 
                {
                    chart_histo.Series["Series1"].Points.AddXY(j, 0);
                }

            }
        }

        
    }
}
