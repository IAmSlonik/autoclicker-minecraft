namespace Clicker
{
    partial class Loader
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
            this.pTitlebar = new System.Windows.Forms.Panel();
            this.bMinimize = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.lTitlebar = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Panel();
            this.lVersion = new System.Windows.Forms.Label();
            this.bKop = new System.Windows.Forms.Button();
            this.bPrawy = new System.Windows.Forms.Button();
            this.bLewy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lProc = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelOp = new System.Windows.Forms.Panel();
            this.pTitlebar.SuspendLayout();
            this.p2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitlebar
            // 
            this.pTitlebar.Controls.Add(this.bMinimize);
            this.pTitlebar.Controls.Add(this.bExit);
            this.pTitlebar.Controls.Add(this.lTitlebar);
            this.pTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitlebar.Location = new System.Drawing.Point(0, 0);
            this.pTitlebar.Name = "pTitlebar";
            this.pTitlebar.Size = new System.Drawing.Size(530, 24);
            this.pTitlebar.TabIndex = 0;
            this.pTitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTitlebar_MouseDown);
            this.pTitlebar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pTitlebar_MouseMove);
            this.pTitlebar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pTitlebar_MouseUp);
            // 
            // bMinimize
            // 
            this.bMinimize.FlatAppearance.BorderSize = 0;
            this.bMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMinimize.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bMinimize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bMinimize.Location = new System.Drawing.Point(458, 0);
            this.bMinimize.Name = "bMinimize";
            this.bMinimize.Size = new System.Drawing.Size(33, 24);
            this.bMinimize.TabIndex = 3;
            this.bMinimize.Text = "-";
            this.bMinimize.UseVisualStyleBackColor = true;
            this.bMinimize.Click += new System.EventHandler(this.bMinimize_Click);
            // 
            // bExit
            // 
            this.bExit.FlatAppearance.BorderSize = 0;
            this.bExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bExit.Location = new System.Drawing.Point(497, 0);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(33, 24);
            this.bExit.TabIndex = 2;
            this.bExit.Text = "X";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // lTitlebar
            // 
            this.lTitlebar.AutoSize = true;
            this.lTitlebar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTitlebar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lTitlebar.Location = new System.Drawing.Point(3, 6);
            this.lTitlebar.Name = "lTitlebar";
            this.lTitlebar.Size = new System.Drawing.Size(151, 13);
            this.lTitlebar.TabIndex = 1;
            this.lTitlebar.Text = "Autoclicker by mArCin213";
            // 
            // p2
            // 
            this.p2.Controls.Add(this.lVersion);
            this.p2.Controls.Add(this.bKop);
            this.p2.Controls.Add(this.bPrawy);
            this.p2.Controls.Add(this.bLewy);
            this.p2.Location = new System.Drawing.Point(0, 30);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(113, 320);
            this.p2.TabIndex = 1;
            this.p2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTitlebar_MouseDown);
            this.p2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pTitlebar_MouseMove);
            this.p2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pTitlebar_MouseUp);
            // 
            // lVersion
            // 
            this.lVersion.AutoSize = true;
            this.lVersion.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lVersion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lVersion.Location = new System.Drawing.Point(4, 304);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(49, 13);
            this.lVersion.TabIndex = 3;
            this.lVersion.Text = "v0.0.1a";
            // 
            // bKop
            // 
            this.bKop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bKop.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bKop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bKop.Location = new System.Drawing.Point(0, 189);
            this.bKop.Name = "bKop";
            this.bKop.Size = new System.Drawing.Size(113, 23);
            this.bKop.TabIndex = 2;
            this.bKop.Text = "KOPANIE";
            this.bKop.UseVisualStyleBackColor = true;
            this.bKop.Click += new System.EventHandler(this.bKop_Click_1);
            // 
            // bPrawy
            // 
            this.bPrawy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrawy.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bPrawy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bPrawy.Location = new System.Drawing.Point(0, 122);
            this.bPrawy.Name = "bPrawy";
            this.bPrawy.Size = new System.Drawing.Size(113, 23);
            this.bPrawy.TabIndex = 1;
            this.bPrawy.Text = "PRAWY";
            this.bPrawy.UseVisualStyleBackColor = true;
            this.bPrawy.Click += new System.EventHandler(this.bPrawy_Click_1);
            // 
            // bLewy
            // 
            this.bLewy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLewy.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bLewy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bLewy.Location = new System.Drawing.Point(0, 55);
            this.bLewy.Name = "bLewy";
            this.bLewy.Size = new System.Drawing.Size(113, 23);
            this.bLewy.TabIndex = 0;
            this.bLewy.Text = "LEWY";
            this.bLewy.UseVisualStyleBackColor = true;
            this.bLewy.Click += new System.EventHandler(this.bLewy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(442, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status";
            // 
            // lProc
            // 
            this.lProc.AutoSize = true;
            this.lProc.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lProc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lProc.Location = new System.Drawing.Point(488, 337);
            this.lProc.Name = "lProc";
            this.lProc.Size = new System.Drawing.Size(25, 13);
            this.lProc.TabIndex = 5;
            this.lProc.Text = "N/A";
            // 
            // panelOp
            // 
            this.panelOp.Location = new System.Drawing.Point(119, 30);
            this.panelOp.Name = "panelOp";
            this.panelOp.Size = new System.Drawing.Size(399, 309);
            this.panelOp.TabIndex = 6;
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(530, 351);
            this.Controls.Add(this.panelOp);
            this.Controls.Add(this.lProc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.pTitlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loader";
            this.Text = "Autoclicker by mArCin213";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTitlebar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pTitlebar_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pTitlebar_MouseUp);
            this.pTitlebar.ResumeLayout(false);
            this.pTitlebar.PerformLayout();
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pTitlebar;
        private System.Windows.Forms.Label lTitlebar;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bMinimize;
        private System.Windows.Forms.Label lVersion;
        private System.Windows.Forms.Button bKop;
        private System.Windows.Forms.Button bPrawy;
        private System.Windows.Forms.Button bLewy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lProc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelOp;
    }
}

