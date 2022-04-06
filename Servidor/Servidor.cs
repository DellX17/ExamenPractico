using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Servidor
{
    
    public partial class Servidor : Form
    {
        DataTable dt = new DataTable();
        ServidorC server = new ServidorC();

        public Servidor()
        {
            InitializeComponent();
            server.nuevoServer();
            
        }

        public void User(Socket client)
        {
            while (true)
            {
                byte[] msg = new byte[1024];
                int size = client.Receive(msg);
                client.Send(msg, 0, size, SocketFlags.None);
            }
        }

        private void leerTXT(string directorio)
        {
            using (StreamReader sr = new StreamReader(directorio))
            {
                List<string> datos = new List<string>();
                string linea = string.Empty;
                while ((linea=sr.ReadLine()) != null)
                {
                    datos.Add(linea);
                }
                usarTXT(datos);
            }
        }

        private void usarTXT(List<string> datos)
        {
            if (!datos.Count.Equals(0))
            {
                int i = 0;
                for (i = 0; i < datos.Count; i++)
                {
                    if (i.Equals(0))
                    {
                        string[] conceptos = datos[i].ToString().Split('%');
                        dt.Columns.Add(conceptos[0]);
                        dt.Columns.Add(conceptos[1]);
                        dt.Columns.Add(conceptos[2]);
                    }
                    else
                    {
                        string[] conceptos = datos[i].ToString().Split('%');
                        dt.Rows.Add(conceptos[0],conceptos[1],conceptos[2]);
                    }
                }
                dgvInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvInfo.DataSource = dt;
            }
        }


        private string buscarArchivoTXT()
        {
            string nombreArchivo = string.Empty;
            OpenFileDialog busqueda = new OpenFileDialog();
            busqueda.Title = "Selecciona tu archivo TXT";
            busqueda.Filter = "TXT Files (*.txt)|*.txt";
            if (busqueda.ShowDialog().Equals(DialogResult.OK))
            {
                nombreArchivo = busqueda.FileName;
            }return nombreArchivo;
        }

        private void btnTXT_Click_1(object sender, EventArgs e)
        {
            leerTXT(buscarArchivoTXT());
        }

        private void btnTEST_Click(object sender, EventArgs e)
        {
            using (DataTable dtT = new DataTable())
            {
                dtT.Columns.Add("Nombre");
                dtT.Columns.Add("Apellido");
                dtT.Columns.Add("Edad");
                string input = txtTEST.Text;
                string[] conceptos = input.Split('%');
                dtT.Rows.Add(conceptos[0], conceptos[1], conceptos[2]);
                StringBuilder sb = new StringBuilder();

                string[] columnNames = dtT.Columns.Cast<DataColumn>().
                                                  Select(column => column.ColumnName).
                                                  ToArray();
                sb.AppendLine(string.Join("%", columnNames));

                foreach (DataRow row in dtT.Rows)
                {
                    string[] fields = row.ItemArray.Select(field => field.ToString()).
                                                    ToArray();
                    sb.AppendLine(string.Join("%", fields));
                }
                var directorio = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\DBEXAMENTEORICO\";

                if (!Directory.Exists(directorio))
                {
                    Directory.CreateDirectory(directorio);
                }
                File.WriteAllText($@"{directorio}{conceptos[0]}.txt", sb.ToString(), Encoding.UTF8);
                MessageBox.Show($@"Guardado satisfactoriamente en: {directorio} como {conceptos[0]}.txt");
            };
            
            
        }
    
    }
}
