using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jp.mn.jp.uk.FileSpliter
{
    public partial class Form1 : Form
    {
        private string getPath = string.Empty;
        private string setPath = string.Empty;
        public Form1()
        {
            InitializeComponent();
            string c1 = System.Environment.CurrentDirectory;
            string c2 = System.IO.Directory.GetCurrentDirectory();
            string c3 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            string c4 = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            System.Environment.CurrentDirectory = c4;
            System.IO.Directory.SetCurrentDirectory(c4);
            getPath = c4;
            setPath = c3;
            this.txtTarget.Text = getPath;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtTarget.Text) || !System.IO.File.Exists(this.txtTarget.Text))
            {
                MessageBox.Show("Not find the file at '" + this.txtTarget.Text + "'", "Error");
                return;
            }
            if (string.IsNullOrEmpty(this.txtDest.Text) || !System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(this.txtDest.Text)))
            {
                MessageBox.Show("Not find the folder at '" + this.txtDest.Text + "'", "Error");
                return;
            }
            try
            {
                Int64 iSize = 1024000;
                Int32 iCnt = 0;
                using (System.IO.StreamWriter dd = new System.IO.StreamWriter(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(this.txtDest.Text + "\\"), System.IO.Path.GetFileName(this.txtTarget.Text) + ".bat"), false))
                {
                    dd.Write("copy -D -V -Y ");
                    dd.Close();
                }
                using (System.IO.StreamReader sr = new System.IO.StreamReader(this.txtTarget.Text, false))
                {
                    using (System.IO.BinaryReader br = new System.IO.BinaryReader(sr.BaseStream))
                    {
                        bool bFlg = false;
                        for (Int32 j = 1; j <= 1000; j++)
                        {
                            iCnt = j;
                            String filename = System.IO.Path.GetFileName(this.txtTarget.Text);
                            String dest = System.IO.Path.GetDirectoryName(this.txtDest.Text + "\\");
                            String destFile = filename + String.Format(".{0}", iCnt);
                            String path = System.IO.Path.Combine(dest, destFile);
                            using (System.IO.StreamWriter dd = new System.IO.StreamWriter(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(this.txtDest.Text + "\\"), System.IO.Path.GetFileName(this.txtTarget.Text) + ".bat"), true))
                            {
                                if (iCnt > 1)
                                {
                                    dd.Write("+");
                                }
                                dd.Write("\"" + destFile + "\"");
                                dd.Close();
                            }
                            using (System.IO.StreamWriter wr = new System.IO.StreamWriter(path, false))
                            {
                                System.IO.BinaryWriter bw = new System.IO.BinaryWriter(wr.BaseStream);
                                
                                for (Int64 i = 0; i < iSize; i++)
                                {
                                    try
                                    {
                                        byte t = br.ReadByte();
                                        bw.Write(t);
                                    }
                                    catch (System.IO.EndOfStreamException ex)
                                    {
                                        bFlg = true;
                                        break;
                                    }
                                    catch (Exception ex2)
                                    {
                                        MessageBox.Show(ex2.Message);
                                        return;
                                    }
                                }
                            }
                            if (bFlg == true)
                            {
                                break;
                            }
                        }
                    }
                    sr.Close();
                }
                using (System.IO.StreamWriter dd = new System.IO.StreamWriter(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(this.txtDest.Text + "\\"), System.IO.Path.GetFileName(this.txtTarget.Text) + ".bat"), true))
                {
                    dd.Write(" \"" + System.IO.Path.GetFileName(this.txtTarget.Text) + "\"");
                    dd.Close();
                }
            }
            catch
            {
                MessageBox.Show("File split about!", "Error");
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdg = new OpenFileDialog();

            string path = string.Empty;

            fdg.InitialDirectory = System.IO.Path.GetDirectoryName(getPath);

            if (fdg.ShowDialog(this) == DialogResult.OK)
            {
                getPath = fdg.FileName;
                txtTarget.Text = getPath;
                this.txtDest.Text = System.IO.Path.Combine(setPath);
            }
        }
    }
}
