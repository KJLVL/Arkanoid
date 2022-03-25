using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class FormStart : Form
    {
        public static int m1, m2, m3;
        private form1 f;
        public FormStart(int i, int mx)
        {
            if (i == 1)
            {
                m1 = mx;
            }
            else if (i == 2)
            {
                m2 = mx;
            }
            else if (i == 3)
            {
                m3 = mx;
            }
            InitializeComponent();
        }
        public FormStart()
        {
            InitializeComponent();
        }

        private void startB_Click(object sender, EventArgs e)
        {
            if (err.Visible)
                err.Visible = false;

            if (cB1.Text == "легкий")
            {
                Hide();
                f = new form1(1, m1);
                f.Show();
            }                
            else if (cB1.Text == "средний")
            {
                Hide();
                f = new form1(2, m2);
                f.Show();
            }
            else if (cB1.Text == "сложный")
            {
                Hide();
                f = new form1(3, m3);
                f.Show();
            }
            else
            {
                err.Visible = true;
                err.Text = "Выберите уровень сожности!";
            }
        }


    }
}
