
namespace HomeUI
{
    partial class HomeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnOpenAdmin = new System.Windows.Forms.Button();
            this.lblWelcoming = new System.Windows.Forms.Label();
            this.btnOpenCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnClose.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 30;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnClose.Location = new System.Drawing.Point(760, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpenAdmin
            // 
            this.btnOpenAdmin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOpenAdmin.FlatAppearance.BorderSize = 0;
            this.btnOpenAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAdmin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpenAdmin.Location = new System.Drawing.Point(187, 275);
            this.btnOpenAdmin.Name = "btnOpenAdmin";
            this.btnOpenAdmin.Size = new System.Drawing.Size(149, 62);
            this.btnOpenAdmin.TabIndex = 1;
            this.btnOpenAdmin.Text = "Admin";
            this.btnOpenAdmin.UseVisualStyleBackColor = false;
            this.btnOpenAdmin.Click += new System.EventHandler(this.btnOpenAdmin_Click);
            // 
            // lblWelcoming
            // 
            this.lblWelcoming.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcoming.AutoSize = true;
            this.lblWelcoming.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcoming.Location = new System.Drawing.Point(240, 64);
            this.lblWelcoming.Name = "lblWelcoming";
            this.lblWelcoming.Size = new System.Drawing.Size(449, 59);
            this.lblWelcoming.TabIndex = 2;
            this.lblWelcoming.Text = "Good {Time_Of_Day}";
            // 
            // btnOpenCustomer
            // 
            this.btnOpenCustomer.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOpenCustomer.FlatAppearance.BorderSize = 0;
            this.btnOpenCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCustomer.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpenCustomer.Location = new System.Drawing.Point(477, 275);
            this.btnOpenCustomer.Name = "btnOpenCustomer";
            this.btnOpenCustomer.Size = new System.Drawing.Size(149, 62);
            this.btnOpenCustomer.TabIndex = 1;
            this.btnOpenCustomer.Text = "Customer";
            this.btnOpenCustomer.UseVisualStyleBackColor = false;
            this.btnOpenCustomer.Click += new System.EventHandler(this.btnOpenCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Online Shop©\r\nIliev and Boshnakov Co";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelcoming);
            this.Controls.Add(this.btnOpenCustomer);
            this.Controls.Add(this.btnOpenAdmin);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Button btnOpenAdmin;
        private System.Windows.Forms.Label lblWelcoming;
        private System.Windows.Forms.Button btnOpenCustomer;
        private System.Windows.Forms.Label label1;
    }
}

