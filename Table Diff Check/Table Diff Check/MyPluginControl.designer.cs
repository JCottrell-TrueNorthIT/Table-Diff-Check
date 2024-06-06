namespace Table_Diff_Check
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSample = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableSelectComboBox = new System.Windows.Forms.ComboBox();
            this.columnTabControl = new System.Windows.Forms.TabControl();
            this.changedTab = new System.Windows.Forms.TabPage();
            this.allTab = new System.Windows.Forms.TabPage();
            this.changedColumnListBox = new System.Windows.Forms.ListBox();
            this.allColumnListBox = new System.Windows.Forms.ListBox();
            this.metadataTabControl = new System.Windows.Forms.TabControl();
            this.changedMetadataTab = new System.Windows.Forms.TabPage();
            this.environmentOneMetadataTab = new System.Windows.Forms.TabPage();
            this.environmentTwoMetadataTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnMetadataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.environment1ValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.environment2ValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.columnTabControl.SuspendLayout();
            this.changedTab.SuspendLayout();
            this.allTab.SuspendLayout();
            this.metadataTabControl.SuspendLayout();
            this.changedMetadataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnMetadataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.tsbSample});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(2014, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(86, 22);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSample
            // 
            this.tsbSample.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSample.Name = "tsbSample";
            this.tsbSample.Size = new System.Drawing.Size(46, 22);
            this.tsbSample.Text = "Try me";
            this.tsbSample.Click += new System.EventHandler(this.tsbSample_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.metadataTabControl);
            this.splitContainer1.Size = new System.Drawing.Size(2014, 870);
            this.splitContainer1.SplitterDistance = 671;
            this.splitContainer1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.columnTabControl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.091954F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.90804F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(671, 870);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableSelectComboBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 47);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table (Entity)";
            // 
            // tableSelectComboBox
            // 
            this.tableSelectComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSelectComboBox.FormattingEnabled = true;
            this.tableSelectComboBox.Location = new System.Drawing.Point(3, 16);
            this.tableSelectComboBox.Name = "tableSelectComboBox";
            this.tableSelectComboBox.Size = new System.Drawing.Size(659, 21);
            this.tableSelectComboBox.TabIndex = 0;
            // 
            // columnTabControl
            // 
            this.columnTabControl.Controls.Add(this.changedTab);
            this.columnTabControl.Controls.Add(this.allTab);
            this.columnTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.columnTabControl.Location = new System.Drawing.Point(3, 56);
            this.columnTabControl.Name = "columnTabControl";
            this.columnTabControl.SelectedIndex = 0;
            this.columnTabControl.Size = new System.Drawing.Size(665, 811);
            this.columnTabControl.TabIndex = 2;
            // 
            // changedTab
            // 
            this.changedTab.Controls.Add(this.changedColumnListBox);
            this.changedTab.Location = new System.Drawing.Point(4, 22);
            this.changedTab.Name = "changedTab";
            this.changedTab.Padding = new System.Windows.Forms.Padding(3);
            this.changedTab.Size = new System.Drawing.Size(657, 785);
            this.changedTab.TabIndex = 0;
            this.changedTab.Text = "Changed Columns";
            this.changedTab.UseVisualStyleBackColor = true;
            // 
            // allTab
            // 
            this.allTab.Controls.Add(this.allColumnListBox);
            this.allTab.Location = new System.Drawing.Point(4, 22);
            this.allTab.Name = "allTab";
            this.allTab.Padding = new System.Windows.Forms.Padding(3);
            this.allTab.Size = new System.Drawing.Size(657, 785);
            this.allTab.TabIndex = 1;
            this.allTab.Text = "All Columns";
            this.allTab.UseVisualStyleBackColor = true;
            // 
            // changedColumnListBox
            // 
            this.changedColumnListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changedColumnListBox.FormattingEnabled = true;
            this.changedColumnListBox.Location = new System.Drawing.Point(3, 3);
            this.changedColumnListBox.Name = "changedColumnListBox";
            this.changedColumnListBox.Size = new System.Drawing.Size(651, 779);
            this.changedColumnListBox.TabIndex = 0;
            // 
            // allColumnListBox
            // 
            this.allColumnListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allColumnListBox.FormattingEnabled = true;
            this.allColumnListBox.Location = new System.Drawing.Point(3, 3);
            this.allColumnListBox.Name = "allColumnListBox";
            this.allColumnListBox.Size = new System.Drawing.Size(651, 779);
            this.allColumnListBox.TabIndex = 0;
            // 
            // metadataTabControl
            // 
            this.metadataTabControl.Controls.Add(this.changedMetadataTab);
            this.metadataTabControl.Controls.Add(this.environmentOneMetadataTab);
            this.metadataTabControl.Controls.Add(this.environmentTwoMetadataTab);
            this.metadataTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metadataTabControl.Location = new System.Drawing.Point(0, 0);
            this.metadataTabControl.Name = "metadataTabControl";
            this.metadataTabControl.SelectedIndex = 0;
            this.metadataTabControl.Size = new System.Drawing.Size(1339, 870);
            this.metadataTabControl.TabIndex = 0;
            // 
            // changedMetadataTab
            // 
            this.changedMetadataTab.Controls.Add(this.dataGridView1);
            this.changedMetadataTab.Location = new System.Drawing.Point(4, 22);
            this.changedMetadataTab.Name = "changedMetadataTab";
            this.changedMetadataTab.Padding = new System.Windows.Forms.Padding(3);
            this.changedMetadataTab.Size = new System.Drawing.Size(1331, 844);
            this.changedMetadataTab.TabIndex = 0;
            this.changedMetadataTab.Text = "Differences";
            this.changedMetadataTab.UseVisualStyleBackColor = true;
            // 
            // environmentOneMetadataTab
            // 
            this.environmentOneMetadataTab.Location = new System.Drawing.Point(4, 22);
            this.environmentOneMetadataTab.Name = "environmentOneMetadataTab";
            this.environmentOneMetadataTab.Padding = new System.Windows.Forms.Padding(3);
            this.environmentOneMetadataTab.Size = new System.Drawing.Size(1331, 844);
            this.environmentOneMetadataTab.TabIndex = 1;
            this.environmentOneMetadataTab.Text = "envOneName";
            this.environmentOneMetadataTab.UseVisualStyleBackColor = true;
            // 
            // environmentTwoMetadataTab
            // 
            this.environmentTwoMetadataTab.Location = new System.Drawing.Point(4, 22);
            this.environmentTwoMetadataTab.Name = "environmentTwoMetadataTab";
            this.environmentTwoMetadataTab.Size = new System.Drawing.Size(1331, 844);
            this.environmentTwoMetadataTab.TabIndex = 2;
            this.environmentTwoMetadataTab.Text = "envTwoName";
            this.environmentTwoMetadataTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.environment1ValueDataGridViewTextBoxColumn,
            this.environment2ValueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.columnMetadataBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1325, 838);
            this.dataGridView1.TabIndex = 0;
            // 
            // columnMetadataBindingSource
            // 
            this.columnMetadataBindingSource.DataSource = typeof(Table_Diff_Check.ColumnMetadata);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // environment1ValueDataGridViewTextBoxColumn
            // 
            this.environment1ValueDataGridViewTextBoxColumn.DataPropertyName = "Environment1Value";
            this.environment1ValueDataGridViewTextBoxColumn.HeaderText = "Environment1Value";
            this.environment1ValueDataGridViewTextBoxColumn.Name = "environment1ValueDataGridViewTextBoxColumn";
            // 
            // environment2ValueDataGridViewTextBoxColumn
            // 
            this.environment2ValueDataGridViewTextBoxColumn.DataPropertyName = "Environment2Value";
            this.environment2ValueDataGridViewTextBoxColumn.HeaderText = "Environment2Value";
            this.environment2ValueDataGridViewTextBoxColumn.Name = "environment2ValueDataGridViewTextBoxColumn";
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(2014, 895);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.columnTabControl.ResumeLayout(false);
            this.changedTab.ResumeLayout(false);
            this.allTab.ResumeLayout(false);
            this.metadataTabControl.ResumeLayout(false);
            this.changedMetadataTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnMetadataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbSample;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox tableSelectComboBox;
        private System.Windows.Forms.TabControl columnTabControl;
        private System.Windows.Forms.TabPage changedTab;
        private System.Windows.Forms.TabPage allTab;
        private System.Windows.Forms.ListBox changedColumnListBox;
        private System.Windows.Forms.ListBox allColumnListBox;
        private System.Windows.Forms.TabControl metadataTabControl;
        private System.Windows.Forms.TabPage changedMetadataTab;
        private System.Windows.Forms.TabPage environmentOneMetadataTab;
        private System.Windows.Forms.TabPage environmentTwoMetadataTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn environment1ValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn environment2ValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource columnMetadataBindingSource;
    }
}
