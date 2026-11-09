namespace MVP_Presentacion.Forms
{
    partial class FrmCraps
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
            this.lblDado1 = new System.Windows.Forms.Label();
            this.lblDado2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblPunto = new System.Windows.Forms.Label();
            this.btnLanzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDado1
            // 
            this.lblDado1.AutoSize = true;
            this.lblDado1.Font = new System.Drawing.Font("Monospac821 BT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDado1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDado1.Location = new System.Drawing.Point(425, 119);
            this.lblDado1.Name = "lblDado1";
            this.lblDado1.Size = new System.Drawing.Size(79, 16);
            this.lblDado1.TabIndex = 0;
            this.lblDado1.Text = "Dado 1: -";
            // 
            // lblDado2
            // 
            this.lblDado2.AutoSize = true;
            this.lblDado2.Font = new System.Drawing.Font("Monospac821 BT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDado2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDado2.Location = new System.Drawing.Point(425, 154);
            this.lblDado2.Name = "lblDado2";
            this.lblDado2.Size = new System.Drawing.Size(87, 16);
            this.lblDado2.TabIndex = 1;
            this.lblDado2.Text = "Dado 2: - ";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Monospac821 BT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResultado.Location = new System.Drawing.Point(425, 189);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(71, 16);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Punto: -";
            // 
            // lblPunto
            // 
            this.lblPunto.AutoSize = true;
            this.lblPunto.Font = new System.Drawing.Font("Monospac821 BT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPunto.Location = new System.Drawing.Point(425, 253);
            this.lblPunto.Name = "lblPunto";
            this.lblPunto.Size = new System.Drawing.Size(79, 16);
            this.lblPunto.TabIndex = 3;
            this.lblPunto.Text = "Resultado";
            // 
            // btnLanzar
            // 
            this.btnLanzar.BackColor = System.Drawing.Color.LightCoral;
            this.btnLanzar.Font = new System.Drawing.Font("Monospac821 BT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanzar.ForeColor = System.Drawing.Color.White;
            this.btnLanzar.Location = new System.Drawing.Point(419, 328);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(159, 31);
            this.btnLanzar.TabIndex = 4;
            this.btnLanzar.Text = "Lanzar dados";
            this.btnLanzar.UseVisualStyleBackColor = false;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // FrmCraps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1210, 529);
            this.Controls.Add(this.btnLanzar);
            this.Controls.Add(this.lblPunto);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDado2);
            this.Controls.Add(this.lblDado1);
            this.Name = "FrmCraps";
            this.Text = "FrmCraps";
            this.Load += new System.EventHandler(this.FrmCraps_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDado1;
        private System.Windows.Forms.Label lblDado2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblPunto;
        private System.Windows.Forms.Button btnLanzar;
    }
}