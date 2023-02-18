using System.Management;
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
            salidaDatosEquipo.Text = string.Empty;

            getUsuarioEquipo();
            salidaDatosEquipo.TextAlign = HorizontalAlignment.Center;
            salidaDatosEquipo.Text += Environment.NewLine + "Sistema Operativo: " + Environment.OSVersion;
            getGestionRAM();
        }

        private void botonIP_Click(object sender, EventArgs e)
        {
            salidaIP.Text = string.Empty;
            getIP();
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            salidaDatosEquipo.ResetText();
            salidaDatosDisco.ResetText();
            salidaIP.ResetText();
            salidaBateria.ResetText();
            botonColor.BackColor = Color.White;
            botonColor.ForeColor = Color.Black;
        }

        private void botonColor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new Form2();
            form2.Show();
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
            salidaDatosDisco.Text = string.Empty;
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
            salidaBateria.Text += valor.ToString();


            if (valor.ToString() == "Online")
            {
                cuadroColorBateria.BackColor = Color.Green;
            }
            else
            {
                cuadroColorBateria.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComprobarPCEnCarga();
        }

        private void getGestionRAM()
        {
            ObjectQuery objectQuery = new("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher managementObject = new(objectQuery);

            ManagementObjectCollection coleccion = managementObject.Get();

            foreach(ManagementObject elemento in coleccion)
            {
                decimal memoriaTotal = Math.Round(Convert.ToDecimal(elemento["TotalVisibleMemorySize"]) / (1024 * 1024), 2);

                decimal memoriaLibre = Math.Round(Convert.ToDecimal(elemento["FreePhysicalMemory"]) / (1024 * 1024), 2);

                salidaDatosEquipo.Text += Environment.NewLine + "Memoria Total: " + memoriaTotal
                    + Environment.NewLine + "Memoria Libre: " + memoriaLibre;
            }
        }

        private void ComprobarBateria_Click(object sender, EventArgs e)
        {
            salidaBateria.Text = string.Empty;
            ComprobarPCEnCarga();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}