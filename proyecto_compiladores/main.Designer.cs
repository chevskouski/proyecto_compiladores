namespace proyecto_compiladores
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.layout_panel_general = new System.Windows.Forms.TableLayoutPanel();
            this.panel_output = new System.Windows.Forms.Panel();
            this.lbl_output = new System.Windows.Forms.Label();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.btn_limpiar_output = new System.Windows.Forms.Button();
            this.panel_input = new System.Windows.Forms.Panel();
            this.lbl_input = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_limpiar_input = new System.Windows.Forms.Button();
            this.panel_control = new System.Windows.Forms.Panel();
            this.btn_validar_rp1 = new System.Windows.Forms.Button();
            this.btn_simbolos = new System.Windows.Forms.Button();
            this.btn_tokens = new System.Windows.Forms.Button();
            this.btn_mantenimiento = new System.Windows.Forms.Button();
            this.btn_lineas_columnas = new System.Windows.Forms.Button();
            this.btn_mostrar_caracteres = new System.Windows.Forms.Button();
            this.btn_flujo_caracteres = new System.Windows.Forms.Button();
            this.btn_seleccionar_archivo = new System.Windows.Forms.Button();
            this.layout_panel_general.SuspendLayout();
            this.panel_output.SuspendLayout();
            this.panel_input.SuspendLayout();
            this.panel_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout_panel_general
            // 
            this.layout_panel_general.ColumnCount = 3;
            this.layout_panel_general.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.layout_panel_general.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.layout_panel_general.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.layout_panel_general.Controls.Add(this.panel_output, 2, 0);
            this.layout_panel_general.Controls.Add(this.panel_input, 1, 0);
            this.layout_panel_general.Controls.Add(this.panel_control, 0, 0);
            this.layout_panel_general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_panel_general.Location = new System.Drawing.Point(0, 0);
            this.layout_panel_general.Name = "layout_panel_general";
            this.layout_panel_general.RowCount = 1;
            this.layout_panel_general.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_panel_general.Size = new System.Drawing.Size(831, 525);
            this.layout_panel_general.TabIndex = 0;
            // 
            // panel_output
            // 
            this.panel_output.Controls.Add(this.lbl_output);
            this.panel_output.Controls.Add(this.txt_output);
            this.panel_output.Controls.Add(this.btn_limpiar_output);
            this.panel_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_output.Location = new System.Drawing.Point(476, 3);
            this.panel_output.Name = "panel_output";
            this.panel_output.Size = new System.Drawing.Size(352, 519);
            this.panel_output.TabIndex = 0;
            // 
            // lbl_output
            // 
            this.lbl_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_output.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_output.Location = new System.Drawing.Point(43, 15);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(265, 26);
            this.lbl_output.TabIndex = 3;
            this.lbl_output.Text = "RESULTADO DEL ANÁLISIS";
            this.lbl_output.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_output
            // 
            this.txt_output.AcceptsTab = true;
            this.txt_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_output.BackColor = System.Drawing.Color.White;
            this.txt_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_output.Location = new System.Drawing.Point(0, 56);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_output.Size = new System.Drawing.Size(351, 404);
            this.txt_output.TabIndex = 2;
            // 
            // btn_limpiar_output
            // 
            this.btn_limpiar_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_limpiar_output.Location = new System.Drawing.Point(0, 466);
            this.btn_limpiar_output.Name = "btn_limpiar_output";
            this.btn_limpiar_output.Size = new System.Drawing.Size(351, 50);
            this.btn_limpiar_output.TabIndex = 1;
            this.btn_limpiar_output.Text = "Limpiar";
            this.btn_limpiar_output.UseVisualStyleBackColor = true;
            this.btn_limpiar_output.Click += new System.EventHandler(this.btn_limpiar_output_Click);
            // 
            // panel_input
            // 
            this.panel_input.Controls.Add(this.lbl_input);
            this.panel_input.Controls.Add(this.txt_input);
            this.panel_input.Controls.Add(this.btn_limpiar_input);
            this.panel_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_input.Location = new System.Drawing.Point(119, 3);
            this.panel_input.Name = "panel_input";
            this.panel_input.Size = new System.Drawing.Size(351, 519);
            this.panel_input.TabIndex = 1;
            // 
            // lbl_input
            // 
            this.lbl_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_input.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_input.Location = new System.Drawing.Point(73, 15);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(206, 26);
            this.lbl_input.TabIndex = 2;
            this.lbl_input.Text = "INGRESO DE DATOS";
            this.lbl_input.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_input
            // 
            this.txt_input.AcceptsTab = true;
            this.txt_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(0, 56);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_input.Size = new System.Drawing.Size(351, 404);
            this.txt_input.TabIndex = 1;
            // 
            // btn_limpiar_input
            // 
            this.btn_limpiar_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_limpiar_input.Location = new System.Drawing.Point(0, 466);
            this.btn_limpiar_input.Name = "btn_limpiar_input";
            this.btn_limpiar_input.Size = new System.Drawing.Size(351, 50);
            this.btn_limpiar_input.TabIndex = 0;
            this.btn_limpiar_input.Text = "Limpiar";
            this.btn_limpiar_input.UseVisualStyleBackColor = true;
            this.btn_limpiar_input.Click += new System.EventHandler(this.limpiar_input_Click);
            // 
            // panel_control
            // 
            this.panel_control.Controls.Add(this.btn_validar_rp1);
            this.panel_control.Controls.Add(this.btn_simbolos);
            this.panel_control.Controls.Add(this.btn_tokens);
            this.panel_control.Controls.Add(this.btn_mantenimiento);
            this.panel_control.Controls.Add(this.btn_lineas_columnas);
            this.panel_control.Controls.Add(this.btn_mostrar_caracteres);
            this.panel_control.Controls.Add(this.btn_flujo_caracteres);
            this.panel_control.Controls.Add(this.btn_seleccionar_archivo);
            this.panel_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_control.Location = new System.Drawing.Point(3, 3);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(110, 519);
            this.panel_control.TabIndex = 2;
            // 
            // btn_validar_rp1
            // 
            this.btn_validar_rp1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_validar_rp1.Location = new System.Drawing.Point(3, 392);
            this.btn_validar_rp1.Name = "btn_validar_rp1";
            this.btn_validar_rp1.Size = new System.Drawing.Size(107, 50);
            this.btn_validar_rp1.TabIndex = 7;
            this.btn_validar_rp1.Text = "Parser";
            this.btn_validar_rp1.UseVisualStyleBackColor = true;
            this.btn_validar_rp1.Click += new System.EventHandler(this.btn_validar_rp1_Click);
            // 
            // btn_simbolos
            // 
            this.btn_simbolos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_simbolos.Location = new System.Drawing.Point(3, 336);
            this.btn_simbolos.Name = "btn_simbolos";
            this.btn_simbolos.Size = new System.Drawing.Size(107, 50);
            this.btn_simbolos.TabIndex = 6;
            this.btn_simbolos.Text = "Tabla de Simbolos";
            this.btn_simbolos.UseVisualStyleBackColor = true;
            this.btn_simbolos.Click += new System.EventHandler(this.btn_simbolos_Click);
            // 
            // btn_tokens
            // 
            this.btn_tokens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tokens.Location = new System.Drawing.Point(3, 280);
            this.btn_tokens.Name = "btn_tokens";
            this.btn_tokens.Size = new System.Drawing.Size(107, 50);
            this.btn_tokens.TabIndex = 5;
            this.btn_tokens.Text = "Tokens";
            this.btn_tokens.UseVisualStyleBackColor = true;
            this.btn_tokens.Click += new System.EventHandler(this.btn_tokens_Click);
            // 
            // btn_mantenimiento
            // 
            this.btn_mantenimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mantenimiento.Location = new System.Drawing.Point(3, 224);
            this.btn_mantenimiento.Name = "btn_mantenimiento";
            this.btn_mantenimiento.Size = new System.Drawing.Size(107, 50);
            this.btn_mantenimiento.TabIndex = 4;
            this.btn_mantenimiento.Text = "Mantenimiento";
            this.btn_mantenimiento.UseVisualStyleBackColor = true;
            this.btn_mantenimiento.Click += new System.EventHandler(this.btn_mantenimiento_Click);
            // 
            // btn_lineas_columnas
            // 
            this.btn_lineas_columnas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_lineas_columnas.Location = new System.Drawing.Point(3, 168);
            this.btn_lineas_columnas.Name = "btn_lineas_columnas";
            this.btn_lineas_columnas.Size = new System.Drawing.Size(107, 50);
            this.btn_lineas_columnas.TabIndex = 3;
            this.btn_lineas_columnas.Text = "Lineas y Columnas";
            this.btn_lineas_columnas.UseVisualStyleBackColor = true;
            this.btn_lineas_columnas.Click += new System.EventHandler(this.btn_lineas_columnas_Click);
            // 
            // btn_mostrar_caracteres
            // 
            this.btn_mostrar_caracteres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mostrar_caracteres.Location = new System.Drawing.Point(3, 56);
            this.btn_mostrar_caracteres.Name = "btn_mostrar_caracteres";
            this.btn_mostrar_caracteres.Size = new System.Drawing.Size(107, 50);
            this.btn_mostrar_caracteres.TabIndex = 2;
            this.btn_mostrar_caracteres.Text = "Mostrar Caracteres";
            this.btn_mostrar_caracteres.UseVisualStyleBackColor = true;
            this.btn_mostrar_caracteres.Click += new System.EventHandler(this.btn_mostrar_caracteres_Click);
            // 
            // btn_flujo_caracteres
            // 
            this.btn_flujo_caracteres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_flujo_caracteres.Location = new System.Drawing.Point(3, 112);
            this.btn_flujo_caracteres.Name = "btn_flujo_caracteres";
            this.btn_flujo_caracteres.Size = new System.Drawing.Size(107, 50);
            this.btn_flujo_caracteres.TabIndex = 1;
            this.btn_flujo_caracteres.Text = "Flujo de Caracteres";
            this.btn_flujo_caracteres.UseVisualStyleBackColor = true;
            this.btn_flujo_caracteres.Click += new System.EventHandler(this.btn_flujo_caracteres_Click);
            // 
            // btn_seleccionar_archivo
            // 
            this.btn_seleccionar_archivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_seleccionar_archivo.Location = new System.Drawing.Point(3, 466);
            this.btn_seleccionar_archivo.Name = "btn_seleccionar_archivo";
            this.btn_seleccionar_archivo.Size = new System.Drawing.Size(107, 50);
            this.btn_seleccionar_archivo.TabIndex = 0;
            this.btn_seleccionar_archivo.Text = "Seleccionar Archivo";
            this.btn_seleccionar_archivo.UseVisualStyleBackColor = true;
            this.btn_seleccionar_archivo.Click += new System.EventHandler(this.btn_seleccionar_archivo_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(831, 525);
            this.Controls.Add(this.layout_panel_general);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Proyecto Compiladores";
            this.layout_panel_general.ResumeLayout(false);
            this.panel_output.ResumeLayout(false);
            this.panel_output.PerformLayout();
            this.panel_input.ResumeLayout(false);
            this.panel_input.PerformLayout();
            this.panel_control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout_panel_general;
        private System.Windows.Forms.Panel panel_output;
        private System.Windows.Forms.Panel panel_input;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Button btn_limpiar_output;
        private System.Windows.Forms.Button btn_limpiar_input;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Button btn_seleccionar_archivo;
        private System.Windows.Forms.Button btn_lineas_columnas;
        private System.Windows.Forms.Button btn_mostrar_caracteres;
        private System.Windows.Forms.Button btn_flujo_caracteres;
        private System.Windows.Forms.Button btn_mantenimiento;
        private System.Windows.Forms.Button btn_tokens;
        private System.Windows.Forms.Button btn_simbolos;
        private System.Windows.Forms.Button btn_validar_rp1;
    }
}

