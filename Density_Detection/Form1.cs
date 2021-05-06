using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;

namespace Density_Detection
{
    public partial class Form1 : Form
    {
        int Gdefault = 120;
        float lowDefault = 5;
        public static class global { public static int[] input = new int[4] { -1, -1, -1, -1 }; } // array to store x1, y1, x2, y2

        public Point c1;
        public Point c2;
        public Point c3;
        bool second = true;
        public string strfilename;
        public Graphics img_rectangle;
        public Rectangle rec;
        public OpenFileDialog ofile;
        public Bitmap b1;
        bool indications = false;
   
        public Form1()
        {
            InitializeComponent();
            txt_Gvalue.Text = Gdefault.ToString();
        }

        private void button_upload_Click(object sender, EventArgs e) //Find image
        {
            indications = false;
            ofile = new OpenFileDialog();
            ofile.Filter = "Image file (*.bmp,*.jpg)|*.bmp;*.jpg";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                Image img = new Bitmap(ofile.FileName);

                var fn = ofile.FileName;
                var currentPath = Path.GetFullPath(fn);
                currentPath = Directory.GetParent(currentPath).FullName;

                FilePathLabel.Text = currentPath;

                var filename = Path.GetFileName(fn);
                FileNameLabel.Text = filename;

                Image resizeImage(Image imgToResize, Size size)
                {
                    return (Image)(new Bitmap(imgToResize, size));
                }

                Image img2 = resizeImage(img, new Size(image_Original.Width, image_Original.Height));

                this.image_Original.Image = new Bitmap(img2);
                strfilename = ofile.FileName;
                lbl_fileName.Text = strfilename.ToString();
            }

            lbl_Coor.Visible = true;
            btn_areaAround.Enabled = true;
            label3.Visible = true;
            txt_width.Text = "";
            txt_height.Text = "";
            txt_Gvalue.Text = "";
            global.input[0] = -1;
            global.input[1] = -1;
            global.input[2] = -1;
            global.input[3] = -1;
            num_angle.Value = 0;
            txt_xRect.Text = "";
            txt_yRect.Text = "";
            p1xtext.Text = "";
            p1ytext.Text = "";
            p2xtext.Text = "";
            p2ytext.Text = "";
            p3xtext.Text = "";
            p3ytext.Text = "";
            p4xtext.Text = "";
            p4ytext.Text = "";
            lbl_Density.Text = "Noise Area % =";
            label_rect.Text = "";
            image_Bw.Image = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            ZoomedImage.Visible = false;
            image_Original.Enabled = false;
            btn_bw.Enabled = false;
            trackBar.Value = 8;
            trackBar.Visible = false;
        }

        private void btn_bw_Click(object sender, EventArgs e)
        {
            try
            {
                indications = false;
                btn_bw.Enabled = false;
                button_Upload.Enabled = true;
                AddDataButton.Enabled = true;
                image_Original.Enabled = false;
                //ZoomedImage.Image.Dispose();
                ZoomedImage.Visible = false;
                btn_areaAround.Enabled = false;
                trackBar.Visible = false;
                if (Convert.ToInt16(num_angle.Value) == 0) // added this ###############################
                {
                    image_Bw.Visible = false;
                    float counterWhite = 0;
                    float counterAll = 0;
                    float counterBlack = 0;
                    float density = 0;
                    float sum = 0;
                    float counterWhite2 = 0;
                    float counterAll2 = 0;
                    float density2 = 0;
                    float counterBlack2 = 0;

                    double p1x = Convert.ToDouble(txt_xRect.Text); //top left
                    double p1y = Convert.ToDouble(txt_yRect.Text);
                    double p2x = p1x + Convert.ToDouble(txt_width.Text); // top right
                    double p2y = p1y;
                    double p3x = p2x; // bottom right
                    double p3y = p1y + Convert.ToDouble(txt_height.Text);
                    double p4x = p1x; // bottom left
                    double p4y = p3y;

                    Bitmap b = new Bitmap((Bitmap)this.image_Original.Image);
                    int[] vec = new int[b.Width * b.Height];
                    int counterX = 0;
                    // Set each pixel in myBitmap to black.
                    for (int i = 0; i < b.Width; i++)
                    {
                        for (int j = 0; j < b.Height; j++)
                        {
                            Color c1 = b.GetPixel(i, j);
                            sum = sum + c1.G;
                            vec[counterX] = c1.G;
                            if (c1.G < Convert.ToInt16(txt_Gvalue.Text))
                            {
                                b.SetPixel(i, j, Color.Black);
                                counterBlack++;
                            }
                            else
                            {
                                counterWhite++;
                            }
                            if (i > p1x && i < p2x && j < p3y && j > p1y)
                            {
                                if (c1.G < Convert.ToInt16(txt_Gvalue.Text))
                                {
                                    // b.SetPixel(i, j, Color.Red); //good check to see which area it is looking at or"true"
                                    counterBlack2++;
                                }
                                else
                                {
                                    counterWhite2++;
                                }
                            }
                            counterX++;
                        }
                    }
                    counterAll = b.Width * b.Height;
                    counterAll2 = Convert.ToInt16(txt_height.Text) * Convert.ToInt16(txt_width.Text);
                    image_Bw.Visible = true;
                    this.image_Bw.Image = b;
                    //this.image_Adjust.Image = c;
                    counterBlack = counterAll - counterWhite;

                    density = counterWhite * 100 / counterAll;
                    lbl_Density.Text = "Noise Area % =" + density.ToString("#.##") + " %";

                    int[] vec2 = new int[Convert.ToInt16(txt_width.Text) * Convert.ToInt16(txt_height.Text)];

                    // Set each pixel in myBitmap to black.
                    int xEnd = Convert.ToInt16(txt_width.Text) + Convert.ToInt16(txt_xRect.Text);
                    int yEnd = Convert.ToInt16(txt_height.Text) + Convert.ToInt16(txt_yRect.Text);

                    counterAll2 = Convert.ToInt16(txt_width.Text) * Convert.ToInt16(txt_height.Text);
                    density2 = counterWhite2 * 100 / counterAll2;
                    if (density2 == 0)
                    {
                        label_rect.Text = "0.00%";
                    }
                    else
                    {
                        label_rect.Text = density2.ToString("#.##") + "%";
                    }

                    //lbl_Average.Text = "Average G value =" + average.ToString("#.##");
                }
                else if (Convert.ToInt16(num_angle.Value) < 0)
                {
                    // add here
                    image_Bw.Visible = false;
                    float counterWhite = 0;
                    float counterAll = 0;
                    float counterBlack = 0;
                    float density = 0;
                    float sum = 0;
                    float density3 = 0;

                    double p1x = Convert.ToDouble(p1xtext.Text); //top left
                    double p1y = Convert.ToDouble(p1ytext.Text);
                    double p2x = Convert.ToDouble(p2xtext.Text); // top right
                    double p2y = Convert.ToDouble(p2ytext.Text);
                    double p3x = Convert.ToDouble(p3xtext.Text); // bottom right
                    double p3y = Convert.ToDouble(p3ytext.Text);
                    double p4x = Convert.ToDouble(p4xtext.Text); // bottom left
                    double p4y = Convert.ToDouble(p4ytext.Text);

                    double m12 = (p2y - p1y) / (p2x - p1x);
                    double m23 = (p2y - p3y) / (p2x - p3x);
                    double m34 = (p3y - p4y) / (p3x - p4x);
                    double m41 = (p4y - p1y) / (p4x - p1x);

                    double b12 = p1y - m12 * p1x;
                    double b23 = p2y - m23 * p2x;
                    double b34 = p3y - m34 * p3x;
                    double b41 = p4y - m41 * p4x;

                    float counterBlack3 = 0;
                    float counterWhite3 = 0;
                    float counterAll3 = 0;

                    Bitmap b = new Bitmap((Bitmap)this.image_Original.Image);
                    int[] vec = new int[b.Width * b.Height];
                    int counterX = 0;
                    // Set each pixel in myBitmap to black.
                    for (int i = 0; i < b.Width; i++)
                    {
                        for (int j = 0; j < b.Height; j++)
                        {
                            Color c1 = b.GetPixel(i, j);
                            sum = sum + c1.G;
                            vec[counterX] = c1.G;
                            if (c1.G < Convert.ToInt16(txt_Gvalue.Text))
                                b.SetPixel(i, j, Color.Black);
                            else
                                counterWhite++;

                            if (i > (j - b12) / m12 && i < (j - b23) / m23 && i < (j - b34) / m34 && i > (j - b41) / m41)
                            {
                                if (c1.G < Convert.ToInt16(txt_Gvalue.Text))
                                {
                                    // b.SetPixel(i, j, Color.Red); //good check to see which area it is looking at or"true"
                                    counterBlack3++;
                                }
                                else
                                {
                                    counterWhite3++;
                                }

                            }
                            counterX++;
                        }
                    }
                    counterAll = b.Width * b.Height;
                    image_Bw.Visible = true;
                    this.image_Bw.Image = b;
                    //this.image_Adjust.Image = c;
                    counterBlack = counterAll - counterWhite;
                    density = counterWhite * 100 / counterAll;
                    lbl_Density.Text = "Noise Area % =" + density.ToString("#.##") + " %";

                    counterAll3 = counterWhite3 + counterBlack3;
                    density3 = counterWhite3 * 100 / counterAll3;
                    if (density3 == 0)
                    {
                        label_rect.Text = "0.00%";
                    }
                    else
                    {
                        label_rect.Text = density3.ToString("#.##") + "%";
                    }

                    //lbl_Average.Text = "Average G value =" + average.ToString("#.##");
                }
                else if (Convert.ToInt16(num_angle.Value) > 0)
                {
                    // add here
                    image_Bw.Visible = false;
                    float counterWhite = 0;
                    float counterAll = 0;
                    float counterBlack = 0;
                    float density = 0;
                    float sum = 0;
                    float density3 = 0;

                    double p1x = Convert.ToDouble(p1xtext.Text); //top left
                    double p1y = Convert.ToDouble(p1ytext.Text);
                    double p2x = Convert.ToDouble(p2xtext.Text); // top right
                    double p2y = Convert.ToDouble(p2ytext.Text);
                    double p3x = Convert.ToDouble(p3xtext.Text); // bottom right
                    double p3y = Convert.ToDouble(p3ytext.Text);
                    double p4x = Convert.ToDouble(p4xtext.Text); // bottom left
                    double p4y = Convert.ToDouble(p4ytext.Text);

                    double m12 = (p2y - p1y) / (p2x - p1x);
                    double m23 = (p2y - p3y) / (p2x - p3x);
                    double m34 = (p3y - p4y) / (p3x - p4x);
                    double m41 = (p4y - p1y) / (p4x - p1x);

                    double b12 = p1y - m12 * p1x;
                    double b23 = p2y - m23 * p2x;
                    double b34 = p3y - m34 * p3x;
                    double b41 = p4y - m41 * p4x;

                    float counterBlack3 = 0;
                    float counterWhite3 = 0;
                    float counterAll3 = 0;

                    Bitmap b = new Bitmap((Bitmap)this.image_Original.Image);
                    int[] vec = new int[b.Width * b.Height];
                    int counterX = 0;
                    // Set each pixel in myBitmap to black.
                    for (int i = 0; i < b.Width; i++)
                    {
                        for (int j = 0; j < b.Height; j++)
                        {
                            Color c1 = b.GetPixel(i, j);
                            sum = sum + c1.G;
                            vec[counterX] = c1.G;
                            if (c1.G < Convert.ToInt16(txt_Gvalue.Text))
                                b.SetPixel(i, j, Color.Black);
                            else
                                counterWhite++;

                            if (i < (j - b12) / m12 && i < (j - b23) / m23 && i > (j - b34) / m34 && i > (j - b41) / m41)
                            {
                                if (c1.G < Convert.ToInt16(txt_Gvalue.Text))
                                {
                                    // b.SetPixel(i, j, Color.Red); //good check to see which area it is looking at or"true"
                                    counterBlack3++;
                                }
                                else
                                {
                                    counterWhite3++;
                                }
                            }
                            counterX++;
                        }
                    }
                    counterAll = b.Width * b.Height;
                    image_Bw.Visible = true;
                    this.image_Bw.Image = b;
                    //this.image_Adjust.Image = c;
                    counterBlack = counterAll - counterWhite;
                    density = counterWhite * 100 / counterAll;
                    lbl_Density.Text = "Noise Area % =" + density.ToString("#.##") + " %";

                    counterAll3 = counterWhite3 + counterBlack3;
                    density3 = counterWhite3 * 100 / counterAll3;
                    if (density3 == 0)
                    {
                        label_rect.Text = "0.00%";
                    }
                    else
                    {
                        label_rect.Text = density3.ToString("#.##") + "%";
                    }
                    //lbl_Average.Text = "Average G value =" + average.ToString("#.##");
                }
            }
            catch
            {
                //  Block of code to handle errors
                MessageBox.Show("Something went wrong, try again. Upload a new photo and make sure to mark both the surrounding area and the indication.", "Error");
            }
        }

        private void image_Original_MouseClick(object sender, MouseEventArgs e)
        {

            button1.Visible = true;
            second = true;

            if (btn_indi.Enabled == false && btn_areaAround.Enabled == true)
            {
                Graphics gB = image_Bw.CreateGraphics(); //drawing cross on click point
                Pen penB = new Pen(Color.White);
                gB.DrawLine(penB, e.X - 15, e.Y, e.X + 15, e.Y);
                gB.DrawLine(penB, e.X, e.Y - 15, e.X, e.Y + 15);

                c1 = new Point(e.X, e.Y);

                gB.Dispose();

                Graphics gA = image_Original.CreateGraphics(); //drawing cross on click point
                Pen penA = new Pen(Color.White);
                gA.DrawLine(penA, e.X - 15, e.Y, e.X + 15, e.Y);
                gA.DrawLine(penA, e.X, e.Y - 15, e.X, e.Y + 15);

                c2 = new Point(e.X, e.Y);

                gA.Dispose();

                Bitmap d = new Bitmap((Bitmap)this.image_Original.Image);
                Color d1 = d.GetPixel(e.X, e.Y);
                dataGridView1.Rows.Add(e.X, e.Y, d1.G);

                c3 = new Point(e.X, e.Y);


                decimal val = 0;
                decimal average_G = 0;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (item.Cells[2] != null && item.Cells[2].Value != null)
                        val += Convert.ToDecimal(item.Cells[2].Value);
                }

                average_G = val / (Convert.ToDecimal(dataGridView1.RowCount) - 1);

                txt_Gvalue.Text = Convert.ToInt16(average_G).ToString();
            }

            // ******************** RECTANGLE SECTION *************************


            if (btn_indi.Enabled == true && btn_areaAround.Enabled == false && button1.Enabled == true) // Added && button1.Enabled == true
            {
                // Important: First click must be the upper left corner of desired rectangle

                if (global.input[0] == -1)
                {
                    global.input[0] = e.X; // x1 = x-coordinate of mouse position upon click 1
                    global.input[1] = e.Y; // y1 = y-coordinate of mouse position upon click 1
                    second = false;

                    txt_xRect.Text = Convert.ToString(global.input[0]); // Displaying x-coordinate of first click in box X
                    txt_yRect.Text = Convert.ToString(global.input[1]); // Displaying y-coordinate of first click in box Y
                }

                // Important: Second click must be the lower right corner of desired rectangle

                if (second == true)
                {
                    global.input[2] = e.X; // x2 = x-coordinate of mouse position upon click 2
                    global.input[3] = e.Y; // y2 = y-coordinate of mouse position upon click 2

                    var width = Math.Abs(global.input[2] - global.input[0]); // width = x2 - x1
                    var height = Math.Abs(global.input[3] - global.input[1]); // height = y2 - y1

                    txt_width.Text = width.ToString(); // Converting width value to string so it can be stored in the textbox
                    txt_height.Text = height.ToString(); // Converting height value to string so it can be stored in the textbox

                    rec = new Rectangle(global.input[0], global.input[1], width, height); // rectangle takes in x1, y1, width, height
                    img_rectangle = image_Original.CreateGraphics();

                    Pen redPen = new Pen(Color.Red, 2);
                    img_rectangle.DrawRectangle(redPen, rec);
                }
            }
        }
        private void image_Original_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_Coor.Text = "X = " + e.X + " ; Y = " + e.Y;

            ResizeAndDisplayImage();
             UpdateZoomedImage(e);


        }

        private void image_Bw_MouseClick(object sender, MouseEventArgs e)
        {
            //button1.Visible = true;

            //Graphics gC = image_Adjust.CreateGraphics(); //drawing cross on click point
            //Pen penC = new Pen(Color.White);
            //gC.DrawLine(penC, e.X - 15, e.Y, e.X + 15, e.Y);
            //gC.DrawLine(penC, e.X, e.Y - 15, e.X, e.Y + 15);
            //gC.Dispose();

            //Graphics gB = image_Bw.CreateGraphics(); //drawing cross on click point
            //Pen penB = new Pen(Color.White);
            //gB.DrawLine(penB, e.X - 15, e.Y, e.X + 15, e.Y);
            //gB.DrawLine(penB, e.X, e.Y - 15, e.X, e.Y + 15);
            //gB.Dispose();

            //Graphics gA = image_Original.CreateGraphics(); //drawing cross on click point
            //Pen penA = new Pen(Color.White);
            //gA.DrawLine(penA, e.X - 15, e.Y, e.X + 15, e.Y);
            //gA.DrawLine(penA, e.X, e.Y - 15, e.X, e.Y + 15);
            //gA.Dispose();
        }

        private void image_Bw_MouseMove(object sender, MouseEventArgs e) //show coordinates of the mouse
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            image_Bw.Invalidate();
            image_Original.Invalidate();
            txt_width.Text = ""; // Text boxes displaying x coordinate, y coordinate, width and height are set to empty if the user wants to redraw
            txt_height.Text = "";
            // txt_xRect.Text = "";
            // txt_yRect.Text = "";
            txt_Gvalue.Text = "";
            global.input[0] = -1; //The user can redraw the rectangle in a new spot if they click the "Clear Markings" Button
            global.input[1] = -1;
            global.input[2] = -1;
            global.input[3] = -1;
            num_angle.Value = 0;
            p1xtext.Text = "";
            p1ytext.Text = "";
            p2xtext.Text = "";
            p2ytext.Text = "";
            p3xtext.Text = "";
            p3ytext.Text = "";
            p4xtext.Text = "";
            p4ytext.Text = "";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            image_Bw.Invalidate();
            image_Original.Invalidate();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            txt_width.Text = "";
            txt_height.Text = "";
            txt_Gvalue.Text = "";
            btn_bw.Enabled = false;
            global.input[0] = -1;
            global.input[1] = -1;
            global.input[2] = -1;
            global.input[3] = -1;
            num_angle.Value = 0;
            txt_xRect.Text = "";
            txt_yRect.Text = "";
            p1xtext.Text = "";
            p1ytext.Text = "";
            p2xtext.Text = "";
            p2ytext.Text = "";
            p3xtext.Text = "";
            p3ytext.Text = "";
            p4xtext.Text = "";
            p4ytext.Text = "";
            lbl_Density.Text = "";
            label_rect.Text = "";
            image_Bw.Image = null;
            btn_indi.Enabled = false;
            btn_areaAround.Enabled = true;
            image_Original.Enabled = false;
            trackBar.Visible = false;
            ZoomedImage.Visible = false;
            trackBar.Value = 8;
            num_angle.Enabled = false;

        }
        private void txt_Gvalue_TextChanged(object sender, EventArgs e)
        {
        }
        private void btn_areaAround_Click(object sender, EventArgs e)
        {
            btn_indi.Enabled = true;
            btn_areaAround.Enabled = false;
            num_angle.Enabled = true;
            image_Original.Enabled = true;
            button1.Enabled = true;
            indications = false;
        }
        private void btn_indi_Click(object sender, EventArgs e)
        {
            btn_indi.Enabled = false;
            btn_areaAround.Enabled = true;
            btn_bw.Enabled = true;
            ZoomedImage.Visible = true;
            num_angle.Enabled = false;
            trackBar.Visible = true;
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            indications = true;
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label8_Click(object sender, EventArgs e)
        {
        }
        private void image_Original_Click(object sender, EventArgs e)
        {
          
        }


        private void btn_redraw_Click(object sender, EventArgs e)
        {
            btn_indi.Enabled = true;
            btn_areaAround.Enabled = true;
        }
        private void label7_Click(object sender, EventArgs e)
        {
        }
        private void txt_width_TextChanged(object sender, EventArgs e)
        {
        }
        private void label_rect_Click(object sender, EventArgs e)
        {
        }
        private void lbl_Density_Click(object sender, EventArgs e)
        {
        }

        // ******************** ROTATION OF RECTANGLE SECTION ********************

        private void num_angle_ValueChanged(object sender, EventArgs e) // If the user changes the angle either by clicking up down, typing new angle, or using scroll wheel, the rectangle is redrawn with that angle
        {
            var width = Math.Abs(global.input[2] - global.input[0]); // Defining width and height the same way as earlier
            var height = Math.Abs(global.input[3] - global.input[1]);
            rec = new Rectangle(global.input[0], global.input[1], width, height);
            img_rectangle = image_Original.CreateGraphics();

            string angle = num_angle.Text; // Angle by which rectangle should be rotated is stored in textbox and accessed later 
            double theta = Convert.ToDouble(angle);
            theta = (double)(theta * (Math.PI / 180)); //Converting the angle to radians so it can be used by sine/cosine functions later on

            int centerx = global.input[0] + ((global.input[2] - global.input[0]) / 2); //The center of the rectangle in the x-direction
            int centery = global.input[1] + ((global.input[3] - global.input[1]) / 2); //The center of the rectangle in the y-direction

            System.Drawing.Drawing2D.Matrix rotateMatrix = new System.Drawing.Drawing2D.Matrix(); // Creating the rotation matrix
            rotateMatrix.RotateAt(int.Parse(angle), new PointF(centerx, centery)); //Telling matrix the angle by which it should be rotated and that it should be rotated about the center point of the rectangle
            img_rectangle.Transform = rotateMatrix; // // Transforming the rectangle -- giving it the same angle as the matrix     

            img_rectangle.Clear(Color.Black); //Cleared so all past instances of the rectangle are no longer on screen
            Graphics img_rectangle2 = image_Original.CreateGraphics(); // Making another variable so the image is not rotated with the rectangle

            var image = Image.FromFile(lbl_fileName.Text); //Finding location of uploaded image again from text
            Rectangle PictureboxRectangle = new Rectangle(0, 0, image_Original.Width, image_Original.Height); //Makes sure that the image will take up the whole picturebox space
            img_rectangle2.DrawImage(image, PictureboxRectangle); //Drawing the uploaded image again 

            Pen redPen = new Pen(Color.Red, 2);

            img_rectangle.DrawRectangle(redPen, rec); //Drawing rectangle on the picturebox
            image.Dispose(); //Dispose image each time so it doesn't use too much memory

            int x1 = (int)(centerx - ((width / 2 * Math.Cos(theta)) - ((height / 2) * Math.Sin(theta)))); //Top left x value after rotation
            int y1 = (int)(centery - ((width / 2 * Math.Sin(theta)) + ((height / 2) * Math.Cos(theta)))); //Top left y value after rotation

            int x2 = (int)(centerx + ((width / 2 * Math.Cos(theta)) + ((height / 2) * Math.Sin(theta)))); //Top right x value after rotation
            int y2 = (int)(centery + ((width / 2 * Math.Sin(theta)) - ((height / 2) * Math.Cos(theta)))); //Top right y value after rotation

            int x3 = (int)(centerx + ((width / 2 * Math.Cos(theta)) - ((height / 2) * Math.Sin(theta)))); //Bottom right x value after rotation
            int y3 = (int)(centery + ((width / 2 * Math.Sin(theta)) + ((height / 2) * Math.Cos(theta)))); //Bottom right y value after rotation

            int x4 = (int)(centerx - ((width / 2 * Math.Cos(theta)) + ((height / 2) * Math.Sin(theta)))); //Bottom left x value after rotation
            int y4 = (int)(centery - ((width / 2 * Math.Sin(theta)) - ((height / 2) * Math.Cos(theta)))); //Bottom left y value after rotation

            p1xtext.Text = Convert.ToString(x1);
            p1ytext.Text = Convert.ToString(y1);
            p2xtext.Text = Convert.ToString(x2);
            p2ytext.Text = Convert.ToString(y2);
            p3xtext.Text = Convert.ToString(x3);
            p3ytext.Text = Convert.ToString(y3);
            p4xtext.Text = Convert.ToString(x4);
            p4ytext.Text = Convert.ToString(y4);

        }
        private void AngleLabel_Click(object sender, EventArgs e)
        {
        }

        InstructionForm InstructionForm = new InstructionForm();

        private void button2_Click(object sender, EventArgs e)
        {
            InstructionForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_Instructions.Enabled = true;
            button_Upload.Enabled = true;
            btn_areaAround.Enabled = false;
            num_angle.Enabled = false;
            btn_indi.Enabled = false;
            btn_bw.Enabled = false;
            button1.Enabled = false;
            trackBar.Value = 8;
            trackBar.Visible = false;
            txt_Gvalue.Text = "";
            AddDataButton.Enabled = false;
            ExcelButton.Enabled = false;
            label3.Visible = false;

        }

        private void image_Original_MouseHover(object sender, EventArgs e)
        {
            if (indications == true)
            {
                ZoomedImage.Visible = true;
            }
        }


        private void ResizeAndDisplayImage()
        {
            image_Original.BackColor = Color.White;
            ZoomedImage.BackColor = Color.Transparent;

            if (image_Original.Image == null)
                return;

            int sourceWidth = image_Original.Image.Width;
            int sourceHeight = image_Original.Image.Height;
            int targetWidth;
            int targetHeight;
            double ratio;

            if (sourceWidth > sourceHeight)
            {
                targetWidth = image_Original.Width;
                ratio = (double)targetWidth / sourceWidth;
                targetHeight = (int)(ratio * sourceHeight);
            }
            else if (sourceWidth < sourceHeight)
            {
                targetHeight = image_Original.Height;
                ratio = (double)targetHeight / sourceHeight;
                targetWidth = (int)(ratio * sourceWidth);
            }
            else
            {
                targetHeight = image_Original.Height;
                targetWidth = image_Original.Width;
            }

            int targetTop = (image_Original.Height - targetHeight) / 2;
            int targetLeft = (image_Original.Width - targetWidth) / 2;

            Bitmap tempBitmap = new Bitmap(image_Original.Width, image_Original.Height,
                                           PixelFormat.Format16bppRgb565);

            tempBitmap.SetResolution(image_Original.Image.HorizontalResolution,
                                     image_Original.Image.VerticalResolution);

            Graphics bmGraphics = Graphics.FromImage(tempBitmap);

            bmGraphics.Clear(Color.Transparent);

            bmGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;

            bmGraphics.DrawImage(image_Original.Image,
                                 new Rectangle(targetLeft, targetTop, targetWidth, targetHeight),
                                 new Rectangle(0, 0, sourceWidth, sourceHeight),
                                 GraphicsUnit.Pixel);

            bmGraphics.Dispose();

            ZoomedImage.Image = tempBitmap;
            ZoomedImage.Image.Dispose();

        }

        private void UpdateZoomedImage(MouseEventArgs e)
        {

            if (image_Original.Image != null)
            {
                var ZoomFactor = trackBar.Value;
                int zoomWidth = 675 / ZoomFactor;
                int zoomHeight = 675 / ZoomFactor;

                int halfWidth = zoomWidth / 2;
                int halfHeight = zoomHeight / 2;

                Bitmap tempBitmap = new Bitmap(zoomWidth, zoomHeight, PixelFormat.Format16bppRgb565);
         
                Graphics bmGraphics = Graphics.FromImage(tempBitmap);

                bmGraphics.Clear(Color.Transparent);

                bmGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;

                bmGraphics.DrawImage(image_Original.Image,
                                     new Rectangle(0, 0, zoomWidth, zoomHeight),
                                     new Rectangle(e.X - halfWidth, e.Y - halfHeight,
                                     zoomWidth, zoomHeight), GraphicsUnit.Pixel);

              

                bmGraphics.DrawLine(Pens.White, halfWidth - 10,
                                    halfHeight, halfWidth + 10, halfHeight);
                bmGraphics.DrawLine(Pens.White, halfWidth, halfHeight -10,
                                    halfWidth, halfHeight + 10);
             
                ZoomedImage.Image = tempBitmap;
                bmGraphics.Dispose();
                ZoomedImage.Refresh();
                
            }

        }

        private void ExcelButton_Click(object sender, EventArgs e)
        {
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < ExcelData.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = ExcelData.Columns[i-1].HeaderText;
                }

                for (int i = 0; i < ExcelData.Rows.Count; i++)
                {
                    for (int j = 0; j < ExcelData.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = ExcelData.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
        
        private void ShowData_Click(object sender, EventArgs e)
        {
            ExcelData.Rows.Add(DateTime.Now.ToString("MM-dd-yyyy"), txt_Gvalue.Text, label_rect.Text, FileNameLabel.Text, FilePathLabel.Text);
            AddDataButton.Enabled = false;
            ExcelButton.Enabled = true;
            ExcelData.ClearSelection();
            image_Original.Image.Dispose();

        }

        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            if (ExcelData.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select any cell in the row(s) you wish to delete first");
            }

            else if(ExcelData.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell oneCell in ExcelData.SelectedCells)
                {
                    if (oneCell.Selected)
                        ExcelData.Rows.RemoveAt(oneCell.RowIndex);

                }
            }
            ExcelData.Refresh();
            ExcelData.ClearSelection();
            
        }

        private void image_Original_MouseLeave(object sender, EventArgs e)
        {
            ZoomedImage.Visible = false;
        }
    }
}
