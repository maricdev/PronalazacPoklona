namespace Tehnomanija
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnZaustavi = new System.Windows.Forms.Button();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.timerJavaScript = new System.Windows.Forms.Timer(this.components);
            this.btnPokreniChrome = new System.Windows.Forms.Button();
            this.lblPoklonaNaSajtu = new System.Windows.Forms.Label();
            this.lblPreostalo = new System.Windows.Forms.Label();
            this.lblBrInfo = new System.Windows.Forms.Label();
            this.lblVremePoklona = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(12, 68);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(245, 53);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnZaustavi
            // 
            this.btnZaustavi.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaustavi.Location = new System.Drawing.Point(263, 14);
            this.btnZaustavi.Name = "btnZaustavi";
            this.btnZaustavi.Size = new System.Drawing.Size(244, 107);
            this.btnZaustavi.TabIndex = 1;
            this.btnZaustavi.Text = "Zaustavi";
            this.btnZaustavi.UseVisualStyleBackColor = true;
            this.btnZaustavi.Click += new System.EventHandler(this.btnZaustavi_Click);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 3000;
            this.timerRefresh.Tick += new System.EventHandler(this.TimerRefresh);
            // 
            // timerJavaScript
            // 
            this.timerJavaScript.Tick += new System.EventHandler(this.TimerJavaScript);
            // 
            // btnPokreniChrome
            // 
            this.btnPokreniChrome.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPokreniChrome.Location = new System.Drawing.Point(12, 12);
            this.btnPokreniChrome.Name = "btnPokreniChrome";
            this.btnPokreniChrome.Size = new System.Drawing.Size(245, 55);
            this.btnPokreniChrome.TabIndex = 2;
            this.btnPokreniChrome.Text = "Startuj Chrome";
            this.btnPokreniChrome.UseVisualStyleBackColor = true;
            this.btnPokreniChrome.Click += new System.EventHandler(this.BtnPokreniChrome_Click);
            // 
            // lblPoklonaNaSajtu
            // 
            this.lblPoklonaNaSajtu.AutoSize = true;
            this.lblPoklonaNaSajtu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPoklonaNaSajtu.Location = new System.Drawing.Point(12, 124);
            this.lblPoklonaNaSajtu.Name = "lblPoklonaNaSajtu";
            this.lblPoklonaNaSajtu.Size = new System.Drawing.Size(185, 20);
            this.lblPoklonaNaSajtu.TabIndex = 3;
            this.lblPoklonaNaSajtu.Text = "Broj poklona na sajtu: 0";
            // 
            // lblPreostalo
            // 
            this.lblPreostalo.AutoSize = true;
            this.lblPreostalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPreostalo.Location = new System.Drawing.Point(259, 144);
            this.lblPreostalo.Name = "lblPreostalo";
            this.lblPreostalo.Size = new System.Drawing.Size(181, 20);
            this.lblPreostalo.TabIndex = 4;
            this.lblPreostalo.Text = "Preostalo poklona: 0";
            // 
            // lblBrInfo
            // 
            this.lblBrInfo.AutoSize = true;
            this.lblBrInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrInfo.Location = new System.Drawing.Point(12, 144);
            this.lblBrInfo.Name = "lblBrInfo";
            this.lblBrInfo.Size = new System.Drawing.Size(194, 20);
            this.lblBrInfo.TabIndex = 5;
            this.lblBrInfo.Text = "Broj otvorenih poklona: 0";
            // 
            // lblVremePoklona
            // 
            this.lblVremePoklona.AutoSize = true;
            this.lblVremePoklona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVremePoklona.Location = new System.Drawing.Point(259, 124);
            this.lblVremePoklona.Name = "lblVremePoklona";
            this.lblVremePoklona.Size = new System.Drawing.Size(155, 20);
            this.lblVremePoklona.TabIndex = 6;
            this.lblVremePoklona.Text = "Vreme poklona: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 169);
            this.Controls.Add(this.lblVremePoklona);
            this.Controls.Add(this.lblBrInfo);
            this.Controls.Add(this.lblPreostalo);
            this.Controls.Add(this.lblPoklonaNaSajtu);
            this.Controls.Add(this.btnPokreniChrome);
            this.Controls.Add(this.btnZaustavi);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tehnomanija - Igraj i uvek pobedi!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnZaustavi;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Timer timerJavaScript;
        private System.Windows.Forms.Button btnPokreniChrome;
        private System.Windows.Forms.Label lblPoklonaNaSajtu;
        private System.Windows.Forms.Label lblPreostalo;
        private System.Windows.Forms.Label lblBrInfo;
        private System.Windows.Forms.Label lblVremePoklona;
    }
}

