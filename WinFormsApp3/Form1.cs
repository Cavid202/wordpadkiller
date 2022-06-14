namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool Select = false;

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                rchtxb.SelectionFont = fontDialog.Font;
            }
        }

        private void nmrcud_ValueChanged(object sender, EventArgs e) => rchtxb.SelectionFont = new(rchtxb.SelectionFont.FontFamily, (float)nmrcud.Value);

        private void colorcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void colorcombobox_MouseClick(object sender, MouseEventArgs e)
        {

            if (sender is Button btn)
                if (btn.Name == "clrcmbx_selectColorAll") { Select = true; }
                else { Select = false; }


            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                rchtxb.SelectionColor = colorDialog.Color;
            }
        }

        private void underline_Click(object sender, EventArgs e)
        {
            FontStyle style = new();
            if (underline.Name == underline.Name)
                style = FontStyle.Underline;
            rchtxb.SelectionFont = new(rchtxb.SelectionFont, style);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                FontStyle style = new();
                if (btn.Name == btn.Name)
                    style = FontStyle.Bold;



                if (style == rchtxb.SelectionFont.Style)
                    style = FontStyle.Regular;

                rchtxb.SelectionFont = new(rchtxb.SelectionFont, style);
            }


        }

        private void eyrixet_Click(object sender, EventArgs e)
        {
            FontStyle style = new();
            if (eyrixet.Name == eyrixet.Name)
                style = FontStyle.Italic;
            rchtxb.SelectionFont = new(rchtxb.SelectionFont, style);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.Name == button1.Name)
                    rchtxb.SelectionAlignment = HorizontalAlignment.Left;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.Name == button2.Name)
                    rchtxb.SelectionAlignment = HorizontalAlignment.Center;
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.Name == button3.Name)
                    rchtxb.SelectionAlignment = HorizontalAlignment.Right;

            }

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(savetxtbx.Text))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Tex File (*.txt)| *.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                    savetxtbx.Text = sfd.FileName;
            }

            
            File.WriteAllText(savetxtbx.Text, rchtxb.Text);
        }

        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new();
            ofd.Filter = "Tex File (*.txt)| *.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rchtxb.Text = File.ReadAllText(ofd.FileName);
                loadtxtbx.Text = ofd.FileName;
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}