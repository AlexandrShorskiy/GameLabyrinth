using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach_v0._0
{
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Кнопка "ОК" - закрыть форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_ok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rtb_info_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
