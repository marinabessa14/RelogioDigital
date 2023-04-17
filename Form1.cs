namespace RelogioDigital
{
    public partial class Form1 : Form
    {
        public int Horas { get; set; }

        public int Minutos { get; set; }

        public int Segundos { get; set; }
        public Form1()
        {
            InitializeComponent();

            Horas = DateTime.Now.Hour;
            Minutos = DateTime.Now.Minute;
            Segundos = DateTime.Now.Second;

            lblHoras.Text = Convert.ToString(Horas).PadLeft(2, '0'); ;
            lblMinutos.Text = Convert.ToString(Minutos).PadLeft(2, '0'); ;
            lblSegundos.Text = Convert.ToString(Segundos).PadLeft(2, '0'); ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Horas == 23)
                Horas = 0;
            else
                Horas++;

            lblHoras.Text = Convert.ToString(Horas).PadLeft(2, '0');
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Horas == 0)
                Horas = 23;
            else
            Horas--;

            lblHoras.Text = Convert.ToString(Horas).PadLeft(2, '0');
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            timerRelogioDigital.Stop();
            btnHorasMenos.Visible = true;
            btnHorasMais.Visible = true;
            btnMinutosMenos.Visible = true;
            btnMinutosMais.Visible = true;
            btnSegundosMenos.Visible = true;
            btnSegundosMais.Visible = true; 
            btnOk.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            btnHorasMenos.Visible = false;
            btnHorasMais.Visible = false;
            btnMinutosMenos.Visible = false;
            btnMinutosMais.Visible = false;
            btnSegundosMenos.Visible = false;
            btnSegundosMais.Visible = false;
            btnOk.Visible = false;
            timerRelogioDigital.Start();
        }

        private void btnMinutosMenos_Click(object sender, EventArgs e)
        {
            if (Minutos == 0)
                Minutos = 59;
            else
                Minutos--;
            lblMinutos.Text = Convert.ToString(Minutos).PadLeft(2, '0');

        }

        private void btnMinutosMais_Click(object sender, EventArgs e)
        {
            if (Minutos == 59)
                Minutos = 0;
            else
                Minutos++;

            lblMinutos.Text = Convert.ToString(Minutos).PadLeft(2, '0');
        }

        private void btnSegundosMenos_Click(object sender, EventArgs e)
        {
            if (Segundos == 0)
                Segundos = 59;
            else
                Segundos--;
            lblSegundos.Text = Convert.ToString(Segundos).PadLeft(2, '0');

        }

        private void btnSegundosMais_Click(object sender, EventArgs e)
        {
            if (Segundos == 59)
                Segundos = 0;
            else
                Segundos++;

            lblSegundos.Text = Convert.ToString(Segundos).PadLeft(2, '0');
        }

        private void timerRelogioDigital_Tick(object sender, EventArgs e)
        {

            if (Segundos == 59)
            { 
                Segundos = 0;
            if (Minutos == 59)
            {
                if (Horas == 23)
                    Horas = 0;
                else
                    Horas++;
                Minutos = 0;
            }
            else
                Minutos++;
        }
            else
                Segundos++;


            lblHoras.Text = Convert.ToString(Horas).PadLeft(2, '0');
            lblMinutos.Text = Convert.ToString(Minutos).PadLeft(2, '0');
            lblSegundos.Text = Convert.ToString(Segundos).PadLeft(2, '0');

        }
    }
}