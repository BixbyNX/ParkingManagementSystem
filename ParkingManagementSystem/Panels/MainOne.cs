using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagementSystem.Panels
{
    public partial class MainOne : UserControl
    {
        public MainOne()
        {
            InitializeComponent();
            PictureBox[] numberButtons = new PictureBox[] { X01A,X01B,X01C,X01D,X01E,X02A,X02B,X02C,X02D,X02E,
                                                            X03A,X03B,X03C,X03D,X03E,X04A,X04B,X04C,X04D,X04E,
                                                            Y01F,Y01G,Y01H,Y01I,Y01J,Y02F,Y02G,Y02H,Y02I,Y02J,
                                                            Y03F,Y03G,Y03H,Y03I,Y03J,Y04F,Y04G,Y04H,Y04I,Y04J,
                                                            Y05F,Y05G,Y05H,Y05I,Y05J,Y06F,Y06G,Y06H,Y06I,Y06J};
            foreach (var b in numberButtons)
                b.Click += new System.EventHandler(Slot_Click);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MainTwo m2 = new MainTwo();
            m2.Show();
            this.Hide();
            m2.BringToFront();
        }

        private void Slot_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm();
            inputForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
