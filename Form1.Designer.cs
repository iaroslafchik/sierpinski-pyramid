namespace sierpinski_pyramid {
    partial class Form1 {
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
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExportOFF = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGuide = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelIterations = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelVertices = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPlanes = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageVertices = new System.Windows.Forms.TabPage();
            this.tabPagePlanes = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelIterations = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageVertices.SuspendLayout();
            this.tabPagePlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.ToolStripMenuItemGuide});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(624, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemExport});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(48, 20);
            this.ToolStripMenuItemFile.Text = "Файл";
            // 
            // ToolStripMenuItemExport
            // 
            this.ToolStripMenuItemExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemExportOFF});
            this.ToolStripMenuItemExport.Name = "ToolStripMenuItemExport";
            this.ToolStripMenuItemExport.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemExport.Text = "Экспорт";
            // 
            // ToolStripMenuItemExportOFF
            // 
            this.ToolStripMenuItemExportOFF.Name = "ToolStripMenuItemExportOFF";
            this.ToolStripMenuItemExportOFF.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemExportOFF.Text = ".OFF";
            // 
            // ToolStripMenuItemGuide
            // 
            this.ToolStripMenuItemGuide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemHelp,
            this.ToolStripMenuItemAbout});
            this.ToolStripMenuItemGuide.Name = "ToolStripMenuItemGuide";
            this.ToolStripMenuItemGuide.Size = new System.Drawing.Size(65, 20);
            this.ToolStripMenuItemGuide.Text = "Справка";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelIterations,
            this.toolStripStatusLabelVertices,
            this.toolStripStatusLabelPlanes,
            this.toolStripStatusLabelSpace,
            this.toolStripStatusLabelTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 24);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
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
            this.toolStripStatusLabelSpace.Size = new System.Drawing.Size(280, 19);
            this.toolStripStatusLabelSpace.Spring = true;
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(129, 19);
            this.toolStripStatusLabelTime.Text = "Время: 00:00:00.000000";
            // 
            // ToolStripMenuItemHelp
            // 
            this.ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
            this.ToolStripMenuItemHelp.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemHelp.Text = "Помощь";
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemAbout.Text = "О программе";
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
            this.splitContainer.Panel1.Controls.Add(this.numericUpDown1);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer.Panel1MinSize = 150;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tabControl);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer.Panel2MinSize = 300;
            this.splitContainer.Size = new System.Drawing.Size(624, 393);
            this.splitContainer.SplitterDistance = 200;
            this.splitContainer.TabIndex = 8;
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
            this.tabControl.Size = new System.Drawing.Size(410, 383);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageVertices
            // 
            this.tabPageVertices.Controls.Add(this.dataGridView1);
            this.tabPageVertices.Location = new System.Drawing.Point(4, 22);
            this.tabPageVertices.Name = "tabPageVertices";
            this.tabPageVertices.Size = new System.Drawing.Size(402, 357);
            this.tabPageVertices.TabIndex = 0;
            this.tabPageVertices.Text = "Вершины";
            this.tabPageVertices.UseVisualStyleBackColor = true;
            // 
            // tabPagePlanes
            // 
            this.tabPagePlanes.Controls.Add(this.dataGridView2);
            this.tabPagePlanes.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlanes.Name = "tabPagePlanes";
            this.tabPagePlanes.Size = new System.Drawing.Size(365, 443);
            this.tabPagePlanes.TabIndex = 1;
            this.tabPagePlanes.Text = "Стороны";
            this.tabPagePlanes.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(402, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(365, 443);
            this.dataGridView2.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(72, 8);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
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
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerate.Location = new System.Drawing.Point(8, 337);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(184, 47);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Генерировать";
            this.buttonGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonGenerate.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Пирамида Серпинского 3D";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageVertices.ResumeLayout(false);
            this.tabPagePlanes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExport;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExportOFF;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGuide;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelIterations;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVertices;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPlanes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSpace;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageVertices;
        private System.Windows.Forms.TabPage tabPagePlanes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelIterations;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonGenerate;
    }
}

