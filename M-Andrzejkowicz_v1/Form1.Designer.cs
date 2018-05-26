namespace M_Andrzejkowicz_v1
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
            this.log_textbox = new System.Windows.Forms.TextBox();
            this.log_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // log_textbox
            // 
            this.log_textbox.Location = new System.Drawing.Point(459, 25);
            this.log_textbox.Multiline = true;
            this.log_textbox.Name = "log_textbox";
            this.log_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log_textbox.Size = new System.Drawing.Size(522, 537);
            this.log_textbox.TabIndex = 0;
            // 
            // log_label
            // 
            this.log_label.AutoSize = true;
            this.log_label.Location = new System.Drawing.Point(697, 9);
            this.log_label.Name = "log_label";
            this.log_label.Size = new System.Drawing.Size(25, 13);
            this.log_label.TabIndex = 1;
            this.log_label.Text = "Log";
            this.log_label.Click += new System.EventHandler(this.log_label_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 574);
            this.Controls.Add(this.log_label);
            this.Controls.Add(this.log_textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox log_textbox;
        private System.Windows.Forms.Label log_label;
    }
}

