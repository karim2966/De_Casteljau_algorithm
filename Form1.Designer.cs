namespace Ite_homework_karim_296610
{
    partial class Form
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
            this.BtnDrawPoint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.BtnDeCas = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnDrawPoint
            // 
            this.BtnDrawPoint.Location = new System.Drawing.Point(12, 32);
            this.BtnDrawPoint.Name = "BtnDrawPoint";
            this.BtnDrawPoint.Size = new System.Drawing.Size(110, 68);
            this.BtnDrawPoint.TabIndex = 0;
            this.BtnDrawPoint.Text = "Draw Points";
            this.BtnDrawPoint.UseVisualStyleBackColor = true;
            this.BtnDrawPoint.Click += new System.EventHandler(this.BtnDrawPoint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 106);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 68);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // BtnDeCas
            // 
            this.BtnDeCas.Location = new System.Drawing.Point(12, 180);
            this.BtnDeCas.Name = "BtnDeCas";
            this.BtnDeCas.Size = new System.Drawing.Size(110, 68);
            this.BtnDeCas.TabIndex = 2;
            this.BtnDeCas.Text = "De Casteljau";
            this.BtnDeCas.UseVisualStyleBackColor = true;
            this.BtnDeCas.Click += new System.EventHandler(this.BtnDeCas_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel.Location = new System.Drawing.Point(161, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(824, 555);
            this.panel.TabIndex = 3;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
           
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1027, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.BtnDeCas);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.BtnDrawPoint);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digitizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDrawPoint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button BtnDeCas;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
    }
}

