using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkwithDB
{
    public partial class frmMain : Form
    {
        MySelect select = new MySelect();
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sanya\source\repos\WorkwithDB\WorkwithDB\MyDatabase.mdf;Integrated Security=True";
        int scr_val; 

        public frmMain()
        {
            InitializeComponent();
            scr_val = 0;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            load(select.standartquery());
            dataGrid.ColumnHeaderMouseClick += dataGrid_ColumnHeaderMouseClick;
            dataGrid.SelectionChanged += dataGrid_SelectionChanged;
            dataGrid.ClearSelection();
        }

        private void load(string myselect)
        {
            dataGrid.Columns.Clear();
            DataTable table = new DataTable();
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand command = new SqlCommand(myselect, conDataBase);
            conDataBase.Open();
            SqlDataReader reader = command.ExecuteReader();
            table.Load(reader);
            dataGrid.DataSource = table;
            conDataBase.Close();
            int column = dataGrid.Columns.Count;
            for (int i = 0; i < column; i++)
            {
                dataGrid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGrid.Columns[i].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
            }
        }

        private void dataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string text = dataGrid.Columns[e.ColumnIndex].HeaderText;
            if (select.selectedcolumns.Count != 0)
            {
                foreach(int index in select.selectedcolumns)
                {
                    if(dataGrid.Columns[index] == dataGrid.Columns[e.ColumnIndex])
                        dataGrid.Columns[e.ColumnIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
            if ((text != "Количество") && (text != "Сумма"))
            {
                dataGrid.Columns[e.ColumnIndex].DefaultCellStyle.BackColor = Color.Bisque;
                select.names.Add(dataGrid.Columns[e.ColumnIndex].HeaderText);
                select.selectedcolumns.Add(e.ColumnIndex);
            }
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            dataGrid.ClearSelection();
        }


        private void result(object sender, EventArgs e)
        {
            if (select.selectedcolumns.Count != 0)
            {
                foreach (int index in select.selectedcolumns)
                {
                    dataGrid.Columns[index].DefaultCellStyle.BackColor = Color.White;
                }
                load(select.query("Organization"));
                select = new MySelect();
            }
            else
            {
                MessageBox.Show("You should choose columns");
            }
        }

        private void original_table(object sender, EventArgs e)
        {
            select = new MySelect();
            load(select.standartquery());
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
