using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataBase2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void показатьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            
        }

        private void показатьТаблицуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            
        }

        private void показатьТаблицуToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
            
        }

        private void выполнитьЗапросНаВыводВШахматномПорядкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Application.StartupPath + "\\Database1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            myOleDbConnection.Open();
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
            myOleDbCommand.Parameters.Add("@p", SqlDbType.NChar);
            myOleDbCommand.Parameters["@p"].Value = textBox1.Text;
            myOleDbCommand.CommandText = "SELECT year(DOCUMENT.DOC_DATE) AS Год, sum ( IIF( month(DOCUMENT.DOC_DATE) = 1, DOCUMENT.SUM, 0 )) AS январь, sum ( IIF( month(DOCUMENT.DOC_DATE) = 2, DOCUMENT.SUM, 0 )) AS февраль, sum ( IIF( month(DOCUMENT.DOC_DATE) = 3, DOCUMENT.SUM, 0 )) AS март, sum ( IIF( month(DOCUMENT.DOC_DATE) = 4, DOCUMENT.SUM, 0 )) AS апрель, sum ( IIF( month(DOCUMENT.DOC_DATE) = 5, DOCUMENT.SUM, 0 )) AS май, sum ( IIF( month(DOCUMENT.DOC_DATE) = 6, DOCUMENT.SUM, 0 )) AS июнь, sum ( IIF( month(DOCUMENT.DOC_DATE) = 7, DOCUMENT.SUM, 0 )) AS июль, sum ( IIF( month(DOCUMENT.DOC_DATE) = 8, DOCUMENT.SUM, 0 )) AS август, sum ( IIF( month(DOCUMENT.DOC_DATE) = 9, DOCUMENT.SUM, 0 )) AS сентябрь, sum ( IIF( month(DOCUMENT.DOC_DATE) = 10, DOCUMENT.SUM, 0 )) AS октябрь, sum ( IIF( month(DOCUMENT.DOC_DATE) = 11, DOCUMENT.SUM, 0 )) AS ноябрь, sum ( IIF( month(DOCUMENT.DOC_DATE) = 12, DOCUMENT.SUM, 0 )) AS декабрь FROM DOCUMENT INNER JOIN FIRM ON FIRM.ID_FIRM=DOCUMENT.FIRM_ID WHERE FIRM.NAME= @p GROUP BY year(DOCUMENT.DOC_DATE);";
            DataSet ds = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter(myOleDbCommand);
            adapter.Fill(ds, "DOCUMENT");
            dataGridView1.DataSource = ds.Tables["DOCUMENT"].DefaultView; // выводим данные в DataGridView
            myOleDbConnection.Close();
        }
    }
}
