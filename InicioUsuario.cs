
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SegundoParcial
{
    public partial class InicioUsuario : Form
    {
        private Usuario usuario;

        public InicioUsuario(Usuario pUsuario)
        {
            InitializeComponent();
            usuario = pUsuario;


        }

        private void InicioUsuario_Load(object sender, EventArgs e)
        {
            label1.Text =
                "Bienvenido " + usuario.usuario + " [" + (usuario.admin ? "Administrador" : "Usuario") + "]";
            if (usuario.admin)
            {


                actualizarControles();
            }
            else
            {

                tabControl1.TabPages[1].Parent = null;
                tabControl1.TabPages[1].Parent = null;
                tabControl1.TabPages[1].Parent = null;
            }
        }

        private void actualizarControles()
        {
            List<Usuario> lista = UsuarioDAO.getLista();
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = lista;

            comboBox1.DataSource = null;
            comboBox1.ValueMember = "contrasena";
            comboBox1.DisplayMember = "usuario";
            comboBox1.DataSource = lista;



        }

        private void button4_Click(object sender, EventArgs e)
        {
            actualizarControles();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario u = (Usuario) comboBox1.SelectedItem;

            if (u.admin)
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;

            if (u.activo)
                radioButton3.Checked = true;
            else
                radioButton4.Checked = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioDAO.actualizarPermisos(comboBox1.Text, radioButton1.Checked, radioButton3.Checked);
            MessageBox.Show("¡Usuario actualizado exitosamente!",
                "SegundoParcial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            actualizarControles();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar al usuario " + comboBox1.Text + "?",
                "SegundoParcial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UsuarioDAO.eliminar(comboBox1.Text);

                MessageBox.Show("¡Usuario eliminado exitosamente!",
                    "SegundoParcial", MessageBoxButtons.OK, MessageBoxIcon.Information);

                actualizarControles();
               }
               
               }
               }
               
               }
               
            
  
    
