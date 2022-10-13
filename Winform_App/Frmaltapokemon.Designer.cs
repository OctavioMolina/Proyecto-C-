namespace Winform_App
{
    partial class Frmaltapokemon
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
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lbldebilidad = new System.Windows.Forms.Label();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.cbodebilidad = new System.Windows.Forms.ComboBox();
            this.lblUrlimagen = new System.Windows.Forms.Label();
            this.txtUrlimagen = new System.Windows.Forms.TextBox();
            this.Pbxpokemon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pbxpokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(19, 42);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(44, 13);
            this.lblnumero.TabIndex = 0;
            this.lblnumero.Text = "Numero";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(19, 80);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(19, 115);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbldescripcion.TabIndex = 2;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(122, 42);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 0;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(122, 80);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(122, 115);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtdescripcion.TabIndex = 2;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(33, 283);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 6;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(165, 283);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(15, 193);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo";
            // 
            // lbldebilidad
            // 
            this.lbldebilidad.AutoSize = true;
            this.lbldebilidad.Location = new System.Drawing.Point(15, 238);
            this.lbldebilidad.Name = "lbldebilidad";
            this.lbldebilidad.Size = new System.Drawing.Size(51, 13);
            this.lbldebilidad.TabIndex = 9;
            this.lbldebilidad.Text = "Debilidad";
            // 
            // cbotipo
            // 
            this.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Location = new System.Drawing.Point(101, 185);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(121, 21);
            this.cbotipo.TabIndex = 4;
            // 
            // cbodebilidad
            // 
            this.cbodebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodebilidad.FormattingEnabled = true;
            this.cbodebilidad.Location = new System.Drawing.Point(101, 230);
            this.cbodebilidad.Name = "cbodebilidad";
            this.cbodebilidad.Size = new System.Drawing.Size(121, 21);
            this.cbodebilidad.TabIndex = 5;
            // 
            // lblUrlimagen
            // 
            this.lblUrlimagen.AutoSize = true;
            this.lblUrlimagen.Location = new System.Drawing.Point(19, 157);
            this.lblUrlimagen.Name = "lblUrlimagen";
            this.lblUrlimagen.Size = new System.Drawing.Size(55, 13);
            this.lblUrlimagen.TabIndex = 12;
            this.lblUrlimagen.Text = "UrlImagen";
            // 
            // txtUrlimagen
            // 
            this.txtUrlimagen.Location = new System.Drawing.Point(122, 150);
            this.txtUrlimagen.Name = "txtUrlimagen";
            this.txtUrlimagen.Size = new System.Drawing.Size(100, 20);
            this.txtUrlimagen.TabIndex = 3;
            this.txtUrlimagen.Leave += new System.EventHandler(this.txtUrlimagen_Leave_1);
            // 
            // Pbxpokemon
            // 
            this.Pbxpokemon.Location = new System.Drawing.Point(272, 42);
            this.Pbxpokemon.Name = "Pbxpokemon";
            this.Pbxpokemon.Size = new System.Drawing.Size(292, 264);
            this.Pbxpokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbxpokemon.TabIndex = 14;
            this.Pbxpokemon.TabStop = false;
            // 
            // Frmaltapokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 366);
            this.Controls.Add(this.Pbxpokemon);
            this.Controls.Add(this.txtUrlimagen);
            this.Controls.Add(this.lblUrlimagen);
            this.Controls.Add(this.cbodebilidad);
            this.Controls.Add(this.cbotipo);
            this.Controls.Add(this.lbldebilidad);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblnumero);
            this.Name = "Frmaltapokemon";
            this.Text = "Alta Pokemon";
            this.Load += new System.EventHandler(this.frmaltapokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pbxpokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lbldebilidad;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.ComboBox cbodebilidad;
        private System.Windows.Forms.Label lblUrlimagen;
        private System.Windows.Forms.TextBox txtUrlimagen;
        private System.Windows.Forms.PictureBox Pbxpokemon;
    }
}