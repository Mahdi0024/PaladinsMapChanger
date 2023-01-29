namespace MapChanger
{
    partial class MapChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapChanger));
            this.Fldr = new System.Windows.Forms.FolderBrowserDialog();
            this.BlankContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.mapSelector = new System.Windows.Forms.ComboBox();
            this.AboutButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Fldr
            // 
            this.Fldr.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.Fldr.SelectedPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Paladins";
            this.Fldr.ShowNewFolderButton = false;
            this.Fldr.Tag = "select the \"Paladins\" folder";
            // 
            // BlankContextMenu
            // 
            this.BlankContextMenu.Name = "contextMenuStrip1";
            this.BlankContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Map:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mapSelector
            // 
            this.mapSelector.ContextMenuStrip = this.BlankContextMenu;
            this.mapSelector.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapSelector.FormattingEnabled = true;
            this.mapSelector.Location = new System.Drawing.Point(53, 8);
            this.mapSelector.Name = "mapSelector";
            this.mapSelector.Size = new System.Drawing.Size(249, 25);
            this.mapSelector.Sorted = true;
            this.mapSelector.TabIndex = 6;
            this.mapSelector.Text = "----select a map----";
            this.mapSelector.SelectedIndexChanged += new System.EventHandler(this.MapSelector_SelectedIndexChanged);
            this.mapSelector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MapSelector_KeyPress);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AboutButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.AboutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.AboutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.Location = new System.Drawing.Point(204, 8);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(98, 26);
            this.AboutButton.TabIndex = 9;
            this.AboutButton.TabStop = false;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Visible = false;
            this.AboutButton.MouseEnter += new System.EventHandler(this.AllButtons_MouseEnter);
            this.AboutButton.MouseLeave += new System.EventHandler(this.AllButtons_MouseLeave);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Transparent;
            this.changeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.changeButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.changeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.White;
            this.changeButton.Location = new System.Drawing.Point(10, 216);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(142, 26);
            this.changeButton.TabIndex = 8;
            this.changeButton.TabStop = false;
            this.changeButton.Text = "Change Map";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            this.changeButton.MouseEnter += new System.EventHandler(this.AllButtons_MouseEnter);
            this.changeButton.MouseLeave += new System.EventHandler(this.AllButtons_MouseLeave);
            // 
            // restoreButton
            // 
            this.restoreButton.BackColor = System.Drawing.Color.Transparent;
            this.restoreButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.restoreButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.restoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.restoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.restoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreButton.ForeColor = System.Drawing.Color.White;
            this.restoreButton.Location = new System.Drawing.Point(160, 216);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(142, 26);
            this.restoreButton.TabIndex = 7;
            this.restoreButton.TabStop = false;
            this.restoreButton.Text = "Restore Original Map";
            this.restoreButton.UseVisualStyleBackColor = false;
            this.restoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            this.restoreButton.MouseEnter += new System.EventHandler(this.AllButtons_MouseEnter);
            this.restoreButton.MouseLeave += new System.EventHandler(this.AllButtons_MouseLeave);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.Location = new System.Drawing.Point(10, 38);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(292, 172);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 5;
            this.picture.TabStop = false;
            // 
            // MapChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(160)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(312, 251);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mapSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MapChanger";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paladins Map Changer V1.0";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MapChanger_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog Fldr;
        private System.Windows.Forms.ContextMenuStrip BlankContextMenu;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox mapSelector;
        private System.Windows.Forms.Button AboutButton;
    }
}

