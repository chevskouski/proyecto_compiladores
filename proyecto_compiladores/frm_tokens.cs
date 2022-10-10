using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_compiladores
{
    public partial class frm_tokens : Form
    {
        private main mainForm = null;
        public frm_tokens(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm as main;
            cargar_datos();
        }

        public void cargar_datos()
        {
            mantenimiento _mantenimiento = new mantenimiento();
            dataGridView_tokens.DataSource = _mantenimiento.consultar_tokens();
            dataGridView_tokens_error.DataSource = _mantenimiento.consultar_tokens_error();
            dataGridView_tokens_validado.DataSource = _mantenimiento.consultar_tokens_validos();
        }

        public void cargar_simbolos()
        {
            mantenimiento _mantenimiento = new mantenimiento();
            _mantenimiento.generar_simbolos();
            dataGridView_Simbolo.DataSource = _mantenimiento.consultar_simbolos();
        }

        private void btn_simbolo_Click(object sender, EventArgs e)
        {
            mantenimiento _mantenimiento = new mantenimiento();
            funciones _funciones = new funciones();
            _mantenimiento.vaciar_tokens();
            string x = this.mainForm._txt_cadena;
            _funciones.generar_token_depurado(x);
            cargar_datos();
            cargar_simbolos();
        }
    }
}
