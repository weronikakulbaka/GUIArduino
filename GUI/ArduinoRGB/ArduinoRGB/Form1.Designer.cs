namespace ArduinoRGB
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.green = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.off = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Gainsboro;
            this.green.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.green.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.green.Location = new System.Drawing.Point(39, 92);
            this.green.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(205, 45);
            this.green.TabIndex = 1;
            this.green.Text = "Zielony";
            this.green.UseVisualStyleBackColor = false;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Gainsboro;
            this.blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.blue.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.blue.Location = new System.Drawing.Point(39, 156);
            this.blue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(205, 45);
            this.blue.TabIndex = 2;
            this.blue.Text = "Niebieski";
            this.blue.UseVisualStyleBackColor = false;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // off
            // 
            this.off.Location = new System.Drawing.Point(71, 222);
            this.off.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(148, 45);
            this.off.TabIndex = 3;
            this.off.Text = "Wyłącz";
            this.off.UseVisualStyleBackColor = true;
            this.off.Click += new System.EventHandler(this.off_Click);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Gainsboro;
            this.red.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.red.Location = new System.Drawing.Point(39, 32);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(205, 45);
            this.red.TabIndex = 4;
            this.red.Text = "Czerwony";
            this.red.UseVisualStyleBackColor = false;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 293);
            this.Controls.Add(this.red);
            this.Controls.Add(this.off);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.green);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "RGB Cube Controler";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button green;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button off;
        private System.Windows.Forms.Button red;
    }
}

