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

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            currentFile = "";
            this.Text = "Editor: New Document";
        }

        private string currentFile;
        private int checkPrint;
#region "Menu Methods"    
        private void mnuNew_Click(object sender, System.EventArgs e)
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
        private void mnuOpen_Click(object sender, System.EventArgs e)
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

            if(strExt == ".RTF")
            {
                rtbDoc.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
            else
            {
                StreamReader txtReader;
            }
        }
        private void mnuSave_Click(object sender, System.EventArgs e)
        {

        }
        private void mnuSaveAs_Click(object sender, System.EventArgs e)
        {

        }
        private void mnuPrint_Click(object sender, System.EventArgs e)
        {

        }
        private void mnuPrintPreview_Click(object sender, System.EventArgs e)
        {

        }
        private void mnuExit_Click(object sender, System.EventArgs e)
        {

        }
        private void mnuUndo_Click(object sender, System.EventArgs e)
        {
            if (rtbDoc.CanUndo) rtbDoc.Undo();
        }
        private void mnuRedo_Click(object sender, System.EventArgs e)
        {
            if (rtbDoc.CanRedo) rtbDoc.Redo();
        }
        private void mnuFind_Click(object sender, System.EventArgs e)
        {

        }
        private void mnuFindAndReplace_Click(object sender, System.EventArgs e)
        {

        }
        private void mnuSelectAll_Click(object sender, System.EventArgs e)
        {

        }
        private void mnCopy_Click(object sender, System.EventArgs e)
        {

        }
        private void mnuCut_Click(object sender, System.EventArgs e)
        {

        }
        private void mnuPaste_Click(object sender, System.EventArgs e)
        {

        }
        private void mnuInsertImage_Click(object sender, System.EventArgs e)
        {

        }
        private void mnuSelectFont_Click(object sender, System.EventArgs e)
        {

        }
        private void mnuBold_Click(object sender, System.EventArgs e)
        {

        }
        private void mnuItalic_Click(object sender, System.EventArgs e)
        {

        }
        private void mnuUnderline_Click(object sender, System.EventArgs e)
        {

        }
        private void mnuNormal_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!(rtbDoc.SelectionFont == null))
                {
                    fontDialog1.Font = rtbDoc.SelectionFont;
                }
                else
                {
                    fontDialog1.Font = null;
                }
                fontDialog1.ShowApply = true;
                if(fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    rtbDoc.SelectionFont = fontDialog1.Font;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }

        }
        private void mnuPageColor_Click(object sender, System.EventArgs e)
        {
            
        }
        private void mnuNone_Click(object sender, System.EventArgs e)
        {
            rtbDoc.SelectionIndent = 0;
        }
        private void mnuFivePts_Click(object sender, System.EventArgs e)
        {
            rtbDoc.SelectionIndent = 5;
        }
        private void mnuTenPts_Click(object sender, System.EventArgs e)
        {
            rtbDoc.SelectionIndent = 10;
        }
        private void mnuFifteenPts_Click(object sender, System.EventArgs e)
        {
            rtbDoc.SelectionIndent = 15;
        }
        private void mnuTwentyPts_Click(object sender, System.EventArgs e)
        {
            rtbDoc.SelectionIndent = 20;
        }
        private void mnuLeft_Click(object sender, System.EventArgs e)
        {
            rtbDoc.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void mnuCenter_Click(object sender, System.EventArgs e)
        {
            rtbDoc.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void mnuRight_Click(object sender, System.EventArgs e)
        {
            rtbDoc.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void mnuAddBullets_Click(object sender, System.EventArgs e)
        {
            rtbDoc.BulletIndent = 10;
            rtbDoc.SelectionBullet = true;
        }
        private void mnuRemoveBullets_Click(object sender, System.EventArgs e)
        {
            rtbDoc.SelectionBullet = false;
        }
        #endregion

        #region "Toolbar Methods"
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void tbrNew_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void tbrOpen_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void tbrSave_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void tbrFont_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void tbrLeft_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void tbrCenter_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void tbrRight_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void tbrBold_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void tbrItalic_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void tbrUnderline_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void tbrFind_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
