using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace januity
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            // StartPosition was set to FormStartPosition.Manual in the properties window.
            //   Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            // int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            //int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            //    this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            //  this.Size = new Size(w, h);

            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }
        private void Loginbtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form3 fm2 = new Form3();
            fm2.Show();

        }

        private void UsernameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
