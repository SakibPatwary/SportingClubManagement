
namespace ADMS
{
    partial class ManagerHome
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
            this.label3 = new System.Windows.Forms.Label();
            this.AdminNamelinkLabel = new System.Windows.Forms.LinkLabel();
            this.playerButton = new System.Windows.Forms.Button();
            this.coachButton = new System.Windows.Forms.Button();
            this.sportsButton = new System.Windows.Forms.Button();
            this.sportingClubButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(833, -55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Admin,";
            // 
            // AdminNamelinkLabel
            // 
            this.AdminNamelinkLabel.AutoSize = true;
            this.AdminNamelinkLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminNamelinkLabel.LinkColor = System.Drawing.Color.DarkBlue;
            this.AdminNamelinkLabel.Location = new System.Drawing.Point(880, -57);
            this.AdminNamelinkLabel.Name = "AdminNamelinkLabel";
            this.AdminNamelinkLabel.Size = new System.Drawing.Size(51, 19);
            this.AdminNamelinkLabel.TabIndex = 5;
            this.AdminNamelinkLabel.TabStop = true;
            this.AdminNamelinkLabel.Text = "Name";
            // 
            // playerButton
            // 
            this.playerButton.BackColor = System.Drawing.Color.Gainsboro;
            this.playerButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playerButton.Location = new System.Drawing.Point(107, 131);
            this.playerButton.Name = "playerButton";
            this.playerButton.Size = new System.Drawing.Size(160, 66);
            this.playerButton.TabIndex = 12;
            this.playerButton.Text = "Player";
            this.playerButton.UseVisualStyleBackColor = false;
            // 
            // coachButton
            // 
            this.coachButton.BackColor = System.Drawing.Color.Gainsboro;
            this.coachButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coachButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.coachButton.Location = new System.Drawing.Point(107, 221);
            this.coachButton.Name = "coachButton";
            this.coachButton.Size = new System.Drawing.Size(160, 66);
            this.coachButton.TabIndex = 11;
            this.coachButton.Text = "Coach";
            this.coachButton.UseVisualStyleBackColor = false;
            // 
            // sportsButton
            // 
            this.sportsButton.BackColor = System.Drawing.Color.Gainsboro;
            this.sportsButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sportsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sportsButton.Location = new System.Drawing.Point(107, 317);
            this.sportsButton.Name = "sportsButton";
            this.sportsButton.Size = new System.Drawing.Size(160, 66);
            this.sportsButton.TabIndex = 10;
            this.sportsButton.Text = "Sports";
            this.sportsButton.UseVisualStyleBackColor = false;
            this.sportsButton.Click += new System.EventHandler(this.sportsButton_Click);
            // 
            // sportingClubButton
            // 
            this.sportingClubButton.BackColor = System.Drawing.Color.Gainsboro;
            this.sportingClubButton.FlatAppearance.BorderSize = 0;
            this.sportingClubButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sportingClubButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sportingClubButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sportingClubButton.Location = new System.Drawing.Point(107, 40);
            this.sportingClubButton.Name = "sportingClubButton";
            this.sportingClubButton.Size = new System.Drawing.Size(160, 66);
            this.sportingClubButton.TabIndex = 9;
            this.sportingClubButton.Text = "Sporting Club";
            this.sportingClubButton.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sportsButton);
            this.groupBox1.Controls.Add(this.coachButton);
            this.groupBox1.Controls.Add(this.playerButton);
            this.groupBox1.Controls.Add(this.sportingClubButton);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 427);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manager Home";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(422, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 427);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View/Edit Profile";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 22);
            this.label9.TabIndex = 32;
            this.label9.Text = "Phone : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 22);
            this.label8.TabIndex = 33;
            this.label8.Text = "Manager Name : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 22);
            this.label11.TabIndex = 28;
            this.label11.Text = "Manager ID : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 22);
            this.label10.TabIndex = 29;
            this.label10.Text = "Email : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 35;
            this.label2.Text = "Salary :";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(276, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 33);
            this.button3.TabIndex = 69;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox8.Location = new System.Drawing.Point(171, 97);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(216, 23);
            this.textBox8.TabIndex = 91;
            this.textBox8.Text = "Name";
            // 
            // textBox7
            // 
            this.textBox7.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox7.Location = new System.Drawing.Point(171, 149);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(216, 23);
            this.textBox7.TabIndex = 90;
            this.textBox7.Text = "Phone";
            // 
            // textBox6
            // 
            this.textBox6.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox6.Location = new System.Drawing.Point(171, 245);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(216, 23);
            this.textBox6.TabIndex = 89;
            this.textBox6.Text = "Email";
            // 
            // textBox5
            // 
            this.textBox5.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox5.Location = new System.Drawing.Point(171, 298);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(216, 23);
            this.textBox5.TabIndex = 88;
            this.textBox5.Text = "Salary";
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox4.Location = new System.Drawing.Point(171, 194);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(216, 23);
            this.textBox4.TabIndex = 87;
            this.textBox4.Text = "Address";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(171, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 23);
            this.textBox1.TabIndex = 86;
            this.textBox1.Text = "ID";
            // 
            // ManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 451);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AdminNamelinkLabel);
            this.Name = "ManagerHome";
            this.Text = "ManagerHome";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel AdminNamelinkLabel;
        private System.Windows.Forms.Button playerButton;
        private System.Windows.Forms.Button coachButton;
        private System.Windows.Forms.Button sportsButton;
        private System.Windows.Forms.Button sportingClubButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
    }
}