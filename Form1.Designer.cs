using System.Drawing;
using System.Windows.Forms;

namespace LearnForms1
{
    partial class Formm1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.finAssetBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripTab2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripTab3 = new System.Windows.Forms.ToolStripMenuItem();
            this.securityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelNameTable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemRow = new System.Windows.Forms.Button();
            this.lbIdForDel = new System.Windows.Forms.Label();
            this.txtBoxIdRowForDel = new System.Windows.Forms.TextBox();
            this.btnSaveTable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClearObl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxIdForObl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 519);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(827, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Edit DB";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel2.Controls.Add(this.labelNameTable);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.btnRemRow);
            this.splitContainer1.Panel2.Controls.Add(this.lbIdForDel);
            this.splitContainer1.Panel2.Controls.Add(this.txtBoxIdRowForDel);
            this.splitContainer1.Panel2.Controls.Add(this.btnSaveTable);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(821, 487);
            this.splitContainer1.SplitterDistance = 122;
            this.splitContainer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finAssetBtn,
            this.tStripTab2,
            this.tStripTab3,
            this.securityToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(130, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(130, 450);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(130, 487);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // finAssetBtn
            // 
            this.finAssetBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.finAssetBtn.Name = "finAssetBtn";
            this.finAssetBtn.Size = new System.Drawing.Size(77, 25);
            this.finAssetBtn.Text = "Fin Asset";
            this.finAssetBtn.Click += new System.EventHandler(this.finAsset_Click);
            // 
            // tStripTab2
            // 
            this.tStripTab2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tStripTab2.Name = "tStripTab2";
            this.tStripTab2.Size = new System.Drawing.Size(77, 25);
            this.tStripTab2.Text = "Bond";
            this.tStripTab2.Click += new System.EventHandler(this.bond_Click);
            // 
            // tStripTab3
            // 
            this.tStripTab3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tStripTab3.Name = "tStripTab3";
            this.tStripTab3.Size = new System.Drawing.Size(77, 25);
            this.tStripTab3.Text = "Tiker";
            this.tStripTab3.Click += new System.EventHandler(this.tiker_Click);
            // 
            // securityToolStripMenuItem
            // 
            this.securityToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.securityToolStripMenuItem.Name = "securityToolStripMenuItem";
            this.securityToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.securityToolStripMenuItem.Text = "Security";
            this.securityToolStripMenuItem.Click += new System.EventHandler(this.security_Click);
            // 
            // labelNameTable
            // 
            this.labelNameTable.AutoSize = true;
            this.labelNameTable.Location = new System.Drawing.Point(7, 2);
            this.labelNameTable.Name = "labelNameTable";
            this.labelNameTable.Size = new System.Drawing.Size(0, 13);
            this.labelNameTable.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(636, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "by n4d3sh";
            // 
            // btnRemRow
            // 
            this.btnRemRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemRow.Location = new System.Drawing.Point(3, 460);
            this.btnRemRow.Name = "btnRemRow";
            this.btnRemRow.Size = new System.Drawing.Size(75, 23);
            this.btnRemRow.TabIndex = 4;
            this.btnRemRow.Text = "Remove";
            this.btnRemRow.UseVisualStyleBackColor = false;
            this.btnRemRow.Click += new System.EventHandler(this.btnRemRow_Click);
            // 
            // lbIdForDel
            // 
            this.lbIdForDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbIdForDel.AutoSize = true;
            this.lbIdForDel.Location = new System.Drawing.Point(176, 465);
            this.lbIdForDel.Name = "lbIdForDel";
            this.lbIdForDel.Size = new System.Drawing.Size(79, 13);
            this.lbIdForDel.TabIndex = 3;
            this.lbIdForDel.Text = "<- id row for del";
            // 
            // txtBoxIdRowForDel
            // 
            this.txtBoxIdRowForDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxIdRowForDel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxIdRowForDel.Location = new System.Drawing.Point(117, 462);
            this.txtBoxIdRowForDel.Name = "txtBoxIdRowForDel";
            this.txtBoxIdRowForDel.Size = new System.Drawing.Size(53, 20);
            this.txtBoxIdRowForDel.TabIndex = 2;
            // 
            // btnSaveTable
            // 
            this.btnSaveTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveTable.Location = new System.Drawing.Point(297, 460);
            this.btnSaveTable.Name = "btnSaveTable";
            this.btnSaveTable.Size = new System.Drawing.Size(83, 23);
            this.btnSaveTable.TabIndex = 1;
            this.btnSaveTable.Text = "Save change";
            this.btnSaveTable.UseVisualStyleBackColor = false;
            this.btnSaveTable.Click += new System.EventHandler(this.btnSaveTable_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 436);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnClearObl);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtBoxIdForObl);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(827, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Obligation Info";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(768, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "by n4d3sh";
            // 
            // btnClearObl
            // 
            this.btnClearObl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearObl.Location = new System.Drawing.Point(323, 465);
            this.btnClearObl.Name = "btnClearObl";
            this.btnClearObl.Size = new System.Drawing.Size(75, 23);
            this.btnClearObl.TabIndex = 4;
            this.btnClearObl.Text = "Clear Table";
            this.btnClearObl.UseVisualStyleBackColor = true;
            this.btnClearObl.Click += new System.EventHandler(this.btnClearObl_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "<- id bonds";
            // 
            // txtBoxIdForObl
            // 
            this.txtBoxIdForObl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxIdForObl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxIdForObl.Location = new System.Drawing.Point(136, 465);
            this.txtBoxIdForObl.Name = "txtBoxIdForObl";
            this.txtBoxIdForObl.Size = new System.Drawing.Size(57, 20);
            this.txtBoxIdForObl.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(9, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exequte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnStoreProc_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(824, 457);
            this.dataGridView2.TabIndex = 0;
            // 
            // columnId
            // 
            this.columnId.Name = "columnId";
            // 
            // colName
            // 
            this.colName.Name = "colName";
            // 
            // colAge
            // 
            this.colAge.Name = "colAge";
            // 
            // colJob
            // 
            this.colJob.Name = "colJob";
            // 
            // Formm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(830, 519);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Formm1";
            this.Text = "Neko Paper";
            this.TransparencyKey = System.Drawing.Color.MediumPurple;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem finAssetBtn;
        private System.Windows.Forms.ToolStripMenuItem tStripTab2;
        private System.Windows.Forms.ToolStripMenuItem tStripTab3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJob;
        private System.Windows.Forms.Button btnSaveTable;
        private System.Windows.Forms.Label lbIdForDel;
        private System.Windows.Forms.TextBox txtBoxIdRowForDel;
        private System.Windows.Forms.Button btnRemRow;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxIdForObl;
        private System.Windows.Forms.Button btnClearObl;
        private Label label2;
        private Label label3;
        private ToolStripMenuItem securityToolStripMenuItem;
        private Label labelNameTable;
    }
}

