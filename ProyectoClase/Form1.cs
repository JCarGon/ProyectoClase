namespace ProyectoClase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonEmpezar_Click(object sender, EventArgs e)
        {
            getUsuarioEquipo();
            salidaDatosEquipo.TextAlign = HorizontalAlignment.Center;
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            salidaDatosEquipo.ResetText();
            salidaDatosDisco.ResetText();
        }

        private void botonColor_Click(object sender, EventArgs e)
        {
            botonColor.BackColor = Color.Red;
            botonColor.ForeColor = Color.White;
        }

        private void getUsuarioEquipo()
        {
            string usuario = SystemInformation.UserName;
            string dominio = SystemInformation.UserDomainName;

            salidaDatosEquipo.Text = "Usuario: " + usuario + Environment.NewLine
                + "Dominio equipo: " + dominio;
        }

        private void getUnidadesDisco()
        {
            DriveInfo[] unidadesDisco = DriveInfo
                .GetDrives()
                .Where(disco => disco.DriveType == DriveType.Fixed)
                .ToArray();
            foreach (DriveInfo drive in unidadesDisco)
            {
                double espacioLibre = drive.TotalFreeSpace;
                double espacioTotal = drive.TotalSize;
                double porcentajeEspacioLibre = (espacioLibre/ espacioTotal) * 100;

                salidaDatosDisco.Text += drive.Name + ": " + porcentajeEspacioLibre + "%" + Environment.NewLine;
            }
        }

        private void datosDisco_Click(object sender, EventArgs e)
        {
            salidaDatosDisco.TextAlign = HorizontalAlignment.Center;

            getUnidadesDisco();
        }
    }
}