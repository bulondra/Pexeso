namespace Pexeso
{
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Runtime.InteropServices;
    using System.Collections;

    public partial class Form1 : Form
    {

        public List<PictureBox> boxes;
        public List<Image> pictures;
        public List<PictureBox> opened;
        public int guessed;


        public Form1()
        {
            InitializeComponent();
            loadBoxes();
            loadPictures();
            initBoxes();
            pictureBox9.Image = getImageFromFolder("pexeso");
            pictureBox10.Image = getImageFromFolder("vyhra");
            pictureBox10.Visible = false;
            guessed = 0;
            opened = new List<PictureBox>();
        }

        public Image getImageFromFolder(String image)
        {
            Image img = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures)+ @"\"+image+".png");
            return img;
        }

        public void loadPictures()
        {
            pictures = new List<Image> { getImageFromFolder("vlk"), getImageFromFolder("ruza"), getImageFromFolder("glock"), getImageFromFolder("hart"), getImageFromFolder("vlk"), getImageFromFolder("ruza"), getImageFromFolder("glock"), getImageFromFolder("hart") };
            pictures = pictures.OrderBy(x => Guid.NewGuid()).ToList();
        }

        public void loadBoxes()
        {
            boxes = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8 };
        }

        public void initBoxes()
        {
            for (int i = 0; i < 8; i++)
            {
                PictureBox box = boxes[i];
                Image img = pictures[i];
                box.Image = getImageFromFolder("blank");

            }
        }

        public void turnBack()
        {
            foreach(PictureBox box in opened)
            {
                box.Image = getImageFromFolder("blank");
            }
            opened.Clear();
        }

        public bool areSame()
        {
            bool same = false;

            // Now set as bitmap
            Bitmap bmp1 = new Bitmap(opened[0].Image);
            Bitmap bmp2 = new Bitmap(opened[1].Image);

            // here will be stored the bitmap data
            byte[] byt1 = null;
            byte[] byt2 = null;

            // Get data of bmp1
            var bitmapData = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width, bmp1.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, bmp1.PixelFormat);
            var length = bitmapData.Stride * bitmapData.Height;
            //
            byt1 = new byte[length];
            //
            Marshal.Copy(bitmapData.Scan0, byt1, 0, length);
            bmp1.UnlockBits(bitmapData);

            // Get data of bmp2
            var bitmapData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, bmp2.PixelFormat);
            var length2 = bitmapData2.Stride * bitmapData2.Height;
            //
            byt2 = new byte[length2];
            //
            Marshal.Copy(bitmapData2.Scan0, byt2, 0, length2);
            bmp2.UnlockBits(bitmapData2);

            // And now compares these arrays
            if (StructuralComparisons.StructuralEqualityComparer.Equals(byt1, byt2))
            {
                same = true;
            }

            return same;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictures[0];
            opened.Add(pictureBox1);
            if (opened.Count == 2)
            {
                if (!areSame())
                {
                    var t = Task.Run(async delegate
                    {
                        await Task.Delay(1500);
                        return 42;
                    });
                    t.Wait();
                    turnBack();
                } else
                {
                    opened.Clear();
                    guessed++;
                }
            }

            if (guessed == 4)
            {
                pictureBox10.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictures[1];
            opened.Add(pictureBox2);
            if (opened.Count == 2)
            {
                if (!areSame())
                {
                    var t = Task.Run(async delegate
                    {
                        await Task.Delay(1500);
                        return 42;
                    });
                    t.Wait();
                    turnBack();
                }
                else
                {
                    opened.Clear();
                    guessed++;
                }
            }

            if (guessed == 4)
            {
                pictureBox10.Visible = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictures[2];
            opened.Add(pictureBox3);
            if (opened.Count == 2)
            {
                if (!areSame())
                {
                    var t = Task.Run(async delegate
                    {
                        await Task.Delay(1500);
                        return 42;
                    });
                    t.Wait();
                    turnBack();
                }
                else
                {
                    opened.Clear();
                    guessed++;
                }
            }

            if (guessed == 4)
            {
                pictureBox10.Visible = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = pictures[3];
            opened.Add(pictureBox4);
            if (opened.Count == 2)
            {
                if (!areSame())
                {
                    var t = Task.Run(async delegate
                    {
                        await Task.Delay(1500);
                        return 42;
                    });
                    t.Wait();
                    turnBack();
                }
                else
                {
                    opened.Clear();
                    guessed++;
                }
            }

            if (guessed == 4)
            {
                pictureBox10.Visible = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = pictures[4];
            opened.Add(pictureBox5);
            if (opened.Count == 2)
            {
                if (!areSame())
                {
                    var t = Task.Run(async delegate
                    {
                        await Task.Delay(1500);
                        return 42;
                    });
                    t.Wait();
                    turnBack();
                }
                else
                {
                    opened.Clear();
                    guessed++;
                }
            }

            if (guessed == 4)
            {
                pictureBox10.Visible = true;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = pictures[5];
            opened.Add(pictureBox6);
            if (opened.Count == 2)
            {
                if (!areSame())
                {
                    var t = Task.Run(async delegate
                    {
                        await Task.Delay(1500);
                        return 42;
                    });
                    t.Wait();
                    turnBack();
                }
                else
                {
                    opened.Clear();
                    guessed++;
                }
            }

            if (guessed == 4)
            {
                pictureBox10.Visible = true;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = pictures[6];
            opened.Add(pictureBox7);
            if (opened.Count == 2)
            {
                if (!areSame())
                {
                    var t = Task.Run(async delegate
                    {
                        await Task.Delay(1500);
                        return 42;
                    });
                    t.Wait();
                    turnBack();
                }
                else
                {
                    opened.Clear();
                    guessed++;
                }
            }

            if (guessed == 4)
            {
                pictureBox10.Visible = true;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = pictures[7];
            opened.Add(pictureBox8);
            if (opened.Count == 2)
            {
                if (!areSame())
                {
                    var t = Task.Run(async delegate
                    {
                        await Task.Delay(1500);
                        return 42;
                    });
                    t.Wait();
                    turnBack();
                }
                else
                {
                    opened.Clear();
                    guessed++;
                }
            }

            if (guessed == 4)
            {
                pictureBox10.Visible = true;
            }
        }
    }
}