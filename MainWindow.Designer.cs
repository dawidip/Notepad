namespace Notepad {
   partial class MainWindow {
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
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
         this.textBox = new System.Windows.Forms.TextBox();
         this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.wytnijToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.kopiujToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.wklejToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.mainMenu = new System.Windows.Forms.MenuStrip();
         this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.ustawieniaStronyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.podglądWydrukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.drukujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.cofnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
         this.wytnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.kopiujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.wklejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.wyglądToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.kolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
         this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
         this.printDocument = new System.Drawing.Printing.PrintDocument();
         this.printDialog = new System.Windows.Forms.PrintDialog();
         this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
         this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
         this.fontDialog = new System.Windows.Forms.FontDialog();
         this.colorDialog = new System.Windows.Forms.ColorDialog();
         this.contextMenu.SuspendLayout();
         this.mainMenu.SuspendLayout();
         this.SuspendLayout();
         // 
         // textBox
         // 
         this.textBox.ContextMenuStrip = this.contextMenu;
         this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textBox.Location = new System.Drawing.Point(0, 24);
         this.textBox.Multiline = true;
         this.textBox.Name = "textBox";
         this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.textBox.Size = new System.Drawing.Size(384, 238);
         this.textBox.TabIndex = 0;
         this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
         // 
         // contextMenu
         // 
         this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wytnijToolStripMenuItem1,
            this.kopiujToolStripMenuItem1,
            this.wklejToolStripMenuItem1});
         this.contextMenu.Name = "contextMenu";
         this.contextMenu.Size = new System.Drawing.Size(109, 70);
         // 
         // wytnijToolStripMenuItem1
         // 
         this.wytnijToolStripMenuItem1.Name = "wytnijToolStripMenuItem1";
         this.wytnijToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
         this.wytnijToolStripMenuItem1.Text = "Wytnij";
         this.wytnijToolStripMenuItem1.Click += new System.EventHandler(this.wytnijToolStripMenuItem_Click);
         // 
         // kopiujToolStripMenuItem1
         // 
         this.kopiujToolStripMenuItem1.Name = "kopiujToolStripMenuItem1";
         this.kopiujToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
         this.kopiujToolStripMenuItem1.Text = "Kopiuj";
         this.kopiujToolStripMenuItem1.Click += new System.EventHandler(this.kopiujToolStripMenuItem_Click);
         // 
         // wklejToolStripMenuItem1
         // 
         this.wklejToolStripMenuItem1.Name = "wklejToolStripMenuItem1";
         this.wklejToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
         this.wklejToolStripMenuItem1.Text = "Wklej";
         this.wklejToolStripMenuItem1.Click += new System.EventHandler(this.wklejToolStripMenuItem_Click);
         // 
         // mainMenu
         // 
         this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.wyglądToolStripMenuItem});
         this.mainMenu.Location = new System.Drawing.Point(0, 0);
         this.mainMenu.Name = "mainMenu";
         this.mainMenu.Size = new System.Drawing.Size(384, 24);
         this.mainMenu.TabIndex = 1;
         this.mainMenu.Text = "menuStrip1";
         // 
         // plikToolStripMenuItem
         // 
         this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.toolStripSeparator1,
            this.ustawieniaStronyToolStripMenuItem,
            this.podglądWydrukuToolStripMenuItem,
            this.drukujToolStripMenuItem,
            this.toolStripSeparator2,
            this.zamknijToolStripMenuItem});
         this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
         this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
         this.plikToolStripMenuItem.Text = "Plik";
         // 
         // nowyToolStripMenuItem
         // 
         this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
         this.nowyToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
         this.nowyToolStripMenuItem.Text = "Nowy";
         this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
         // 
         // otwórzToolStripMenuItem
         // 
         this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
         this.otwórzToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
         this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
         this.otwórzToolStripMenuItem.Text = "Otwórz...";
         this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
         // 
         // zapiszToolStripMenuItem
         // 
         this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
         this.zapiszToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
         this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
         this.zapiszToolStripMenuItem.Text = "Zapisz";
         this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
         // 
         // zapiszJakoToolStripMenuItem
         // 
         this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
         this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
         this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako...";
         this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
         // 
         // ustawieniaStronyToolStripMenuItem
         // 
         this.ustawieniaStronyToolStripMenuItem.Name = "ustawieniaStronyToolStripMenuItem";
         this.ustawieniaStronyToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
         this.ustawieniaStronyToolStripMenuItem.Text = "Ustawienia strony...";
         this.ustawieniaStronyToolStripMenuItem.Click += new System.EventHandler(this.ustawieniaStronyToolStripMenuItem_Click);
         // 
         // podglądWydrukuToolStripMenuItem
         // 
         this.podglądWydrukuToolStripMenuItem.Name = "podglądWydrukuToolStripMenuItem";
         this.podglądWydrukuToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
         this.podglądWydrukuToolStripMenuItem.Text = "Podgląd wydruku...";
         this.podglądWydrukuToolStripMenuItem.Click += new System.EventHandler(this.podglądWydrukuToolStripMenuItem_Click);
         // 
         // drukujToolStripMenuItem
         // 
         this.drukujToolStripMenuItem.Name = "drukujToolStripMenuItem";
         this.drukujToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
         this.drukujToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
         this.drukujToolStripMenuItem.Text = "Drukuj...";
         this.drukujToolStripMenuItem.Click += new System.EventHandler(this.drukujToolStripMenuItem_Click);
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
         // 
         // zamknijToolStripMenuItem
         // 
         this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
         this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
         this.zamknijToolStripMenuItem.Text = "Zamknij";
         this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
         // 
         // edycjaToolStripMenuItem
         // 
         this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cofnijToolStripMenuItem,
            this.toolStripSeparator3,
            this.wytnijToolStripMenuItem,
            this.kopiujToolStripMenuItem,
            this.wklejToolStripMenuItem});
         this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
         this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
         this.edycjaToolStripMenuItem.Text = "Edycja";
         // 
         // cofnijToolStripMenuItem
         // 
         this.cofnijToolStripMenuItem.Name = "cofnijToolStripMenuItem";
         this.cofnijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
         this.cofnijToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
         this.cofnijToolStripMenuItem.Text = "Cofnij";
         this.cofnijToolStripMenuItem.Click += new System.EventHandler(this.cofnijToolStripMenuItem_Click);
         // 
         // toolStripSeparator3
         // 
         this.toolStripSeparator3.Name = "toolStripSeparator3";
         this.toolStripSeparator3.Size = new System.Drawing.Size(147, 6);
         // 
         // wytnijToolStripMenuItem
         // 
         this.wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
         this.wytnijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
         this.wytnijToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
         this.wytnijToolStripMenuItem.Text = "Wytnij";
         this.wytnijToolStripMenuItem.Click += new System.EventHandler(this.wytnijToolStripMenuItem_Click);
         // 
         // kopiujToolStripMenuItem
         // 
         this.kopiujToolStripMenuItem.Name = "kopiujToolStripMenuItem";
         this.kopiujToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
         this.kopiujToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
         this.kopiujToolStripMenuItem.Text = "Kopiuj";
         this.kopiujToolStripMenuItem.Click += new System.EventHandler(this.kopiujToolStripMenuItem_Click);
         // 
         // wklejToolStripMenuItem
         // 
         this.wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
         this.wklejToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
         this.wklejToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
         this.wklejToolStripMenuItem.Text = "Wklej";
         this.wklejToolStripMenuItem.Click += new System.EventHandler(this.wklejToolStripMenuItem_Click);
         // 
         // wyglądToolStripMenuItem
         // 
         this.wyglądToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.czcionkaToolStripMenuItem,
            this.kolorToolStripMenuItem});
         this.wyglądToolStripMenuItem.Name = "wyglądToolStripMenuItem";
         this.wyglądToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
         this.wyglądToolStripMenuItem.Text = "Wygląd";
         // 
         // czcionkaToolStripMenuItem
         // 
         this.czcionkaToolStripMenuItem.Name = "czcionkaToolStripMenuItem";
         this.czcionkaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
         this.czcionkaToolStripMenuItem.Text = "Czcionka...";
         this.czcionkaToolStripMenuItem.Click += new System.EventHandler(this.czcionkaToolStripMenuItem_Click);
         // 
         // kolorToolStripMenuItem
         // 
         this.kolorToolStripMenuItem.Name = "kolorToolStripMenuItem";
         this.kolorToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
         this.kolorToolStripMenuItem.Text = "Kolor...";
         this.kolorToolStripMenuItem.Click += new System.EventHandler(this.kolorToolStripMenuItem_Click);
         // 
         // printDocument
         // 
         this.printDocument.DocumentName = "Notatnik.NET";
         this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
         this.printDocument.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_EndPrint);
         this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
         // 
         // printDialog
         // 
         this.printDialog.Document = this.printDocument;
         this.printDialog.UseEXDialog = true;
         // 
         // printPreviewDialog
         // 
         this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
         this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
         this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
         this.printPreviewDialog.Document = this.printDocument;
         this.printPreviewDialog.Enabled = true;
         this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
         this.printPreviewDialog.Name = "printPreviewDialog";
         this.printPreviewDialog.Visible = false;
         // 
         // pageSetupDialog
         // 
         this.pageSetupDialog.Document = this.printDocument;
         // 
         // fontDialog
         // 
         this.fontDialog.Color = System.Drawing.SystemColors.ControlText;
         // 
         // MainWindow
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(384, 262);
         this.Controls.Add(this.textBox);
         this.Controls.Add(this.mainMenu);
         this.MainMenuStrip = this.mainMenu;
         this.Name = "MainWindow";
         this.Text = "Notatnik.NET";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
         this.Load += new System.EventHandler(this.MainWindow_Load);
         this.contextMenu.ResumeLayout(false);
         this.mainMenu.ResumeLayout(false);
         this.mainMenu.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox textBox;
      private System.Windows.Forms.MenuStrip mainMenu;
      private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripMenuItem ustawieniaStronyToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem podglądWydrukuToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem drukujToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
      private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem cofnijToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
      private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem wyglądToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem kolorToolStripMenuItem;
      private System.Windows.Forms.ContextMenuStrip contextMenu;
      private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem1;
      private System.Windows.Forms.OpenFileDialog openFileDialog;
      private System.Windows.Forms.SaveFileDialog saveFileDialog;
      private System.Windows.Forms.PageSetupDialog pageSetupDialog;
      private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
      private System.Windows.Forms.PrintDialog printDialog;
      private System.Drawing.Printing.PrintDocument printDocument;
      private System.Windows.Forms.FontDialog fontDialog;
      private System.Windows.Forms.ColorDialog colorDialog;
   }
}

