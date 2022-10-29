namespace vanick
{
    partial class Menu
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.picker = new Cyotek.Windows.Forms.ColorWheel();
            this.titlelbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.modeswitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.team_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.enemy_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.SuspendLayout();
            // 
            // picker
            // 
            this.picker.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.picker.Location = new System.Drawing.Point(177, 88);
            this.picker.Name = "picker";
            this.picker.Size = new System.Drawing.Size(112, 89);
            this.picker.TabIndex = 5;
            this.picker.ColorChanged += new System.EventHandler(this.colorWheel1_ColorChanged);
            // 
            // titlelbl
            // 
            this.titlelbl.BackColor = System.Drawing.Color.Transparent;
            this.titlelbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.titlelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.titlelbl.IsContextMenuEnabled = false;
            this.titlelbl.IsSelectionEnabled = false;
            this.titlelbl.Location = new System.Drawing.Point(197, 52);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(68, 30);
            this.titlelbl.TabIndex = 7;
            this.titlelbl.Text = "VanicK";
            // 
            // modeswitch
            // 
            this.modeswitch.Animated = true;
            this.modeswitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.modeswitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.modeswitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.modeswitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.modeswitch.Location = new System.Drawing.Point(199, 185);
            this.modeswitch.Name = "modeswitch";
            this.modeswitch.Size = new System.Drawing.Size(68, 21);
            this.modeswitch.TabIndex = 8;
            this.modeswitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.modeswitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.modeswitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.modeswitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.modeswitch.CheckedChanged += new System.EventHandler(this.modeswitch_CheckedChanged);
            // 
            // team_lbl
            // 
            this.team_lbl.BackColor = System.Drawing.Color.Transparent;
            this.team_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team_lbl.ForeColor = System.Drawing.Color.White;
            this.team_lbl.Location = new System.Drawing.Point(182, 215);
            this.team_lbl.Name = "team_lbl";
            this.team_lbl.Size = new System.Drawing.Size(37, 19);
            this.team_lbl.TabIndex = 9;
            this.team_lbl.Text = "Team";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(225, 215);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(9, 19);
            this.guna2HtmlLabel1.TabIndex = 10;
            this.guna2HtmlLabel1.Text = "/";
            // 
            // enemy_lbl
            // 
            this.enemy_lbl.BackColor = System.Drawing.Color.Transparent;
            this.enemy_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemy_lbl.ForeColor = System.Drawing.Color.White;
            this.enemy_lbl.Location = new System.Drawing.Point(240, 215);
            this.enemy_lbl.Name = "enemy_lbl";
            this.enemy_lbl.Size = new System.Drawing.Size(44, 19);
            this.enemy_lbl.TabIndex = 11;
            this.enemy_lbl.Text = "Enemy";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.BorderColor = System.Drawing.Color.Indigo;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(414, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.DarkCyan;
            this.guna2ControlBox1.Size = new System.Drawing.Size(40, 29);
            this.guna2ControlBox1.TabIndex = 12;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(466, 281);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.enemy_lbl);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.team_lbl);
            this.Controls.Add(this.modeswitch);
            this.Controls.Add(this.titlelbl);
            this.Controls.Add(this.picker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private Cyotek.Windows.Forms.ColorWheel picker;
        private Guna.UI2.WinForms.Guna2HtmlLabel titlelbl;
        private Guna.UI2.WinForms.Guna2ToggleSwitch modeswitch;
        private Guna.UI2.WinForms.Guna2HtmlLabel team_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel enemy_lbl;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}