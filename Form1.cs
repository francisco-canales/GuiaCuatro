using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace GuiaCuatro
{
    public partial class Form1 : Form
    {
        //defino una variable de tipo connection
        private SqlConnection conn1;
        //defino una varialbe de tipo Data apapter
        private SqlDataAdapter da1;
        //defino una variable de tipo data reader
        private SqlDataReader dr1;
        //defino una varialbe que contendra la cadena de conexion
        private string sCn1;
        //instancio una variable oledbconection
        OleDbConnection cnn = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            //Linea de conexion con el servidor de base de datos sql por oledb
            cnn.ConnectionString = "Provider=SQLOLEDB;Server=FRANCISCO\\SQLEXPRESS;Database=BD_Sucarnet;Uid=sa;Pwd=123456";
            //ocultamos el boton modificar
            modificar1.Visible = false;
            //conexion por medio de sqlclient
            conexion cn1= new
                conexion();
            cn1.conec();
            sCn1 = cn1.cadena;
            conn1 = new SqlConnection(sCn1);
            conn1.Open();

        }

        private void buscar1_Click(object sender, EventArgs e)
        {
            //mostrando los textbox ocultos
            textedad1.Visible = true;
            textnom1.Visible = true;
            textapel1.Visible = true;
            modificar1.Visible = true;
            //Variable que tendra la consulta
            string seleccion;
            seleccion = "Select * From Participantes where Codigo='" + textcod1.Text+"'";
            da1 = new SqlDataAdapter(seleccion, conn1);
            SqlParameter prm = new SqlParameter("Codigo", SqlDbType.VarChar);
            prm.Value = textcod1.Text;
            da1.SelectCommand.Parameters.Add(prm); dr1 = da1.SelectCommand.ExecuteReader();
            while (dr1.Read())
            {
                textnom1.Text = dr1["Nombres"].ToString().Trim();
                textapel1.Text = dr1["Apellidos"].ToString().Trim();
                textedad1.Text = dr1["Edad"].ToString().Trim();
            }
            if (dr1 != null)
            {
                MessageBox.Show("Datos encontrados");
                dr1.Close();
            }
        }

        private void modificar1_Click(object sender, EventArgs e)
        {
            string actualizar;
            actualizar = "update Participantes set "+ " Nombres= '" + textnom1.Text + "', Apellidos= '" + 
                textapel1.Text+ "', Edad= '" + textedad1.Text + "' where Codigo =" + textcod1.Text + "";
            
            OleDbCommand datos = new OleDbCommand(actualizar, cnn);
            cnn.Open();
            //mandando sql a base de datos
            datos.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("REGISTRO ACTUALIZADO");
            Reset();
        }
        private void Reset()
        {
            textcod1.Text = "";
            textnom1.Text = "";
            textapel1.Text = "";
            textedad1.Text = "";
            textedad1.Visible = false;
            textnom1.Visible = false;
            textapel1.Visible = false;
            modificar1.Visible = false;
            Form2 formu2 = new Form2();
            //mostramos el form2
            formu2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
