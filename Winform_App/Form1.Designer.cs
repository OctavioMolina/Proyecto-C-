namespace Winform_App
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvpokemons = new System.Windows.Forms.DataGridView();
            this.Pbxpokemon = new System.Windows.Forms.PictureBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.btnEliminarLogico = new System.Windows.Forms.Button();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.cbocriterio = new System.Windows.Forms.ComboBox();
            this.cbocampo = new System.Windows.Forms.ComboBox();
            this.txtfiltroavanzado = new System.Windows.Forms.TextBox();
            this.lblcampo = new System.Windows.Forms.Label();
            this.lblcriterio = new System.Windows.Forms.Label();
            this.lblFiltroavanzado = new System.Windows.Forms.Label();
            this.btnfiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbxpokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvpokemons
            // 
            this.dgvpokemons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvpokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpokemons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvpokemons.Location = new System.Drawing.Point(12, 42);
            this.dgvpokemons.MultiSelect = false;
            this.dgvpokemons.Name = "dgvpokemons";
            this.dgvpokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpokemons.Size = new System.Drawing.Size(503, 277);
            this.dgvpokemons.TabIndex = 13;
            this.dgvpokemons.SelectionChanged += new System.EventHandler(this.dgvpokemons_SelectionChanged_1);
            // 
            // Pbxpokemon
            // 
            this.Pbxpokemon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pbxpokemon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pbxpokemon.Location = new System.Drawing.Point(543, 42);
            this.Pbxpokemon.Name = "Pbxpokemon";
            this.Pbxpokemon.Size = new System.Drawing.Size(282, 277);
            this.Pbxpokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbxpokemon.TabIndex = 1;
            this.Pbxpokemon.TabStop = false;
            // 
            // btnagregar
            // 
            this.btnagregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnagregar.Location = new System.Drawing.Point(18, 419);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 5;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnmodificar.Location = new System.Drawing.Point(119, 419);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 6;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminarFisico.Location = new System.Drawing.Point(230, 419);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(148, 23);
            this.btnEliminarFisico.TabIndex = 7;
            this.btnEliminarFisico.Text = "Eliminar Fisico";
            this.btnEliminarFisico.UseVisualStyleBackColor = true;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // btnEliminarLogico
            // 
            this.btnEliminarLogico.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminarLogico.Location = new System.Drawing.Point(404, 419);
            this.btnEliminarLogico.Name = "btnEliminarLogico";
            this.btnEliminarLogico.Size = new System.Drawing.Size(148, 23);
            this.btnEliminarLogico.TabIndex = 8;
            this.btnEliminarLogico.Text = "Eliminar Logico";
            this.btnEliminarLogico.UseVisualStyleBackColor = true;
            this.btnEliminarLogico.Click += new System.EventHandler(this.btnEliminarLogico_Click);
            // 
            // lblfiltro
            // 
            this.lblfiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.Location = new System.Drawing.Point(28, 16);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(32, 13);
            this.lblfiltro.TabIndex = 6;
            this.lblfiltro.Text = "Filtro:";
            // 
            // txtfiltro
            // 
            this.txtfiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfiltro.Location = new System.Drawing.Point(66, 13);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(174, 20);
            this.txtfiltro.TabIndex = 0;
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            // 
            // cbocriterio
            // 
            this.cbocriterio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbocriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocriterio.FormattingEnabled = true;
            this.cbocriterio.Location = new System.Drawing.Point(319, 352);
            this.cbocriterio.Name = "cbocriterio";
            this.cbocriterio.Size = new System.Drawing.Size(121, 21);
            this.cbocriterio.TabIndex = 2;
            // 
            // cbocampo
            // 
            this.cbocampo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbocampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocampo.FormattingEnabled = true;
            this.cbocampo.Location = new System.Drawing.Point(102, 349);
            this.cbocampo.Name = "cbocampo";
            this.cbocampo.Size = new System.Drawing.Size(121, 21);
            this.cbocampo.TabIndex = 1;
            this.cbocampo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtfiltroavanzado
            // 
            this.txtfiltroavanzado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtfiltroavanzado.Location = new System.Drawing.Point(518, 353);
            this.txtfiltroavanzado.Name = "txtfiltroavanzado";
            this.txtfiltroavanzado.Size = new System.Drawing.Size(166, 20);
            this.txtfiltroavanzado.TabIndex = 3;
            // 
            // lblcampo
            // 
            this.lblcampo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblcampo.AutoSize = true;
            this.lblcampo.Location = new System.Drawing.Point(46, 355);
            this.lblcampo.Name = "lblcampo";
            this.lblcampo.Size = new System.Drawing.Size(40, 13);
            this.lblcampo.TabIndex = 11;
            this.lblcampo.Text = "Campo";
            // 
            // lblcriterio
            // 
            this.lblcriterio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblcriterio.AutoSize = true;
            this.lblcriterio.Location = new System.Drawing.Point(264, 355);
            this.lblcriterio.Name = "lblcriterio";
            this.lblcriterio.Size = new System.Drawing.Size(39, 13);
            this.lblcriterio.TabIndex = 12;
            this.lblcriterio.Text = "Criterio";
            // 
            // lblFiltroavanzado
            // 
            this.lblFiltroavanzado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFiltroavanzado.AutoSize = true;
            this.lblFiltroavanzado.Location = new System.Drawing.Point(468, 355);
            this.lblFiltroavanzado.Name = "lblFiltroavanzado";
            this.lblFiltroavanzado.Size = new System.Drawing.Size(32, 13);
            this.lblFiltroavanzado.TabIndex = 13;
            this.lblFiltroavanzado.Text = "Filtro:";
            // 
            // btnfiltro
            // 
            this.btnfiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnfiltro.Location = new System.Drawing.Point(711, 350);
            this.btnfiltro.Name = "btnfiltro";
            this.btnfiltro.Size = new System.Drawing.Size(75, 23);
            this.btnfiltro.TabIndex = 4;
            this.btnfiltro.Text = "Buscar";
            this.btnfiltro.UseVisualStyleBackColor = true;
            this.btnfiltro.Click += new System.EventHandler(this.btnfiltro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 463);
            this.Controls.Add(this.btnfiltro);
            this.Controls.Add(this.lblFiltroavanzado);
            this.Controls.Add(this.lblcriterio);
            this.Controls.Add(this.lblcampo);
            this.Controls.Add(this.txtfiltroavanzado);
            this.Controls.Add(this.cbocampo);
            this.Controls.Add(this.cbocriterio);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.lblfiltro);
            this.Controls.Add(this.btnEliminarLogico);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.Pbxpokemon);
            this.Controls.Add(this.dgvpokemons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbxpokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpokemons;
        private System.Windows.Forms.PictureBox Pbxpokemon;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Button btnEliminarLogico;
        private System.Windows.Forms.Label lblfiltro;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.ComboBox cbocriterio;
        private System.Windows.Forms.ComboBox cbocampo;
        private System.Windows.Forms.TextBox txtfiltroavanzado;
        private System.Windows.Forms.Label lblcampo;
        private System.Windows.Forms.Label lblcriterio;
        private System.Windows.Forms.Label lblFiltroavanzado;
        private System.Windows.Forms.Button btnfiltro;
    }
}

