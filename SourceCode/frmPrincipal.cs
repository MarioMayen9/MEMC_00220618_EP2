using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class frmPrincipal : Form
    {
        private Usuario  username;
        public frmPrincipal(Usuario pUsuario)
        {
            InitializeComponent();
            username = pUsuario;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = 
                "Bienvenido " + username.username + " [" + (username.usertype ? "Administrador" : "Usuario") + "]";
                

            if (username.usertype)
            {
                
                actualizarControles();
                

                tabContenedor.TabPages[0].Parent = null;
                
            }
            else
            {
                tabContenedor.TabPages[1].Parent = null;
                tabContenedor.TabPages[1].Parent = null;
                tabContenedor.TabPages[1].Parent = null;
                tabContenedor.TabPages[1].Parent = null;
            }
        }

        private void actualizarControles()
        {
            List<Usuario> lista = UsuarioD.getLista();

            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "contrasena";
            cmbUsuario.DisplayMember = "username";
            cmbUsuario.DataSource = lista;

            dvgUsuarios.DataSource = null;
            dvgUsuarios.DataSource = lista;

            List<Negocio> lista1 = NegocioD.getLista();

            cmbNegocioEliminar.DataSource = null;
            cmbNegocioEliminar.ValueMember = "name";
            cmbNegocioEliminar.DisplayMember = "name";
            cmbNegocioEliminar.DataSource = lista1;

            List<Negocio> lista2 = NegocioD.getLista();

            cmbNegocio.DataSource = null;
            cmbNegocio.ValueMember = "idbusiness";
            cmbNegocio.DisplayMember = "name";
            cmbNegocio.DataSource = lista2;

            List<Producto> lista3 = ProductoD.getLista();

            cmbProductoEliminar.DataSource = null;
            cmbProductoEliminar.ValueMember = "idproduct";
            cmbProductoEliminar.DisplayMember = "name";
            cmbProductoEliminar.DataSource = lista3;

            List<Direcciones> lista4 = DireccionesD.getLista();

            cmbDireccion.DataSource = null;
            cmbDireccion.ValueMember = "idaddress";
            cmbDireccion.DisplayMember = "address";
            cmbDireccion.DataSource = lista4;
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNuevoUsuario.Text.Length >= 5)
                {
                    UsuarioD.crearNuevo(txtNuevoUsuario.Text);
                    
                    MessageBox.Show("¡Usuario agregado exitosamente! " +
                                    "contrasena igual a usuario", 
                        "Bien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txtNuevoUsuario.Clear();
                    actualizarControles();
                }
                else
                    MessageBox.Show("Favor digite un usuario", 
                        "alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("no se encuentra disponible.", 
                    ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar " + cmbUsuario.Text + "?", 
                "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UsuarioD.eliminar(cmbUsuario.Text);
                
                MessageBox.Show("Usuario eliminado ", 
                    ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                actualizarControles();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarControles();
        }

        private void btnAgregarNegocio_Click(object sender, EventArgs e)
        {
            Negocio u = new Negocio();
            u.name = txtNegocio.Text;
            u.description = rtbDescripcion.Text;
            
            try
            {
                NegocioD.nuevoNegocio(u);
                
                MessageBox.Show("Negocio agregado ", ":)",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                actualizarControles();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarNegocio_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿eliminar el negocio " + cmbNegocioEliminar.Text + "?", 
                "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NegocioD.eliminarNegocio(cmbNegocioEliminar.Text);
                
                MessageBox.Show("se elimino exitosamente", 
                    ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                actualizarControles();
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto u = new Producto();
            u.name = txtProducto.Text;
            
            try
            {
                ProductoD.nuevoProducto(u);
                
                MessageBox.Show("Producto agregado", ":)",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                actualizarControles();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿eliminar el producto " + cmbProductoEliminar.Text + "?", 
                "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProductoD.eliminarProducto(cmbProductoEliminar.Text);
                
                MessageBox.Show("se elimino", 
                    ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                actualizarControles();
            }
            
        }

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {
            Direcciones u = new Direcciones();
            u.address = txtDireccion.Text;
            
            try
            {
                DireccionesD.nuevoDireccion(u);
                
                MessageBox.Show("agregada exitosamente", ":)",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                actualizarControles();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminarDireccion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿eliminar la direcion " + cmbDireccion.Text + "?", 
                "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DireccionesD.eliminarDireccion(cmbDireccion.Text);
                
                MessageBox.Show(" se elimino", 
                    ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                actualizarControles();
            }
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            try
            {
                 Producto i = (Producto) cmbProducto1.SelectedItem;
                Direcciones u = (Direcciones) cmbDireccion1.SelectedItem;
                
                OrdenD.realizarOrden(u, i, dtpfecha.Value);
                
                MessageBox.Show("Orden agregada", ":)",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message, ":(",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        
    }
}