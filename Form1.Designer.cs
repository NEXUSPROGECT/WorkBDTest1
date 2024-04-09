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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formm1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNameTable = new System.Windows.Forms.Label();
            this.btnRemRow = new System.Windows.Forms.Button();
            this.btnSaveTable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxIdForObl = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnClearObl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.finAssetBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.bondBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.tikerBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.securityBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(834, 521);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(826, 495);
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
            this.splitContainer1.Panel2.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel2.Controls.Add(this.btnSet);
            this.splitContainer1.Panel2.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.labelNameTable);
            this.splitContainer1.Panel2.Controls.Add(this.btnRemRow);
            this.splitContainer1.Panel2.Controls.Add(this.btnSaveTable);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(820, 489);
            this.splitContainer1.SplitterDistance = 122;
            this.splitContainer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(130, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(130, 450);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(130, 489);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnSet
            // 
            this.btnSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSet.BackgroundImage = global::LearnForms1.Properties.Resources.free_icon_setting_3421830;
            this.btnSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSet.Location = new System.Drawing.Point(661, 5);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(30, 30);
            this.btnSet.TabIndex = 8;
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::LearnForms1.Properties.Resources.btnAdded;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(3, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(27, 27);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(638, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "by n4d3sh";
            // 
            // labelNameTable
            // 
            this.labelNameTable.AutoSize = true;
            this.labelNameTable.BackColor = System.Drawing.Color.Transparent;
            this.labelNameTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelNameTable.Location = new System.Drawing.Point(342, 16);
            this.labelNameTable.Name = "labelNameTable";
            this.labelNameTable.Size = new System.Drawing.Size(0, 22);
            this.labelNameTable.TabIndex = 6;
            // 
            // btnRemRow
            // 
            this.btnRemRow.BackColor = System.Drawing.Color.Transparent;
            this.btnRemRow.BackgroundImage = global::LearnForms1.Properties.Resources.btnDelete;
            this.btnRemRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemRow.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemRow.Location = new System.Drawing.Point(36, 7);
            this.btnRemRow.Name = "btnRemRow";
            this.btnRemRow.Size = new System.Drawing.Size(27, 27);
            this.btnRemRow.TabIndex = 4;
            this.btnRemRow.UseVisualStyleBackColor = false;
            this.btnRemRow.Click += new System.EventHandler(this.btnRemRow_Click);
            // 
            // btnSaveTable
            // 
            this.btnSaveTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveTable.BackgroundImage = global::LearnForms1.Properties.Resources.btnSave;
            this.btnSaveTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveTable.Location = new System.Drawing.Point(69, 7);
            this.btnSaveTable.Name = "btnSaveTable";
            this.btnSaveTable.Size = new System.Drawing.Size(27, 27);
            this.btnSaveTable.TabIndex = 1;
            this.btnSaveTable.UseVisualStyleBackColor = false;
            this.btnSaveTable.Click += new System.EventHandler(this.btnSaveTable_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 40);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(687, 443);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtBoxIdForObl);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.btnClearObl);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(826, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Obligation Info";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(770, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "by n4d3sh";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "<- id bonds";
            // 
            // txtBoxIdForObl
            // 
            this.txtBoxIdForObl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxIdForObl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxIdForObl.Location = new System.Drawing.Point(42, 465);
            this.txtBoxIdForObl.Name = "txtBoxIdForObl";
            this.txtBoxIdForObl.Size = new System.Drawing.Size(57, 20);
            this.txtBoxIdForObl.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(826, 455);
            this.dataGridView2.TabIndex = 0;
            // 
            // btnClearObl
            // 
            this.btnClearObl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearObl.BackgroundImage = global::LearnForms1.Properties.Resources.btnDelete;
            this.btnClearObl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearObl.Location = new System.Drawing.Point(790, 461);
            this.btnClearObl.Name = "btnClearObl";
            this.btnClearObl.Size = new System.Drawing.Size(27, 27);
            this.btnClearObl.TabIndex = 4;
            this.btnClearObl.UseVisualStyleBackColor = true;
            this.btnClearObl.Click += new System.EventHandler(this.btnClearObl_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::LearnForms1.Properties.Resources.free_icon_eject_10347376;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(9, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 27);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnStoreProc_Click);
            // 
            // finAssetBtn
            // 
            this.finAssetBtn.Name = "finAssetBtn";
            this.finAssetBtn.Size = new System.Drawing.Size(32, 19);
            // 
            // bondBtn
            // 
            this.bondBtn.Name = "bondBtn";
            this.bondBtn.Size = new System.Drawing.Size(32, 19);
            // 
            // tikerBtn
            // 
            this.tikerBtn.Name = "tikerBtn";
            this.tikerBtn.Size = new System.Drawing.Size(32, 19);
            // 
            // securityBtn
            // 
            this.securityBtn.Name = "securityBtn";
            this.securityBtn.Size = new System.Drawing.Size(32, 19);
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
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(102, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 27);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Formm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(830, 519);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolStripMenuItem bondBtn;
        private System.Windows.Forms.ToolStripMenuItem tikerBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJob;
        private System.Windows.Forms.Button btnSaveTable;
        private System.Windows.Forms.Button btnRemRow;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxIdForObl;
        private System.Windows.Forms.Button btnClearObl;
        private Label label2;
        private Label label3;
        private ToolStripMenuItem securityBtn;
        private Label labelNameTable;
        private Button btnAdd;
        private Button btnSet;
        private Button btnSearch;
    }
}

