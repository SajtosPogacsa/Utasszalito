namespace UtasszalitokGUI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1Click;
        }

        private void Button1Click(object? sender, EventArgs e)
        {
            double torlo = 0;
            double stat = 0;
            try
            {
                torlo = double.Parse(torloTbx.Text);
                stat = double.Parse(statTbx.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nem megfelelõ a bemeneti karakterlánc formátuma.");
            }


            double m = Math.Sqrt(5 * (Math.Pow((torlo / stat) + 1, 0.2857142857142857) - 1));

            if (m < 1)
            {
                listBox1.Items.Add($"qc={torlo} p0={stat} Ma={m}");
            }
        }
    }
}
