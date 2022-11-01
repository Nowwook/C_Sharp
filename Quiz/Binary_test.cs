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

namespace MyApp
{
    // 이미지 파일 copy
    
    public partial class Form1 : Form
    {
        string path_first = "C:\\Temp\\";
        string path_last = "C:\\Temp\\";
        byte[] photo;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            path_first += textBox1.Text;
            path_last += textBox2.Text;
            using (FileStream fs = new FileStream(path_first, FileMode.Open))
            {
                BinaryReader br = new BinaryReader(fs);
                photo = br.ReadBytes((int)fs.Length);
                br.Close();
            }
            using (FileStream fs = new FileStream(path_last, FileMode.Create))
            {
                BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
                bw.Write(photo);
                bw.Flush();
                bw.Close();
            }
        }
    }
}
