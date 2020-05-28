using System;
using System.Windows.Forms;



namespace SegundoParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            poblarControles();
        }

        private void poblarControles()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "contrasena";
            comboBox1.DisplayMember = "usuario";
            comboBox1.DataSource = UsuarioDAO.getLista();

        }

        private void Iniciarseccion_Click(object sender, EventArgs e)
        {

            if (Encriptador.CompararMD5(cajacontraseña.Text, comboBox1.SelectedValue.ToString()))
            {
                Usuario u = (Usuario) comboBox1.SelectedItem;

                if (u.activo)
                {
                    RegistroDAO.iniciarSesion(u.usuario);

                    MessageBox.Show("¡Bienvenido!",
                        "SegundoParcial", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    InicioUsuario ventana = new InicioUsuario(u);
                    ventana.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Su cuenta se encuentra inactiva, favor hable con el administrador",
                        "SegundoParcial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else


                MessageBox.Show("¡Contraseña incorrecta!", "SegundoParcial",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

        }
        

        private void cajacontraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Iniciarseccion_Click(sender, e);
        }

        
        }
    }




        




