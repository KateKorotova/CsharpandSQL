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
        SqlDataAdapter da;
        DataSet ds;
        int scr_val;
        int fullsize;

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
            scr_val = 0; 
            dataGrid.Columns.Clear();
            SqlConnection conDataBase = new SqlConnection(constring);
            da = new SqlDataAdapter(myselect, conDataBase);
            ds = new DataSet();
            conDataBase.Open();

            da.Fill(ds, scr_val, 10, "info");
            dataGrid.DataSource = ds;
            dataGrid.DataMember = "info";

            int column = dataGrid.Columns.Count;
            for (int i = 0; i < column; i++)
            {
                dataGrid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGrid.Columns[i].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
            }
            DataSet dss = new DataSet();
            da.Fill(dss);
            fullsize = dss.Tables[0].Rows.Count;
            int pages = 0;
            int currpage = 0;
            if ((fullsize - 1) % 10 == 0 && fullsize != 1)
                pages = (fullsize- 1) / 10;
            else
                pages = (fullsize - 1) / 10 + 1;

            if (scr_val % 10 == 0 && scr_val != 0)
                currpage = scr_val / 10;
            else
                currpage = scr_val/ 10 + 1;
            label1.Text = (pages).ToString(); 
            label2.Text = "Page " + currpage + " of ";

        }

        private Tuple<bool, int> check(int index)
        {
            Tuple<bool, int> result = new Tuple<bool, int>(false, -1);
            for (int i = 0; i < select.selectedcolumns.Count; i++)
                if (select.selectedcolumns[i] == index)
                    return result = new Tuple<bool, int>(true, i);
            return result;
        }

        private void dataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string text = dataGrid.Columns[e.ColumnIndex].HeaderText;

            Tuple<bool, int> checkIndex = check(e.ColumnIndex); 

            if ((text != "Количество") && (text != "Сумма") && checkIndex.Item1 == false)
            {
                dataGrid.Columns[e.ColumnIndex].DefaultCellStyle.BackColor = Color.Bisque;
                select.names.Add(text);
                select.selectedcolumns.Add(e.ColumnIndex);
            }
            if(checkIndex.Item1 == true) { 
                dataGrid.Columns[e.ColumnIndex].DefaultCellStyle.BackColor = Color.White;
                select.selectedcolumns.RemoveAt(checkIndex.Item2);
                select.names.RemoveAt(checkIndex.Item2);
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

        private void next_page(object sender, EventArgs e)
        { 
            scr_val += 10;
            if (scr_val >= fullsize - 1)
            {
                scr_val -=10;
            }
            ds.Clear();
            da.Fill(ds, scr_val, 10, "info");
            label2.Text = "Page " + (scr_val / 10 + 1) + " of ";

        }

        private void previous(object sender, EventArgs e)
        {
            scr_val -= 10;
            if (scr_val <= 0)
            {
                scr_val = 0;
            }
            ds.Clear();
            da.Fill(ds, scr_val, 10, "info");
            label2.Text = "Page " + (scr_val / 10 + 1) + " of ";
        }
    }
}
