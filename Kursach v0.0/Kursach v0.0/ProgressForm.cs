using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach_v0._0
{
    public partial class ProgressForm : Form
    {
        static DataView view; // Объект данных для отображения предыдущих результатов
        public ProgressForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Закрыть текущую форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Отображение загруженных данных из файла на форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProgressForm_Load(object sender, EventArgs e)
        {
            try
            {
                DataPrint();
                dataGrid1.DataSource = view;
                dataGrid1.Columns[1].Width = 175;
            }
            catch
            {
                MessageBox.Show("Достижений пока никах нет!");
                this.Close();
            }
        }
        /// <summary>
        /// Загрузка данных из файла и сохранения их в переменную view
        /// </summary>
        public static void DataPrint()
        {
            DataTable table = new DataTable();
            ArrayList arrText = new ArrayList();
            DataColumn column;
            DataRow row;
            string str = Assembly.GetExecutingAssembly().Location;
            str = str.Replace((Application.ProductName + ".exe"), "");
            StreamReader objReader = new StreamReader(str + "Progress.txt");
            string sLine = "";
            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null && sLine != "")
                    arrText.Add(sLine);
            }
            objReader.Close();
   
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Игрок";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Уровень";
            table.Columns.Add(column);
            

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Результат";
            table.Columns.Add(column);
  
            for (int i = 0; i < arrText.Count; i++)
            {
                row = table.NewRow();
                string str1 = arrText[i].ToString();
                row["Игрок"] = str1.Substring(0, str1.IndexOf(' '));
                row["Уровень"] = str1.Substring(str1.IndexOf(' '), str1.LastIndexOf(' ') - str1.IndexOf(' '));
                row["Результат"] = str1.Substring(str1.LastIndexOf(' '), 6);
                table.Rows.Add(row);
            }
            view = new DataView(table);
        }
    }
}
