using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class FormularioOficina : Form
    {
        Oficina o;
        Departamentos dptos;

        public FormularioOficina()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load principal form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormularioOficina_Load(object sender, EventArgs e)
        {
            //Cargo los combos
            cmbDepartamentoOficina.DataSource = Enum.GetValues(typeof(Departamentos));
            cmbDepartamento.DataSource = Enum.GetValues(typeof(Departamentos));
        }

        /// <summary>
        /// Crea una oficina con su jefe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearOficina_Click(object sender, EventArgs e)
        {
            
            Enum.TryParse<Departamentos>(cmbDepartamentoOficina.SelectedValue.ToString(), out dptos);

            Jefe j = new Jefe(txtNombreOficina.Text, txtApellidoOficina.Text, txtDNIOficina.Text, dateTimeIngresoJefe.Value);

            o = new Oficina(short.Parse(numericUpDown1.Text), dptos, j);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            rtbBox.AppendText((string)o);
        }

        /// <summary>
        /// Agrega un nuevo empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Departamentos dptos2;
            Enum.TryParse<Departamentos>(cmbDepartamento.SelectedValue.ToString(), out dptos2);
            Empleado empleado = new Empleado(txtNombreEmpleado.Text, txtApellidoEmpleado.Text, txtLegajo.Text, short.Parse(numericUpDown2.Text), dptos2);

        }
    }
}
