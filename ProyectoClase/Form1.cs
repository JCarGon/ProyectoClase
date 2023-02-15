using System.Net;
using System.Reflection;

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
            ComprobarPCEnCarga();
        }

        private void botonIP_Click(object sender, EventArgs e)
        {
            getIP();
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            salidaDatosEquipo.ResetText();
            salidaDatosDisco.ResetText();
            salidaIP.ResetText();
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

        private void getIP()
        {
            IPAddress[] direcciones = 
             Dns.GetHostAddresses(Dns.GetHostName())
            .Where(async => !async.IsIPv6LinkLocal)
            .ToArray();

            foreach(IPAddress direccion in direcciones)
            {
            salidaIP.Text += "IP: "+direccion.ToString() + Environment.NewLine;
            }
        }

        private void ComprobarPCEnCarga()
        {
            Type pw = typeof(PowerStatus);

            PropertyInfo[] propiedades = pw.GetProperties();

            object? valor = propiedades[0].GetValue(SystemInformation.PowerStatus, null);
            salidaDatosEquipo.Text += valor.ToString();

            if (valor.ToString() == "Online")
            {
                pictureBox1.BackColor = Color.Green;
            }
            else
            {
                pictureBox1.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComprobarPCEnCarga();
        }
    }
}