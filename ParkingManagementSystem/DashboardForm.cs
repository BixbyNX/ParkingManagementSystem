using ParkingManagementSystem.Panels;
using System;
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
    public partial class DashboardForm : Form
    {

        Thread th;
        String TxtUsername;
        public DashboardForm()
        {
            InitializeComponent();
        }
        public DashboardForm(String s)
        {
            InitializeComponent();
            TxtUsername = s;
            customDesigning();
        }

        private void customDesigning()
        {
            PnlSubAdm.Visible = false;
        }
        private void hideSubAdm()
        {
            if (PnlSubAdm.Visible == true)
                PnlSubAdm.Visible = false;
        }
        private void showSubAdm(Panel PnlSubAdm)
        {
            if (PnlSubAdm.Visible == false)
            {
                hideSubAdm();
                PnlSubAdm.Visible = true;
            }
            else
                PnlSubAdm.Visible = false;

        }

        private void DshbrdTmr_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1) // kapag 100% opacity mag sstop na yung timer para sa transition
            {
                DshbrdTmr.Stop();
            }
            Opacity += .2; // naka 0% opacity kasi yung Login form natin so tataas siya by 10% hanggang matapos timer
        }

        private void BtnAdmn_Click(object sender, EventArgs e)
        {
            showSubAdm(PnlSubAdm);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                th = new Thread(goToLoadForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
            }
        }
        private void goToLoadForm()
        {
            Application.Run(new LoadingForm());
        }

        private void DashboardForm_Load(object sender, EventArgs e) // hide admin module if employee
        {
            if (TxtUsername != "Admin")
            {
                BtnAdmn.Visible = false;
                PnlSubAdm.Visible = false;
                BtnReport.Visible = true;
            }
            manageAccounts1.Visible = false;
            history1.Visible = false;
            sales1.Visible = false;
            report1.Visible = false;
        }
        
    }
    
}
