namespace Translator
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.pnlBo = new System.Windows.Forms.Panel();
            this.lnkSobre = new System.Windows.Forms.LinkLabel();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.grdTranslate = new System.Windows.Forms.DataGridView();
            this.Filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MD5Hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Input = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Output = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop.SuspendLayout();
            this.pnlBo.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTranslate)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnAddToList);
            this.pnlTop.Controls.Add(this.lblOutput);
            this.pnlTop.Controls.Add(this.txtOutput);
            this.pnlTop.Controls.Add(this.lblInput);
            this.pnlTop.Controls.Add(this.txtInput);
            this.pnlTop.Controls.Add(this.lblFilename);
            this.pnlTop.Controls.Add(this.txtFilename);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(698, 94);
            this.pnlTop.TabIndex = 0;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(537, 7);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(149, 23);
            this.btnAddToList.TabIndex = 3;
            this.btnAddToList.Text = "Adicionar à lista";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(23, 66);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(42, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Output:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(71, 63);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(615, 20);
            this.txtOutput.TabIndex = 2;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(31, 40);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(34, 13);
            this.lblInput.TabIndex = 3;
            this.lblInput.Text = "Input:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(71, 37);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(615, 20);
            this.txtInput.TabIndex = 1;
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(13, 13);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(52, 13);
            this.lblFilename.TabIndex = 1;
            this.lblFilename.Text = "Filename:";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(71, 10);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(460, 20);
            this.txtFilename.TabIndex = 0;
            // 
            // pnlBo
            // 
            this.pnlBo.Controls.Add(this.lnkSobre);
            this.pnlBo.Controls.Add(this.BtnGenerate);
            this.pnlBo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBo.Location = new System.Drawing.Point(0, 337);
            this.pnlBo.Name = "pnlBo";
            this.pnlBo.Size = new System.Drawing.Size(698, 48);
            this.pnlBo.TabIndex = 1;
            // 
            // lnkSobre
            // 
            this.lnkSobre.AutoSize = true;
            this.lnkSobre.Location = new System.Drawing.Point(4, 22);
            this.lnkSobre.Name = "lnkSobre";
            this.lnkSobre.Size = new System.Drawing.Size(35, 13);
            this.lnkSobre.TabIndex = 1;
            this.lnkSobre.TabStop = true;
            this.lnkSobre.Text = "Sobre";
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(611, 13);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.grdTranslate);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 94);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(698, 243);
            this.pnlCenter.TabIndex = 2;
            // 
            // grdTranslate
            // 
            this.grdTranslate.AllowUserToAddRows = false;
            this.grdTranslate.AllowUserToDeleteRows = false;
            this.grdTranslate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTranslate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Filename,
            this.MD5Hash,
            this.Input,
            this.Output});
            this.grdTranslate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTranslate.Location = new System.Drawing.Point(0, 0);
            this.grdTranslate.Name = "grdTranslate";
            this.grdTranslate.ReadOnly = true;
            this.grdTranslate.Size = new System.Drawing.Size(698, 243);
            this.grdTranslate.TabIndex = 0;
            this.grdTranslate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grdTranslate_MouseDown);
            // 
            // Filename
            // 
            this.Filename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Filename.HeaderText = "Filename";
            this.Filename.Name = "Filename";
            this.Filename.ReadOnly = true;
            // 
            // MD5Hash
            // 
            this.MD5Hash.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MD5Hash.HeaderText = "MD5 Hash";
            this.MD5Hash.Name = "MD5Hash";
            this.MD5Hash.ReadOnly = true;
            // 
            // Input
            // 
            this.Input.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Input.HeaderText = "Input";
            this.Input.Name = "Input";
            this.Input.ReadOnly = true;
            // 
            // Output
            // 
            this.Output.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Output.HeaderText = "Output";
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(134, 26);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 385);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlBo);
            this.Controls.Add(this.pnlTop);
            this.Name = "Main";
            this.Text = "Presta Shop - Front Office - Theme Translator";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBo.ResumeLayout(false);
            this.pnlBo.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTranslate)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Panel pnlBo;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.DataGridView grdTranslate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn MD5Hash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Input;
        private System.Windows.Forms.DataGridViewTextBoxColumn Output;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.LinkLabel lnkSobre;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
    }
}

