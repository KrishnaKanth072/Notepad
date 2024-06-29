using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Reflection.Emit;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private RichTextBox GetRichTextBox()
        {
            RichTextBox NewBox = null;
            TabPage Newpage = tabControl1.SelectedTab;
            if (Newpage != null)
            {
                NewBox = Newpage.Controls[0] as RichTextBox;
            }
            return NewBox;
        }
        private void newTabCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TabPage Newpage = new TabPage("New Document");
            RichTextBox NewBox = new RichTextBox();
            NewBox.Dock = DockStyle.Fill;
            Newpage.Controls.Add(NewBox);
            tabControl1.TabPages.Add(Newpage);
        }


        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("d:\\File.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);


            sw.WriteLine("Krishna Programming zone");
            sw.Close();
            fs.Close();


        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    GetRichTextBox().Text = filetext;
                }
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = GetRichTextBox().Font.Size;
            currentSize += 50.0F;
            GetRichTextBox().Font = new Font(GetRichTextBox().Font.Name, currentSize,
             GetRichTextBox().Font.Style, GetRichTextBox().Font.Unit);
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void display_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cut_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Cut();
        }

        private void copy_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Copy();
        }

        private void paste_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Paste();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            GetRichTextBox();
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(GetRichTextBox().Text);
                }
            }
        }

        private void saveAll_Click(object sender, EventArgs e)
        {
            TabPage Current_tab = tabControl1.SelectedTab;
            tabControl1.TabPages.Remove(Current_tab);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void undo_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Undo();
        }

        private void selectAll_Click(object sender, EventArgs e)
        {
            GetRichTextBox().SelectAll();
        }

        private void saveAs_Click(object sender, EventArgs e)
        {

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Redo();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog Font = new FontDialog();
            if (Font.ShowDialog() == DialogResult.OK)
            {
                GetRichTextBox().Font = Font.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                GetRichTextBox().ForeColor = color.Color;
            }
        }

        private void zoomIn_Click(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = GetRichTextBox().Font.Size;
            currentSize += 50.0F;
            GetRichTextBox().Font = new Font(GetRichTextBox().Font.Name, currentSize,
             GetRichTextBox().Font.Style, GetRichTextBox().Font.Unit);
        }

        private void zoomOut_Click(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = GetRichTextBox().Font.Size;
            currentSize -= 50.0F;
            GetRichTextBox().Font = new Font(GetRichTextBox().Font.Name, currentSize,
            GetRichTextBox().Font.Style, GetRichTextBox().Font.Unit);
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = GetRichTextBox().Font.Size;
            currentSize -= 50.0F;
            GetRichTextBox().Font = new Font(GetRichTextBox().Font.Name, currentSize,
            GetRichTextBox().Font.Style, GetRichTextBox().Font.Unit);
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
