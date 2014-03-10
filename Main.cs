using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Translator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.txtFilename.Text))
                MessageBox.Show("O campo Filename não pode ficar vazio");

            if(string.IsNullOrEmpty(this.txtInput.Text))
                MessageBox.Show("O campo Input não pode ficar vazio");

            if(string.IsNullOrEmpty(this.txtOutput.Text))
                MessageBox.Show("O campo Output não pode ficar vazio");

            if (!string.IsNullOrEmpty(this.txtFilename.Text) && !string.IsNullOrEmpty(this.txtInput.Text) && !string.IsNullOrEmpty(this.txtOutput.Text))
            {
                grdTranslate.Rows.Add(new string[] { this.txtFilename.Text, EncryptMd5(this.txtInput.Text), this.txtInput.Text, this.txtOutput.Text });

                //this.txtFilename.Text = string.Empty;
                this.txtFilename.Focus();
                this.txtInput.Text = string.Empty;
                this.txtOutput.Text = string.Empty;
            }
        }

        public string EncryptMd5(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] data = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(input));
            System.Text.StringBuilder sbString = new System.Text.StringBuilder();
            for (int i = 0; i < data.Length; i++)
                sbString.Append(data[i].ToString("x2"));
            return sbString.ToString();
        }

        private void grdTranslate_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = grdTranslate.HitTest(e.X, e.Y);
                if (hti.Type == DataGridViewHitTestType.Cell || hti.Type == DataGridViewHitTestType.RowHeader)
                {
                    grdTranslate.ClearSelection();
                    grdTranslate.Rows[hti.RowIndex].Selected = true;
                    contextMenu.Show(System.Windows.Forms.Control.MousePosition);
                }
            }
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 rowToDelete = grdTranslate.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            grdTranslate.Rows.RemoveAt(rowToDelete);
            grdTranslate.ClearSelection();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            result.Show();
            result.GenerateCode(this.grdTranslate);
        }

        private void deleteAllRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grdTranslate.Rows.Clear();
        }
    }
}
