using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sprinklers_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*Some starting parameters like setting the combobox to index0 and making version label background transparent ;)*/
            Sprinklers_List.SelectedIndex = 0;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            /*END Starting parameters*/
        }

        /*Calculate Button*/
        private void Calculate_Click(object sender, EventArgs e)
        {
            int input1, input2;
            if (InputOfSprinklersAmount.Text != "")
            {
                input1 = Convert.ToInt32(InputOfSprinklersAmount.Text);
                if (Sprinklers_List.SelectedIndex == 0) { input2 = 4; if (PressureNozleCheckBox.Checked == true) { input2 = 4 * 2; } else { input2 = 4; }; } else { input2 = 24; if (PressureNozleCheckBox.Checked == true) { input2 = 24 * 2; } else { input2 = 24; }; }
                if (Sprinklers_List.SelectedIndex == 1)
                {
                    input2 = 8; if (PressureNozleCheckBox.Checked == true) { input2 = 8 * 3; } else { input2 = 8; };
                };
                int result = input1 * input2;
                MessageBox.Show("With this setup you can water" + " " + result.ToString() + " " + "tiles everyday.", "Calculated");
            }
            else { MessageBox.Show("Before calculating please enter the amount of sprinklers", "Missing sprinklers amount"); }
        }
        /*END Calculate Button*/

        /*Allow only numbers and backspace in sprinklers amount textbox*/
        private void InputOfSprinklersNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        /*END Allow only numbers and backspace in sprinklers amount textbox*/

        /*Change sprinkler image when changing sprinkler quality in combobox(changing combobox index)*/
        private void Sprinklers_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Sprinklers_List.SelectedIndex)
            {
                case 0:
                    pictureBox3.Image = Properties.Resources.Sprinkler;
                    break;
                case 1:
                    pictureBox3.Image = Properties.Resources.Quality_Sprinkler;
                    break;
                case 2:
                    pictureBox3.Image = Properties.Resources.Iridium_Sprinkler;
                    break;
            }
        }
        /*END Change sprinkler image when changing sprinkler quality in combobox(changing combobox index)*/

        /*Fade in on program start*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .2;
        }
        /*END Fade in on program start*/
    }
}

