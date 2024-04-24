namespace course_sierpinski_pyramid {
    partial class MainProgramInterface {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGuide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelIterations = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelVertices = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPlanes = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelIterations = new System.Windows.Forms.Label();
            this.numericUpDownIterations = new System.Windows.Forms.NumericUpDown();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageVertices = new System.Windows.Forms.TabPage();
            this.dataGridViewVertices = new System.Windows.Forms.DataGridView();
            this.tabPagePlanes = new System.Windows.Forms.TabPage();
            this.dataGridViewPlanes = new System.Windows.Forms.DataGridView();
            this.toolStripMenuItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageVertices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVertices)).BeginInit();
            this.tabPagePlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemGuide});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(704, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemImport,
            this.toolStripMenuItemExport});
            this.toolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItemFile.Text = "Файл";
            // 
            // ToolStripMenuItemGuide
            // 
            this.toolStripMenuItemGuide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemHelp,
            this.toolStripMenuItemAbout});
            this.toolStripMenuItemGuide.Name = "ToolStripMenuItemGuide";
            this.toolStripMenuItemGuide.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItemGuide.Text = "Справка";
            // 
            // ToolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItemHelp.Text = "Помощь";
            // 
            // ToolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItemAbout.Text = "О программе";
            // 
            // statusStrip1
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelIterations,
            this.toolStripStatusLabelVertices,
            this.toolStripStatusLabelPlanes,
            this.toolStripStatusLabelSpace,
            this.toolStripStatusLabelTime});
            this.statusStrip.Location = new System.Drawing.Point(5, 388);
            this.statusStrip.Name = "statusStrip1";
            this.statusStrip.Size = new System.Drawing.Size(490, 24);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelIterations
            // 
            this.toolStripStatusLabelIterations.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabelIterations.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabelIterations.Name = "toolStripStatusLabelIterations";
            this.toolStripStatusLabelIterations.Size = new System.Drawing.Size(76, 19);
            this.toolStripStatusLabelIterations.Text = "Итерация: 0";
            // 
            // toolStripStatusLabelVertices
            // 
            this.toolStripStatusLabelVertices.Name = "toolStripStatusLabelVertices";
            this.toolStripStatusLabelVertices.Size = new System.Drawing.Size(64, 19);
            this.toolStripStatusLabelVertices.Text = "Вершин: 0";
            // 
            // toolStripStatusLabelPlanes
            // 
            this.toolStripStatusLabelPlanes.Name = "toolStripStatusLabelPlanes";
            this.toolStripStatusLabelPlanes.Size = new System.Drawing.Size(60, 19);
            this.toolStripStatusLabelPlanes.Text = "Сторон: 0";
            // 
            // toolStripStatusLabelSpace
            // 
            this.toolStripStatusLabelSpace.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabelSpace.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabelSpace.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusLabelSpace.Name = "toolStripStatusLabelSpace";
            this.toolStripStatusLabelSpace.Size = new System.Drawing.Size(267, 19);
            this.toolStripStatusLabelSpace.Spring = true;
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(129, 19);
            this.toolStripStatusLabelTime.Text = "Время: 00:00:00.000000";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.buttonGenerate);
            this.splitContainer.Panel1.Controls.Add(this.labelIterations);
            this.splitContainer.Panel1.Controls.Add(this.numericUpDownIterations);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer.Panel1MinSize = 150;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tabControl);
            this.splitContainer.Panel2.Controls.Add(this.statusStrip);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer.Panel2MinSize = 300;
            this.splitContainer.Size = new System.Drawing.Size(704, 417);
            this.splitContainer.SplitterDistance = 200;
            this.splitContainer.TabIndex = 8;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerate.Location = new System.Drawing.Point(8, 361);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(184, 47);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Генерировать";
            this.buttonGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonGenerate.UseVisualStyleBackColor = false;
            // 
            // labelIterations
            // 
            this.labelIterations.AutoSize = true;
            this.labelIterations.Location = new System.Drawing.Point(8, 10);
            this.labelIterations.Name = "labelIterations";
            this.labelIterations.Size = new System.Drawing.Size(56, 13);
            this.labelIterations.TabIndex = 1;
            this.labelIterations.Text = "Итерации";
            // 
            // numericUpDown1
            // 
            this.numericUpDownIterations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownIterations.Location = new System.Drawing.Point(72, 8);
            this.numericUpDownIterations.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownIterations.Name = "numericUpDown1";
            this.numericUpDownIterations.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownIterations.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageVertices);
            this.tabControl.Controls.Add(this.tabPagePlanes);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(5, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(490, 383);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageVertices
            // 
            this.tabPageVertices.Controls.Add(this.dataGridViewVertices);
            this.tabPageVertices.Location = new System.Drawing.Point(4, 22);
            this.tabPageVertices.Name = "tabPageVertices";
            this.tabPageVertices.Size = new System.Drawing.Size(482, 357);
            this.tabPageVertices.TabIndex = 0;
            this.tabPageVertices.Text = "Вершины";
            this.tabPageVertices.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridViewVertices.AllowUserToAddRows = false;
            this.dataGridViewVertices.AllowUserToDeleteRows = false;
            this.dataGridViewVertices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVertices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVertices.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewVertices.Name = "dataGridView1";
            this.dataGridViewVertices.ReadOnly = true;
            this.dataGridViewVertices.Size = new System.Drawing.Size(482, 357);
            this.dataGridViewVertices.TabIndex = 0;
            // 
            // tabPagePlanes
            // 
            this.tabPagePlanes.Controls.Add(this.dataGridViewPlanes);
            this.tabPagePlanes.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlanes.Name = "tabPagePlanes";
            this.tabPagePlanes.Size = new System.Drawing.Size(603, 357);
            this.tabPagePlanes.TabIndex = 1;
            this.tabPagePlanes.Text = "Стороны";
            this.tabPagePlanes.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridViewPlanes.AllowUserToAddRows = false;
            this.dataGridViewPlanes.AllowUserToDeleteRows = false;
            this.dataGridViewPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPlanes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPlanes.Name = "dataGridView2";
            this.dataGridViewPlanes.ReadOnly = true;
            this.dataGridViewPlanes.Size = new System.Drawing.Size(603, 357);
            this.dataGridViewPlanes.TabIndex = 0;
            // 
            // экспортToolStripMenuItem
            // 
            this.toolStripMenuItemExport.Name = "экспортToolStripMenuItem";
            this.toolStripMenuItemExport.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemExport.Text = "Экспорт";
            // 
            // импортToolStripMenuItem
            // 
            this.toolStripMenuItemImport.Name = "импортToolStripMenuItem";
            this.toolStripMenuItemImport.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemImport.Text = "Импорт";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Пирамида Серпинского 3D";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageVertices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVertices)).EndInit();
            this.tabPagePlanes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGuide;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExport;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImport;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelIterations;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVertices;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPlanes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSpace;
        private System.Windows.Forms.TabPage tabPageVertices;
        private System.Windows.Forms.DataGridView dataGridViewVertices;
        private System.Windows.Forms.TabPage tabPagePlanes;
        private System.Windows.Forms.DataGridView dataGridViewPlanes;

        private System.Windows.Forms.Label labelIterations;
        private System.Windows.Forms.NumericUpDown numericUpDownIterations;
        private System.Windows.Forms.Button buttonGenerate;
    }
}

