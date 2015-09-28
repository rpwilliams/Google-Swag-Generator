/*
* Form1.CS
* Author: Ryan Williams
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private int _frisbees = 0;
        private int _hats = 0;
        private int _sunglasses = 0;
        private int _bottles = 0;
        private int _bags = 0;
        private int _blankets = 0;
        private int _shirts = 0;
        private int _socks = 0;

        public Form1()
        {
            InitializeComponent();
            Hiding();
            uxReturn.Hide();
            uxPicture2.Image = WindowsFormsApplication1.Properties.Resources.google_animated;


            _frisbees = Convert.ToInt32(uxFrisbees.Text);
            _hats = Convert.ToInt32(uxHats.Text);
            _sunglasses = Convert.ToInt32(uxSunglasses.Text);
            _bottles = Convert.ToInt32(uxBottles.Text);
            _bags = Convert.ToInt32(uxBags.Text);
            _blankets = Convert.ToInt32(uxBlankets.Text);
            _shirts = Convert.ToInt32(uxShirts.Text);
            _socks = Convert.ToInt32(uxSocks.Text);
        }

        /// <summary>
        /// Detects if there is any swag left
        /// </summary>
        /// <param name="amt"></param>
        /// <returns></returns>
        public bool IsEmpty(int amt)
        {
            bool empty = false;
            if (amt == 0)
            {
                empty = true;
            }
            return empty;
        }

        /// <summary>
        /// Generate a random piece of Google swag
        /// </summary>
        public void randomSwag()
        {
            
            bool b= false;

            do
            {
                Random r = new Random();
                int prizeNum = r.Next(1, 9);

                switch (prizeNum)
                {
                    case 1:
                        if (_frisbees == 0)
                        {
                            b = true;
                            break;
                        }
                        else
                        {
                            b = false;
                            _frisbees--;
                            uxPicture.Show();
                            uxButton.Text = "You won a chrome frisbee!";
                            uxPicture.Image = WindowsFormsApplication1.Properties.Resources.chromeFrisbee;
                            uxFrisbees.Text = _frisbees.ToString();

                            uxPicture2.Hide();
                            uxReturn.Show();
                            uxRichText.Hide();
                            uxButton.Enabled = false;
                            break;
                        }
                    case 2:
                        if (_hats == 0)
                        {
                            b = true;
                            break;
                        }
                        else
                        {
                            b = false;
                            _hats--;
                            uxPicture.Show();
                            uxButton.Text = "You won a Google hat!";
                            uxPicture.Image = WindowsFormsApplication1.Properties.Resources.Googlehat2;
                            uxHats.Text = _hats.ToString();

                            uxPicture2.Hide();
                            uxReturn.Show();
                            uxRichText.Hide();
                            uxButton.Enabled = false;
                            break;
                        }
                    case 3:
                        if (_sunglasses == 0)
                        {
                            b = true;
                            break;
                        }
                        else
                        {
                            b = false;
                            uxButton.Text = "You won Google sunglasses!";
                            uxPicture.Show();
                            uxPicture.Image = WindowsFormsApplication1.Properties.Resources.mscott_glasses;
                            _sunglasses--;
                            uxSunglasses.Text = _sunglasses.ToString();

                            uxPicture2.Hide();
                            uxReturn.Show();
                            uxRichText.Hide();
                            uxButton.Enabled = false;
                            break;
                        }
                    case 4:
                        if (_bottles == 0)
                        {
                            b = true;
                            break;
                        }
                        else
                        {
                            b = false;
                            uxButton.Text = "You won a water bottle!";
                            uxPicture.Show();
                            uxPicture.Image = WindowsFormsApplication1.Properties.Resources.water;
                            _bottles--;
                            uxBottles.Text = _bottles.ToString();

                            uxPicture2.Hide();
                            uxReturn.Show();
                            uxRichText.Hide();
                            uxButton.Enabled = false;
                            break;
                        }
                    case 5:
                        if (_bags == 0)
                        {
                            b = true;
                            break;
                        }
                        else
                        {
                            b = false;
                            uxButton.Text = "You won a Google bag!";
                            uxPicture.Show();
                            uxPicture.Image = WindowsFormsApplication1.Properties.Resources.Googlebags3;
                            _bags--;
                            uxBags.Text = _bags.ToString();

                            uxPicture2.Hide();
                            uxReturn.Show();
                            uxRichText.Hide();
                            uxButton.Enabled = false;
                            break;
                        }
                    case 6:
                        if (_blankets == 0)
                        {
                            b = true;
                            break;
                        }
                        else
                        {
                            b = false;
                            _blankets--;
                            uxButton.Text = "You won a Google blanket!";
                            uxPicture.Show();
                            uxPicture.Image = WindowsFormsApplication1.Properties.Resources.GoogleBlanket2;
                            uxBlankets.Text = _blankets.ToString();

                            uxPicture2.Hide();
                            uxReturn.Show();
                            uxRichText.Hide();
                            uxButton.Enabled = false;
                            break;
                        }
                    case 7:
                        if (_shirts == 0)
                        {
                            b = true;
                            break;
                        }
                        else
                        {
                            b = false;
                            _shirts--;
                            uxButton.Text = "You won a Google shirt!";
                            uxPicture.Show();
                            uxPicture.Image = WindowsFormsApplication1.Properties.Resources.google_shirt;
                            uxShirts.Text = _shirts.ToString();

                            uxPicture2.Hide();
                            uxReturn.Show();
                            uxRichText.Hide();
                            uxButton.Enabled = false;
                            break;
                        }
                    case 8:
                        if (_socks == 0)
                        {
                            b = true;
                            break;
                        }
                        else
                        {
                            b = false;
                            _socks--;
                            uxButton.Text = "YOU WON THE SOCKS!!!";
                            uxPicture.Show();
                            uxPicture.Image = WindowsFormsApplication1.Properties.Resources.Mscott;
                            uxSocks.Text = _socks.ToString();

                            uxPicture2.Hide();
                            uxReturn.Show();
                            uxRichText.Hide();
                            uxButton.Enabled = false;
                            break;
                        }
                    default:
                        b = false;
                        MessageBox.Show("Out of swag!");
                        break;
                }
            } while (b);
        }


        /// <summary>
        /// Call the random swag method when the person clicks the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button1_Click(object sender, EventArgs e)
        {
            randomSwag();
            
        }

        /// <summary>
        /// Determines how many pieces of swag are left
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void uxOptions_Click(object sender, EventArgs e)
        {

            uxFrisbees.Show();
            uxFrisbeeText.Show();
            uxHatText.Show();
            uxHats.Show();
            uxSunglassesText.Show();
            uxSunglasses.Show();
            uxBottleText.Show();
            uxBottles.Show();
            uxBagText.Show();
            uxBags.Show();
            uxBlanketText.Show();
            uxBlankets.Show();
            uxShirts.Show();
            uxShirtText.Show();
            uxUpdate.Show();
            uxSocks.Show();
            uxSocksText.Show();
        }

        /// <summary>
        /// Hide the options
        /// </summary>
        public void Hiding()
        {
            uxFrisbees.Hide();
            uxFrisbeeText.Hide();
            uxHatText.Hide();
            uxHats.Hide();
            uxSunglassesText.Hide();
            uxSunglasses.Hide();
            uxBottleText.Hide();
            uxBottles.Hide();
            uxBagText.Hide();
            uxBags.Hide();
            uxBlanketText.Hide();
            uxBlankets.Hide();
            uxShirts.Hide();
            uxShirtText.Hide();
            uxSocks.Hide();
            uxSocksText.Hide();

        }

        /// <summary>
        /// Update the options and make them disappear again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void uxUpdate_Click(object sender, EventArgs e)
        { 
            //Update the totals
            _frisbees = Convert.ToInt32(uxFrisbees.Text);
            _hats = Convert.ToInt32(uxHats.Text);
            _sunglasses = Convert.ToInt32(uxSunglasses.Text);
            _bottles = Convert.ToInt32(uxBottles.Text);
            _bags = Convert.ToInt32(uxBags.Text);
            _blankets = Convert.ToInt32(uxBlankets.Text);
            _shirts = Convert.ToInt32(uxShirts.Text);
            _socks = Convert.ToInt32(uxSocks.Text);
            Hiding();
            uxUpdate.Hide();
        }

        /// <summary>
        /// Head back to the previous screen after the swag received has been shown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxReturn_Click(object sender, EventArgs e)
        {
            Return();
        }

        /// <summary>
        /// What happens when return is clicked
        /// </summary>
        private void Return()
        {
            uxButton.Text = "PRESS HERE FOR SWAG";
            uxReturn.Hide();
            uxPicture.Hide();
            uxPicture2.Show();
            uxRichText.Show();
            uxButton.Enabled = true;
        }

        private void uxPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
