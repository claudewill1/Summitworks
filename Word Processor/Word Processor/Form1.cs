using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Processor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string currentFile;
        private int checkPrint;
#region "Menubar methods"
        private void mnuNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (rtbDoc.Modified)
                {
                    DialogResult answer;
                    answer = MessageBox.Show("The current document has not been saved, would you like to continue without saving?",
                                             "Unsaved Document", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.No)
                    {
                        currentFile = "";
                        this.Text = "Editor: New Document";
                        rtbDoc.Modified = false;
                        rtbDoc.Clear();
                        return;
                    }
                    else
                    {
                        mnuSave_Click(this, new EventArgs());
                        rtbDoc.Modified = false;
                        rtbDoc.Clear();
                        currentFile = "";
                        this.Text = "Editor: New Document";
                        return;
                    }
                }
                else
                {
                    currentFile = "";
                    this.Text = "Editor: New Document";
                    rtbDoc.Modified = false;
                    rtbDoc.Clear();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "RTE - Open File";
                openFileDialog1.DefaultExt = "rtf";
                openFileDialog1.Filter = "Rich Text Files|*.rtf|Text Files|*.txt|HTML Files|*.htm|All Files|*.*";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.ShowDialog();

                if (openFileDialog1.FileName == "") return;
                string strExt = "";
                strExt = Path.GetExtension(openFileDialog1.FileName);
                strExt = strExt.ToUpper();

                if (strExt == ".RTF")
                {
                    rtbDoc.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    StreamReader txtReader;
                    txtReader = new StreamReader(openFileDialog1.FileName);
                    rtbDoc.Text = txtReader.ReadToEnd();
                    txtReader.Close();
                    txtReader = null;
                    rtbDoc.SelectionStart = 0;
                    rtbDoc.SelectionLength = 0;
                }
                currentFile = openFileDialog1.FileName;
                rtbDoc.Modified = false;
                this.Text = "Editor: " + currentFile.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentFile == string.Empty)
                {
                    mnuSaveAs_Click(this, e);
                    return;
                }
                try
                {
                    string strExt;
                    strExt = Path.GetExtension(currentFile);
                    strExt = strExt.ToUpper();
                    if (strExt == ".RTF")
                    {
                        rtbDoc.SaveFile(currentFile);
                    }
                    else
                    {
                        StreamWriter txtWriter;
                        txtWriter = new StreamWriter(currentFile);
                        txtWriter.Write(rtbDoc.Text);
                        txtWriter.Close();
                        txtWriter = null;
                        rtbDoc.SelectionStart = 0;
                        rtbDoc.SelectionLength = 0;

                    }
                    this.Text = "Editor: " + currentFile.ToString();
                    rtbDoc.Modified = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Title = "RTE - Save File";
                saveFileDialog1.DefaultExt = "rtf";
                saveFileDialog1.Filter = "Rich Text Files|*.rtf|Text Files|*.txt|HTML Files|*.htm|All Files|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName == "")
                {
                    return;
                }
                string strExt;
                strExt = Path.GetExtension(saveFileDialog1.FileName);
                strExt = strExt.ToUpper();
                if (strExt == ".RTF")
                {
                    rtbDoc.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    StreamWriter txtWriter;
                    txtWriter = new StreamWriter(saveFileDialog1.FileName);
                    txtWriter.Write(rtbDoc.Text);
                    txtWriter.Close();
                    txtWriter = null;
                    rtbDoc.SelectionStart = 0;
                    rtbDoc.SelectionLength = 0;
                }
                currentFile = saveFileDialog1.FileName;
                rtbDoc.Modified = false;
                this.Text = "Editor: " + currentFile.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                printDialog1.Document = printDocument1;

                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (rtbDoc.Modified)
                {
                    DialogResult answer;
                    answer = MessageBox.Show("Save this document before closing?", "Unsaved Document", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (rtbDoc.CanUndo) rtbDoc.Undo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (rtbDoc.CanRedo) rtbDoc.Redo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Find(rtbDoc, txtFind.Text, Color.Blue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void findAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void insertImageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void selectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pageColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuNormal_Click(object sender, EventArgs e)
        {

        }

        private void mnuFivePts_Click(object sender, EventArgs e)
        {

        }

        private void mnuTenPts_Click(object sender, EventArgs e)
        {

        }

        private void mnuFifteenPts_Click(object sender, EventArgs e)
        {

        }

        

        private void mnuTwentyPts_Click(object sender, EventArgs e)
        {

        }

        private void mnuLeft_Click(object sender, EventArgs e)
        {

        }

        private void mnuCenter_Click(object sender, EventArgs e)
        {

        }

        private void mnuRight_Click(object sender, EventArgs e)
        {

        }

        private void mnuAddBullets_Click(object sender, EventArgs e)
        {

        }

        private void mnuRemoveBullets_Click(object sender, EventArgs e)
        {

        }
        #endregion

        public void Find(RichTextBox rtb, String word, Color color)
        {
            if (word == "")
            {
                return;
            }

            int s_start = rtb.SelectionStart, startIndex = 0, index;
            //lblFind.Visible = true;
            //txtFind.Visible = true;
            while ((index = rtb.Text.IndexOf(word, startIndex)) != -1)
            {

                rtb.Select(index, word.Length);
                rtb.SelectionColor = color;
                startIndex = index + word.Length;
            }
            rtb.SelectionStart = 0;
            rtb.SelectionLength = rtb.Text.Length;
            rtb.SelectionColor = Color.Black;
        }
    }
}
