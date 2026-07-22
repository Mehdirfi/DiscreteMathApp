namespace DiscreteMathApp
{
    partial class DiscreteMathApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscreteMathApp));
            this.lblMenuIcon = new System.Windows.Forms.Label();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.lblWelcome1 = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblWelcome2 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnGraphMenu = new System.Windows.Forms.Button();
            this.panelGradient = new System.Windows.Forms.Panel();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.ShortestPathPanel = new System.Windows.Forms.Panel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.timerShowerLabel = new System.Windows.Forms.Label();
            this.errorTextbox = new System.Windows.Forms.TextBox();
            this.secondVertex = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.firstVertex = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.toolbarPanel = new System.Windows.Forms.Panel();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnBacktoHome = new System.Windows.Forms.Button();
            this.btnShortestPath = new System.Windows.Forms.Button();
            this.btnClearGraph = new System.Windows.Forms.Button();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.btnAddVertex = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelWelcome.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelGradient.SuspendLayout();
            this.panelGraph.SuspendLayout();
            this.ShortestPathPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondVertex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstVertex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.toolbarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenuIcon
            // 
            this.lblMenuIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenuIcon.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuIcon.ForeColor = System.Drawing.Color.Transparent;
            this.lblMenuIcon.Location = new System.Drawing.Point(1318, 9);
            this.lblMenuIcon.Name = "lblMenuIcon";
            this.lblMenuIcon.Size = new System.Drawing.Size(60, 50);
            this.lblMenuIcon.TabIndex = 0;
            this.lblMenuIcon.Text = "☰";
            this.lblMenuIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.panelWelcome.Controls.Add(this.lblWelcome1);
            this.panelWelcome.Controls.Add(this.lblSubtitle);
            this.panelWelcome.Controls.Add(this.lblWelcome2);
            this.panelWelcome.Location = new System.Drawing.Point(430, 254);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(530, 180);
            this.panelWelcome.TabIndex = 4;
            this.panelWelcome.Click += new System.EventHandler(this.MenuDisable_Click);
            // 
            // lblWelcome1
            // 
            this.lblWelcome1.AutoSize = true;
            this.lblWelcome1.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome1.ForeColor = System.Drawing.Color.White;
            this.lblWelcome1.Location = new System.Drawing.Point(161, 9);
            this.lblWelcome1.Name = "lblWelcome1";
            this.lblWelcome1.Size = new System.Drawing.Size(209, 54);
            this.lblWelcome1.TabIndex = 3;
            this.lblWelcome1.Text = "به اپلیکیشن";
            this.lblWelcome1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome1.Click += new System.EventHandler(this.MenuDisable_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblSubtitle.Location = new System.Drawing.Point(110, 131);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(323, 28);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "از منوی بالا موضوع خود را انتخاب کنید";
            this.lblSubtitle.Click += new System.EventHandler(this.MenuDisable_Click);
            // 
            // lblWelcome2
            // 
            this.lblWelcome2.AutoSize = true;
            this.lblWelcome2.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome2.ForeColor = System.Drawing.Color.White;
            this.lblWelcome2.Location = new System.Drawing.Point(20, 63);
            this.lblWelcome2.Name = "lblWelcome2";
            this.lblWelcome2.Size = new System.Drawing.Size(494, 54);
            this.lblWelcome2.TabIndex = 1;
            this.lblWelcome2.Text = "ریاضیات گسسته خوش آمدید\r\n";
            this.lblWelcome2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome2.Click += new System.EventHandler(this.MenuDisable_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.btnGraphMenu);
            this.panelMenu.Location = new System.Drawing.Point(1144, 36);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(168, 43);
            this.panelMenu.TabIndex = 5;
            this.panelMenu.Visible = false;
            // 
            // btnGraphMenu
            // 
            this.btnGraphMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(116)))));
            this.btnGraphMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGraphMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraphMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraphMenu.ForeColor = System.Drawing.Color.White;
            this.btnGraphMenu.Location = new System.Drawing.Point(0, 0);
            this.btnGraphMenu.Name = "btnGraphMenu";
            this.btnGraphMenu.Size = new System.Drawing.Size(168, 43);
            this.btnGraphMenu.TabIndex = 0;
            this.btnGraphMenu.Text = "📊 محاسبات گراف";
            this.btnGraphMenu.UseVisualStyleBackColor = false;
            // 
            // panelGradient
            // 
            this.panelGradient.Controls.Add(this.panelGraph);
            this.panelGradient.Controls.Add(this.panelMenu);
            this.panelGradient.Controls.Add(this.panelWelcome);
            this.panelGradient.Controls.Add(this.lblMenuIcon);
            this.panelGradient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGradient.Location = new System.Drawing.Point(0, 0);
            this.panelGradient.Name = "panelGradient";
            this.panelGradient.Size = new System.Drawing.Size(1390, 689);
            this.panelGradient.TabIndex = 0;
            this.panelGradient.Click += new System.EventHandler(this.MenuDisable_Click);
            // 
            // panelGraph
            // 
            this.panelGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(79)))), ((int)(((byte)(139)))));
            this.panelGraph.Controls.Add(this.ShortestPathPanel);
            this.panelGraph.Controls.Add(this.pictureBoxCanvas);
            this.panelGraph.Controls.Add(this.toolbarPanel);
            this.panelGraph.Controls.Add(this.listBox2);
            this.panelGraph.Controls.Add(this.listBox1);
            this.panelGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph.Location = new System.Drawing.Point(0, 0);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(1390, 689);
            this.panelGraph.TabIndex = 6;
            this.panelGraph.Visible = false;
            // 
            // ShortestPathPanel
            // 
            this.ShortestPathPanel.Controls.Add(this.textBox9);
            this.ShortestPathPanel.Controls.Add(this.textBox8);
            this.ShortestPathPanel.Controls.Add(this.textBox7);
            this.ShortestPathPanel.Controls.Add(this.textBox6);
            this.ShortestPathPanel.Controls.Add(this.textBox5);
            this.ShortestPathPanel.Controls.Add(this.listBox4);
            this.ShortestPathPanel.Controls.Add(this.textBox4);
            this.ShortestPathPanel.Controls.Add(this.button1);
            this.ShortestPathPanel.Controls.Add(this.listBox3);
            this.ShortestPathPanel.Controls.Add(this.timerShowerLabel);
            this.ShortestPathPanel.Controls.Add(this.errorTextbox);
            this.ShortestPathPanel.Controls.Add(this.secondVertex);
            this.ShortestPathPanel.Controls.Add(this.textBox3);
            this.ShortestPathPanel.Controls.Add(this.firstVertex);
            this.ShortestPathPanel.Controls.Add(this.textBox2);
            this.ShortestPathPanel.Controls.Add(this.textBox1);
            this.ShortestPathPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShortestPathPanel.Location = new System.Drawing.Point(6, 74);
            this.ShortestPathPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ShortestPathPanel.Name = "ShortestPathPanel";
            this.ShortestPathPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShortestPathPanel.Size = new System.Drawing.Size(653, 635);
            this.ShortestPathPanel.TabIndex = 5;
            this.ShortestPathPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ShortestPathPanel_Paint);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.Turquoise;
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(143, 463);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(306, 53);
            this.textBox9.TabIndex = 19;
            this.textBox9.Text = "کوتاه ترین مسیر است";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Turquoise;
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(11, 411);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(148, 53);
            this.textBox8.TabIndex = 18;
            this.textBox8.Text = "به طول";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Turquoise;
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(495, 411);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(156, 53);
            this.textBox7.TabIndex = 17;
            this.textBox7.Text = "مسیر";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Info;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(120, 140);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox6.Size = new System.Drawing.Size(152, 37);
            this.textBox6.TabIndex = 16;
            this.textBox6.Text = "طول مسیر ها";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(507, 140);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox5.Size = new System.Drawing.Size(144, 37);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "تمامی مسیر ها";
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 20;
            this.listBox4.Location = new System.Drawing.Point(11, 182);
            this.listBox4.Margin = new System.Windows.Forms.Padding(2);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(261, 204);
            this.listBox4.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Turquoise;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(159, 411);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(341, 53);
            this.textBox4.TabIndex = 14;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(198, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "نمایش کوتاه ترین مسیر";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(276, 182);
            this.listBox3.Margin = new System.Windows.Forms.Padding(2);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(375, 204);
            this.listBox3.TabIndex = 12;
            // 
            // timerShowerLabel
            // 
            this.timerShowerLabel.AutoSize = true;
            this.timerShowerLabel.BackColor = System.Drawing.Color.White;
            this.timerShowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerShowerLabel.Location = new System.Drawing.Point(486, 536);
            this.timerShowerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timerShowerLabel.Name = "timerShowerLabel";
            this.timerShowerLabel.Size = new System.Drawing.Size(42, 46);
            this.timerShowerLabel.TabIndex = 11;
            this.timerShowerLabel.Text = "4";
            this.timerShowerLabel.Visible = false;
            // 
            // errorTextbox
            // 
            this.errorTextbox.BackColor = System.Drawing.Color.Red;
            this.errorTextbox.Enabled = false;
            this.errorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.errorTextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.errorTextbox.Location = new System.Drawing.Point(98, 537);
            this.errorTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.errorTextbox.Name = "errorTextbox";
            this.errorTextbox.Size = new System.Drawing.Size(384, 45);
            this.errorTextbox.TabIndex = 10;
            this.errorTextbox.Visible = false;
            this.errorTextbox.TextChanged += new System.EventHandler(this.errorTextbox_TextChanged);
            // 
            // secondVertex
            // 
            this.secondVertex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.secondVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.secondVertex.Location = new System.Drawing.Point(76, 8);
            this.secondVertex.Margin = new System.Windows.Forms.Padding(2);
            this.secondVertex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.secondVertex.Name = "secondVertex";
            this.secondVertex.Size = new System.Drawing.Size(83, 45);
            this.secondVertex.TabIndex = 8;
            this.secondVertex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.secondVertex.ValueChanged += new System.EventHandler(this.secondVertex_ValueChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Yellow;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox3.Location = new System.Drawing.Point(182, 8);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox3.Size = new System.Drawing.Size(26, 45);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "و";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstVertex
            // 
            this.firstVertex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.firstVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.firstVertex.Location = new System.Drawing.Point(229, 8);
            this.firstVertex.Margin = new System.Windows.Forms.Padding(2);
            this.firstVertex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.firstVertex.Name = "firstVertex";
            this.firstVertex.Size = new System.Drawing.Size(88, 45);
            this.firstVertex.TabIndex = 6;
            this.firstVertex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Yellow;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.Location = new System.Drawing.Point(351, 8);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(302, 45);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "\r\n\r\nدو راس را انتخاب کنید";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Turquoise;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Location = new System.Drawing.Point(441, 463);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 53);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCanvas.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxCanvas.Location = new System.Drawing.Point(671, 76);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(707, 601);
            this.pictureBoxCanvas.TabIndex = 0;
            this.pictureBoxCanvas.TabStop = false;
            this.pictureBoxCanvas.Click += new System.EventHandler(this.pictureBoxCanvas_Click);
            // 
            // toolbarPanel
            // 
            this.toolbarPanel.Controls.Add(this.btnRedo);
            this.toolbarPanel.Controls.Add(this.btnUndo);
            this.toolbarPanel.Controls.Add(this.btnBacktoHome);
            this.toolbarPanel.Controls.Add(this.btnShortestPath);
            this.toolbarPanel.Controls.Add(this.btnClearGraph);
            this.toolbarPanel.Controls.Add(this.btnAddEdge);
            this.toolbarPanel.Controls.Add(this.btnAddVertex);
            this.toolbarPanel.Location = new System.Drawing.Point(0, 6);
            this.toolbarPanel.Name = "toolbarPanel";
            this.toolbarPanel.Size = new System.Drawing.Size(1378, 70);
            this.toolbarPanel.TabIndex = 1;
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.Color.Blue;
            this.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnRedo.ForeColor = System.Drawing.Color.White;
            this.btnRedo.Location = new System.Drawing.Point(668, 3);
            this.btnRedo.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(115, 60);
            this.btnRedo.TabIndex = 6;
            this.btnRedo.Text = "↪️";
            this.btnRedo.UseVisualStyleBackColor = false;
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnUndo.ForeColor = System.Drawing.Color.White;
            this.btnUndo.Location = new System.Drawing.Point(531, 3);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(132, 60);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.Text = "↩️ ";
            this.btnUndo.UseVisualStyleBackColor = false;
            // 
            // btnBacktoHome
            // 
            this.btnBacktoHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBacktoHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBacktoHome.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnBacktoHome.ForeColor = System.Drawing.Color.White;
            this.btnBacktoHome.Location = new System.Drawing.Point(282, 4);
            this.btnBacktoHome.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnBacktoHome.Name = "btnBacktoHome";
            this.btnBacktoHome.Size = new System.Drawing.Size(243, 60);
            this.btnBacktoHome.TabIndex = 4;
            this.btnBacktoHome.Text = "📊 برگشت به خانه";
            this.btnBacktoHome.UseVisualStyleBackColor = false;
            // 
            // btnShortestPath
            // 
            this.btnShortestPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnShortestPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShortestPath.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnShortestPath.ForeColor = System.Drawing.Color.White;
            this.btnShortestPath.Location = new System.Drawing.Point(6, 3);
            this.btnShortestPath.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnShortestPath.Name = "btnShortestPath";
            this.btnShortestPath.Size = new System.Drawing.Size(271, 60);
            this.btnShortestPath.TabIndex = 2;
            this.btnShortestPath.Text = "🛣️ کوتاه‌ترین مسیر";
            this.btnShortestPath.UseVisualStyleBackColor = false;
            this.btnShortestPath.Click += new System.EventHandler(this.btnShortestPath_Click);
            // 
            // btnClearGraph
            // 
            this.btnClearGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(68)))), ((int)(((byte)(67)))));
            this.btnClearGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearGraph.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnClearGraph.ForeColor = System.Drawing.Color.White;
            this.btnClearGraph.Location = new System.Drawing.Point(788, 3);
            this.btnClearGraph.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnClearGraph.Name = "btnClearGraph";
            this.btnClearGraph.Size = new System.Drawing.Size(190, 60);
            this.btnClearGraph.TabIndex = 3;
            this.btnClearGraph.Text = "🗑️ پاک کن";
            this.btnClearGraph.UseVisualStyleBackColor = false;
            this.btnClearGraph.Click += new System.EventHandler(this.btnClearGraph_Click);
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(108)))), ((int)(((byte)(186)))));
            this.btnAddEdge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEdge.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAddEdge.ForeColor = System.Drawing.Color.White;
            this.btnAddEdge.Location = new System.Drawing.Point(983, 3);
            this.btnAddEdge.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(190, 60);
            this.btnAddEdge.TabIndex = 1;
            this.btnAddEdge.Text = "✏️ یال جدید";
            this.btnAddEdge.UseVisualStyleBackColor = false;
            // 
            // btnAddVertex
            // 
            this.btnAddVertex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddVertex.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddVertex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVertex.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVertex.ForeColor = System.Drawing.Color.White;
            this.btnAddVertex.Location = new System.Drawing.Point(1178, 3);
            this.btnAddVertex.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnAddVertex.Name = "btnAddVertex";
            this.btnAddVertex.Size = new System.Drawing.Size(190, 60);
            this.btnAddVertex.TabIndex = 0;
            this.btnAddVertex.Text = "➕ راس جدید";
            this.btnAddVertex.UseVisualStyleBackColor = false;
            this.btnAddVertex.Click += new System.EventHandler(this.btnAddVertex_Click);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.DimGray;
            this.listBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(1049, 746);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(90, 100);
            this.listBox2.TabIndex = 3;
            this.listBox2.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DimGray;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1112, 468);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(88, 100);
            this.listBox1.TabIndex = 2;
            this.listBox1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DiscreteMathApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1390, 689);
            this.Controls.Add(this.panelGradient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DiscreteMathApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اپلیکیشن ریاضیات گسسته";
            this.Load += new System.EventHandler(this.DiscreteMathApp_Load);
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelGradient.ResumeLayout(false);
            this.panelGraph.ResumeLayout(false);
            this.ShortestPathPanel.ResumeLayout(false);
            this.ShortestPathPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondVertex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstVertex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.toolbarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMenuIcon;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label lblWelcome1;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblWelcome2;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnGraphMenu;
        private System.Windows.Forms.Panel panelGradient;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Panel toolbarPanel;
        private System.Windows.Forms.Button btnAddVertex;
        private System.Windows.Forms.Button btnShortestPath;
        private System.Windows.Forms.Button btnClearGraph;
        private System.Windows.Forms.Button btnAddEdge;
        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel ShortestPathPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown secondVertex;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown firstVertex;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox errorTextbox;
        private System.Windows.Forms.Label timerShowerLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnBacktoHome;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnUndo;
    }
}

