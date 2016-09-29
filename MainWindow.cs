using Notepad.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad {
   public partial class MainWindow : Form {
      public MainWindow() {
         InitializeComponent();
      }

      private string currentFileName;
      private bool modified = false;

      private void textBox_TextChanged(object sender, EventArgs e) {
         modified = true;
      }

      private bool OpenFile(string name = null) {
         if (name == null) {
            openFileDialog.FileName = currentFileName;
            if (openFileDialog.ShowDialog() != DialogResult.OK) return false;
            name = openFileDialog.FileName;
         }
         try {
            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader(name)) {
               while (!reader.EndOfStream) lines.Add(reader.ReadLine());
            }
            textBox.Lines = lines.ToArray();
            textBox.SelectionStart = 0;
            textBox.SelectionLength = 0;
         }
         catch (IOException ex) {
            MessageBox.Show("Błąd odczytu pliku: " + ex.Message, "Notatnik.NET",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
         }
         currentFileName = name;
         modified = false;
         return true;
      }

      private bool SaveFile(string name = null) {
         if (name == null) {
            saveFileDialog.FileName = currentFileName;
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return false;
            name = saveFileDialog.FileName;
         }
         try {
            using (StreamWriter writer = new StreamWriter(name)) {
               foreach (string line in textBox.Lines) writer.WriteLine(line);
            }
         }
         catch(IOException ex) {
            MessageBox.Show("Błąd zapisu do pliku: " + ex.Message, "Notatnik.NET",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
         }
         currentFileName = name;
         modified = false;
         return true;
      }

      private bool AskToSaveIfModified() {
         if (!modified) return true;
         DialogResult r = MessageBox.Show("Czy zapisać zmiany?", "Notatnik.NET",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button3);
         switch (r) {
            case DialogResult.Yes:
               return SaveFile(currentFileName);
            case DialogResult.No:
               return true;
            default:
               return false;
         }
      }

      private void nowyToolStripMenuItem_Click(object sender, EventArgs e) {
         if (AskToSaveIfModified()) {
            textBox.Clear();
            currentFileName = null;
            modified = false;
         }
      }

      private void otwórzToolStripMenuItem_Click(object sender, EventArgs e) {
         if (AskToSaveIfModified()) OpenFile();
      }

      private void zapiszToolStripMenuItem_Click(object sender, EventArgs e) {
         SaveFile(currentFileName);
      }

      private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e) {
         SaveFile();
      }

      private void ustawieniaStronyToolStripMenuItem_Click(object sender, EventArgs e) {
         pageSetupDialog.ShowDialog();
      }

      private void podglądWydrukuToolStripMenuItem_Click(object sender, EventArgs e) {
         printPreviewDialog.ShowDialog();
      }

      private void drukujToolStripMenuItem_Click(object sender, EventArgs e) {
         if (printDialog.ShowDialog() == DialogResult.OK) printDocument.Print();
      }

      private string toPrint = null;

      private void printDocument_BeginPrint(object sender, PrintEventArgs e) {
         toPrint = textBox.Text;
      }

      private void printDocument_PrintPage(object sender, PrintPageEventArgs e) {
         e.HasMorePages = false;
         Brush brush = new SolidBrush(textBox.ForeColor);
         int charactersFitted, linesFilled;
         e.Graphics.MeasureString(toPrint, textBox.Font, e.MarginBounds.Size,
            StringFormat.GenericTypographic, out charactersFitted, out linesFilled);
         if (toPrint.Length > 0 && charactersFitted == 0) {
            MessageBox.Show("Błąd drukowania", "Notatnik.NET", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            return;
         }
         e.Graphics.DrawString(toPrint, textBox.Font, brush, e.MarginBounds,
            StringFormat.GenericTypographic);
         toPrint = toPrint.Substring(charactersFitted);
         if (toPrint.Length > 0) e.HasMorePages = true;
      }

      private void printDocument_EndPrint(object sender, PrintEventArgs e) {
         toPrint = null;
      }

      private void zamknijToolStripMenuItem_Click(object sender, EventArgs e) {
         Close();
      }

      private void cofnijToolStripMenuItem_Click(object sender, EventArgs e) {
         textBox.Undo();
         textBox.ClearUndo();
      }

      private void wytnijToolStripMenuItem_Click(object sender, EventArgs e) {
         if (textBox.SelectionLength > 0) textBox.Cut();
      }

      private void kopiujToolStripMenuItem_Click(object sender, EventArgs e) {
         if (textBox.SelectionLength > 0) textBox.Copy();
      }

      private void wklejToolStripMenuItem_Click(object sender, EventArgs e) {
         textBox.Paste();
      }

      private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e) {
         fontDialog.Font = textBox.Font;
         if (fontDialog.ShowDialog() == DialogResult.OK)
            textBox.Font = fontDialog.Font;
      }

      private void kolorToolStripMenuItem_Click(object sender, EventArgs e) {
         colorDialog.Color = textBox.ForeColor;
         if (colorDialog.ShowDialog() == DialogResult.OK)
            textBox.ForeColor = colorDialog.Color;
      }

      private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
         if (!AskToSaveIfModified()) e.Cancel = true;
      }

      private Settings settings = new Settings();

      private void MainWindow_Load(object sender, EventArgs e) {
         Width = settings.Width;
         Height = settings.Height;
         if (settings.Font != null) textBox.Font = settings.Font;
         if (settings.Color != null) textBox.ForeColor = settings.Color;
      }

      private void MainWindow_FormClosed(object sender, FormClosedEventArgs e) {
         settings.Width = Width;
         settings.Height = Height;
         settings.Font = textBox.Font;
         settings.Color = textBox.ForeColor;
         settings.Save();
      }
   }
}
