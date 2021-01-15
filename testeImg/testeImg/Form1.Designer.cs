namespace testeImg
{
    partial class Form1
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
            this.picLampada = new System.Windows.Forms.PictureBox();
            this.btnAcender = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblSaida = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLampada)).BeginInit();
            this.SuspendLayout();
            // 
            // picLampada
            // 
            this.picLampada.Image = global::testeImg.Properties.Resources.LampadaApagada;
            this.picLampada.Location = new System.Drawing.Point(46, 29);
            this.picLampada.Name = "picLampada";
            this.picLampada.Size = new System.Drawing.Size(212, 294);
            this.picLampada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLampada.TabIndex = 0;
            this.picLampada.TabStop = false;
            this.picLampada.DoubleClick += new System.EventHandler(this.picLampada_DoubleClick);
            // 
            // btnAcender
            // 
            this.btnAcender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcender.Location = new System.Drawing.Point(282, 98);
            this.btnAcender.Name = "btnAcender";
            this.btnAcender.Size = new System.Drawing.Size(173, 62);
            this.btnAcender.TabIndex = 1;
            this.btnAcender.Text = "Acender";
            this.btnAcender.UseVisualStyleBackColor = true;
            this.btnAcender.Click += new System.EventHandler(this.btnAcender_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(282, 189);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(173, 62);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(299, 33);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(16, 17);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "0";
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaida.Location = new System.Drawing.Point(690, 215);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(64, 25);
            this.lblSaida.TabIndex = 4;
            this.lblSaida.Text = "label1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(666, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Botão 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clicou_no_botao);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(666, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Botão 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.clicou_no_botao);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 440);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAcender);
            this.Controls.Add(this.picLampada);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picLampada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLampada;
        private System.Windows.Forms.Button btnAcender;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

