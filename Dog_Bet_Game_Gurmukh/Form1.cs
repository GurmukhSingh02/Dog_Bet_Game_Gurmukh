using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dog_Bet_Game_Gurmukh
{
    public partial class Form1 : Form
    {
        //instances of classes
        int dg = 0;
        int gurmukh = 100, sham = 100, raman = 100;
        int winner = 0;
        GurmukhGreyHoundClass houndClass = new GurmukhGreyHoundClass();
        GurmukhGuyClass guys = new GurmukhGuyClass();//object of client class
        public Form1()
        {
            InitializeComponent();
            //dynamic loading of amount
            for (int i = 1;i <= 50; i++)
            {
                amountSelection.Items.Add(i.ToString());
            }
            RaceTrackSetting();
            Race_run.Enabled = false;
        }

        private void bet_set_btn_Click(object sender, EventArgs e)
        {
            if (playerSelection.SelectedIndex == 0 && dg > 0 && Convert.ToInt32(amountSelection.SelectedItem.ToString()) <= gurmukh)
            {
                //we have selected the gurmukh here
                gurmukhLabel.Text = "Gurmukh choosed " + dg + " dog and " + amountSelection.SelectedItem.ToString() + " Dollar";
                Race_run.Enabled = true;
            }
            else if (playerSelection.SelectedIndex == 1 && dg > 0 && Convert.ToInt32(amountSelection.SelectedItem.ToString()) <= sham)
            {
                shamLabel.Text = "Sham choosed " + dg + " dog and " + amountSelection.SelectedItem.ToString() + " Dollar";
                Race_run.Enabled = true;
            }
            else if (playerSelection.SelectedIndex == 2 && dg > 0 && Convert.ToInt32(amountSelection.SelectedItem.ToString()) <= raman)
            {
                ramanLabel.Text = "Raman choosed " + dg + " dog and " + amountSelection.SelectedItem.ToString() + " Dollar";
                Race_run.Enabled = true;
            }
            else
            {
                MessageBox.Show("You must folow the Details of the game to Play ");
            }
            dg = 0;
            
        }

        private void raceTimer_Tick(object sender, EventArgs e)
        {
            racer1.Left += houndClass.moveMent();
            racer2.Left += houndClass.moveMent();
            racer3.Left += houndClass.moveMent();
            racer4.Left += houndClass.moveMent();
            //when ethe dog reach at the finishing point stop the game announce the result
            if (racer1.Left > 700)
            {
                winner = 1;

                raceTimer.Enabled = false;
                resultset();
            }
            if (racer2.Left > 700)
            {
                winner = 2;

                raceTimer.Enabled = false;
                resultset();
            }
            if (racer3.Left > 700)
            {
                winner = 3;

                raceTimer.Enabled = false;
                resultset();
            }
            if (racer4.Left > 700)
            {
                winner = 4;

                raceTimer.Enabled = false;
                resultset();
            }
        }

        private void Race_run_Click(object sender, EventArgs e)
        {
            raceTimer.Enabled = true;
        }

        private void dogSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dogSelection.SelectedIndex ==0)
            {
                dg = 1;
            }
            else if(dogSelection.SelectedIndex == 1)
            {
                dg = 2;
            }
            else if (dogSelection.SelectedIndex == 2)
            {
                dg = 3;
            }
            else if (dogSelection.SelectedIndex ==3)
            {
                dg = 4;
            }
            else
            {
                dg = 0;
            }
        }

        private void racer1_Click(object sender, EventArgs e)
        {

        }

        private void RaceTrackSetting()//this funtion is for setting the race track
        {
            amountLabel.Text = string.Format("Minimum Bet $1");//Showing the minimum bet rate in label

            
        }
        public void resultset()
        {
            MessageBox.Show(winner + " dog Won the race");
            if (gurmukhLabel.Text.Contains("dog"))
            {
                gurmukh = guys.budgetSet(gurmukhLabel.Text, gurmukh, winner);
                label3.Text = "Gurmukh has Total $" + gurmukh;
            }
            if (shamLabel.Text.Contains("dog"))
            {
                sham = guys.budgetSet(shamLabel.Text, sham, winner);
                label4.Text = "Johan has Total $" + sham;
            }
            if (ramanLabel.Text.Contains("dog"))
            {
                raman = guys.budgetSet(ramanLabel.Text, raman, winner);
                label5.Text = "Harpreet has Total $" + raman;
            }

            

            racer1.Left = 0;
            racer2.Left = 0;
            racer3.Left = 0;
            racer4.Left = 0;
            dg = 0;
            winner = 0;
            playerSelection.Text = "";
            amountSelection.Text = "";
            dogSelection.Text = "";
            Race_run.Enabled = false;
        }
    }
}
