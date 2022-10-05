using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;


namespace semana10_mysql
{
   
  



    public partial class Form1 : Form
    {
        //Variables globales
        public string cadena_conexion = "Database=agenda;Data Source=localhost;User Id=carin;Password=12345";
        public string usuario_modificar;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Desabilitar campos, se activan al crear nuevo registro
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;

            try
            {

                string consulta = "select * from contacto";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);

                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";

            }
            catch (MySqlException)
            {

                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }

        private void bnuevo_Click(object sender, EventArgs e)
        {

            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;
            txtusuario.Text = "";
            txtclave.Text = "";
            lstnivel.Text = "Seleccione nivel";
            txtusuario.Focus();
            bnuevo.Visible = false;
            bguardar.Visible = true;
        }

        //Guardamos el nuevo registro con INSER INTO
        private void bguardar_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "INSERT INTO usuarios(nombre,clave,nivel) Values(?nombre,?clave,?nivel)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 75).Value = txtusuario.Text;
                myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 75).Value = txtclave.Text;
                myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 11).Value = lstnivel.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from usuarios";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "sistemapro1");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "sistemapro1";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Ya existe el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bnuevo.Visible = true;
            bguardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            bnuevo.Focus();
        }


        //El boton nuevo solo habilita el formulario para actualizar el registro actual
        private void bmodificar_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;

            txtusuario.Focus();

            bmodificar.Visible = false;
            bactualizar.Visible = true;

            usuario_modificar = txtusuario.Text.ToString();

        }

        private void bguardar_Click_1(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "INSERT INTO usuarios(nombre,clave,nivel) Values(?nombre,?clave,?nivel)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 75).Value = txtusuario.Text;
                myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 75).Value = txtclave.Text;
                myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 11).Value = lstnivel.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from contacto";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Ya existe el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bnuevo.Visible = true;
            bguardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            bnuevo.Focus();

        }

        private void bmodificar_Click_1(object sender, EventArgs e)
        {

            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;

            txtusuario.Focus();

            bmodificar.Visible = false;
            bactualizar.Visible = true;

            usuario_modificar = txtusuario.Text.ToString();

        }

        private void bactualizar_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string nom = txtusuario.Text.ToString();
                string cla = txtclave.Text.ToString();
                string niv = lstnivel.Text;

                //Hay dos formas de pasar los valores

                //Primera forma de pasar los valores
                //string myInsertQuery = "UPDATE usuarios SET nombre = ?nombre, clave = ?clave, nivel = ?nivel Where nombre = " + usuario_modificar + "";

                //Segunda forma de pasar los valores, usaremos esto
                string myInsertQuery = "UPDATE usuarios SET nombre = '" + nom + "', clave = '" + cla + "',nivel = '" + niv + "' WHERE nombre = '" + usuario_modificar + "'";

                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                //En caso de usar primera forma, se pasan estos parámetros.
                //myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 75).Value = txtusuario.Text;
                //myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 75).Value = txtclave.Text;
                //myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 11).Value = lstnivel.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario modificado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from usuarios";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "sistemapro1");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "sistemapro1";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al modificar el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bmodificar.Visible = true;
            bactualizar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            bmodificar.Focus();

        }

        private void bsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void beliminar_Click(object sender, EventArgs e)
        {


            try
            {

                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "delete from usuarios Where idusuario = " + txtbuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string consulta = "select * from usuarios";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "sistemapro1");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "sistemapro1";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al eliminar el usuario, primero realice búsqueda del usuario y después puede eliminar.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bnuevo.Visible = true;
            bguardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;

            txtusuario.Text = "";
            txtclave.Text = "";
            lstnivel.Text = "Seleccione nivel";
            txtbuscar.Focus();


        }
    }
}
