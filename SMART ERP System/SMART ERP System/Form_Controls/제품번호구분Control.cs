using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using ClassLibrary.EntityData;
using SMART_ERP_System.Class;

namespace SMART_ERP_System.MainForm_Control
{
    public partial class 제품번호구분Control : UserControl
    {
        CodeHelperForm codeHelperForm;

        public 제품번호구분Control()
        {
            InitializeComponent();

            if (!제품단위.SendCode.IsNullOrEmpty())
                txbSearch.Text = 제품단위.SendCode;

            List<string> list = DB.자재명세서.GetAll().Select(x=>x.제품번호).Distinct().ToList();
            for (int j = 0; j < list.Count(); j++)
            {
                dgv제품번호List.Rows.Add();
                dgv제품번호List.Rows[j].Cells[0].Value = list[j];
            }
        }

        private void TxbSearch_TextChanged(object sender, EventArgs e)
        {
            List<제품> list = DB.자재명세서.SearchByCode(txbSearch.Text);

            if (list != null)
            {
                dgv제품번호List.DataSource = list;
            }
        }

        private void DgvList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                string accountCode = dgv제품번호List.CurrentRow.Cells[0].Value.ToString();

                제품단위.Code = accountCode;

                codeHelperForm.Close();
            }

            if (e.KeyData == Keys.Escape)
            {
                codeHelperForm.Close();
            }
        }

        public void RecieveLoginForm(CodeHelperForm menuForm)
        {
            this.codeHelperForm = menuForm;
        }

        private void DgvList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv제품번호List.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void DgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string accountCode = dgv제품번호List.CurrentRow.Cells[0].Value.ToString();

            제품단위.Code = accountCode;

            codeHelperForm.Close();
        }
    }
}
