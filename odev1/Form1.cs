namespace odev1
{
    public partial class Form1 : Form
    {
        private string cumle = "";
        public Form1()
        {
            InitializeComponent();
        }

        public string Str { get => cumle; set => cumle = value; }

        private void but1_Click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            if (Str.Length != 0 && Str[Str.Length - 1] == '=')
            {

            }
            else
                Ekran.Text += b.Text;


        }

        private void butM_Click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            if (Str.Length != 0 && Str[Str.Length - 1] == '=')
            {
                Str = "";
            }
            Str += Ekran.Text;
            if (Str.Length != 0 && Str[Str.Length - 1] > '/')
            {

                Str += b.Text;
                label1.Text = Str;
                Ekran.Text = "";
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            if (Str.Length == 0) { }
            else if (Str[Str.Length - 1] == '=') { }
            else
            {
                try
                {
                    Str += Ekran.Text;

                    mathOperation m = new mathOperation(Str);
                    Ekran.Text = m.opertor1;
                    Str += b.Text;
                    label1.Text = Str;

                }
                catch
                {
                    MessageBox.Show("Hata!!");
                    return;
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Str = "";
            Ekran.Text = "";
            label1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Ekran.Text.Length != 0)
            {
                Ekran.Text = Ekran.Text.Substring(0, Ekran.Text.Length - 1);
            }
            if (Str.Length != 0)
            {
                Str = Str.Substring(0, Str.Length - 1);
                label1.Text = Str;
            }

        }

        private void v_Click(object sender, EventArgs e)
        {
            var b = (Button)sender;

            if (Ekran.Text.Length != 0 && Ekran.Text[Ekran.Text.Length - 1] != b.Text[0])
            {
                Ekran.Text = Ekran.Text + b.Text;
            }
        }
    }
}