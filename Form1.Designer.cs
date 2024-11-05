namespace Projecto_Login_04_11_2024
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
            this.label1 = new System.Windows.Forms.Label();
            this.rutInput = new System.Windows.Forms.TextBox();
            this.contraseñaInput = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ingresarBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // rutInput
            // 
            this.rutInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rutInput.Location = new System.Drawing.Point(398, 163);
            this.rutInput.Name = "rutInput";
            this.rutInput.Size = new System.Drawing.Size(153, 34);
            this.rutInput.TabIndex = 1;
            // 
            // contraseñaInput
            // 
            this.contraseñaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaInput.Location = new System.Drawing.Point(398, 203);
            this.contraseñaInput.Name = "contraseñaInput";
            this.contraseñaInput.Size = new System.Drawing.Size(153, 34);
            this.contraseñaInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // ingresarBtn
            // 
            this.ingresarBtn.Location = new System.Drawing.Point(462, 257);
            this.ingresarBtn.Name = "ingresarBtn";
            this.ingresarBtn.Size = new System.Drawing.Size(89, 32);
            this.ingresarBtn.TabIndex = 5;
            this.ingresarBtn.Text = "Ingresar";
            this.ingresarBtn.UseVisualStyleBackColor = true;
            this.ingresarBtn.Click += new System.EventHandler(this.ingresarBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(367, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ingresarBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contraseñaInput);
            this.Controls.Add(this.rutInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rutInput;
        private System.Windows.Forms.MaskedTextBox contraseñaInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ingresarBtn;
        private System.Windows.Forms.Button button2;
    }
}

