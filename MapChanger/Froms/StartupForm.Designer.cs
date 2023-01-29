
namespace MapChanger
{
    partial class StartupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupForm));
            this.logBox = new System.Windows.Forms.TextBox();
            this.buttonManual = new System.Windows.Forms.Button();
            this.buttonAuto = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.Color.Black;
            this.logBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.logBox.Location = new System.Drawing.Point(10, 10);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(288, 200);
            this.logBox.TabIndex = 0;
            // 
            // buttonManual
            // 
            this.buttonManual.BackColor = System.Drawing.Color.Transparent;
            this.buttonManual.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonManual.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.buttonManual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.buttonManual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.buttonManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManual.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManual.ForeColor = System.Drawing.Color.White;
            this.buttonManual.Location = new System.Drawing.Point(162, 222);
            this.buttonManual.Name = "buttonManual";
            this.buttonManual.Size = new System.Drawing.Size(136, 26);
            this.buttonManual.TabIndex = 10;
            this.buttonManual.TabStop = false;
            this.buttonManual.Text = "Set Manually";
            this.buttonManual.UseVisualStyleBackColor = false;
            this.buttonManual.Click += new System.EventHandler(this.ButtonManual_Click);
            // 
            // buttonAuto
            // 
            this.buttonAuto.BackColor = System.Drawing.Color.Transparent;
            this.buttonAuto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAuto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.buttonAuto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.buttonAuto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.buttonAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAuto.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAuto.ForeColor = System.Drawing.Color.White;
            this.buttonAuto.Location = new System.Drawing.Point(10, 222);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(136, 26);
            this.buttonAuto.TabIndex = 11;
            this.buttonAuto.TabStop = false;
            this.buttonAuto.Text = "Set Atuomatically";
            this.buttonAuto.UseVisualStyleBackColor = false;
            this.buttonAuto.Click += new System.EventHandler(this.ButtonAuto_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(160)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(310, 217);
            this.Controls.Add(this.buttonAuto);
            this.Controls.Add(this.buttonManual);
            this.Controls.Add(this.logBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartupForm_FormClosed);
            this.Load += new System.EventHandler(this.StartupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Button buttonManual;
        private System.Windows.Forms.Button buttonAuto;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
    }
}