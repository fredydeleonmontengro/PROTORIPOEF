namespace ejecutable.CONTENEDOR
{
    partial class programa
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
            this.interfazGrafica1 = new capaDiseño.interfazGrafica();
            this.SuspendLayout();
            // 
            // interfazGrafica1
            // 
            this.interfazGrafica1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.interfazGrafica1.Location = new System.Drawing.Point(-2, 1);
            this.interfazGrafica1.Name = "interfazGrafica1";
            this.interfazGrafica1.Size = new System.Drawing.Size(878, 349);
            this.interfazGrafica1.TabIndex = 0;
            // 
            // programa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 326);
            this.Controls.Add(this.interfazGrafica1);
            this.Name = "programa";
            this.Text = "programa";
            this.ResumeLayout(false);

        }

        #endregion

        private capaDiseño.interfazGrafica interfazGrafica1;
    }
}