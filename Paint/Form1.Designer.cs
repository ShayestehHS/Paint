
namespace Paint
{
    partial class frmMain
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
            this.Panel = new System.Windows.Forms.Panel();
            this.ColorPicker = new System.Windows.Forms.Panel();
            this.cbFont = new System.Windows.Forms.ComboBox();
            this.ColorBlack = new System.Windows.Forms.Label();
            this.ColorBlue = new System.Windows.Forms.Label();
            this.ColorGreen = new System.Windows.Forms.Label();
            this.ColorRed = new System.Windows.Forms.Label();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.ColorPicker.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.ColorPicker);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Margin = new System.Windows.Forms.Padding(5);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1125, 620);
            this.Panel.TabIndex = 0;
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // ColorPicker
            // 
            this.ColorPicker.BackColor = System.Drawing.Color.Transparent;
            this.ColorPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorPicker.Controls.Add(this.btnErase);
            this.ColorPicker.Controls.Add(this.btnSave);
            this.ColorPicker.Controls.Add(this.cbMode);
            this.ColorPicker.Controls.Add(this.cbFont);
            this.ColorPicker.Controls.Add(this.ColorBlack);
            this.ColorPicker.Controls.Add(this.ColorBlue);
            this.ColorPicker.Controls.Add(this.ColorGreen);
            this.ColorPicker.Controls.Add(this.ColorRed);
            this.ColorPicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.ColorPicker.Location = new System.Drawing.Point(0, 0);
            this.ColorPicker.Name = "ColorPicker";
            this.ColorPicker.Size = new System.Drawing.Size(1125, 70);
            this.ColorPicker.TabIndex = 0;
            // 
            // cbFont
            // 
            this.cbFont.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbFont.FormattingEnabled = true;
            this.cbFont.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "20",
            "30"});
            this.cbFont.Location = new System.Drawing.Point(259, 28);
            this.cbFont.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(60, 25);
            this.cbFont.TabIndex = 5;
            this.cbFont.Text = "Font";
            this.cbFont.SelectedIndexChanged += new System.EventHandler(this.cbWidth_SelectedIndexChanged);
            // 
            // ColorBlack
            // 
            this.ColorBlack.BackColor = System.Drawing.Color.Black;
            this.ColorBlack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorBlack.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ColorBlack.Location = new System.Drawing.Point(14, 10);
            this.ColorBlack.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.ColorBlack.Name = "ColorBlack";
            this.ColorBlack.Size = new System.Drawing.Size(50, 50);
            this.ColorBlack.TabIndex = 4;
            this.ColorBlack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ColorBlack.Click += new System.EventHandler(this.Color_Click);
            // 
            // ColorBlue
            // 
            this.ColorBlue.BackColor = System.Drawing.Color.Blue;
            this.ColorBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorBlue.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ColorBlue.Location = new System.Drawing.Point(139, 15);
            this.ColorBlue.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.ColorBlue.Name = "ColorBlue";
            this.ColorBlue.Size = new System.Drawing.Size(40, 40);
            this.ColorBlue.TabIndex = 3;
            this.ColorBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ColorBlue.Click += new System.EventHandler(this.Color_Click);
            // 
            // ColorGreen
            // 
            this.ColorGreen.BackColor = System.Drawing.Color.Green;
            this.ColorGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorGreen.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ColorGreen.Location = new System.Drawing.Point(79, 15);
            this.ColorGreen.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.ColorGreen.Name = "ColorGreen";
            this.ColorGreen.Size = new System.Drawing.Size(40, 40);
            this.ColorGreen.TabIndex = 2;
            this.ColorGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ColorGreen.Click += new System.EventHandler(this.Color_Click);
            // 
            // ColorRed
            // 
            this.ColorRed.BackColor = System.Drawing.Color.Red;
            this.ColorRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorRed.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ColorRed.Location = new System.Drawing.Point(199, 15);
            this.ColorRed.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.ColorRed.Name = "ColorRed";
            this.ColorRed.Size = new System.Drawing.Size(40, 40);
            this.ColorRed.TabIndex = 1;
            this.ColorRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ColorRed.Click += new System.EventHandler(this.Color_Click);
            // 
            // cbMode
            // 
            this.cbMode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "Line",
            "Square"});
            this.cbMode.Location = new System.Drawing.Point(332, 28);
            this.cbMode.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(86, 25);
            this.cbMode.TabIndex = 6;
            this.cbMode.Text = "Line";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.Location = new System.Drawing.Point(1037, 28);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnErase
            // 
            this.btnErase.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnErase.Location = new System.Drawing.Point(928, 28);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(103, 27);
            this.btnErase.TabIndex = 8;
            this.btnErase.Text = "Erase all";
            this.btnErase.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1125, 620);
            this.Controls.Add(this.Panel);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Panel.ResumeLayout(false);
            this.ColorPicker.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Panel ColorPicker;
        private System.Windows.Forms.Label ColorBlack;
        private System.Windows.Forms.Label ColorBlue;
        private System.Windows.Forms.Label ColorGreen;
        private System.Windows.Forms.Label ColorRed;
        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnSave;
    }
}

