using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGOEditor.Structure;

namespace YGOEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public YuGiData data;

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    data = new YuGiData(openFileDialog.FileName);

                    data.LoadFileList();
                    yuGiDataEntryBindingSource.ResetBindings(false);
                    yuGiDataEntryBindingSource.DataSource = data.Files;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(this, exc.Message, "File error");
                }
            }
        }

        private void ExtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog(this) == DialogResult.OK)
            {
                //BinaryReader reader = new BinaryReader(stream);

                /*foreach (ListViewItem item in fileList.DataSource)
                {
                    string fileName = Path.Combine(folderDialog.SelectedPath, item.Text);
                    string directory = Path.GetDirectoryName(fileName);
                    FileStream outStream = null;

                    try
                    {
                        if (!Directory.Exists(directory))
                            Directory.CreateDirectory(directory);
                        outStream = File.OpenWrite(fileName);

                        int fileID = item.Index;
                        uint fileOffset = filesOffset[fileID];
                        uint fileSize = filesSize[fileID];

                        stream.Seek(fileOffset, SeekOrigin.Begin);

                        for (uint i = 0; i < fileSize; i++)
                        {
                            outStream.WriteByte(reader.ReadByte());
                        }
                        Console.WriteLine(fileName);
                        outStream.Close();
                    }
                    catch
                    {
                        if (outStream != null)
                        {
                            outStream.Close();
                        }
                    }
                }*/
            }
        }



        private void ShowPicture(YuGiDataEntry yuGiDataEntry)
        {
            MemoryStream pictureStream = new MemoryStream();
            pictureStream.Write(yuGiDataEntry.GetData(), 0, yuGiDataEntry.FullSize);

            pictureStream.Flush();

            try
            {
                Image bitmap = Bitmap.FromStream(pictureStream);
                picture.Image = bitmap;
            }
            catch (Exception e)
            {
                Graphics g = picture.CreateGraphics();
                g.DrawString(e.Message, new Font("Arial", 10), Brushes.Blue, 0, 0);
                g.Dispose();
            }
            finally
            {
                pictureStream.Close();
            }
        }

        private void ShowText(YuGiDataEntry yuGiDataEntry)
        {
            textFile.Text = string.Join("\n\n", 
                Encoding.UTF8.GetString(yuGiDataEntry.GetData()).Split(new char[] { '\0' }, 
                StringSplitOptions.RemoveEmptyEntries));
        }

        private void FileList_SelectionChanged(object sender, EventArgs e)
        {
            if (FileList.SelectedRows.Count != 0)
            {
                YuGiDataEntry yuGiDataEntry = data.Files[FileList.SelectedRows[0].Index];
                string extension = Path.GetExtension(yuGiDataEntry.FileName);
                if (extension == ".bmp")
                {
                    picture.Visible = true;
                    textFile.Visible = false;
                    ShowPicture(yuGiDataEntry);
                }
                else
                {
                    picture.Visible = false;
                    textFile.Visible = true;
                    ShowText(yuGiDataEntry);
                }
                    
            }
        }

        private void YuGiDataEntryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CardListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CardForm cardForm = new CardForm(this.data);
            cardForm.FormClosed += new FormClosedEventHandler(CardForm_Closed);
            cardForm.Show();
            this.Hide();
        }

        private void CardForm_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // will exit the application     
        }
    }
}
