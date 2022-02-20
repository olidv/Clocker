namespace Digital_Clock
{
    partial class frmClock
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClock));
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlCity1 = new System.Windows.Forms.Panel();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblCity1 = new System.Windows.Forms.Label();
            this.pnlCity2 = new System.Windows.Forms.Panel();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblCity2 = new System.Windows.Forms.Label();
            this.pnlCity3 = new System.Windows.Forms.Panel();
            this.lblTime3 = new System.Windows.Forms.Label();
            this.lblCity3 = new System.Windows.Forms.Label();
            this.pnlCity4 = new System.Windows.Forms.Panel();
            this.lblTime4 = new System.Windows.Forms.Label();
            this.lblCity4 = new System.Windows.Forms.Label();
            this.pnlCity9 = new System.Windows.Forms.Panel();
            this.lblTime9 = new System.Windows.Forms.Label();
            this.lblCity9 = new System.Windows.Forms.Label();
            this.pnlCity6 = new System.Windows.Forms.Panel();
            this.lblTime6 = new System.Windows.Forms.Label();
            this.lblCity6 = new System.Windows.Forms.Label();
            this.pnlCity7 = new System.Windows.Forms.Panel();
            this.lblTime7 = new System.Windows.Forms.Label();
            this.lblCity7 = new System.Windows.Forms.Label();
            this.pnlCity8 = new System.Windows.Forms.Panel();
            this.lblTime8 = new System.Windows.Forms.Label();
            this.lblCity8 = new System.Windows.Forms.Label();
            this.pnlCity5 = new System.Windows.Forms.Panel();
            this.lblTime5 = new System.Windows.Forms.Label();
            this.lblCity5 = new System.Windows.Forms.Label();
            this.ckbClose = new System.Windows.Forms.CheckBox();
            this.iglCheckClose = new System.Windows.Forms.ImageList(this.components);
            this.ckbOff = new System.Windows.Forms.CheckBox();
            this.pnlCity1.SuspendLayout();
            this.pnlCity2.SuspendLayout();
            this.pnlCity3.SuspendLayout();
            this.pnlCity4.SuspendLayout();
            this.pnlCity9.SuspendLayout();
            this.pnlCity6.SuspendLayout();
            this.pnlCity7.SuspendLayout();
            this.pnlCity8.SuspendLayout();
            this.pnlCity5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Arial Black", 200.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTime.Location = new System.Drawing.Point(203, 161);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(961, 379);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "08:40";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblDay.Location = new System.Drawing.Point(869, 604);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(462, 46);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "Dia  333º,   Semana  33ª";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Yellow;
            this.lblDate.Location = new System.Drawing.Point(15, 604);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(731, 46);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "TERÇA-FEIRA,  10  NOVEMBRO  2020";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSecond.Font = new System.Drawing.Font("Arial Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.ForeColor = System.Drawing.Color.Silver;
            this.lblSecond.Location = new System.Drawing.Point(1104, 349);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(219, 138);
            this.lblSecond.TabIndex = 3;
            this.lblSecond.Text = ":00";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pnlCity1
            // 
            this.pnlCity1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlCity1.Controls.Add(this.lblTime1);
            this.pnlCity1.Controls.Add(this.lblCity1);
            this.pnlCity1.Location = new System.Drawing.Point(14, 15);
            this.pnlCity1.Name = "pnlCity1";
            this.pnlCity1.Size = new System.Drawing.Size(143, 82);
            this.pnlCity1.TabIndex = 4;
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1.Location = new System.Drawing.Point(33, 36);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(105, 41);
            this.lblTime1.TabIndex = 6;
            this.lblTime1.Text = "00:00";
            this.lblTime1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCity1
            // 
            this.lblCity1.AutoSize = true;
            this.lblCity1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.lblCity1.Location = new System.Drawing.Point(5, 5);
            this.lblCity1.Name = "lblCity1";
            this.lblCity1.Size = new System.Drawing.Size(133, 24);
            this.lblCity1.TabIndex = 5;
            this.lblCity1.Text = "Chicago, US";
            this.lblCity1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlCity2
            // 
            this.pnlCity2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlCity2.Controls.Add(this.lblTime2);
            this.pnlCity2.Controls.Add(this.lblCity2);
            this.pnlCity2.Location = new System.Drawing.Point(168, 15);
            this.pnlCity2.Name = "pnlCity2";
            this.pnlCity2.Size = new System.Drawing.Size(151, 82);
            this.pnlCity2.TabIndex = 7;
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2.Location = new System.Drawing.Point(41, 36);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(105, 41);
            this.lblTime2.TabIndex = 6;
            this.lblTime2.Text = "00:00";
            this.lblTime2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCity2
            // 
            this.lblCity2.AutoSize = true;
            this.lblCity2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.lblCity2.Location = new System.Drawing.Point(5, 5);
            this.lblCity2.Name = "lblCity2";
            this.lblCity2.Size = new System.Drawing.Size(141, 24);
            this.lblCity2.TabIndex = 5;
            this.lblCity2.Text = "New York, US";
            this.lblCity2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlCity3
            // 
            this.pnlCity3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlCity3.Controls.Add(this.lblTime3);
            this.pnlCity3.Controls.Add(this.lblCity3);
            this.pnlCity3.Location = new System.Drawing.Point(330, 15);
            this.pnlCity3.Name = "pnlCity3";
            this.pnlCity3.Size = new System.Drawing.Size(139, 82);
            this.pnlCity3.TabIndex = 7;
            // 
            // lblTime3
            // 
            this.lblTime3.AutoSize = true;
            this.lblTime3.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime3.Location = new System.Drawing.Point(29, 36);
            this.lblTime3.Name = "lblTime3";
            this.lblTime3.Size = new System.Drawing.Size(105, 41);
            this.lblTime3.TabIndex = 6;
            this.lblTime3.Text = "00:00";
            this.lblTime3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCity3
            // 
            this.lblCity3.AutoSize = true;
            this.lblCity3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.lblCity3.Location = new System.Drawing.Point(5, 5);
            this.lblCity3.Name = "lblCity3";
            this.lblCity3.Size = new System.Drawing.Size(129, 24);
            this.lblCity3.TabIndex = 5;
            this.lblCity3.Text = "London, UK";
            this.lblCity3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlCity4
            // 
            this.pnlCity4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlCity4.Controls.Add(this.lblTime4);
            this.pnlCity4.Controls.Add(this.lblCity4);
            this.pnlCity4.Location = new System.Drawing.Point(480, 15);
            this.pnlCity4.Name = "pnlCity4";
            this.pnlCity4.Size = new System.Drawing.Size(154, 82);
            this.pnlCity4.TabIndex = 7;
            // 
            // lblTime4
            // 
            this.lblTime4.AutoSize = true;
            this.lblTime4.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime4.Location = new System.Drawing.Point(44, 36);
            this.lblTime4.Name = "lblTime4";
            this.lblTime4.Size = new System.Drawing.Size(105, 41);
            this.lblTime4.TabIndex = 6;
            this.lblTime4.Text = "00:00";
            this.lblTime4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCity4
            // 
            this.lblCity4.AutoSize = true;
            this.lblCity4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.lblCity4.Location = new System.Drawing.Point(5, 5);
            this.lblCity4.Name = "lblCity4";
            this.lblCity4.Size = new System.Drawing.Size(144, 24);
            this.lblCity4.TabIndex = 5;
            this.lblCity4.Text = "Frankfurt, DE";
            this.lblCity4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlCity9
            // 
            this.pnlCity9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlCity9.Controls.Add(this.lblTime9);
            this.pnlCity9.Controls.Add(this.lblCity9);
            this.pnlCity9.Location = new System.Drawing.Point(1187, 15);
            this.pnlCity9.Name = "pnlCity9";
            this.pnlCity9.Size = new System.Drawing.Size(165, 82);
            this.pnlCity9.TabIndex = 7;
            // 
            // lblTime9
            // 
            this.lblTime9.AutoSize = true;
            this.lblTime9.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime9.Location = new System.Drawing.Point(55, 36);
            this.lblTime9.Name = "lblTime9";
            this.lblTime9.Size = new System.Drawing.Size(105, 41);
            this.lblTime9.TabIndex = 6;
            this.lblTime9.Text = "00:00";
            this.lblTime9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCity9
            // 
            this.lblCity9.AutoSize = true;
            this.lblCity9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.lblCity9.Location = new System.Drawing.Point(5, 5);
            this.lblCity9.Name = "lblCity9";
            this.lblCity9.Size = new System.Drawing.Size(155, 24);
            this.lblCity9.TabIndex = 5;
            this.lblCity9.Text = "Wellington, NZ";
            this.lblCity9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlCity6
            // 
            this.pnlCity6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlCity6.Controls.Add(this.lblTime6);
            this.pnlCity6.Controls.Add(this.lblCity6);
            this.pnlCity6.Location = new System.Drawing.Point(774, 15);
            this.pnlCity6.Name = "pnlCity6";
            this.pnlCity6.Size = new System.Drawing.Size(130, 82);
            this.pnlCity6.TabIndex = 8;
            // 
            // lblTime6
            // 
            this.lblTime6.AutoSize = true;
            this.lblTime6.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime6.Location = new System.Drawing.Point(20, 36);
            this.lblTime6.Name = "lblTime6";
            this.lblTime6.Size = new System.Drawing.Size(105, 41);
            this.lblTime6.TabIndex = 6;
            this.lblTime6.Text = "00:00";
            this.lblTime6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCity6
            // 
            this.lblCity6.AutoSize = true;
            this.lblCity6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.lblCity6.Location = new System.Drawing.Point(5, 5);
            this.lblCity6.Name = "lblCity6";
            this.lblCity6.Size = new System.Drawing.Size(120, 24);
            this.lblCity6.TabIndex = 5;
            this.lblCity6.Text = "Xangai, CN";
            this.lblCity6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlCity7
            // 
            this.pnlCity7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlCity7.Controls.Add(this.lblTime7);
            this.pnlCity7.Controls.Add(this.lblCity7);
            this.pnlCity7.Location = new System.Drawing.Point(915, 15);
            this.pnlCity7.Name = "pnlCity7";
            this.pnlCity7.Size = new System.Drawing.Size(118, 82);
            this.pnlCity7.TabIndex = 7;
            // 
            // lblTime7
            // 
            this.lblTime7.AutoSize = true;
            this.lblTime7.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime7.Location = new System.Drawing.Point(8, 36);
            this.lblTime7.Name = "lblTime7";
            this.lblTime7.Size = new System.Drawing.Size(105, 41);
            this.lblTime7.TabIndex = 6;
            this.lblTime7.Text = "00:00";
            this.lblTime7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCity7
            // 
            this.lblCity7.AutoSize = true;
            this.lblCity7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.lblCity7.Location = new System.Drawing.Point(5, 5);
            this.lblCity7.Name = "lblCity7";
            this.lblCity7.Size = new System.Drawing.Size(108, 24);
            this.lblCity7.TabIndex = 5;
            this.lblCity7.Text = "Tokyo, JP";
            this.lblCity7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlCity8
            // 
            this.pnlCity8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlCity8.Controls.Add(this.lblTime8);
            this.pnlCity8.Controls.Add(this.lblCity8);
            this.pnlCity8.Location = new System.Drawing.Point(1044, 15);
            this.pnlCity8.Name = "pnlCity8";
            this.pnlCity8.Size = new System.Drawing.Size(132, 82);
            this.pnlCity8.TabIndex = 7;
            // 
            // lblTime8
            // 
            this.lblTime8.AutoSize = true;
            this.lblTime8.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime8.Location = new System.Drawing.Point(22, 36);
            this.lblTime8.Name = "lblTime8";
            this.lblTime8.Size = new System.Drawing.Size(105, 41);
            this.lblTime8.TabIndex = 6;
            this.lblTime8.Text = "00:00";
            this.lblTime8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCity8
            // 
            this.lblCity8.AutoSize = true;
            this.lblCity8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.lblCity8.Location = new System.Drawing.Point(5, 5);
            this.lblCity8.Name = "lblCity8";
            this.lblCity8.Size = new System.Drawing.Size(122, 24);
            this.lblCity8.TabIndex = 5;
            this.lblCity8.Text = "Sydney, AU";
            this.lblCity8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlCity5
            // 
            this.pnlCity5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlCity5.Controls.Add(this.lblTime5);
            this.pnlCity5.Controls.Add(this.lblCity5);
            this.pnlCity5.Location = new System.Drawing.Point(645, 15);
            this.pnlCity5.Name = "pnlCity5";
            this.pnlCity5.Size = new System.Drawing.Size(118, 82);
            this.pnlCity5.TabIndex = 9;
            // 
            // lblTime5
            // 
            this.lblTime5.AutoSize = true;
            this.lblTime5.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime5.Location = new System.Drawing.Point(8, 36);
            this.lblTime5.Name = "lblTime5";
            this.lblTime5.Size = new System.Drawing.Size(105, 41);
            this.lblTime5.TabIndex = 6;
            this.lblTime5.Text = "00:00";
            this.lblTime5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCity5
            // 
            this.lblCity5.AutoSize = true;
            this.lblCity5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.lblCity5.Location = new System.Drawing.Point(5, 5);
            this.lblCity5.Name = "lblCity5";
            this.lblCity5.Size = new System.Drawing.Size(108, 24);
            this.lblCity5.TabIndex = 5;
            this.lblCity5.Text = "Dubai, AE";
            this.lblCity5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ckbClose
            // 
            this.ckbClose.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbClose.Checked = true;
            this.ckbClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbClose.ImageIndex = 1;
            this.ckbClose.ImageList = this.iglCheckClose;
            this.ckbClose.Location = new System.Drawing.Point(1083, 162);
            this.ckbClose.Name = "ckbClose";
            this.ckbClose.Size = new System.Drawing.Size(80, 50);
            this.ckbClose.TabIndex = 10;
            this.ckbClose.UseVisualStyleBackColor = true;
            this.ckbClose.CheckedChanged += new System.EventHandler(this.ckbClose_CheckedChanged);
            // 
            // iglCheckClose
            // 
            this.iglCheckClose.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iglCheckClose.ImageStream")));
            this.iglCheckClose.TransparentColor = System.Drawing.Color.Transparent;
            this.iglCheckClose.Images.SetKeyName(0, "close-unchecked.png");
            this.iglCheckClose.Images.SetKeyName(1, "close-checked.png");
            // 
            // ckbOff
            // 
            this.ckbOff.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbOff.Checked = true;
            this.ckbOff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbOff.Image = ((System.Drawing.Image)(resources.GetObject("ckbOff.Image")));
            this.ckbOff.Location = new System.Drawing.Point(203, 162);
            this.ckbOff.Name = "ckbOff";
            this.ckbOff.Size = new System.Drawing.Size(80, 50);
            this.ckbOff.TabIndex = 11;
            this.ckbOff.UseVisualStyleBackColor = true;
            this.ckbOff.Click += new System.EventHandler(this.ckbOff_Click);
            // 
            // frmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1344, 681);
            this.Controls.Add(this.ckbOff);
            this.Controls.Add(this.ckbClose);
            this.Controls.Add(this.pnlCity5);
            this.Controls.Add(this.pnlCity8);
            this.Controls.Add(this.pnlCity7);
            this.Controls.Add(this.pnlCity6);
            this.Controls.Add(this.pnlCity9);
            this.Controls.Add(this.pnlCity4);
            this.Controls.Add(this.pnlCity3);
            this.Controls.Add(this.pnlCity2);
            this.Controls.Add(this.pnlCity1);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblTime);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relógio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmClock_Load);
            this.Resize += new System.EventHandler(this.frmClock_Resize);
            this.pnlCity1.ResumeLayout(false);
            this.pnlCity1.PerformLayout();
            this.pnlCity2.ResumeLayout(false);
            this.pnlCity2.PerformLayout();
            this.pnlCity3.ResumeLayout(false);
            this.pnlCity3.PerformLayout();
            this.pnlCity4.ResumeLayout(false);
            this.pnlCity4.PerformLayout();
            this.pnlCity9.ResumeLayout(false);
            this.pnlCity9.PerformLayout();
            this.pnlCity6.ResumeLayout(false);
            this.pnlCity6.PerformLayout();
            this.pnlCity7.ResumeLayout(false);
            this.pnlCity7.PerformLayout();
            this.pnlCity8.ResumeLayout(false);
            this.pnlCity8.PerformLayout();
            this.pnlCity5.ResumeLayout(false);
            this.pnlCity5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel pnlCity1;
        private System.Windows.Forms.Label lblCity1;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Panel pnlCity2;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblCity2;
        private System.Windows.Forms.Panel pnlCity3;
        private System.Windows.Forms.Label lblTime3;
        private System.Windows.Forms.Label lblCity3;
        private System.Windows.Forms.Panel pnlCity4;
        private System.Windows.Forms.Label lblTime4;
        private System.Windows.Forms.Label lblCity4;
        private System.Windows.Forms.Panel pnlCity9;
        private System.Windows.Forms.Label lblTime9;
        private System.Windows.Forms.Label lblCity9;
        private System.Windows.Forms.Panel pnlCity6;
        private System.Windows.Forms.Label lblTime6;
        private System.Windows.Forms.Label lblCity6;
        private System.Windows.Forms.Panel pnlCity7;
        private System.Windows.Forms.Label lblTime7;
        private System.Windows.Forms.Label lblCity7;
        private System.Windows.Forms.Panel pnlCity8;
        private System.Windows.Forms.Label lblTime8;
        private System.Windows.Forms.Label lblCity8;
        private System.Windows.Forms.Panel pnlCity5;
        private System.Windows.Forms.Label lblTime5;
        private System.Windows.Forms.Label lblCity5;
        private System.Windows.Forms.CheckBox ckbClose;
        private System.Windows.Forms.ImageList iglCheckClose;
        private System.Windows.Forms.CheckBox ckbOff;
    }
}

