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
        private bool tryNext = false;



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


                //Chrome frisbee. Amount: 5
                if ((prizeNum == 1) && (!IsEmpty(_frisbees)))
                {
                    uxButton.Text = "You won a chrome frisbee!";
                    uxPicture.Image = WindowsFormsApplication1.Properties.Resources.chromeFrisbee;
                    _frisbees--;
                                            
                    tryNext = false;

                }
                else
                {
                    tryNext = true;
                }

                //Google hat. Amount: 2
                if ( (prizeNum == 2) && (!IsEmpty(_hats)))
                {
                    uxButton.Text = "You won a Google hat!";
                    uxPicture.Image = WindowsFormsApplication1.Properties.Resources.Googlehat2;
                    _hats--;
                    tryNext = false;
                }
                //Google sunglasses. Amount: 25
                else if ((prizeNum == 3) && (!IsEmpty(_sunglasses)))
                {
                    uxButton.Text = "You won Google sunglasses!";
                    uxPicture.Image = WindowsFormsApplication1.Properties.Resources.mscott_glasses;
                    _sunglasses--;
                    tryNext = false;
                }

                //Google water bottle. Amount: 1
                else if ((prizeNum == 4) && (!IsEmpty(_bottles)))
                {
                    uxButton.Text = "You won a water bottle!";
                    uxPicture.Image = WindowsFormsApplication1.Properties.Resources.water;
                    _bottles--;
                    tryNext = false;

                }

                //Google bag. Amount :20
                else if ((prizeNum == 5) && (!IsEmpty(_bags)))
                {
                    uxButton.Text = "You won a Google bag!";
                    uxPicture.Image = WindowsFormsApplication1.Properties.Resources.Googlebags3;
                    _bags--;
                    tryNext = false;

                }

                //Google blanket. Amount: 1
                else if ((prizeNum == 6) && (!IsEmpty(_blankets)))
                {
                    uxButton.Text = "You won a Google blanket!";
                    uxPicture.Image = WindowsFormsApplication1.Properties.Resources.GoogleBlanket2;
                    _blankets--;
                    tryNext = false;

                }

                //Google shirt. Amount: 2.
                else if ((prizeNum == 7) && (!IsEmpty(_shirts)))
                {
                    uxButton.Text = "You won a Google shirt!";
                    uxPicture.Image = WindowsFormsApplication1.Properties.Resources.google_shirt;
                    _shirts--;
                    tryNext = false;

                }

                //Google shirt. Amount: 2.
                else if ((prizeNum == 8) && (!IsEmpty(_socks)))
                {
                    uxButton.Text = "YOU WON THE SOCKS!!!";
                    uxPicture.Image = WindowsFormsApplication1.Properties.Resources.Mscott;
                    _socks--;
                    tryNext = false;

                }
                else
                {
                    tryNext = true;

                }

               
            
            uxPicture2.Hide();
            uxPicture.Show();

        }
        

        /// <summary>
        /// Call the random swag method when the person clicks the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button1_Click(object sender, EventArgs e)
        {
            
            uxPicture.Enabled = true;
            randomSwag();
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
            uxButton.Enabled = true;   
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
        }

        private void uxRichText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
