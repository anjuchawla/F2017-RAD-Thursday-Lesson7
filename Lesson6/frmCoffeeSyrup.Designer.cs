namespace Lesson6
{
    partial class frmCoffeeSyrup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoffeeSyrup));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCoffee = new System.Windows.Forms.ComboBox();
            this.lstSyrup = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrintSelectedFlavours = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrintSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPreviewSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrintAllFlavours = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrintAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPreviewAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddCoffeeFlavour = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRemoveCoffeeFlavour = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCountCoffeeFlavours = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printAllDocument = new System.Drawing.Printing.PrintDocument();
            this.printSelectedDocument = new System.Drawing.Printing.PrintDocument();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCoffeeFlavoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coffee and Syrup Selection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anju Chawla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Coffee Flavour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "&Syrup";
            // 
            // cboCoffee
            // 
            this.cboCoffee.FormattingEnabled = true;
            this.cboCoffee.Items.AddRange(new object[] {
            "Chocolate Almond",
            "Espresso Roast",
            "Jamaica Blue Mountain",
            "Kona Blend",
            "Vanilla Nut"});
            this.cboCoffee.Location = new System.Drawing.Point(68, 167);
            this.cboCoffee.Name = "cboCoffee";
            this.cboCoffee.Size = new System.Drawing.Size(193, 24);
            this.cboCoffee.Sorted = true;
            this.cboCoffee.TabIndex = 4;
            // 
            // lstSyrup
            // 
            this.lstSyrup.FormattingEnabled = true;
            this.lstSyrup.ItemHeight = 16;
            this.lstSyrup.Items.AddRange(new object[] {
            "(None)",
            "Chocolate",
            "Hazel Nut",
            "Irish Creme",
            "Orange "});
            this.lstSyrup.Location = new System.Drawing.Point(398, 167);
            this.lstSyrup.Name = "lstSyrup";
            this.lstSyrup.Size = new System.Drawing.Size(120, 84);
            this.lstSyrup.Sorted = true;
            this.lstSyrup.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.editToolStripMenuItem,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPrintSelectedFlavours,
            this.tsmiPrintAllFlavours,
            this.toolStripSeparator1,
            this.tsmiExit,
            this.openFileToolStripMenuItem,
            this.saveCoffeeFlavoursToolStripMenuItem});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(44, 24);
            this.tsmiFile.Text = "&File";
            // 
            // tsmiPrintSelectedFlavours
            // 
            this.tsmiPrintSelectedFlavours.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPrintSelected,
            this.tsmiPreviewSelected});
            this.tsmiPrintSelectedFlavours.Name = "tsmiPrintSelectedFlavours";
            this.tsmiPrintSelectedFlavours.Size = new System.Drawing.Size(233, 26);
            this.tsmiPrintSelectedFlavours.Text = "Print &Selected Flavours";
            // 
            // tsmiPrintSelected
            // 
            this.tsmiPrintSelected.Name = "tsmiPrintSelected";
            this.tsmiPrintSelected.Size = new System.Drawing.Size(196, 26);
            this.tsmiPrintSelected.Text = "&Print Selected";
            this.tsmiPrintSelected.Click += new System.EventHandler(this.tsmiPrintSelected_Click);
            // 
            // tsmiPreviewSelected
            // 
            this.tsmiPreviewSelected.Name = "tsmiPreviewSelected";
            this.tsmiPreviewSelected.Size = new System.Drawing.Size(196, 26);
            this.tsmiPreviewSelected.Text = "Preview &Selected";
            this.tsmiPreviewSelected.Click += new System.EventHandler(this.tsmiPreviewSelected_Click);
            // 
            // tsmiPrintAllFlavours
            // 
            this.tsmiPrintAllFlavours.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPrintAll,
            this.tsmiPreviewAll});
            this.tsmiPrintAllFlavours.Name = "tsmiPrintAllFlavours";
            this.tsmiPrintAllFlavours.Size = new System.Drawing.Size(233, 26);
            this.tsmiPrintAllFlavours.Text = "Print &All Flavours";
            // 
            // tsmiPrintAll
            // 
            this.tsmiPrintAll.Name = "tsmiPrintAll";
            this.tsmiPrintAll.Size = new System.Drawing.Size(155, 26);
            this.tsmiPrintAll.Text = "&Print All";
            this.tsmiPrintAll.Click += new System.EventHandler(this.tsmiPrintAll_Click);
            // 
            // tsmiPreviewAll
            // 
            this.tsmiPreviewAll.Name = "tsmiPreviewAll";
            this.tsmiPreviewAll.Size = new System.Drawing.Size(155, 26);
            this.tsmiPreviewAll.Text = "Pre&view all";
            this.tsmiPreviewAll.Click += new System.EventHandler(this.tsmiPreviewAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(233, 26);
            this.tsmiExit.Text = "E&xit";
            this.tsmiExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddCoffeeFlavour,
            this.tsmiRemoveCoffeeFlavour,
            this.tsmiClearAll,
            this.tsmiCountCoffeeFlavours});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // tsmiAddCoffeeFlavour
            // 
            this.tsmiAddCoffeeFlavour.Name = "tsmiAddCoffeeFlavour";
            this.tsmiAddCoffeeFlavour.Size = new System.Drawing.Size(246, 26);
            this.tsmiAddCoffeeFlavour.Text = "&Add Coffee Flavour";
            this.tsmiAddCoffeeFlavour.Click += new System.EventHandler(this.tsmiAddCoffeeFlavour_Click);
            // 
            // tsmiRemoveCoffeeFlavour
            // 
            this.tsmiRemoveCoffeeFlavour.Name = "tsmiRemoveCoffeeFlavour";
            this.tsmiRemoveCoffeeFlavour.Size = new System.Drawing.Size(246, 26);
            this.tsmiRemoveCoffeeFlavour.Text = "&Remove Coffee Flavour";
            this.tsmiRemoveCoffeeFlavour.Click += new System.EventHandler(this.tsmiRemoveCoffeeFlavour_Click);
            // 
            // tsmiClearAll
            // 
            this.tsmiClearAll.Name = "tsmiClearAll";
            this.tsmiClearAll.Size = new System.Drawing.Size(246, 26);
            this.tsmiClearAll.Text = "&Clear All Coffee Flavours";
            this.tsmiClearAll.Click += new System.EventHandler(this.tsmiClearAll_Click);
            // 
            // tsmiCountCoffeeFlavours
            // 
            this.tsmiCountCoffeeFlavours.Name = "tsmiCountCoffeeFlavours";
            this.tsmiCountCoffeeFlavours.Size = new System.Drawing.Size(246, 26);
            this.tsmiCountCoffeeFlavours.Text = "C&ount Coffee Flavours";
            this.tsmiCountCoffeeFlavours.Click += new System.EventHandler(this.tsmiCountCoffeeFlavours_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(53, 24);
            this.tsmiHelp.Text = "&Help";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(125, 26);
            this.tsmiAbout.Text = "&About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printAllDocument
            // 
            this.printAllDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printAllDocument_PrintPage);
            // 
            // printSelectedDocument
            // 
            this.printSelectedDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printSelectedDocument_PrintPage);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.openFileToolStripMenuItem.Text = "&Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveCoffeeFlavoursToolStripMenuItem
            // 
            this.saveCoffeeFlavoursToolStripMenuItem.Name = "saveCoffeeFlavoursToolStripMenuItem";
            this.saveCoffeeFlavoursToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.saveCoffeeFlavoursToolStripMenuItem.Text = "Sa&ve Coffee Flavours ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmCoffeeSyrup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 329);
            this.Controls.Add(this.lstSyrup);
            this.Controls.Add(this.cboCoffee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCoffeeSyrup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R \'n R for Reading and Refreshment";
            this.Load += new System.EventHandler(this.frmCoffeeSyrup_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCoffee;
        private System.Windows.Forms.ListBox lstSyrup;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrintSelectedFlavours;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrintAllFlavours;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddCoffeeFlavour;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveCoffeeFlavour;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiCountCoffeeFlavours;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printAllDocument;
        private System.Drawing.Printing.PrintDocument printSelectedDocument;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrintSelected;
        private System.Windows.Forms.ToolStripMenuItem tsmiPreviewSelected;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrintAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiPreviewAll;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCoffeeFlavoursToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

