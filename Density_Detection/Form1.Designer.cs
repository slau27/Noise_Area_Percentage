namespace Density_Detection
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_Upload = new System.Windows.Forms.Button();
            this.lbl_Originalimage = new System.Windows.Forms.Label();
            this.lbl_Adjusted = new System.Windows.Forms.Label();
            this.btn_bw = new System.Windows.Forms.Button();
            this.txt_Gvalue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Density = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_areaAround = new System.Windows.Forms.Button();
            this.btn_indi = new System.Windows.Forms.Button();
            this.AngleLabel = new System.Windows.Forms.Label();
            this.num_angle = new System.Windows.Forms.NumericUpDown();
            this.button_Instructions = new System.Windows.Forms.Button();
            this.NoiseAreaPercentageText = new System.Windows.Forms.Label();
            this.BottomLeft = new System.Windows.Forms.Label();
            this.p1xtext = new System.Windows.Forms.TextBox();
            this.BottomRight = new System.Windows.Forms.Label();
            this.p1ytext = new System.Windows.Forms.TextBox();
            this.TopRight = new System.Windows.Forms.Label();
            this.p2xtext = new System.Windows.Forms.TextBox();
            this.txt_width = new System.Windows.Forms.TextBox();
            this.p2ytext = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.p3xtext = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.p3ytext = new System.Windows.Forms.TextBox();
            this.txt_yRect = new System.Windows.Forms.TextBox();
            this.p4xtext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.p4ytext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Xlabel = new System.Windows.Forms.Label();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.Ylabel = new System.Windows.Forms.Label();
            this.txt_xRect = new System.Windows.Forms.TextBox();
            this.TopLeft = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.ExcelButton = new System.Windows.Forms.Button();
            this.AddDataButton = new System.Windows.Forms.Button();
            this.ExcelData = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageGValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiseAreaPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePathName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_rect = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Coor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.ZoomedImage = new System.Windows.Forms.PictureBox();
            this.image_Original = new System.Windows.Forms.PictureBox();
            this.image_Bw = new System.Windows.Forms.PictureBox();
            this.DeleteRowButton = new System.Windows.Forms.Button();
            this.lbl_fileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_angle)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExcelData)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Bw)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Upload
            // 
            this.button_Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Upload.Location = new System.Drawing.Point(7, 551);
            this.button_Upload.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_Upload.Name = "button_Upload";
            this.button_Upload.Size = new System.Drawing.Size(158, 39);
            this.button_Upload.TabIndex = 2;
            this.button_Upload.Text = "Upload Photo";
            this.button_Upload.UseVisualStyleBackColor = true;
            this.button_Upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // lbl_Originalimage
            // 
            this.lbl_Originalimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Originalimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Originalimage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Originalimage.Location = new System.Drawing.Point(139, 13);
            this.lbl_Originalimage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Originalimage.Name = "lbl_Originalimage";
            this.lbl_Originalimage.Size = new System.Drawing.Size(173, 21);
            this.lbl_Originalimage.TabIndex = 17;
            this.lbl_Originalimage.Text = "Original Image";
            this.lbl_Originalimage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Originalimage.Visible = false;
            // 
            // lbl_Adjusted
            // 
            this.lbl_Adjusted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Adjusted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Adjusted.Location = new System.Drawing.Point(621, 13);
            this.lbl_Adjusted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Adjusted.Name = "lbl_Adjusted";
            this.lbl_Adjusted.Size = new System.Drawing.Size(173, 21);
            this.lbl_Adjusted.TabIndex = 18;
            this.lbl_Adjusted.Text = "Black/Green Image";
            this.lbl_Adjusted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Adjusted.Visible = false;
            // 
            // btn_bw
            // 
            this.btn_bw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bw.Location = new System.Drawing.Point(7, 737);
            this.btn_bw.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_bw.Name = "btn_bw";
            this.btn_bw.Size = new System.Drawing.Size(158, 39);
            this.btn_bw.TabIndex = 25;
            this.btn_bw.Text = "Convert To Black";
            this.btn_bw.UseVisualStyleBackColor = true;
            this.btn_bw.Click += new System.EventHandler(this.btn_bw_Click);
            // 
            // txt_Gvalue
            // 
            this.txt_Gvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gvalue.Location = new System.Drawing.Point(66, 47);
            this.txt_Gvalue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Gvalue.Name = "txt_Gvalue";
            this.txt_Gvalue.ReadOnly = true;
            this.txt_Gvalue.Size = new System.Drawing.Size(92, 26);
            this.txt_Gvalue.TabIndex = 26;
            this.txt_Gvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Gvalue.TextChanged += new System.EventHandler(this.txt_Gvalue_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 33);
            this.label1.TabIndex = 27;
            this.label1.Text = "Pixels with G values less than or equal to this will be black:\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(7, 790);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 39);
            this.button1.TabIndex = 28;
            this.button1.Text = "Clear Markings";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "G value 0 to 255";
            // 
            // lbl_Density
            // 
            this.lbl_Density.AutoSize = true;
            this.lbl_Density.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Density.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Density.Location = new System.Drawing.Point(642, 47);
            this.lbl_Density.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Density.Name = "lbl_Density";
            this.lbl_Density.Size = new System.Drawing.Size(112, 19);
            this.lbl_Density.TabIndex = 33;
            this.lbl_Density.Text = "Noise Area % = ";
            this.lbl_Density.Visible = false;
            this.lbl_Density.Click += new System.EventHandler(this.lbl_Density_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y,
            this.G});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(271, 104);
            this.dataGridView1.TabIndex = 44;
            // 
            // X
            // 
            this.X.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 90;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 90;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 90;
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Width = 90;
            // 
            // G
            // 
            this.G.HeaderText = "G value";
            this.G.MinimumWidth = 88;
            this.G.Name = "G";
            this.G.ReadOnly = true;
            this.G.Width = 88;
            // 
            // btn_areaAround
            // 
            this.btn_areaAround.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_areaAround.Location = new System.Drawing.Point(7, 601);
            this.btn_areaAround.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_areaAround.Name = "btn_areaAround";
            this.btn_areaAround.Size = new System.Drawing.Size(158, 39);
            this.btn_areaAround.TabIndex = 45;
            this.btn_areaAround.Text = "Surrounding Area";
            this.btn_areaAround.UseVisualStyleBackColor = true;
            this.btn_areaAround.Click += new System.EventHandler(this.btn_areaAround_Click);
            // 
            // btn_indi
            // 
            this.btn_indi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_indi.Location = new System.Drawing.Point(7, 685);
            this.btn_indi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_indi.Name = "btn_indi";
            this.btn_indi.Size = new System.Drawing.Size(158, 39);
            this.btn_indi.TabIndex = 46;
            this.btn_indi.Text = "Indication(s)";
            this.btn_indi.UseVisualStyleBackColor = true;
            this.btn_indi.Click += new System.EventHandler(this.btn_indi_Click);
            // 
            // AngleLabel
            // 
            this.AngleLabel.AutoSize = true;
            this.AngleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AngleLabel.Location = new System.Drawing.Point(8, 651);
            this.AngleLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.AngleLabel.Name = "AngleLabel";
            this.AngleLabel.Size = new System.Drawing.Size(50, 20);
            this.AngleLabel.TabIndex = 58;
            this.AngleLabel.Text = "Angle";
            this.AngleLabel.Click += new System.EventHandler(this.AngleLabel_Click);
            // 
            // num_angle
            // 
            this.num_angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_angle.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_angle.Location = new System.Drawing.Point(59, 651);
            this.num_angle.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.num_angle.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.num_angle.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.num_angle.Name = "num_angle";
            this.num_angle.ReadOnly = true;
            this.num_angle.Size = new System.Drawing.Size(105, 26);
            this.num_angle.TabIndex = 59;
            this.num_angle.ValueChanged += new System.EventHandler(this.num_angle_ValueChanged);
            // 
            // button_Instructions
            // 
            this.button_Instructions.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_Instructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Instructions.ForeColor = System.Drawing.Color.White;
            this.button_Instructions.Location = new System.Drawing.Point(7, 500);
            this.button_Instructions.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_Instructions.Name = "button_Instructions";
            this.button_Instructions.Size = new System.Drawing.Size(158, 39);
            this.button_Instructions.TabIndex = 96;
            this.button_Instructions.Text = "Instructions";
            this.button_Instructions.UseVisualStyleBackColor = false;
            this.button_Instructions.Click += new System.EventHandler(this.button2_Click);
            // 
            // NoiseAreaPercentageText
            // 
            this.NoiseAreaPercentageText.AutoSize = true;
            this.NoiseAreaPercentageText.BackColor = System.Drawing.Color.Transparent;
            this.NoiseAreaPercentageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoiseAreaPercentageText.ForeColor = System.Drawing.Color.Black;
            this.NoiseAreaPercentageText.Location = new System.Drawing.Point(45, 9);
            this.NoiseAreaPercentageText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoiseAreaPercentageText.Name = "NoiseAreaPercentageText";
            this.NoiseAreaPercentageText.Size = new System.Drawing.Size(136, 30);
            this.NoiseAreaPercentageText.TabIndex = 97;
            this.NoiseAreaPercentageText.Text = "Noise Area Percentage\r\nof Rectangular Region  \r\n";
            this.NoiseAreaPercentageText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BottomLeft
            // 
            this.BottomLeft.AutoSize = true;
            this.BottomLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomLeft.Location = new System.Drawing.Point(242, 21);
            this.BottomLeft.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.BottomLeft.Name = "BottomLeft";
            this.BottomLeft.Size = new System.Drawing.Size(43, 9);
            this.BottomLeft.TabIndex = 85;
            this.BottomLeft.Text = "Bottom Left";
            // 
            // p1xtext
            // 
            this.p1xtext.Location = new System.Drawing.Point(88, 34);
            this.p1xtext.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.p1xtext.Name = "p1xtext";
            this.p1xtext.ReadOnly = true;
            this.p1xtext.Size = new System.Drawing.Size(52, 20);
            this.p1xtext.TabIndex = 86;
            this.p1xtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BottomRight
            // 
            this.BottomRight.AutoSize = true;
            this.BottomRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomRight.Location = new System.Drawing.Point(189, 21);
            this.BottomRight.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.BottomRight.Name = "BottomRight";
            this.BottomRight.Size = new System.Drawing.Size(49, 9);
            this.BottomRight.TabIndex = 84;
            this.BottomRight.Text = "Bottom Right";
            // 
            // p1ytext
            // 
            this.p1ytext.Location = new System.Drawing.Point(88, 53);
            this.p1ytext.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.p1ytext.Name = "p1ytext";
            this.p1ytext.ReadOnly = true;
            this.p1ytext.Size = new System.Drawing.Size(52, 20);
            this.p1ytext.TabIndex = 87;
            this.p1ytext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TopRight
            // 
            this.TopRight.AutoSize = true;
            this.TopRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopRight.Location = new System.Drawing.Point(144, 21);
            this.TopRight.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TopRight.Name = "TopRight";
            this.TopRight.Size = new System.Drawing.Size(38, 9);
            this.TopRight.TabIndex = 83;
            this.TopRight.Text = "Top Right";
            this.TopRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2xtext
            // 
            this.p2xtext.Location = new System.Drawing.Point(139, 34);
            this.p2xtext.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.p2xtext.Name = "p2xtext";
            this.p2xtext.ReadOnly = true;
            this.p2xtext.Size = new System.Drawing.Size(52, 20);
            this.p2xtext.TabIndex = 88;
            this.p2xtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_width
            // 
            this.txt_width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_width.Location = new System.Drawing.Point(36, 49);
            this.txt_width.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_width.Name = "txt_width";
            this.txt_width.ReadOnly = true;
            this.txt_width.Size = new System.Drawing.Size(37, 26);
            this.txt_width.TabIndex = 47;
            this.txt_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_width.TextChanged += new System.EventHandler(this.txt_width_TextChanged);
            // 
            // p2ytext
            // 
            this.p2ytext.Location = new System.Drawing.Point(139, 53);
            this.p2ytext.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.p2ytext.Name = "p2ytext";
            this.p2ytext.ReadOnly = true;
            this.p2ytext.Size = new System.Drawing.Size(52, 20);
            this.p2ytext.TabIndex = 89;
            this.p2ytext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 9);
            this.label7.TabIndex = 54;
            this.label7.Text = "Y";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // p3xtext
            // 
            this.p3xtext.Location = new System.Drawing.Point(189, 34);
            this.p3xtext.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.p3xtext.Name = "p3xtext";
            this.p3xtext.ReadOnly = true;
            this.p3xtext.Size = new System.Drawing.Size(52, 20);
            this.p3xtext.TabIndex = 90;
            this.p3xtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 9);
            this.label8.TabIndex = 53;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // p3ytext
            // 
            this.p3ytext.Location = new System.Drawing.Point(189, 53);
            this.p3ytext.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.p3ytext.Name = "p3ytext";
            this.p3ytext.ReadOnly = true;
            this.p3ytext.Size = new System.Drawing.Size(52, 20);
            this.p3ytext.TabIndex = 91;
            this.p3ytext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_yRect
            // 
            this.txt_yRect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_yRect.Location = new System.Drawing.Point(36, 27);
            this.txt_yRect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_yRect.Name = "txt_yRect";
            this.txt_yRect.ReadOnly = true;
            this.txt_yRect.Size = new System.Drawing.Size(37, 26);
            this.txt_yRect.TabIndex = 52;
            this.txt_yRect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p4xtext
            // 
            this.p4xtext.Location = new System.Drawing.Point(239, 34);
            this.p4xtext.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.p4xtext.Name = "p4xtext";
            this.p4xtext.ReadOnly = true;
            this.p4xtext.Size = new System.Drawing.Size(52, 20);
            this.p4xtext.TabIndex = 92;
            this.p4xtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 9);
            this.label6.TabIndex = 50;
            this.label6.Text = "Height";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // p4ytext
            // 
            this.p4ytext.Location = new System.Drawing.Point(239, 53);
            this.p4ytext.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.p4ytext.Name = "p4ytext";
            this.p4ytext.ReadOnly = true;
            this.p4ytext.Size = new System.Drawing.Size(52, 20);
            this.p4ytext.TabIndex = 93;
            this.p4ytext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 9);
            this.label5.TabIndex = 49;
            this.label5.Text = "Width";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xlabel.Location = new System.Drawing.Point(77, 38);
            this.Xlabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(10, 9);
            this.Xlabel.TabIndex = 94;
            this.Xlabel.Text = "X";
            // 
            // txt_height
            // 
            this.txt_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_height.Location = new System.Drawing.Point(36, 73);
            this.txt_height.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_height.Name = "txt_height";
            this.txt_height.ReadOnly = true;
            this.txt_height.Size = new System.Drawing.Size(37, 26);
            this.txt_height.TabIndex = 48;
            this.txt_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ylabel
            // 
            this.Ylabel.AutoSize = true;
            this.Ylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ylabel.Location = new System.Drawing.Point(76, 53);
            this.Ylabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Ylabel.Name = "Ylabel";
            this.Ylabel.Size = new System.Drawing.Size(10, 9);
            this.Ylabel.TabIndex = 95;
            this.Ylabel.Text = "Y";
            // 
            // txt_xRect
            // 
            this.txt_xRect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_xRect.Location = new System.Drawing.Point(36, 3);
            this.txt_xRect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_xRect.Name = "txt_xRect";
            this.txt_xRect.ReadOnly = true;
            this.txt_xRect.Size = new System.Drawing.Size(37, 26);
            this.txt_xRect.TabIndex = 51;
            this.txt_xRect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TopLeft
            // 
            this.TopLeft.AutoSize = true;
            this.TopLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopLeft.Location = new System.Drawing.Point(94, 21);
            this.TopLeft.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TopLeft.Name = "TopLeft";
            this.TopLeft.Size = new System.Drawing.Size(32, 9);
            this.TopLeft.TabIndex = 82;
            this.TopLeft.Text = "Top Left";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TopLeft);
            this.panel1.Controls.Add(this.txt_xRect);
            this.panel1.Controls.Add(this.Ylabel);
            this.panel1.Controls.Add(this.txt_height);
            this.panel1.Controls.Add(this.Xlabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.p4ytext);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.p4xtext);
            this.panel1.Controls.Add(this.txt_yRect);
            this.panel1.Controls.Add(this.p3ytext);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.p3xtext);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.p2ytext);
            this.panel1.Controls.Add(this.txt_width);
            this.panel1.Controls.Add(this.p2xtext);
            this.panel1.Controls.Add(this.TopRight);
            this.panel1.Controls.Add(this.p1ytext);
            this.panel1.Controls.Add(this.BottomRight);
            this.panel1.Controls.Add(this.p1xtext);
            this.panel1.Controls.Add(this.BottomLeft);
            this.panel1.Location = new System.Drawing.Point(532, 121);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 105);
            this.panel1.TabIndex = 98;
            this.panel1.Visible = false;
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.trackBar.Location = new System.Drawing.Point(595, 448);
            this.trackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar.Minimum = 6;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(181, 45);
            this.trackBar.TabIndex = 100;
            this.trackBar.Value = 8;
            // 
            // ExcelButton
            // 
            this.ExcelButton.BackColor = System.Drawing.Color.SeaGreen;
            this.ExcelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcelButton.ForeColor = System.Drawing.Color.White;
            this.ExcelButton.Location = new System.Drawing.Point(621, 790);
            this.ExcelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Size = new System.Drawing.Size(295, 39);
            this.ExcelButton.TabIndex = 101;
            this.ExcelButton.Text = "Export Data Table to Excel";
            this.ExcelButton.UseVisualStyleBackColor = false;
            this.ExcelButton.Click += new System.EventHandler(this.ExcelButton_Click);
            // 
            // AddDataButton
            // 
            this.AddDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDataButton.Location = new System.Drawing.Point(185, 790);
            this.AddDataButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddDataButton.Name = "AddDataButton";
            this.AddDataButton.Size = new System.Drawing.Size(187, 39);
            this.AddDataButton.TabIndex = 102;
            this.AddDataButton.Text = "Add Data to Table";
            this.AddDataButton.UseVisualStyleBackColor = true;
            this.AddDataButton.Click += new System.EventHandler(this.ShowData_Click);
            // 
            // ExcelData
            // 
            this.ExcelData.AllowUserToAddRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ExcelData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.ExcelData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExcelData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.ExcelData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExcelData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.AverageGValue,
            this.NoiseAreaPercentage,
            this.FileName,
            this.FilePathName});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExcelData.DefaultCellStyle = dataGridViewCellStyle18;
            this.ExcelData.Location = new System.Drawing.Point(3, 120);
            this.ExcelData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExcelData.Name = "ExcelData";
            this.ExcelData.ReadOnly = true;
            this.ExcelData.RowHeadersVisible = false;
            this.ExcelData.RowHeadersWidth = 62;
            this.ExcelData.RowTemplate.Height = 28;
            this.ExcelData.Size = new System.Drawing.Size(730, 156);
            this.ExcelData.TabIndex = 103;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 65;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 65;
            // 
            // AverageGValue
            // 
            this.AverageGValue.HeaderText = "Average Indication G Value";
            this.AverageGValue.MinimumWidth = 65;
            this.AverageGValue.Name = "AverageGValue";
            this.AverageGValue.ReadOnly = true;
            this.AverageGValue.Width = 65;
            // 
            // NoiseAreaPercentage
            // 
            this.NoiseAreaPercentage.HeaderText = "Noise Area Percentage";
            this.NoiseAreaPercentage.MinimumWidth = 70;
            this.NoiseAreaPercentage.Name = "NoiseAreaPercentage";
            this.NoiseAreaPercentage.ReadOnly = true;
            this.NoiseAreaPercentage.Width = 70;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "File Name";
            this.FileName.MinimumWidth = 220;
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 220;
            // 
            // FilePathName
            // 
            this.FilePathName.HeaderText = "File Path";
            this.FilePathName.MinimumWidth = 307;
            this.FilePathName.Name = "FilePathName";
            this.FilePathName.ReadOnly = true;
            this.FilePathName.Width = 307;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.ExcelData);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(182, 500);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 287);
            this.panel2.TabIndex = 104;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label_rect);
            this.panel4.Controls.Add(this.NoiseAreaPercentageText);
            this.panel4.Location = new System.Drawing.Point(514, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 105);
            this.panel4.TabIndex = 106;
            // 
            // label_rect
            // 
            this.label_rect.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_rect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rect.Location = new System.Drawing.Point(63, 54);
            this.label_rect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.label_rect.Name = "label_rect";
            this.label_rect.ReadOnly = true;
            this.label_rect.Size = new System.Drawing.Size(93, 26);
            this.label_rect.TabIndex = 98;
            this.label_rect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_Gvalue);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(284, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 105);
            this.panel3.TabIndex = 105;
            // 
            // lbl_Coor
            // 
            this.lbl_Coor.AutoSize = true;
            this.lbl_Coor.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Coor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Coor.Location = new System.Drawing.Point(199, 465);
            this.lbl_Coor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Coor.Name = "lbl_Coor";
            this.lbl_Coor.Size = new System.Drawing.Size(110, 15);
            this.lbl_Coor.TabIndex = 56;
            this.lbl_Coor.Text = "X:______   Y:______";
            this.lbl_Coor.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 465);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Mouse Position";
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Enabled = false;
            this.FilePathLabel.Location = new System.Drawing.Point(489, 32);
            this.FilePathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FilePathLabel.MaximumSize = new System.Drawing.Size(54, 13);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(48, 13);
            this.FilePathLabel.TabIndex = 105;
            this.FilePathLabel.Text = "File Path";
            this.FilePathLabel.Visible = false;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Enabled = false;
            this.FileNameLabel.Location = new System.Drawing.Point(489, 52);
            this.FileNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FileNameLabel.MaximumSize = new System.Drawing.Size(54, 13);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(54, 13);
            this.FileNameLabel.TabIndex = 106;
            this.FileNameLabel.Text = "File Name";
            this.FileNameLabel.Visible = false;
            // 
            // ZoomedImage
            // 
            this.ZoomedImage.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ZoomedImage.InitialImage = null;
            this.ZoomedImage.Location = new System.Drawing.Point(466, 8);
            this.ZoomedImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ZoomedImage.MaximumSize = new System.Drawing.Size(450, 439);
            this.ZoomedImage.MinimumSize = new System.Drawing.Size(450, 439);
            this.ZoomedImage.Name = "ZoomedImage";
            this.ZoomedImage.Size = new System.Drawing.Size(450, 439);
            this.ZoomedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ZoomedImage.TabIndex = 99;
            this.ZoomedImage.TabStop = false;
            this.ZoomedImage.Visible = false;
            // 
            // image_Original
            // 
            this.image_Original.BackColor = System.Drawing.Color.White;
            this.image_Original.Cursor = System.Windows.Forms.Cursors.Cross;
            this.image_Original.Location = new System.Drawing.Point(7, 6);
            this.image_Original.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.image_Original.Name = "image_Original";
            this.image_Original.Size = new System.Drawing.Size(450, 487);
            this.image_Original.TabIndex = 0;
            this.image_Original.TabStop = false;
            this.image_Original.Click += new System.EventHandler(this.image_Original_Click);
            this.image_Original.MouseClick += new System.Windows.Forms.MouseEventHandler(this.image_Original_MouseClick);
            this.image_Original.MouseLeave += new System.EventHandler(this.image_Original_MouseLeave);
            this.image_Original.MouseHover += new System.EventHandler(this.image_Original_MouseHover);
            this.image_Original.MouseMove += new System.Windows.Forms.MouseEventHandler(this.image_Original_MouseMove);
            // 
            // image_Bw
            // 
            this.image_Bw.BackColor = System.Drawing.Color.White;
            this.image_Bw.Cursor = System.Windows.Forms.Cursors.Cross;
            this.image_Bw.Enabled = false;
            this.image_Bw.Location = new System.Drawing.Point(466, 6);
            this.image_Bw.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.image_Bw.Name = "image_Bw";
            this.image_Bw.Size = new System.Drawing.Size(449, 487);
            this.image_Bw.TabIndex = 3;
            this.image_Bw.TabStop = false;
            this.image_Bw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.image_Bw_MouseClick);
            this.image_Bw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.image_Bw_MouseMove);
            // 
            // DeleteRowButton
            // 
            this.DeleteRowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRowButton.Location = new System.Drawing.Point(389, 790);
            this.DeleteRowButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteRowButton.Name = "DeleteRowButton";
            this.DeleteRowButton.Size = new System.Drawing.Size(216, 39);
            this.DeleteRowButton.TabIndex = 107;
            this.DeleteRowButton.Text = "Delete Selected Row(s)";
            this.DeleteRowButton.UseVisualStyleBackColor = true;
            this.DeleteRowButton.Click += new System.EventHandler(this.DeleteRowButton_Click);
            // 
            // lbl_fileName
            // 
            this.lbl_fileName.AutoSize = true;
            this.lbl_fileName.Enabled = false;
            this.lbl_fileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fileName.Location = new System.Drawing.Point(466, 5);
            this.lbl_fileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fileName.Name = "lbl_fileName";
            this.lbl_fileName.Size = new System.Drawing.Size(0, 20);
            this.lbl_fileName.TabIndex = 43;
            this.lbl_fileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_fileName.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(923, 768);
            this.Controls.Add(this.lbl_fileName);
            this.Controls.Add(this.DeleteRowButton);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Adjusted);
            this.Controls.Add(this.AddDataButton);
            this.Controls.Add(this.ExcelButton);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.ZoomedImage);
            this.Controls.Add(this.button_Instructions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_angle);
            this.Controls.Add(this.AngleLabel);
            this.Controls.Add(this.lbl_Coor);
            this.Controls.Add(this.btn_indi);
            this.Controls.Add(this.btn_areaAround);
            this.Controls.Add(this.lbl_Density);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_bw);
            this.Controls.Add(this.lbl_Originalimage);
            this.Controls.Add(this.button_Upload);
            this.Controls.Add(this.image_Original);
            this.Controls.Add(this.image_Bw);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "ss";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_angle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExcelData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Bw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image_Original;
        private System.Windows.Forms.Button button_Upload;
        private System.Windows.Forms.PictureBox image_Bw;
        private System.Windows.Forms.Label lbl_Originalimage;
        private System.Windows.Forms.Label lbl_Adjusted;
        private System.Windows.Forms.Button btn_bw;
        private System.Windows.Forms.TextBox txt_Gvalue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Density;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_areaAround;
        private System.Windows.Forms.Button btn_indi;
        private System.Windows.Forms.Label AngleLabel;
        private System.Windows.Forms.NumericUpDown num_angle;
        private System.Windows.Forms.Button button_Instructions;
        private System.Windows.Forms.Label NoiseAreaPercentageText;
        private System.Windows.Forms.PictureBox ZoomedImage;
        private System.Windows.Forms.Label BottomLeft;
        private System.Windows.Forms.TextBox p1xtext;
        private System.Windows.Forms.Label BottomRight;
        private System.Windows.Forms.TextBox p1ytext;
        private System.Windows.Forms.Label TopRight;
        private System.Windows.Forms.TextBox p2xtext;
        private System.Windows.Forms.TextBox txt_width;
        private System.Windows.Forms.TextBox p2ytext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox p3xtext;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox p3ytext;
        private System.Windows.Forms.TextBox txt_yRect;
        private System.Windows.Forms.TextBox p4xtext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox p4ytext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.Label Ylabel;
        private System.Windows.Forms.TextBox txt_xRect;
        private System.Windows.Forms.Label TopLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Button ExcelButton;
        private System.Windows.Forms.Button AddDataButton;
        private System.Windows.Forms.DataGridView ExcelData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Coor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox label_rect;
        private System.Windows.Forms.Button DeleteRowButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn G;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageGValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiseAreaPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePathName;
        private System.Windows.Forms.Label lbl_fileName;
    }
}

