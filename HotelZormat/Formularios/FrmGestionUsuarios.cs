// Cedula: 402-1035106-6
using HotelZormat.UI.Formularios;
using HotelZormat.Modelo;
using HotelZormat.Negocio.Servicios;
using HotelZormat.Negocio.Sesion;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmGestionUsuarios : Form
    {
        private UsuarioService usuarioService = new UsuarioService();
        

        public FrmGestionUsuarios()
        {
            InitializeComponent();
        }

        private void FrmGestionUsuarios_Load(object sender, EventArgs e)
        {
            // Solo Administrador puede gestionar usuarios
            if (SesionActual.UsuarioActivo.Rol != "Administrador")
            {
                MessageBox.Show("No tiene permisos para acceder a esta pantalla.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            // Solo usuarios activos (los inactivos no aparecen en la lista)
            var usuariosActivos = usuarioService.ObtenerTodosUsuarios()
                .Where(u => u.Activo)
                .ToList();

            dgvUsuarios.DataSource = usuariosActivos;

            // Oculta la columna Activo, ya que aqui solo se muestran los activos
            if (dgvUsuarios.Columns["Activo"] != null)
                dgvUsuarios.Columns["Activo"].Visible = false;
        }

        private Usuario ObtenerUsuarioSeleccionado()
        {
            if (dgvUsuarios.CurrentRow == null)
                return null;

            return dgvUsuarios.CurrentRow.DataBoundItem as Usuario;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FrmCrearUsuario frm = new FrmCrearUsuario(); // modo crear (sin usuario)
            frm.ShowDialog();
            CargarUsuarios(); // refresca la lista al volver, por si se creo alguien
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Usuario seleccionado = ObtenerUsuarioSeleccionado();

            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un usuario de la lista para modificar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FrmCrearUsuario frm = new FrmCrearUsuario(seleccionado.IdUsuario); // modo editar
            frm.ShowDialog();
            CargarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario seleccionado = ObtenerUsuarioSeleccionado();

            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un usuario de la lista para eliminar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (seleccionado.IdUsuario == SesionActual.UsuarioActivo.IdUsuario)
            {
                MessageBox.Show("No puede eliminar su propio usuario mientras esta logueado.",
                    "Accion no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Seguro que desea eliminar al usuario '{seleccionado.Nombre}'?",
                "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            // "Eliminar" = desactivar (soft delete), nunca se borra el registro real
            usuarioService.CambiarEstadoUsuario(seleccionado.IdUsuario, false);
           

            MessageBox.Show("Usuario eliminado correctamente.", "Exito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarUsuarios();
        }
    }
}
