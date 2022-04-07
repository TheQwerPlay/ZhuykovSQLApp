namespace ZhuykovSQLApp
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.candyTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sweetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.arrivalLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 532);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.candyTableToolStripMenuItem,
            this.referenceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(784, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // candyTableToolStripMenuItem
            // 
            this.candyTableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sweetsToolStripMenuItem,
            this.supplierToolStripMenuItem1,
            this.arrivalLogToolStripMenuItem});
            this.candyTableToolStripMenuItem.Name = "candyTableToolStripMenuItem";
            this.candyTableToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.candyTableToolStripMenuItem.Text = "Выбор таблицы";
            // 
            // sweetsToolStripMenuItem
            // 
            this.sweetsToolStripMenuItem.Name = "sweetsToolStripMenuItem";
            this.sweetsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.sweetsToolStripMenuItem.Text = "Конфеты";
            this.sweetsToolStripMenuItem.Click += new System.EventHandler(this.sweetsToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem1
            // 
            this.supplierToolStripMenuItem1.Name = "supplierToolStripMenuItem1";
            this.supplierToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.supplierToolStripMenuItem1.Text = "Поставщики";
            this.supplierToolStripMenuItem1.Click += new System.EventHandler(this.supplierToolStripMenuItem1_Click);
            // 
            // arrivalLogToolStripMenuItem
            // 
            this.arrivalLogToolStripMenuItem.Name = "arrivalLogToolStripMenuItem";
            this.arrivalLogToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.arrivalLogToolStripMenuItem.Text = "Журнал поступления";
            this.arrivalLogToolStripMenuItem.Click += new System.EventHandler(this.arrivalLogToolStripMenuItem_Click);
            // 
            // referenceToolStripMenuItem
            // 
            this.referenceToolStripMenuItem.Name = "referenceToolStripMenuItem";
            this.referenceToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.referenceToolStripMenuItem.Text = "Справка";
            this.referenceToolStripMenuItem.Click += new System.EventHandler(this.referenceToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("GOST type A", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem candyTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sweetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem arrivalLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}