using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Byte sang ảnh
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                var returnImage = Image.FromStream(ms);

                return returnImage;
            }
        }
        // Ảnh sang byte
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);

                return ms.ToArray();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Thu_Nghiem x = new Thu_Nghiem();
            var y = from z in x.SaveFiles where z.FileID == 2 select z;
            foreach(var a in y)
            {
                pictureBox1.BackgroundImage = ByteArrayToImage(a.Files);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thu_Nghiem x = new Thu_Nghiem();
            Image Y = pictureBox1.BackgroundImage;
            var Z = ImageToByteArray(Y);
            SaveFile A=new SaveFile();
            A.Name = "Yes";
            A.Files = Z;
            x.SaveFiles.Add(A);
            x.SaveChanges();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
