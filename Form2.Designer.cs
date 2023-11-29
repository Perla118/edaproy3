namespace edaproy3
{
    partial class Form2
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
            this.nombrelabel = new System.Windows.Forms.Label();
            this.autorlabel = new System.Windows.Forms.Label();
            this.descripcionlabel = new System.Windows.Forms.Label();
            this.guardararreglo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombrelabel
            // 
            this.nombrelabel.AutoSize = true;
            this.nombrelabel.Location = new System.Drawing.Point(75, 78);
            this.nombrelabel.Name = "nombrelabel";
            this.nombrelabel.Size = new System.Drawing.Size(69, 20);
            this.nombrelabel.TabIndex = 0;
            this.nombrelabel.Text = "Nombre:";
            // 
            // autorlabel
            // 
            this.autorlabel.AutoSize = true;
            this.autorlabel.Location = new System.Drawing.Point(323, 78);
            this.autorlabel.Name = "autorlabel";
            this.autorlabel.Size = new System.Drawing.Size(52, 20);
            this.autorlabel.TabIndex = 1;
            this.autorlabel.Text = "Autor:";
            // 
            // descripcionlabel
            // 
            this.descripcionlabel.AutoSize = true;
            this.descripcionlabel.Location = new System.Drawing.Point(579, 78);
            this.descripcionlabel.Name = "descripcionlabel";
            this.descripcionlabel.Size = new System.Drawing.Size(96, 20);
            this.descripcionlabel.TabIndex = 2;
            this.descripcionlabel.Text = "Descripción:";
            // 
            // guardararreglo
            // 
            this.guardararreglo.Location = new System.Drawing.Point(343, 356);
            this.guardararreglo.Name = "guardararreglo";
            this.guardararreglo.Size = new System.Drawing.Size(95, 36);
            this.guardararreglo.TabIndex = 3;
            this.guardararreglo.Text = "Guardar";
            this.guardararreglo.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 454);
            this.Controls.Add(this.guardararreglo);
            this.Controls.Add(this.descripcionlabel);
            this.Controls.Add(this.autorlabel);
            this.Controls.Add(this.nombrelabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombrelabel;
        private System.Windows.Forms.Label autorlabel;
        private System.Windows.Forms.Label descripcionlabel;
        private System.Windows.Forms.Button guardararreglo;
    }
}