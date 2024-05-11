namespace course_sierpinski_pyramid {
    partial class MainApplicationInterface {
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripLabelVertices = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripLabelFaces = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownIterations = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageVertices = new System.Windows.Forms.TabPage();
            this.dataGridViewVertices = new System.Windows.Forms.DataGridView();
            this.vertexNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vertexX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vertexY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vertexZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageFaces = new System.Windows.Forms.TabPage();
            this.dataGridViewFaces = new System.Windows.Forms.DataGridView();
            this.faceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verticesUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label = new System.Windows.Forms.Label();
            this.labelScroll = new System.Windows.Forms.Label();
            this.numericUpDownScroll = new System.Windows.Forms.NumericUpDown();
            this.labelNumber = new System.Windows.Forms.Label();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageVertices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVertices)).BeginInit();
            this.tabPageFaces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabelVertices,
            this.statusStripLabelFaces,
            this.statusStripSpacer,
            this.statusStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 439);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(624, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "Строка состояния";
            // 
            // statusStripLabelVertices
            // 
            this.statusStripLabelVertices.Name = "statusStripLabelVertices";
            this.statusStripLabelVertices.Size = new System.Drawing.Size(64, 17);
            this.statusStripLabelVertices.Text = "Вершин: 0";
            // 
            // statusStripLabelFaces
            // 
            this.statusStripLabelFaces.Name = "statusStripLabelFaces";
            this.statusStripLabelFaces.Size = new System.Drawing.Size(58, 17);
            this.statusStripLabelFaces.Text = "Граней: 0";
            // 
            // statusStripSpacer
            // 
            this.statusStripSpacer.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.statusStripSpacer.Name = "statusStripSpacer";
            this.statusStripSpacer.Size = new System.Drawing.Size(285, 17);
            this.statusStripSpacer.Spring = true;
            this.statusStripSpacer.Text = "some space";
            // 
            // statusStripProgressBar
            // 
            this.statusStripProgressBar.Name = "statusStripProgressBar";
            this.statusStripProgressBar.Size = new System.Drawing.Size(200, 16);
            this.statusStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItemFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip";
            // 
            // menuStripItemFile
            // 
            this.menuStripItemFile.Name = "menuStripItemFile";
            this.menuStripItemFile.Size = new System.Drawing.Size(48, 20);
            this.menuStripItemFile.Text = "Файл";
            // 
            // numericUpDownIterations
            // 
            this.numericUpDownIterations.Location = new System.Drawing.Point(71, 27);
            this.numericUpDownIterations.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownIterations.Name = "numericUpDownIterations";
            this.numericUpDownIterations.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownIterations.TabIndex = 2;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonGenerate.Location = new System.Drawing.Point(279, 38);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(166, 46);
            this.buttonGenerate.TabIndex = 3;
            this.buttonGenerate.Text = "Генерировать";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.Generate);
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.tabPageVertices);
            this.tabControl.Controls.Add(this.tabPageFaces);
            this.tabControl.ItemSize = new System.Drawing.Size(96, 32);
            this.tabControl.Location = new System.Drawing.Point(12, 87);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(433, 335);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 5;
            // 
            // tabPageVertices
            // 
            this.tabPageVertices.Controls.Add(this.dataGridViewVertices);
            this.tabPageVertices.Location = new System.Drawing.Point(4, 36);
            this.tabPageVertices.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageVertices.Name = "tabPageVertices";
            this.tabPageVertices.Size = new System.Drawing.Size(425, 295);
            this.tabPageVertices.TabIndex = 0;
            this.tabPageVertices.Text = "Вершины";
            this.tabPageVertices.UseVisualStyleBackColor = true;
            // 
            // dataGridViewVertices
            // 
            this.dataGridViewVertices.AllowUserToAddRows = false;
            this.dataGridViewVertices.AllowUserToDeleteRows = false;
            this.dataGridViewVertices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVertices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVertices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vertexNumber,
            this.vertexX,
            this.vertexY,
            this.vertexZ});
            this.dataGridViewVertices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVertices.EnableHeadersVisualStyles = false;
            this.dataGridViewVertices.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewVertices.Name = "dataGridViewVertices";
            this.dataGridViewVertices.ReadOnly = true;
            this.dataGridViewVertices.RowHeadersVisible = false;
            this.dataGridViewVertices.Size = new System.Drawing.Size(425, 295);
            this.dataGridViewVertices.TabIndex = 0;
            // 
            // vertexNumber
            // 
            this.vertexNumber.HeaderText = "Номер вершины";
            this.vertexNumber.Name = "vertexNumber";
            this.vertexNumber.ReadOnly = true;
            // 
            // vertexX
            // 
            this.vertexX.HeaderText = "X";
            this.vertexX.Name = "vertexX";
            this.vertexX.ReadOnly = true;
            // 
            // vertexY
            // 
            this.vertexY.HeaderText = "Y";
            this.vertexY.Name = "vertexY";
            this.vertexY.ReadOnly = true;
            // 
            // vertexZ
            // 
            this.vertexZ.HeaderText = "Z";
            this.vertexZ.Name = "vertexZ";
            this.vertexZ.ReadOnly = true;
            // 
            // tabPageFaces
            // 
            this.tabPageFaces.Controls.Add(this.dataGridViewFaces);
            this.tabPageFaces.Location = new System.Drawing.Point(4, 36);
            this.tabPageFaces.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageFaces.Name = "tabPageFaces";
            this.tabPageFaces.Size = new System.Drawing.Size(425, 295);
            this.tabPageFaces.TabIndex = 1;
            this.tabPageFaces.Text = "Стороны";
            this.tabPageFaces.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFaces
            // 
            this.dataGridViewFaces.AllowUserToAddRows = false;
            this.dataGridViewFaces.AllowUserToDeleteRows = false;
            this.dataGridViewFaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faceNumber,
            this.verticesUsed});
            this.dataGridViewFaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFaces.EnableHeadersVisualStyles = false;
            this.dataGridViewFaces.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFaces.Name = "dataGridViewFaces";
            this.dataGridViewFaces.ReadOnly = true;
            this.dataGridViewFaces.RowHeadersVisible = false;
            this.dataGridViewFaces.Size = new System.Drawing.Size(425, 295);
            this.dataGridViewFaces.TabIndex = 0;
            // 
            // faceNumber
            // 
            this.faceNumber.HeaderText = "Номер стороны";
            this.faceNumber.Name = "faceNumber";
            this.faceNumber.ReadOnly = true;
            // 
            // verticesUsed
            // 
            this.verticesUsed.HeaderText = "Вершины";
            this.verticesUsed.Name = "verticesUsed";
            this.verticesUsed.ReadOnly = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(9, 29);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 13);
            this.label.TabIndex = 6;
            this.label.Text = "Итерации";
            this.label.Click += new System.EventHandler(this.Label_Click);
            // 
            // labelScroll
            // 
            this.labelScroll.AutoSize = true;
            this.labelScroll.Location = new System.Drawing.Point(7, 55);
            this.labelScroll.Name = "labelScroll";
            this.labelScroll.Size = new System.Drawing.Size(58, 13);
            this.labelScroll.TabIndex = 8;
            this.labelScroll.Text = "Просмотр";
            // 
            // numericUpDownScroll
            // 
            this.numericUpDownScroll.Location = new System.Drawing.Point(71, 53);
            this.numericUpDownScroll.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownScroll.Name = "numericUpDownScroll";
            this.numericUpDownScroll.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownScroll.TabIndex = 7;
            this.numericUpDownScroll.ValueChanged += new System.EventHandler(this.NumericUpDownScroll_ValueChanged);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(141, 55);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(66, 13);
            this.labelNumber.TabIndex = 10;
            this.labelNumber.Text = "Количество";
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.Location = new System.Drawing.Point(209, 53);
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownNumber.TabIndex = 9;
            this.numericUpDownNumber.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownNumber.ValueChanged += new System.EventHandler(this.NumericUpDownNumber_ValueChanged);
            // 
            // MainApplicationInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(624, 461);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.numericUpDownNumber);
            this.Controls.Add(this.labelScroll);
            this.Controls.Add(this.numericUpDownScroll);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.numericUpDownIterations);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 500);
            this.Name = "MainApplicationInterface";
            this.ShowIcon = false;
            this.Text = "Пирамида Серпинского 3D";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageVertices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVertices)).EndInit();
            this.tabPageFaces.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemFile;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabelVertices;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabelFaces;
        private System.Windows.Forms.ToolStripProgressBar statusStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusStripSpacer;
        private System.Windows.Forms.NumericUpDown numericUpDownIterations;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageVertices;
        private System.Windows.Forms.TabPage tabPageFaces;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dataGridViewFaces;
        private System.Windows.Forms.DataGridView dataGridViewVertices;
        private System.Windows.Forms.DataGridViewTextBoxColumn vertexNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn vertexX;
        private System.Windows.Forms.DataGridViewTextBoxColumn vertexY;
        private System.Windows.Forms.DataGridViewTextBoxColumn vertexZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn faceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn verticesUsed;
        private System.Windows.Forms.Label labelScroll;
        private System.Windows.Forms.NumericUpDown numericUpDownScroll;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
    }
}

