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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }

        public void GenerateCode(DataGridView data)
        {
            StringBuilder sBuilder = new StringBuilder();

            sBuilder.AppendLine("<?php");
            sBuilder.AppendLine("");
            sBuilder.AppendLine("global $_LANG;");
            sBuilder.AppendLine("$_LANG = array();");
            sBuilder.AppendLine("");

            foreach (DataGridViewRow row in data.Rows)
            {
                string filename = row.Cells["Filename"].Value.ToString();
                string md5Hash = row.Cells["MD5Hash"].Value.ToString();
                string input = row.Cells["Input"].Value.ToString();
                string output = row.Cells["Output"].Value.ToString();

                sBuilder.AppendLine(string.Format("$_LANG['{0}_{1}'] = '{2}';", filename, md5Hash, output));
            }

            txtResult.Text = sBuilder.ToString();
        }
    }
}
