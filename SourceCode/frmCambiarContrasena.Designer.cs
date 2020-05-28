using System.ComponentModel;

namespace SourceCode
{
    partial class frmCambiarContrasena
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtActual = new System.Windows.Forms.TextBox();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRepetir = new System.Windows.Forms.TextBox();
            this.btnCambiarContrasena = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nueva Contrasena:";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repetir contrasena:";
            // 
            // txtActual
            // 
            this.txtActual.Location = new System.Drawing.Point(217, 68);
            this.txtActual.Name = "txtActual";
            this.txtActual.PasswordChar = '*';
            this.txtActual.Size = new System.Drawing.Size(137, 23);
            this.txtActual.TabIndex = 3;
            // 
            // txtNueva
            // 
            this.txtNueva.Location = new System.Drawing.Point(217, 105);
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.PasswordChar = '*';
            this.txtNueva.Size = new System.Drawing.Size(137, 23);
            this.txtNueva.TabIndex = 4;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(217, 27);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(137, 23);
            this.cmbUsuario.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contrasena Actual:";
            // 
            // txtRepetir
            // 
            this.txtRepetir.Location = new System.Drawing.Point(217, 143);
            this.txtRepetir.Name = "txtRepetir";
            this.txtRepetir.PasswordChar = '*';
            this.txtRepetir.Size = new System.Drawing.Size(137, 23);
            this.txtRepetir.TabIndex = 8;
            // 
            // btnCambiarContrasena
            // 
            this.btnCambiarContrasena.Location = new System.Drawing.Point(383, 49);
            this.btnCambiarContrasena.Name = "btnCambiarContrasena";
            this.btnCambiarContrasena.Size = new System.Drawing.Size(129, 27);
            this.btnCambiarContrasena.TabIndex = 9;
            this.btnCambiarContrasena.Text = "Confirmar";
            this.btnCambiarContrasena.UseVisualStyleBackColor = true;
            this.btnCambiarContrasena.Click += new System.EventHandler(this.btnCambiarContrasena_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(383, 105);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 27);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmCambiarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(539, 320);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCambiarContrasena);
            this.Controls.Add(this.txtRepetir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.txtNueva);
            this.Controls.Add(this.txtActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCambiarContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contrasena";
            this.Load += new System.EventHandler(this.frmCambiarContrasena_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.TextBox txtRepetir;
        private System.Windows.Forms.TextBox txtActual;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCambiarContrasena;
    }
}