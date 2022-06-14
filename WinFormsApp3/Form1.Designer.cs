namespace WinFormsApp3
{
    partial class Form1
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
            this.font = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.fontstyle = new System.Windows.Forms.Label();
            this.alignment = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rchtxb = new System.Windows.Forms.RichTextBox();
            this.nmrcud = new System.Windows.Forms.NumericUpDown();
            this.colorcombobox = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn = new System.Windows.Forms.Button();
            this.underline = new System.Windows.Forms.Button();
            this.eyrixet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.loadtxtbx = new System.Windows.Forms.TextBox();
            this.savetxtbx = new System.Windows.Forms.TextBox();
            this.load = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcud)).BeginInit();
            this.SuspendLayout();
            // 
            // font
            // 
            this.font.AutoSize = true;
            this.font.Location = new System.Drawing.Point(12, 9);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(31, 15);
            this.font.TabIndex = 0;
            this.font.Text = "Font";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(185, 9);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(27, 15);
            this.size.TabIndex = 1;
            this.size.Text = "Size";
            // 
            // fontstyle
            // 
            this.fontstyle.AutoSize = true;
            this.fontstyle.Location = new System.Drawing.Point(347, 10);
            this.fontstyle.Name = "fontstyle";
            this.fontstyle.Size = new System.Drawing.Size(56, 15);
            this.fontstyle.TabIndex = 2;
            this.fontstyle.Text = "FontStyle";
            // 
            // alignment
            // 
            this.alignment.AutoSize = true;
            this.alignment.Location = new System.Drawing.Point(577, 9);
            this.alignment.Name = "alignment";
            this.alignment.Size = new System.Drawing.Size(63, 15);
            this.alignment.TabIndex = 3;
            this.alignment.Text = "Alignment";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(792, 9);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(36, 15);
            this.color.TabIndex = 4;
            this.color.Text = "Color";
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // rchtxb
            // 
            this.rchtxb.Location = new System.Drawing.Point(12, 75);
            this.rchtxb.Name = "rchtxb";
            this.rchtxb.Size = new System.Drawing.Size(1475, 503);
            this.rchtxb.TabIndex = 6;
            this.rchtxb.Text = "";
            // 
            // nmrcud
            // 
            this.nmrcud.Location = new System.Drawing.Point(185, 27);
            this.nmrcud.Name = "nmrcud";
            this.nmrcud.Size = new System.Drawing.Size(41, 23);
            this.nmrcud.TabIndex = 7;
            this.nmrcud.ValueChanged += new System.EventHandler(this.nmrcud_ValueChanged);
            // 
            // colorcombobox
            // 
            this.colorcombobox.FormattingEnabled = true;
            this.colorcombobox.Location = new System.Drawing.Point(792, 30);
            this.colorcombobox.Name = "colorcombobox";
            this.colorcombobox.Size = new System.Drawing.Size(121, 23);
            this.colorcombobox.TabIndex = 8;
            this.colorcombobox.SelectedIndexChanged += new System.EventHandler(this.colorcombobox_SelectedIndexChanged);
            this.colorcombobox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorcombobox_MouseClick);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(347, 28);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(22, 23);
            this.btn.TabIndex = 9;
            this.btn.Text = "B";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // underline
            // 
            this.underline.Location = new System.Drawing.Point(375, 28);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(22, 24);
            this.underline.TabIndex = 10;
            this.underline.Text = "U\r\n";
            this.underline.UseVisualStyleBackColor = true;
            this.underline.Click += new System.EventHandler(this.underline_Click);
            // 
            // eyrixet
            // 
            this.eyrixet.Location = new System.Drawing.Point(403, 28);
            this.eyrixet.Name = "eyrixet";
            this.eyrixet.Size = new System.Drawing.Size(22, 24);
            this.eyrixet.TabIndex = 11;
            this.eyrixet.Text = "/";
            this.eyrixet.UseVisualStyleBackColor = true;
            this.eyrixet.Click += new System.EventHandler(this.eyrixet_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "L";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "C";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(633, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "R";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // loadtxtbx
            // 
            this.loadtxtbx.Location = new System.Drawing.Point(1065, 12);
            this.loadtxtbx.Name = "loadtxtbx";
            this.loadtxtbx.Size = new System.Drawing.Size(177, 23);
            this.loadtxtbx.TabIndex = 15;
            this.loadtxtbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // savetxtbx
            // 
            this.savetxtbx.Location = new System.Drawing.Point(1065, 46);
            this.savetxtbx.Name = "savetxtbx";
            this.savetxtbx.Size = new System.Drawing.Size(177, 23);
            this.savetxtbx.TabIndex = 16;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(1330, 12);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 17;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(1330, 45);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 18;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 633);
            this.Controls.Add(this.save);
            this.Controls.Add(this.load);
            this.Controls.Add(this.savetxtbx);
            this.Controls.Add(this.loadtxtbx);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eyrixet);
            this.Controls.Add(this.underline);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.colorcombobox);
            this.Controls.Add(this.nmrcud);
            this.Controls.Add(this.rchtxb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.color);
            this.Controls.Add(this.alignment);
            this.Controls.Add(this.fontstyle);
            this.Controls.Add(this.size);
            this.Controls.Add(this.font);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmrcud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label font;
        private Label size;
        private Label fontstyle;
        private Label alignment;
        private Label color;
        private FontDialog fontDialog1;
        private ComboBox comboBox1;
        private RichTextBox rchtxb;
        private NumericUpDown nmrcud;
        private ComboBox colorcombobox;
        private ColorDialog colorDialog1;
        private Button btn;
        private Button underline;
        private Button eyrixet;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox loadtxtbx;
        private TextBox savetxtbx;
        private Button load;
        private Button save;
    }
}