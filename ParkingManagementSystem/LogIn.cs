using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ParkingManagementSystem
{
    public partial class LogIn : Form
    {
        Thread th;
        private int attempt = 0;
        private int countAttmpt = 0;
        private int duration = 10;
      

        public LogIn()
        {
            InitializeComponent();    
        }

        private void timer1_Tick(object sender, EventArgs e) // code para sa transition effect
        {
            if (Opacity == 1) // kapag 100% opacity mag sstop na yung timer para sa transition
            {
                timer1.Stop();
            }
            Opacity += .1; // naka 0% opacity kasi yung Login form natin so tataas siya by 10% hanggang matapos timer
        }

        private void TxtUsername_Enter(object sender, EventArgs e) // event pag pinindot yung username textbox
        {
            if (TxtUsername.Text == "Username") // conditonal statement para mawala yung Username na text pag magttype na tayo
            {
                TxtUsername.Text = "";
                TxtUsername.ForeColor = Color.DimGray;
                LblMsgErr.ResetText();
            }
        }

        private void TxtUsername_Leave(object sender, EventArgs e) // event pag di na pinipindot yung usernmae textbox
        {
            if (TxtUsername.Text == "") // conditonal statement para bumalik yung Username na text pagtapos magtype 
            {
                TxtUsername.ForeColor = Color.DarkGray;
                TxtUsername.Text = "Username";
                LblMsgErr.ResetText();

            }
        }

        private void TxtPass_Enter(object sender, EventArgs e) // event pag pinindot yung password textbox
        {
            if (TxtPass.Text == "Password")
            {
                BtnHide.Hide(); // itatago yung Hide eye icon
                BtnShow.Show(); // papalabasin yung Show eye icon
                TxtPass.Text = "";
                TxtPass.PasswordChar = '*'; // encryption para sa password 
                TxtPass.ForeColor = Color.DimGray;
                LblMsgErr.ResetText();
            }
        }

        private void TxtPass_Leave(object sender, EventArgs e) // event pag di na pinipindot yung password textbox
        {
            if (TxtPass.Text == "")
            {
                TxtPass.ForeColor = Color.DarkGray;
                TxtPass.Text = "Password"; // babalik sa original form
                TxtPass.PasswordChar = '\0'; // decryption or babalik ulit siya sa letters
                LblMsgErr.ResetText();
            }
        }

        private void label1_MouseClick(object sender, MouseEventArgs e) // code para sa mimimize button
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnExit_Click(object sender, EventArgs e) // code para sa exit button
        {
            th = new Thread(goToLoadForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void goToLoadForm() //method para pumunta sa loading form
        {
            Application.Run(new LoadingForm());
        }

        private void BtnHide_Click(object sender, EventArgs e) // code para sa Hide password
        {
            if (TxtPass.PasswordChar == '\0') // decryption or babalik ulit siya sa letters
            {
                BtnHide.Hide();
                BtnShow.Show();
                TxtPass.PasswordChar = '*'; // encryption or magiging * yung letters natin
            }
        }

        private void BtnShow_Click(object sender, EventArgs e) // code para sa Show password
        {
            if (TxtPass.PasswordChar == '*') // encryption or magiging * yung letters natin
            {
                BtnShow.Hide();
                BtnHide.Show();
                TxtPass.PasswordChar = '\0'; // decryption or babalik ulit siya sa letters
            }
        }

        private void LblLogIn_Click(object sender, EventArgs e)
        {

                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DLTS2CD\SQLEXPRESS;Initial Catalog=LoginDatabaseTemp;Integrated Security=True");
                    String querry = "SELECT * FROM LoginTempDb WHERE Username = '" + TxtUsername.Text + "'AND Password = '" + TxtPass.Text + "'"; //query 
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                    DataTable dtable = new DataTable(); // gumawa ng imaginary table
                    sda.Fill(dtable); // nilagay ang mga data sa table

                    if (dtable.Rows.Count > 0) // kapag tama
                    {

                        for (int i = 0; i < dtable.Rows.Count; i++) // loop para mahanap
                        {
                            if (dtable.Rows[i]["username"].ToString() == "Admin") // detect admin
                            {
                                DashboardForm dfrm = new DashboardForm(TxtUsername.Text);
                                dfrm.Show();
                                Visible = false;
                            }
                            else
                            {
                                DashboardForm dfrm = new DashboardForm(TxtUsername.Text);
                                dfrm.Show();
                                Visible = false;
                            }
                        } // end for loop
                    } 
                    else if (TxtUsername.Text == " " || TxtPass.Text == "" )
                    {
                        LblMsgErr.Text = "Input Username or Password"; // kapag walang nilagay 
                        ClearFields();
                        ErrAttmpt();
                }
                    else
                    {
                        LblMsgErr.Text = "Username or Password is incorrect"; // kapag mali 
                        ClearFields();
                        ErrAttmpt();
                    }
                }
        
                catch
                {
                    MessageBox.Show("Invalid login details", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); // error message
                    ClearFields();
                }
        }

        private void ClearFields() // method pang clear ng txt boxes
        {
            TxtUsername.Clear();
            TxtPass.Clear();
        }

        private void timer2_Tick(object sender, EventArgs e) 
        {
           
            if (duration == 1)
            {
                LblMsgErr.ResetText();
                TxtUsername.Enabled = true;
                TxtPass.Enabled = true;
                LblLogIn.Enabled = true;
                attempt = 0;
                timer2.Stop();
            }
            else if (duration > 1)
            {
                duration--;
                LblMsgErr.Text = "Login again after " + duration.ToString() + " seconds";
            }
        }

        private void ErrAttmpt()
        {
            attempt += 1;
            if (attempt == 3) // 3 attempts, unang set ng error
            {
                countAttmpt += 1;
                if (countAttmpt < 2)
                {
                    DialogResult dr = MessageBox.Show("Login attempts exceeded", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    if (dr == DialogResult.OK)
                    {
                        TxtUsername.ForeColor = Color.DimGray;
                        TxtPass.ForeColor = Color.DimGray;
                        TxtPass.PasswordChar = '\0';
                        TxtPass.Text = "Password";
                        TxtUsername.Text = "Username";
                        TxtUsername.Enabled = false;
                        TxtPass.Enabled = false;
                        LblLogIn.Enabled = false;
                        timer2.Start();
                    }
                }
                else if (countAttmpt == 2) //pangalawang set ng error pupunta sa loading form at malolock
                {
                    DialogResult drs = MessageBox.Show("Please contact your administrator to log in again", "Login Session Expired", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    if (drs == DialogResult.OK)
                    {
                        // code para malock si laodingform
                    }
                     
                }        
            }
        }
     
    } //end } partial

} //end } namespace
