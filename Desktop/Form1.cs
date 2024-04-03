namespace Desktop
{
    public partial class Form1 : Form
    {
        public List<int> Tippek = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblEredmenyek.Text = "";
            btnSorsol.Enabled = false;
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 5; j++)
                {
                    CheckBox box = new CheckBox();
                    box.Text = ((i + 1) + (j * 9)).ToString();
                    box.AutoSize = true;
                    box.Location = new Point(i * 40, j * 40);
                    box.CheckedChanged += checkBox1_CheckedChanged;
                    panel.Controls.Add(box);
                }


        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                Tippek.Add(Convert.ToInt32(box.Text));
                if (Tippek.Count() == 6)
                {
                    btnSorsol.Enabled = true;
                    Kapcsol(false);
                }
            }
            else
            {
                Tippek.Remove(Convert.ToInt32(box.Text));
                if (Tippek.Count() == 5)
                {
                    btnSorsol.Enabled = false;
                    Kapcsol(true);
                }
            }
            lblEredmenyek.Text = String.Join("; ", Tippek.OrderBy(x => x));
        }
        public void Kapcsol(bool kapcs)
        {
            foreach (CheckBox item in panel.Controls)
                if (!item.Checked) item.Enabled = kapcs;
        }

        private void btnSorsol_Click(object sender, EventArgs e)
        {
            HashSet<int> set = new HashSet<int>();
            Random rnd = new Random();
            do
            {
                set.Add(rnd.Next(1, 46));
            } while (set.Count() != 6);

            lblEredmenyek.Text = "Tippek: " + String.Join("; ", Tippek.OrderBy(x => x)) + Environment.NewLine;
            lblEredmenyek.Text += "Sorsolás: " + String.Join("; ", set.OrderBy(x => x)) + Environment.NewLine;
            lblEredmenyek.Text += "Eltaláltál " + (set.Intersect(Tippek)).Count() + " db-ot (" + String.Join(", ", set.Intersect(Tippek)) + ")";


        }
    }
}