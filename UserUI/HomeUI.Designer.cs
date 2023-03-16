
namespace AdminUIForm
{
    partial class HomeUI
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
            this.btnOpenCustomer = new System.Windows.Forms.Button();
            this.lblWelcoming = new System.Windows.Forms.Label();
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
            this.btnClose.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnClose.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 35;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.Location = new System.Drawing.Point(757, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpenAdmin
            // 
            this.btnOpenAdmin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOpenAdmin.FlatAppearance.BorderSize = 0;
            this.btnOpenAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAdmin.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenAdmin.Location = new System.Drawing.Point(147, 294);
            this.btnOpenAdmin.Name = "btnOpenAdmin";
            this.btnOpenAdmin.Size = new System.Drawing.Size(169, 61);
            this.btnOpenAdmin.TabIndex = 1;
            this.btnOpenAdmin.Text = "Admin";
            this.btnOpenAdmin.UseVisualStyleBackColor = false;
            this.btnOpenAdmin.Click += new System.EventHandler(this.btnOpenAdmin_Click);
            // 
            // btnOpenCustomer
            // 
            this.btnOpenCustomer.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOpenCustomer.FlatAppearance.BorderSize = 0;
            this.btnOpenCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCustomer.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenCustomer.Location = new System.Drawing.Point(491, 294);
            this.btnOpenCustomer.Name = "btnOpenCustomer";
            this.btnOpenCustomer.Size = new System.Drawing.Size(169, 61);
            this.btnOpenCustomer.TabIndex = 1;
            this.btnOpenCustomer.Text = "Customer";
            this.btnOpenCustomer.UseVisualStyleBackColor = false;
            this.btnOpenCustomer.Click += new System.EventHandler(this.btnOpenCustomer_Click);
            // 
            // lblWelcoming
            // 
            this.lblWelcoming.AutoSize = true;
            this.lblWelcoming.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcoming.Location = new System.Drawing.Point(213, 91);
            this.lblWelcoming.Name = "lblWelcoming";
            this.lblWelcoming.Size = new System.Drawing.Size(458, 59);
            this.lblWelcoming.TabIndex = 2;
            this.lblWelcoming.Text = "Good, {Type_Of_Day}";
            // 
            // HomeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWelcoming);
            this.Controls.Add(this.btnOpenCustomer);
            this.Controls.Add(this.btnOpenAdmin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeUI";
            this.Text = "HomeUI";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Button btnOpenAdmin;
        private System.Windows.Forms.Button btnOpenCustomer;
        private System.Windows.Forms.Label lblWelcoming;
    }
}