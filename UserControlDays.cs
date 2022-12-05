using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace テスト
{
    public partial class UserControlDays : UserControl
    {
        //lets us create another atatic variable for day
        public static String static_days;

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_days = lbdays.Text;
            EvenForm eventform = new EvenForm();
            eventform.Show();
        }
    }
}
