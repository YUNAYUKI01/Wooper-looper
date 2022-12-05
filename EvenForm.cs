using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace テスト
{
    public partial class EvenForm : Form
    {
        //接続文字列
        String connString = "Server=127.0.0.1;User=root;Database=calendar;Password=Wooperlooper0H13030AOIKAI;";

        //T already created a database using 
        public EvenForm()
        {
            InitializeComponent();
        }

        private void EvenForm_Load(object sender, EventArgs e)
        {
            //lets call the static variable we declare
            txdate.Text = UserControlDays.static_days;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //コネクション生成
            MySqlConnection conn = new MySqlConnection(connString);

            //DB接続
            conn.Open();

            //DBに追加処理のテキスト
            String sql = "INSERT INTO tbl_calendar(date,event) values(@date,@event)";

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@date", txdate.Text);
            cmd.Parameters.AddWithValue("@event", txevent.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            cmd.Dispose();

            //DB切断
            conn.Close();
        }
    }
}
