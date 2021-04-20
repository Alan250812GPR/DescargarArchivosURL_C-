
namespace ActualizarFTP
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
            this.UpdateSoft = new System.Windows.Forms.Button();
            this.txturl = new System.Windows.Forms.TextBox();
            this.pbprogreso = new System.Windows.Forms.ProgressBar();
            this.lbprogreso = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdateSoft
            // 
            this.UpdateSoft.Location = new System.Drawing.Point(594, 29);
            this.UpdateSoft.Name = "UpdateSoft";
            this.UpdateSoft.Size = new System.Drawing.Size(125, 26);
            this.UpdateSoft.TabIndex = 0;
            this.UpdateSoft.Text = "Actualizacion";
            this.UpdateSoft.UseVisualStyleBackColor = true;
            this.UpdateSoft.Click += new System.EventHandler(this.UpdateSoft_Click);
            // 
            // txturl
            // 
            this.txturl.HideSelection = false;
            this.txturl.Location = new System.Drawing.Point(37, 71);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(535, 20);
            this.txturl.TabIndex = 1;
            this.txturl.Text = "http://10.10.30.211/test/sensorgraphicDesktop.exe";
            this.txturl.Visible = false;
            this.txturl.TextChanged += new System.EventHandler(this.txturl_TextChanged);
            // 
            // pbprogreso
            // 
            this.pbprogreso.Location = new System.Drawing.Point(61, 32);
            this.pbprogreso.Name = "pbprogreso";
            this.pbprogreso.Size = new System.Drawing.Size(511, 23);
            this.pbprogreso.TabIndex = 2;
            // 
            // lbprogreso
            // 
            this.lbprogreso.AutoSize = true;
            this.lbprogreso.Location = new System.Drawing.Point(32, 35);
            this.lbprogreso.Name = "lbprogreso";
            this.lbprogreso.Size = new System.Drawing.Size(21, 13);
            this.lbprogreso.TabIndex = 3;
            this.lbprogreso.Text = "0%";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 159);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbprogreso);
            this.Controls.Add(this.pbprogreso);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.UpdateSoft);
            this.Name = "Form1";
            this.Text = "Actualizar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateSoft;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.ProgressBar pbprogreso;
        private System.Windows.Forms.Label lbprogreso;
        private System.Windows.Forms.Button button1;
    }
}

