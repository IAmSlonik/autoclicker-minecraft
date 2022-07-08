namespace Clicker.GUI.LEWY
{
    partial class Lewy
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
            this.bBind = new System.Windows.Forms.Button();
            this.tbMin = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Ltimer = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tBind = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbMin)).BeginInit();
            this.SuspendLayout();
            // 
            // bBind
            // 
            this.bBind.FlatAppearance.BorderSize = 0;
            this.bBind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBind.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bBind.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bBind.Location = new System.Drawing.Point(150, 29);
            this.bBind.Name = "bBind";
            this.bBind.Size = new System.Drawing.Size(75, 23);
            this.bBind.TabIndex = 0;
            this.bBind.Text = "brak";
            this.bBind.UseVisualStyleBackColor = true;
            this.bBind.Click += new System.EventHandler(this.bBind_Click_1);
            this.bBind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bBind_KeyUp);
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(124, 94);
            this.tbMin.Maximum = 25;
            this.tbMin.Minimum = 1;
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(104, 45);
            this.tbMin.TabIndex = 1;
            this.tbMin.Value = 1;
            this.tbMin.Scroll += new System.EventHandler(this.tbMin_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(248, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CPS";
            // 
            // Ltimer
            // 
            this.Ltimer.Enabled = true;
            this.Ltimer.Tick += new System.EventHandler(this.Ltimer_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox1.Location = new System.Drawing.Point(150, 154);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "disabled";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tBind
            // 
            this.tBind.Enabled = true;
            this.tBind.Interval = 150;
            this.tBind.Tick += new System.EventHandler(this.tBind_Tick);
            // 
            // Lewy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(383, 270);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.bBind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lewy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lewy";
            ((System.ComponentModel.ISupportInitialize)(this.tbMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBind;
        private System.Windows.Forms.TrackBar tbMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Ltimer;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer tBind;
    }
}