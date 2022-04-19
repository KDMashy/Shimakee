namespace ShimaKeeCSharp
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
            this.MAINMENU = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CREATENEWGAMEB = new System.Windows.Forms.Button();
            this.LOADGAMEB = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.usernamesListBox = new System.Windows.Forms.ListBox();
            this.LOADCHARB = new System.Windows.Forms.Button();
            this.DELETECHARB = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CANCELCREATIONB = new System.Windows.Forms.Button();
            this.CREATECHARB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.createUsernameField = new System.Windows.Forms.TextBox();
            this.EXITB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MAINMENU.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // MAINMENU
            // 
            this.MAINMENU.BackColor = System.Drawing.Color.LightGray;
            this.MAINMENU.Controls.Add(this.EXITB);
            this.MAINMENU.Controls.Add(this.panel5);
            this.MAINMENU.Controls.Add(this.panel4);
            this.MAINMENU.Controls.Add(this.panel3);
            this.MAINMENU.Controls.Add(this.panel2);
            this.MAINMENU.Location = new System.Drawing.Point(12, 12);
            this.MAINMENU.Name = "MAINMENU";
            this.MAINMENU.Size = new System.Drawing.Size(342, 814);
            this.MAINMENU.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 120);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = "SHIMAKEE GAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.LOADGAMEB);
            this.panel3.Controls.Add(this.CREATENEWGAMEB);
            this.panel3.Location = new System.Drawing.Point(0, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 193);
            this.panel3.TabIndex = 1;
            // 
            // CREATENEWGAMEB
            // 
            this.CREATENEWGAMEB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.CREATENEWGAMEB.Location = new System.Drawing.Point(3, 3);
            this.CREATENEWGAMEB.Name = "CREATENEWGAMEB";
            this.CREATENEWGAMEB.Size = new System.Drawing.Size(336, 81);
            this.CREATENEWGAMEB.TabIndex = 0;
            this.CREATENEWGAMEB.Text = "CREATE NEW GAME";
            this.CREATENEWGAMEB.UseVisualStyleBackColor = true;
            // 
            // LOADGAMEB
            // 
            this.LOADGAMEB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.LOADGAMEB.Location = new System.Drawing.Point(3, 109);
            this.LOADGAMEB.Name = "LOADGAMEB";
            this.LOADGAMEB.Size = new System.Drawing.Size(336, 81);
            this.LOADGAMEB.TabIndex = 1;
            this.LOADGAMEB.Text = "LOAD GAME";
            this.LOADGAMEB.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.DELETECHARB);
            this.panel4.Controls.Add(this.LOADCHARB);
            this.panel4.Controls.Add(this.usernamesListBox);
            this.panel4.Location = new System.Drawing.Point(0, 387);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 145);
            this.panel4.TabIndex = 2;
            // 
            // usernamesListBox
            // 
            this.usernamesListBox.FormattingEnabled = true;
            this.usernamesListBox.Location = new System.Drawing.Point(3, 3);
            this.usernamesListBox.Name = "usernamesListBox";
            this.usernamesListBox.Size = new System.Drawing.Size(176, 134);
            this.usernamesListBox.TabIndex = 0;
            // 
            // LOADCHARB
            // 
            this.LOADCHARB.BackColor = System.Drawing.Color.LimeGreen;
            this.LOADCHARB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.LOADCHARB.Location = new System.Drawing.Point(185, 3);
            this.LOADCHARB.Name = "LOADCHARB";
            this.LOADCHARB.Size = new System.Drawing.Size(153, 52);
            this.LOADCHARB.TabIndex = 1;
            this.LOADCHARB.Text = "LOAD CHARACTER";
            this.LOADCHARB.UseVisualStyleBackColor = false;
            // 
            // DELETECHARB
            // 
            this.DELETECHARB.BackColor = System.Drawing.Color.OrangeRed;
            this.DELETECHARB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.DELETECHARB.Location = new System.Drawing.Point(185, 85);
            this.DELETECHARB.Name = "DELETECHARB";
            this.DELETECHARB.Size = new System.Drawing.Size(153, 52);
            this.DELETECHARB.TabIndex = 2;
            this.DELETECHARB.Text = "DELETE CHARACTER";
            this.DELETECHARB.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.createUsernameField);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.CREATECHARB);
            this.panel5.Controls.Add(this.CANCELCREATIONB);
            this.panel5.Location = new System.Drawing.Point(0, 557);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(341, 100);
            this.panel5.TabIndex = 3;
            // 
            // CANCELCREATIONB
            // 
            this.CANCELCREATIONB.BackColor = System.Drawing.Color.OrangeRed;
            this.CANCELCREATIONB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.CANCELCREATIONB.Location = new System.Drawing.Point(3, 45);
            this.CANCELCREATIONB.Name = "CANCELCREATIONB";
            this.CANCELCREATIONB.Size = new System.Drawing.Size(90, 52);
            this.CANCELCREATIONB.TabIndex = 3;
            this.CANCELCREATIONB.Text = "CANCEL";
            this.CANCELCREATIONB.UseVisualStyleBackColor = false;
            // 
            // CREATECHARB
            // 
            this.CREATECHARB.BackColor = System.Drawing.Color.LimeGreen;
            this.CREATECHARB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.CREATECHARB.Location = new System.Drawing.Point(185, 45);
            this.CREATECHARB.Name = "CREATECHARB";
            this.CREATECHARB.Size = new System.Drawing.Size(153, 52);
            this.CREATECHARB.TabIndex = 3;
            this.CREATECHARB.Text = "CREATE CHARACTER";
            this.CREATECHARB.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label2.Location = new System.Drawing.Point(11, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "USERNAME";
            // 
            // createUsernameField
            // 
            this.createUsernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.createUsernameField.Location = new System.Drawing.Point(110, 14);
            this.createUsernameField.Name = "createUsernameField";
            this.createUsernameField.Size = new System.Drawing.Size(228, 22);
            this.createUsernameField.TabIndex = 5;
            // 
            // EXITB
            // 
            this.EXITB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.EXITB.Location = new System.Drawing.Point(37, 734);
            this.EXITB.Name = "EXITB";
            this.EXITB.Size = new System.Drawing.Size(264, 63);
            this.EXITB.TabIndex = 4;
            this.EXITB.Text = "EXIT";
            this.EXITB.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(375, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 814);
            this.panel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(650, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(321, 312);
            this.panel6.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label3.Location = new System.Drawing.Point(0, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Player: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label4.Location = new System.Drawing.Point(0, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "EXP: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label5.Location = new System.Drawing.Point(0, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "LvL: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label6.Location = new System.Drawing.Point(-1, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "HP: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label7.Location = new System.Drawing.Point(-1, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(322, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "MONEY: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label8.Location = new System.Drawing.Point(0, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(322, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "ATK: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label9.Location = new System.Drawing.Point(0, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(322, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "DEF: ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.button1.Location = new System.Drawing.Point(3, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 61);
            this.button1.TabIndex = 7;
            this.button1.Text = "SAVE AND LOGOUT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1359, 821);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MAINMENU);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MAINMENU.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Panel panel6;

        private System.Windows.Forms.Button EXITB;

        private System.Windows.Forms.TextBox createUsernameField;

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button CANCELCREATIONB;
        private System.Windows.Forms.Button CREATECHARB;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button LOADCHARB;
        private System.Windows.Forms.Button DELETECHARB;

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox usernamesListBox;

        private System.Windows.Forms.Button CREATENEWGAMEB;
        private System.Windows.Forms.Button LOADGAMEB;

        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}