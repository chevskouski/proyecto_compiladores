namespace proyecto_compiladores
{
    partial class frm_tokens
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView_tokens = new System.Windows.Forms.DataGridView();
            this.dataGridView_tokens_error = new System.Windows.Forms.DataGridView();
            this.dataGridView_tokens_validado = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_input = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_Simbolo = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_simbolo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idTokenDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lexemaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoLexemaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idSimboloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoSimboloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simboloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTokenErrorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lexemaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTokenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokenerrorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTokenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lexemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoLexemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tokens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tokens_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tokens_validado)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Simbolo)).BeginInit();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tokenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simboloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenerrorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_tokens
            // 
            this.dataGridView_tokens.AllowUserToAddRows = false;
            this.dataGridView_tokens.AllowUserToDeleteRows = false;
            this.dataGridView_tokens.AutoGenerateColumns = false;
            this.dataGridView_tokens.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_tokens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_tokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tokens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTokenDataGridViewTextBoxColumn,
            this.lexemaDataGridViewTextBoxColumn,
            this.tipoLexemaDataGridViewTextBoxColumn});
            this.dataGridView_tokens.DataSource = this.tokenBindingSource;
            this.dataGridView_tokens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_tokens.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_tokens.Name = "dataGridView_tokens";
            this.dataGridView_tokens.ReadOnly = true;
            this.dataGridView_tokens.Size = new System.Drawing.Size(548, 369);
            this.dataGridView_tokens.TabIndex = 0;
            // 
            // dataGridView_tokens_error
            // 
            this.dataGridView_tokens_error.AllowUserToAddRows = false;
            this.dataGridView_tokens_error.AllowUserToDeleteRows = false;
            this.dataGridView_tokens_error.AutoGenerateColumns = false;
            this.dataGridView_tokens_error.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_tokens_error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_tokens_error.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tokens_error.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTokenErrorDataGridViewTextBoxColumn,
            this.lexemaDataGridViewTextBoxColumn1,
            this.errorDataGridViewTextBoxColumn,
            this.idTokenDataGridViewTextBoxColumn1});
            this.dataGridView_tokens_error.DataSource = this.tokenerrorBindingSource;
            this.dataGridView_tokens_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_tokens_error.Location = new System.Drawing.Point(3, 398);
            this.dataGridView_tokens_error.Name = "dataGridView_tokens_error";
            this.dataGridView_tokens_error.ReadOnly = true;
            this.dataGridView_tokens_error.Size = new System.Drawing.Size(548, 154);
            this.dataGridView_tokens_error.TabIndex = 1;
            // 
            // dataGridView_tokens_validado
            // 
            this.dataGridView_tokens_validado.AllowUserToAddRows = false;
            this.dataGridView_tokens_validado.AllowUserToDeleteRows = false;
            this.dataGridView_tokens_validado.AutoGenerateColumns = false;
            this.dataGridView_tokens_validado.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_tokens_validado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_tokens_validado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tokens_validado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTokenDataGridViewTextBoxColumn2,
            this.lexemaDataGridViewTextBoxColumn2,
            this.tipoLexemaDataGridViewTextBoxColumn1});
            this.dataGridView_tokens_validado.DataSource = this.tokenBindingSource1;
            this.dataGridView_tokens_validado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_tokens_validado.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_tokens_validado.Name = "dataGridView_tokens_validado";
            this.dataGridView_tokens_validado.ReadOnly = true;
            this.dataGridView_tokens_validado.Size = new System.Drawing.Size(548, 284);
            this.dataGridView_tokens_validado.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.lbl_input, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1120, 632);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // lbl_input
            // 
            this.lbl_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_input.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_input.Location = new System.Drawing.Point(3, 0);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(554, 25);
            this.lbl_input.TabIndex = 6;
            this.lbl_input.Text = "RESULTADO DEL ANÁLISIS";
            this.lbl_input.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.dataGridView_tokens_validado, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.dataGridView_Simbolo, 0, 2);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(563, 28);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(554, 601);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(548, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "TABLA DE SIMBOLOS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_Simbolo
            // 
            this.dataGridView_Simbolo.AllowUserToAddRows = false;
            this.dataGridView_Simbolo.AllowUserToDeleteRows = false;
            this.dataGridView_Simbolo.AutoGenerateColumns = false;
            this.dataGridView_Simbolo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_Simbolo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Simbolo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Simbolo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSimboloDataGridViewTextBoxColumn,
            this.tipoSimboloDataGridViewTextBoxColumn});
            this.dataGridView_Simbolo.DataSource = this.simboloBindingSource;
            this.dataGridView_Simbolo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Simbolo.Location = new System.Drawing.Point(3, 313);
            this.dataGridView_Simbolo.Name = "dataGridView_Simbolo";
            this.dataGridView_Simbolo.ReadOnly = true;
            this.dataGridView_Simbolo.Size = new System.Drawing.Size(548, 285);
            this.dataGridView_Simbolo.TabIndex = 8;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.dataGridView_tokens_error, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.dataGridView_tokens, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.btn_simbolo, 0, 3);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 4;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(554, 601);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(548, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "ERRORES ENCONTRADOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_simbolo
            // 
            this.btn_simbolo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_simbolo.Location = new System.Drawing.Point(3, 558);
            this.btn_simbolo.Name = "btn_simbolo";
            this.btn_simbolo.Size = new System.Drawing.Size(548, 40);
            this.btn_simbolo.TabIndex = 7;
            this.btn_simbolo.Text = "Actualizar | Generar Simbolos";
            this.btn_simbolo.UseVisualStyleBackColor = true;
            this.btn_simbolo.Click += new System.EventHandler(this.btn_simbolo_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(563, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "TOKENS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idTokenDataGridViewTextBoxColumn2
            // 
            this.idTokenDataGridViewTextBoxColumn2.DataPropertyName = "Id_Token";
            this.idTokenDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.idTokenDataGridViewTextBoxColumn2.Name = "idTokenDataGridViewTextBoxColumn2";
            this.idTokenDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // lexemaDataGridViewTextBoxColumn2
            // 
            this.lexemaDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lexemaDataGridViewTextBoxColumn2.DataPropertyName = "Lexema";
            this.lexemaDataGridViewTextBoxColumn2.HeaderText = "Lexema";
            this.lexemaDataGridViewTextBoxColumn2.Name = "lexemaDataGridViewTextBoxColumn2";
            this.lexemaDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tipoLexemaDataGridViewTextBoxColumn1
            // 
            this.tipoLexemaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoLexemaDataGridViewTextBoxColumn1.DataPropertyName = "Tipo_Lexema";
            this.tipoLexemaDataGridViewTextBoxColumn1.HeaderText = "Tipo Lexema";
            this.tipoLexemaDataGridViewTextBoxColumn1.Name = "tipoLexemaDataGridViewTextBoxColumn1";
            this.tipoLexemaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tokenBindingSource1
            // 
            this.tokenBindingSource1.DataSource = typeof(proyecto_compiladores.token);
            // 
            // idSimboloDataGridViewTextBoxColumn
            // 
            this.idSimboloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idSimboloDataGridViewTextBoxColumn.DataPropertyName = "Id_Simbolo";
            this.idSimboloDataGridViewTextBoxColumn.HeaderText = "ID Simbolo";
            this.idSimboloDataGridViewTextBoxColumn.Name = "idSimboloDataGridViewTextBoxColumn";
            this.idSimboloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoSimboloDataGridViewTextBoxColumn
            // 
            this.tipoSimboloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoSimboloDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Simbolo";
            this.tipoSimboloDataGridViewTextBoxColumn.HeaderText = "Tipo Simbolo";
            this.tipoSimboloDataGridViewTextBoxColumn.Name = "tipoSimboloDataGridViewTextBoxColumn";
            this.tipoSimboloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // simboloBindingSource
            // 
            this.simboloBindingSource.DataSource = typeof(proyecto_compiladores.simbolo);
            // 
            // idTokenErrorDataGridViewTextBoxColumn
            // 
            this.idTokenErrorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idTokenErrorDataGridViewTextBoxColumn.DataPropertyName = "Id_Token_Error";
            this.idTokenErrorDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idTokenErrorDataGridViewTextBoxColumn.Name = "idTokenErrorDataGridViewTextBoxColumn";
            this.idTokenErrorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTokenErrorDataGridViewTextBoxColumn.Width = 43;
            // 
            // lexemaDataGridViewTextBoxColumn1
            // 
            this.lexemaDataGridViewTextBoxColumn1.DataPropertyName = "Lexema";
            this.lexemaDataGridViewTextBoxColumn1.HeaderText = "Lexema";
            this.lexemaDataGridViewTextBoxColumn1.Name = "lexemaDataGridViewTextBoxColumn1";
            this.lexemaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lexemaDataGridViewTextBoxColumn1.Width = 105;
            // 
            // errorDataGridViewTextBoxColumn
            // 
            this.errorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.errorDataGridViewTextBoxColumn.DataPropertyName = "Error";
            this.errorDataGridViewTextBoxColumn.HeaderText = "Error";
            this.errorDataGridViewTextBoxColumn.Name = "errorDataGridViewTextBoxColumn";
            this.errorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idTokenDataGridViewTextBoxColumn1
            // 
            this.idTokenDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idTokenDataGridViewTextBoxColumn1.DataPropertyName = "Id_Token";
            this.idTokenDataGridViewTextBoxColumn1.HeaderText = "ID Token";
            this.idTokenDataGridViewTextBoxColumn1.Name = "idTokenDataGridViewTextBoxColumn1";
            this.idTokenDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idTokenDataGridViewTextBoxColumn1.Width = 77;
            // 
            // tokenerrorBindingSource
            // 
            this.tokenerrorBindingSource.DataSource = typeof(proyecto_compiladores.token_error);
            // 
            // idTokenDataGridViewTextBoxColumn
            // 
            this.idTokenDataGridViewTextBoxColumn.DataPropertyName = "Id_Token";
            this.idTokenDataGridViewTextBoxColumn.HeaderText = "Id_Token";
            this.idTokenDataGridViewTextBoxColumn.Name = "idTokenDataGridViewTextBoxColumn";
            this.idTokenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lexemaDataGridViewTextBoxColumn
            // 
            this.lexemaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lexemaDataGridViewTextBoxColumn.DataPropertyName = "Lexema";
            this.lexemaDataGridViewTextBoxColumn.HeaderText = "Lexema";
            this.lexemaDataGridViewTextBoxColumn.Name = "lexemaDataGridViewTextBoxColumn";
            this.lexemaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoLexemaDataGridViewTextBoxColumn
            // 
            this.tipoLexemaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoLexemaDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Lexema";
            this.tipoLexemaDataGridViewTextBoxColumn.HeaderText = "Tipo_Lexema";
            this.tipoLexemaDataGridViewTextBoxColumn.Name = "tipoLexemaDataGridViewTextBoxColumn";
            this.tipoLexemaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tokenBindingSource
            // 
            this.tokenBindingSource.DataSource = typeof(proyecto_compiladores.token);
            // 
            // frm_tokens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1120, 632);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Name = "frm_tokens";
            this.Text = "[TOKENS] - Análisis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tokens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tokens_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tokens_validado)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Simbolo)).EndInit();
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tokenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simboloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenerrorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_tokens;
        private System.Windows.Forms.BindingSource tokenBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTokenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lexemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoLexemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_tokens_error;
        private System.Windows.Forms.BindingSource tokenerrorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaErrorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaErrorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tokenBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTokenErrorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lexemaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTokenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView_tokens_validado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTokenDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lexemaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoLexemaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_Simbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSimboloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoSimboloDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource simboloBindingSource;
        private System.Windows.Forms.Button btn_simbolo;
    }
}