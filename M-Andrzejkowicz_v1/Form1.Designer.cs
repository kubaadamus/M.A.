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
            this.components = new System.ComponentModel.Container();
            this.log_textbox = new System.Windows.Forms.TextBox();
            this.log_label = new System.Windows.Forms.Label();
            this.LISTA = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Proto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.L0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.L1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.L2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.L3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.L_port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.F0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.F1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.F2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.F3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.F_port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.skanuj_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.podsluch_alert = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Progress_text_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.zakres_text_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // log_textbox
            // 
            this.log_textbox.Location = new System.Drawing.Point(866, 25);
            this.log_textbox.Multiline = true;
            this.log_textbox.Name = "log_textbox";
            this.log_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log_textbox.Size = new System.Drawing.Size(474, 797);
            this.log_textbox.TabIndex = 0;
            // 
            // log_label
            // 
            this.log_label.AutoSize = true;
            this.log_label.Location = new System.Drawing.Point(1099, 9);
            this.log_label.Name = "log_label";
            this.log_label.Size = new System.Drawing.Size(25, 13);
            this.log_label.TabIndex = 1;
            this.log_label.Text = "Log";
            // 
            // LISTA
            // 
            this.LISTA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.Proto,
            this.L0,
            this.L1,
            this.L2,
            this.L3,
            this.L_port,
            this.F0,
            this.F1,
            this.F2,
            this.F3,
            this.F_port,
            this.State,
            this.PID});
            this.LISTA.FullRowSelect = true;
            this.LISTA.GridLines = true;
            this.LISTA.Location = new System.Drawing.Point(71, 39);
            this.LISTA.Name = "LISTA";
            this.LISTA.Size = new System.Drawing.Size(626, 783);
            this.LISTA.TabIndex = 2;
            this.LISTA.UseCompatibleStateImageBehavior = false;
            this.LISTA.View = System.Windows.Forms.View.Details;
            // 
            // Index
            // 
            this.Index.Text = "Index";
            // 
            // Proto
            // 
            this.Proto.Text = "Proto";
            // 
            // L0
            // 
            this.L0.Text = "L0";
            this.L0.Width = 32;
            // 
            // L1
            // 
            this.L1.Text = "L1";
            this.L1.Width = 34;
            // 
            // L2
            // 
            this.L2.Text = "L2";
            this.L2.Width = 38;
            // 
            // L3
            // 
            this.L3.Text = "L3";
            this.L3.Width = 34;
            // 
            // L_port
            // 
            this.L_port.Text = "L_port";
            this.L_port.Width = 51;
            // 
            // F0
            // 
            this.F0.Text = "F0";
            this.F0.Width = 30;
            // 
            // F1
            // 
            this.F1.Text = "F1";
            this.F1.Width = 29;
            // 
            // F2
            // 
            this.F2.Text = "F2";
            this.F2.Width = 37;
            // 
            // F3
            // 
            this.F3.Text = "F3";
            this.F3.Width = 33;
            // 
            // F_port
            // 
            this.F_port.Text = "F_port";
            this.F_port.Width = 49;
            // 
            // State
            // 
            this.State.Text = "State";
            this.State.Width = 69;
            // 
            // PID
            // 
            this.PID.Text = "PID";
            this.PID.Width = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Local Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Foreign Address";
            // 
            // skanuj_button
            // 
            this.skanuj_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.skanuj_button.Location = new System.Drawing.Point(703, 39);
            this.skanuj_button.Name = "skanuj_button";
            this.skanuj_button.Size = new System.Drawing.Size(157, 43);
            this.skanuj_button.TabIndex = 5;
            this.skanuj_button.Text = "SKANUJ LISTENINGI";
            this.skanuj_button.UseVisualStyleBackColor = true;
            this.skanuj_button.Click += new System.EventHandler(this.skanuj_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(381, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 21);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(198, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 21);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // podsluch_alert
            // 
            this.podsluch_alert.Location = new System.Drawing.Point(702, 157);
            this.podsluch_alert.Name = "podsluch_alert";
            this.podsluch_alert.Size = new System.Drawing.Size(157, 20);
            this.podsluch_alert.TabIndex = 8;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(727, 88);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "LISTENING";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(727, 111);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ESTABLISHED";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(727, 134);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(94, 17);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "CLOSE_WAIT";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(702, 334);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(107, 22);
            this.progressBar1.TabIndex = 12;
            // 
            // Progress_text_box
            // 
            this.Progress_text_box.BackColor = System.Drawing.Color.White;
            this.Progress_text_box.Location = new System.Drawing.Point(812, 334);
            this.Progress_text_box.Name = "Progress_text_box";
            this.Progress_text_box.Size = new System.Drawing.Size(47, 20);
            this.Progress_text_box.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(702, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "PINGUJ PODSIEĆ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(703, 270);
            this.hScrollBar1.Maximum = 255;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(106, 17);
            this.hScrollBar1.TabIndex = 15;
            this.hScrollBar1.Value = 255;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(727, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Zakres skanowania";
            // 
            // zakres_text_box
            // 
            this.zakres_text_box.Location = new System.Drawing.Point(813, 270);
            this.zakres_text_box.Name = "zakres_text_box";
            this.zakres_text_box.Size = new System.Drawing.Size(46, 20);
            this.zakres_text_box.TabIndex = 17;
            this.zakres_text_box.Text = "255";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(727, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Progress skanowania";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 842);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zakres_text_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Progress_text_box);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.podsluch_alert);
            this.Controls.Add(this.skanuj_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LISTA);
            this.Controls.Add(this.log_label);
            this.Controls.Add(this.log_textbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox log_textbox;
        private System.Windows.Forms.Label log_label;
        private System.Windows.Forms.ListView LISTA;
        private System.Windows.Forms.ColumnHeader Proto;
        private System.Windows.Forms.ColumnHeader L0;
        private System.Windows.Forms.ColumnHeader L1;
        private System.Windows.Forms.ColumnHeader L2;
        private System.Windows.Forms.ColumnHeader L3;
        private System.Windows.Forms.ColumnHeader L_port;
        private System.Windows.Forms.ColumnHeader F0;
        private System.Windows.Forms.ColumnHeader F1;
        private System.Windows.Forms.ColumnHeader F2;
        private System.Windows.Forms.ColumnHeader F3;
        private System.Windows.Forms.ColumnHeader F_port;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.ColumnHeader PID;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button skanuj_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox podsluch_alert;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox Progress_text_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox zakres_text_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

