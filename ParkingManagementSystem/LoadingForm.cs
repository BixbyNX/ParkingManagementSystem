exusing System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagementSystem
{
    public partial class LoadingForm : Form
    {
        Thread th; //threading
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e) // timer
        {
            Timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e) // Date and Time
        {
            label1.Text = DateTime.Now.ToShortTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void panel1_DoubleClick(object sender, EventArgs e) // double click para mapunta sa login
        {
            th = new Thread(goToLogIn); // threading
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        private void goToLogIn() // threading
        {
            Application.Run(new LogIn());
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1) // kapag 100% opacity mag sstop na yung timer para sa transition
            {
                Timer1.Stop();
            }
            Opacity += .2; // naka 0% opacity kasi yung Login form natin so tataas siya by 10% hanggang matapos timer
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            th = new Thread(goToLogIn); // threading
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            th = new Thread(goToLogIn); // threading
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void BtnOff_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Shut down application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit(); // exit program
            }
        }

        private void BtnOff_MouseHover(object sender, EventArgs e)
        {
            LblTxtOff.Show();
        }

        private void BtnOff_MouseLeave(object sender, EventArgs e)
        {
            LblTxtOff.Hide();
        }
    }
}
