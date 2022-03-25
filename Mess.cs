using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Mess : Form
    {
        int i;
        int mx;
        public Mess(int ind, int m)
        {
            InitializeComponent();
            mx = m;
            i = ind;
            rec.Text += mx; 
        }

        public void yesB_Click(object sender, EventArgs e)
        {
            FormStart fs = new FormStart(i, mx);
            Hide();
            form1 f = new form1(i, mx);
            f.Show();

        }

        public void noB_Click(object sender, EventArgs e)
        {
            Hide();
            FormStart fs = new FormStart(i, mx);
            fs.Show();
        }
    }
}
