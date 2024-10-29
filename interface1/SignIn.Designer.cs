namespace interface1
{
    partial class SignIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            fontDialog1 = new FontDialog();
            groupBox1 = new GroupBox();
            linkLabel2 = new LinkLabel();
            label4 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(151, 249);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(98, 45);
            button1.TabIndex = 2;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(110, 121);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 188);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Forte", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 54);
            label1.Name = "label1";
            label1.Size = new Size(203, 41);
            label1.TabIndex = 5;
            label1.Text = "InstaClone";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.RosyBrown;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.ForeColor = SystemColors.AppWorkspace;
            linkLabel1.LinkColor = Color.DimGray;
            linkLabel1.Location = new Point(192, 323);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(176, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 482);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.RosyBrown;
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.DimGray;
            linkLabel2.Location = new Point(230, 374);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(55, 20);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Kaydol";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(110, 374);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 9;
            label4.Text = "Hesabın yok mu?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(151, 323);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 8;
            label3.Text = "----YA DA----";
            // 
            // SignIn
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.girişara_plan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(752, 648);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private LinkLabel linkLabel1;
        private FontDialog fontDialog1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel2;
    }
}
