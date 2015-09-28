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
            uxTextBox.Hide();

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
            Random r = new Random();
            int prizeNum = r.Next(1, 9);
            tryNext = false;
            //use switch statement, check if 0. If it is, break. If it isn't does the case.


            switch (prizeNum)
            {
                case 0:
                case 1:
                    if (_frisbees == 0) break;
                    uxButton.Text = "You won a chrome frisbee!";
                    uxPicture.Image = WindowsFormsApplication1.Properties.Resources.chromeFrisbee;
                    _frisbees--;
                    uxFrisbees.Text = _frisbees.ToString();
                    break;
                case 2:
                    if (_hats == 0) break;
                    uxButton.Text = "You won a Google hat!";
                    uxPicture.Image = WindowsFormsApplication1.Properties.Resources.Googlehat2;
                    _hats--;
                    uxHats.Text = _hats.ToString();
                    break;
                case 3:
                    if (_sunglasses == 0) break;
                    uxButton.Text = "You won Google sunglasses!";
                    uxPicture.Image = WindowsFormsApplication1.Properties.Resources.mscott_glasses;
                    _sunglasses--;
                    uxSunglasses.Text = _sunglasses.ToString();
                    break;
                case 4:
                    if (_bottles == 0) break;
                    uxButton.Text = "You won a water bottle!";
                    uxPicture.Image = WindowsFormsApplication1.Properties.Resources.water;
                    _bottles--;
                    uxBottles.Text = _bottles.ToString();
                    break;
                case 5:
                    if (_bags == 0) break;
                    uxButton.Text = "You won a Google bag!";
                    uxPicture.Image = WindowsFormsApplication1.Properties.Resources.Googlebags3;
                    _bags--;
                    uxBags.Text = _bags.ToString();
                    break;
                case 6:
                    if (_blankets == 0) break;
                    uxButton.Text = "You won a Google blanket!";
                    uxPicture.Image = WindowsFormsApplication1.Properties.Resources.GoogleBlanket2;
                    _blankets--;
                    uxBlankets.Text = _blankets.ToString();
                    break;
                case 7:
                    if (_shirts == 0) break;
                    uxButton.Text = "You won a Google shirt!";
                    uxPicture.Image = WindowsFormsApplication1.Properties.Resources.google_shirt;
                    _shirts--;
                    uxShirts.Text = _shirts.ToString();
                    break;
                case 8:
                    if (_socks == 0) break;
                    uxButton.Text = "YOU WON THE SOCKS!!!";
                    uxPicture.Image = WindowsFormsApplication1.Properties.Resources.Mscott;
                    _socks--;
                    uxSocks.Text = _socks.ToString();
                    break;
                default:
                    MessageBox.Show("Out of swag!");
                    break;
            }
            /*
            //Chrome frisbee. Amount: 5
            if (((tryNext) || (prizeNum == 1)) && (!IsEmpty(_frisbees)))
            {
                uxButton.Text = "You won a chrome frisbee!";
                uxPicture.Image = WindowsFormsApplication1.Properties.Resources.chromeFrisbee;
                _frisbees--;
                uxFrisbees.Text = _frisbees.ToString();
                
            }
           
            else
            {
                tryNext = true;
            }

            //Google hat. Amount: 2
            if (((tryNext) || (prizeNum == 2)) && (!IsEmpty(_hats)))
            {
                uxButton.Text = "You won a Google hat!";
                uxPicture.Image = WindowsFormsApplication1.Properties.Resources.Googlehat2;
                _hats--;
                uxHats.Text = _hats.ToString();
                
            }

            else
            {
                tryNext = true;
            }


            //Google sunglasses. Amount: 25
            if (((tryNext) || (prizeNum == 3)) && (!IsEmpty(_sunglasses)))
            {
                uxButton.Text = "You won Google sunglasses!";
                uxPicture.Image = WindowsFormsApplication1.Properties.Resources.mscott_glasses;
                _sunglasses--;
                uxSunglasses.Text = _sunglasses.ToString();
                
            }
            else
            {
                tryNext = true;
            }

            //Google water bottle. Amount: 1
            if (((tryNext) || (prizeNum == 4)) && (!IsEmpty(_bottles)))
            {
                uxButton.Text = "You won a water bottle!";
                uxPicture.Image = WindowsFormsApplication1.Properties.Resources.water;
                _bottles--;
                uxBottles.Text = _bottles.ToString();
            }
            else
            {
                tryNext = true;
            }

            //Google bag. Amount :20
            if (((tryNext) || (prizeNum == 5)) && (!IsEmpty(_bags)))
            {
                uxButton.Text = "You won a Google bag!";
                uxPicture.Image = WindowsFormsApplication1.Properties.Resources.Googlebags3;
                _bags--;
                uxBags.Text = _bags.ToString();
                
            }
            else
            {
                tryNext = true;
            }

            //Google blanket. Amount: 1
            if (((tryNext) || (prizeNum == 6)) && (!IsEmpty(_blankets)))
            {
                uxButton.Text = "You won a Google blanket!";
                uxPicture.Image = WindowsFormsApplication1.Properties.Resources.GoogleBlanket2;
                _blankets--;
                uxBlankets.Text = _blankets.ToString();
                
            }
            else
            {
                tryNext = true;
            }

            //Google shirt. Amount: 2.
            if (((tryNext) || (prizeNum == 7)) && (!IsEmpty(_shirts)))
            {
                uxButton.Text = "You won a Google shirt!";
                uxPicture.Image = WindowsFormsApplication1.Properties.Resources.google_shirt;
                _shirts--;
                uxShirts.Text = _shirts.ToString();
               

            }
            else
            {
                tryNext = true;
            }

            //Google socks. Amount: 2.
            if (((tryNext) || (prizeNum == 8)) && (!IsEmpty(_socks)))
            {
                uxButton.Text = "YOU WON THE SOCKS!!!";
                uxPicture.Image = WindowsFormsApplication1.Properties.Resources.Mscott;
                _socks--;
                uxSocks.Text = _socks.ToString();
                
            }
            else
            {
                tryNext = true;
            }
            */
        }


        /// <summary>
        /// Call the random swag method when the person clicks the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button1_Click(object sender, EventArgs e)
        {
            randomSwag();
            uxPicture2.Hide();
            uxPicture.Show();
            uxReturn.Show();
            uxRichText.Hide();
            uxButton.Enabled = false;
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
    }
}
