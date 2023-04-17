namespace RelogioDigital
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnHorasMenos = new System.Windows.Forms.Button();
            this.btnHorasMais = new System.Windows.Forms.Button();
            this.btnMinutosMais = new System.Windows.Forms.Button();
            this.btnMinutosMenos = new System.Windows.Forms.Button();
            this.btnSegundosMais = new System.Windows.Forms.Button();
            this.btnSegundosMenos = new System.Windows.Forms.Button();
            this.timerRelogioDigital = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblHoras.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoras.Location = new System.Drawing.Point(57, 110);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(110, 89);
            this.lblHoras.TabIndex = 0;
            this.lblHoras.Text = "00";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMinutos.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMinutos.Location = new System.Drawing.Point(232, 110);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(110, 89);
            this.lblMinutos.TabIndex = 1;
            this.lblMinutos.Text = "00";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSegundos.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSegundos.Location = new System.Drawing.Point(407, 110);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(110, 89);
            this.lblSegundos.TabIndex = 2;
            this.lblSegundos.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(173, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 89);
            this.label4.TabIndex = 3;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(348, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 89);
            this.label5.TabIndex = 4;
            this.label5.Text = ":";
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(151, 271);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(75, 23);
            this.btnConfigurar.TabIndex = 5;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(232, 271);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnHorasMenos
            // 
            this.btnHorasMenos.Location = new System.Drawing.Point(74, 202);
            this.btnHorasMenos.Name = "btnHorasMenos";
            this.btnHorasMenos.Size = new System.Drawing.Size(39, 23);
            this.btnHorasMenos.TabIndex = 7;
            this.btnHorasMenos.Text = "-";
            this.btnHorasMenos.UseVisualStyleBackColor = true;
            this.btnHorasMenos.Visible = false;
            this.btnHorasMenos.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnHorasMais
            // 
            this.btnHorasMais.Location = new System.Drawing.Point(119, 202);
            this.btnHorasMais.Name = "btnHorasMais";
            this.btnHorasMais.Size = new System.Drawing.Size(39, 23);
            this.btnHorasMais.TabIndex = 8;
            this.btnHorasMais.Text = "+";
            this.btnHorasMais.UseVisualStyleBackColor = true;
            this.btnHorasMais.Visible = false;
            this.btnHorasMais.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMinutosMais
            // 
            this.btnMinutosMais.Location = new System.Drawing.Point(284, 202);
            this.btnMinutosMais.Name = "btnMinutosMais";
            this.btnMinutosMais.Size = new System.Drawing.Size(39, 23);
            this.btnMinutosMais.TabIndex = 10;
            this.btnMinutosMais.Text = "+";
            this.btnMinutosMais.UseVisualStyleBackColor = true;
            this.btnMinutosMais.Visible = false;
            this.btnMinutosMais.Click += new System.EventHandler(this.btnMinutosMais_Click);
            // 
            // btnMinutosMenos
            // 
            this.btnMinutosMenos.Location = new System.Drawing.Point(239, 202);
            this.btnMinutosMenos.Name = "btnMinutosMenos";
            this.btnMinutosMenos.Size = new System.Drawing.Size(39, 23);
            this.btnMinutosMenos.TabIndex = 9;
            this.btnMinutosMenos.Text = "-";
            this.btnMinutosMenos.UseVisualStyleBackColor = true;
            this.btnMinutosMenos.Visible = false;
            this.btnMinutosMenos.Click += new System.EventHandler(this.btnMinutosMenos_Click);
            // 
            // btnSegundosMais
            // 
            this.btnSegundosMais.Location = new System.Drawing.Point(467, 202);
            this.btnSegundosMais.Name = "btnSegundosMais";
            this.btnSegundosMais.Size = new System.Drawing.Size(39, 23);
            this.btnSegundosMais.TabIndex = 12;
            this.btnSegundosMais.Text = "+";
            this.btnSegundosMais.UseVisualStyleBackColor = true;
            this.btnSegundosMais.Visible = false;
            this.btnSegundosMais.Click += new System.EventHandler(this.btnSegundosMais_Click);
            // 
            // btnSegundosMenos
            // 
            this.btnSegundosMenos.Location = new System.Drawing.Point(422, 202);
            this.btnSegundosMenos.Name = "btnSegundosMenos";
            this.btnSegundosMenos.Size = new System.Drawing.Size(39, 23);
            this.btnSegundosMenos.TabIndex = 11;
            this.btnSegundosMenos.Text = "-";
            this.btnSegundosMenos.UseVisualStyleBackColor = true;
            this.btnSegundosMenos.Visible = false;
            this.btnSegundosMenos.Click += new System.EventHandler(this.btnSegundosMenos_Click);
            // 
            // timerRelogioDigital
            // 
            this.timerRelogioDigital.Enabled = true;
            this.timerRelogioDigital.Interval = 1000;
            this.timerRelogioDigital.Tick += new System.EventHandler(this.timerRelogioDigital_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(550, 319);
            this.Controls.Add(this.btnSegundosMais);
            this.Controls.Add(this.btnSegundosMenos);
            this.Controls.Add(this.btnMinutosMais);
            this.Controls.Add(this.btnMinutosMenos);
            this.Controls.Add(this.btnHorasMais);
            this.Controls.Add(this.btnHorasMenos);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lblHoras);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relógio Digital";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHoras;
        private Label lblMinutos;
        private Label lblSegundos;
        private Label label4;
        private Label label5;
        private Button btnConfigurar;
        private Button btnOk;
        private Button btnHorasMenos;
        private Button btnHorasMais;
        private Button btnMinutosMais;
        private Button btnMinutosMenos;
        private Button btnSegundosMais;
        private Button btnSegundosMenos;
        private System.Windows.Forms.Timer timerRelogioDigital;
    }
}