
namespace AutoClickerVer1._0
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
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.trckbarLeftClick = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.lblClickCounter = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.AutoClicker = new System.Windows.Forms.Timer(this.components);
            this.btnToggle = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Random = new System.Windows.Forms.Timer(this.components);
            this.trckbarRandom = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.lblAntiCheat = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.SuspendLayout();
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(13, 13);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(87, 33);
            this.siticoneHtmlLabel1.TabIndex = 0;
            this.siticoneHtmlLabel1.Text = "Clicker";
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(11, 109);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(125, 27);
            this.siticoneHtmlLabel2.TabIndex = 1;
            this.siticoneHtmlLabel2.Text = "Left click CPS";
            // 
            // trckbarLeftClick
            // 
            this.trckbarLeftClick.HoverState.Parent = this.trckbarLeftClick;
            this.trckbarLeftClick.Location = new System.Drawing.Point(12, 138);
            this.trckbarLeftClick.Maximum = 20;
            this.trckbarLeftClick.Minimum = 6;
            this.trckbarLeftClick.Name = "trckbarLeftClick";
            this.trckbarLeftClick.Size = new System.Drawing.Size(360, 23);
            this.trckbarLeftClick.Style = Siticone.Desktop.UI.WinForms.Enums.TrackBarStyle.Metro;
            this.trckbarLeftClick.TabIndex = 2;
            this.trckbarLeftClick.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.trckbarLeftClick.Value = 10;
            this.trckbarLeftClick.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrckbarLeftClick_Scroll);
            // 
            // lblClickCounter
            // 
            this.lblClickCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblClickCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.lblClickCounter.Location = new System.Drawing.Point(390, 138);
            this.lblClickCounter.Name = "lblClickCounter";
            this.lblClickCounter.Size = new System.Drawing.Size(78, 27);
            this.lblClickCounter.TabIndex = 3;
            this.lblClickCounter.Text = "CPS: 10";
            // 
            // AutoClicker
            // 
            this.AutoClicker.Tick += new System.EventHandler(this.AutoClicker_Tick);
            // 
            // btnToggle
            // 
            this.btnToggle.Animated = true;
            this.btnToggle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.btnToggle.BorderRadius = 5;
            this.btnToggle.BorderThickness = 3;
            this.btnToggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.btnToggle.CheckedState.Parent = this.btnToggle;
            this.btnToggle.CustomImages.Parent = this.btnToggle;
            this.btnToggle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToggle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToggle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToggle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToggle.DisabledState.Parent = this.btnToggle;
            this.btnToggle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btnToggle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.btnToggle.HoverState.Parent = this.btnToggle;
            this.btnToggle.Location = new System.Drawing.Point(115, 13);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.ShadowDecoration.Parent = this.btnToggle;
            this.btnToggle.Size = new System.Drawing.Size(354, 34);
            this.btnToggle.TabIndex = 4;
            this.btnToggle.Text = "Toggle";
            this.btnToggle.TextChanged += new System.EventHandler(this.BtnToggle_TextChanged);
            this.btnToggle.Click += new System.EventHandler(this.BtnToggle_Click);
            // 
            // Random
            // 
            this.Random.Interval = 150;
            this.Random.Tick += new System.EventHandler(this.Random_Tick);
            // 
            // trckbarRandom
            // 
            this.trckbarRandom.HoverState.Parent = this.trckbarRandom;
            this.trckbarRandom.Location = new System.Drawing.Point(12, 167);
            this.trckbarRandom.Maximum = 30;
            this.trckbarRandom.Name = "trckbarRandom";
            this.trckbarRandom.Size = new System.Drawing.Size(360, 23);
            this.trckbarRandom.Style = Siticone.Desktop.UI.WinForms.Enums.TrackBarStyle.Metro;
            this.trckbarRandom.TabIndex = 5;
            this.trckbarRandom.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.trckbarRandom.Value = 10;
            // 
            // lblAntiCheat
            // 
            this.lblAntiCheat.BackColor = System.Drawing.Color.Transparent;
            this.lblAntiCheat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntiCheat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.lblAntiCheat.Location = new System.Drawing.Point(378, 167);
            this.lblAntiCheat.Name = "lblAntiCheat";
            this.lblAntiCheat.Size = new System.Drawing.Size(90, 27);
            this.lblAntiCheat.TabIndex = 6;
            this.lblAntiCheat.Text = "AntiCheat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(480, 256);
            this.Controls.Add(this.lblAntiCheat);
            this.Controls.Add(this.trckbarRandom);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.lblClickCounter);
            this.Controls.Add(this.trckbarLeftClick);
            this.Controls.Add(this.siticoneHtmlLabel2);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Auto Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar trckbarLeftClick;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblClickCounter;
        private System.Windows.Forms.Timer AutoClicker;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnToggle;
        private System.Windows.Forms.Timer Random;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar trckbarRandom;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblAntiCheat;
    }
}

