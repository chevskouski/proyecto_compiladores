using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto_compiladores
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        funciones funciones = new funciones();
        db_conexion cn = new db_conexion();

        private void limpiar_input_Click(object sender, EventArgs e)
        {
            txt_input.Clear();
        }

        private void btn_limpiar_output_Click(object sender, EventArgs e)
        {
            txt_output.Clear();
        }

        private void btn_seleccionar_archivo_Click(object sender, EventArgs e)
        {
            txt_input.Text += funciones.carga_lectura_archivo();
        }

        private void btn_flujo_caracteres_Click(object sender, EventArgs e)
        {
            txt_output.Text += funciones.crear_cadena_por_operacion(txt_input.Text, "flujo_caracteres");
        }

        private void btn_mostrar_caracteres_Click(object sender, EventArgs e)
        {
            funciones.crear_cadena_por_operacion(txt_input.Text, "mostrar_caracteres");
        }

        private void btn_lineas_columnas_Click(object sender, EventArgs e)
        {
            txt_output.Text += funciones.crear_cadena_por_operacion(txt_input.Text, "lineas_columnas");
        }

        private void btn_mantenimiento_Click(object sender, EventArgs e)
        {
            frm_mantenimiento mantenimiento = new frm_mantenimiento();
            mantenimiento.Show();
        }

        public string _txt_cadena
        {
            get { return txt_input.Text; }
            set { txt_input.Text = value; }
        }

        private void btn_tokens_Click(object sender, EventArgs e)
        {
            mantenimiento _mantenimiento = new mantenimiento();
            _mantenimiento.vaciar_tokens();
            funciones.generar_token_depurado(txt_input.Text);
            frm_tokens tokens = new frm_tokens(this);
            tokens.Show();
        }

        private void btn_simbolos_Click(object sender, EventArgs e)
        {
            mantenimiento _mantenimiento = new mantenimiento();
            _mantenimiento.vaciar_tokens();
            funciones.generar_token_depurado(txt_input.Text);
            frm_tokens tokens = new frm_tokens(this);
            tokens.Show();
            tokens.cargar_simbolos();
        }

        private void btn_validar_rp1_Click(object sender, EventArgs e)
        {
            if (txt_input.Text != "")
            {
                txt_output.Text = funciones.regla_produccion_1_S();
            }
        }
    }
}
