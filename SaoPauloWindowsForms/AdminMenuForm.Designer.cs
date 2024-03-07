namespace SaoPauloWindowsForms
{
    partial class AdminMenuForm
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
            this.tabControlPages = new System.Windows.Forms.TabControl();
            this.RunnerMainMenu = new System.Windows.Forms.TabPage();
            this.lblAdminHeader = new System.Windows.Forms.Label();
            this.btnAdminLogout = new System.Windows.Forms.Button();
            this.btnAMenuBack = new System.Windows.Forms.Button();
            this.btnAdminInvent = new System.Windows.Forms.Button();
            this.lblAdminMenu = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.adminMenuFooter = new System.Windows.Forms.DataGridView();
            this.adminMenuHeader = new System.Windows.Forms.DataGridView();
            this.btnAdminCharities = new System.Windows.Forms.Button();
            this.btnAdminVolunteers = new System.Windows.Forms.Button();
            this.btnAdminUsers = new System.Windows.Forms.Button();
            this.RunnerPage = new System.Windows.Forms.TabPage();
            this.LoginPage = new System.Windows.Forms.TabPage();
            this.btnRunnerLogin = new System.Windows.Forms.Button();
            this.btnRunnerCancel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tabControlPages.SuspendLayout();
            this.RunnerMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminMenuFooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminMenuHeader)).BeginInit();
            this.LoginPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPages
            // 
            this.tabControlPages.Controls.Add(this.RunnerMainMenu);
            this.tabControlPages.Controls.Add(this.RunnerPage);
            this.tabControlPages.Controls.Add(this.LoginPage);
            this.tabControlPages.Location = new System.Drawing.Point(-2, -59);
            this.tabControlPages.Name = "tabControlPages";
            this.tabControlPages.SelectedIndex = 0;
            this.tabControlPages.Size = new System.Drawing.Size(1894, 1064);
            this.tabControlPages.TabIndex = 2;
            // 
            // RunnerMainMenu
            // 
            this.RunnerMainMenu.Controls.Add(this.lblAdminHeader);
            this.RunnerMainMenu.Controls.Add(this.btnAdminLogout);
            this.RunnerMainMenu.Controls.Add(this.btnAMenuBack);
            this.RunnerMainMenu.Controls.Add(this.btnAdminInvent);
            this.RunnerMainMenu.Controls.Add(this.lblAdminMenu);
            this.RunnerMainMenu.Controls.Add(this.lblTime);
            this.RunnerMainMenu.Controls.Add(this.adminMenuFooter);
            this.RunnerMainMenu.Controls.Add(this.adminMenuHeader);
            this.RunnerMainMenu.Controls.Add(this.btnAdminCharities);
            this.RunnerMainMenu.Controls.Add(this.btnAdminVolunteers);
            this.RunnerMainMenu.Controls.Add(this.btnAdminUsers);
            this.RunnerMainMenu.Location = new System.Drawing.Point(10, 48);
            this.RunnerMainMenu.Name = "RunnerMainMenu";
            this.RunnerMainMenu.Padding = new System.Windows.Forms.Padding(3);
            this.RunnerMainMenu.Size = new System.Drawing.Size(1874, 1006);
            this.RunnerMainMenu.TabIndex = 0;
            this.RunnerMainMenu.Text = "RunnerMainMenu";
            this.RunnerMainMenu.UseVisualStyleBackColor = true;
            // 
            // lblAdminHeader
            // 
            this.lblAdminHeader.AutoSize = true;
            this.lblAdminHeader.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblAdminHeader.Location = new System.Drawing.Point(220, 38);
            this.lblAdminHeader.Name = "lblAdminHeader";
            this.lblAdminHeader.Size = new System.Drawing.Size(752, 70);
            this.lblAdminHeader.TabIndex = 25;
            this.lblAdminHeader.Text = "MARATHON SKILLS 2015";
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAdminLogout.Location = new System.Drawing.Point(1679, 34);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(179, 78);
            this.btnAdminLogout.TabIndex = 17;
            this.btnAdminLogout.Text = "Logout";
            this.btnAdminLogout.UseVisualStyleBackColor = true;
            this.btnAdminLogout.Click += new System.EventHandler(this.btnAdminLogout_Click);
            // 
            // btnAMenuBack
            // 
            this.btnAMenuBack.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAMenuBack.Location = new System.Drawing.Point(25, 34);
            this.btnAMenuBack.Name = "btnAMenuBack";
            this.btnAMenuBack.Size = new System.Drawing.Size(179, 78);
            this.btnAMenuBack.TabIndex = 16;
            this.btnAMenuBack.Text = "Back";
            this.btnAMenuBack.UseVisualStyleBackColor = true;
            // 
            // btnAdminInvent
            // 
            this.btnAdminInvent.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminInvent.Location = new System.Drawing.Point(1014, 478);
            this.btnAdminInvent.Name = "btnAdminInvent";
            this.btnAdminInvent.Size = new System.Drawing.Size(507, 127);
            this.btnAdminInvent.TabIndex = 14;
            this.btnAdminInvent.Text = "Inventory";
            this.btnAdminInvent.UseVisualStyleBackColor = true;
            // 
            // lblAdminMenu
            // 
            this.lblAdminMenu.AutoSize = true;
            this.lblAdminMenu.Font = new System.Drawing.Font("Arial", 12F);
            this.lblAdminMenu.Location = new System.Drawing.Point(793, 197);
            this.lblAdminMenu.Name = "lblAdminMenu";
            this.lblAdminMenu.Size = new System.Drawing.Size(241, 45);
            this.lblAdminMenu.TabIndex = 13;
            this.lblAdminMenu.Text = "Admin menu";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 9F);
            this.lblTime.Location = new System.Drawing.Point(681, 932);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(62, 35);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "test";
            // 
            // adminMenuFooter
            // 
            this.adminMenuFooter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminMenuFooter.Location = new System.Drawing.Point(0, 898);
            this.adminMenuFooter.Name = "adminMenuFooter";
            this.adminMenuFooter.RowTemplate.Height = 40;
            this.adminMenuFooter.Size = new System.Drawing.Size(1874, 105);
            this.adminMenuFooter.TabIndex = 11;
            // 
            // adminMenuHeader
            // 
            this.adminMenuHeader.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.adminMenuHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminMenuHeader.Location = new System.Drawing.Point(-3, 0);
            this.adminMenuHeader.Name = "adminMenuHeader";
            this.adminMenuHeader.RowTemplate.Height = 40;
            this.adminMenuHeader.Size = new System.Drawing.Size(1874, 155);
            this.adminMenuHeader.TabIndex = 10;
            // 
            // btnAdminCharities
            // 
            this.btnAdminCharities.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminCharities.Location = new System.Drawing.Point(332, 478);
            this.btnAdminCharities.Name = "btnAdminCharities";
            this.btnAdminCharities.Size = new System.Drawing.Size(507, 127);
            this.btnAdminCharities.TabIndex = 8;
            this.btnAdminCharities.Text = "Charities";
            this.btnAdminCharities.UseVisualStyleBackColor = true;
            // 
            // btnAdminVolunteers
            // 
            this.btnAdminVolunteers.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminVolunteers.Location = new System.Drawing.Point(1014, 296);
            this.btnAdminVolunteers.Name = "btnAdminVolunteers";
            this.btnAdminVolunteers.Size = new System.Drawing.Size(507, 127);
            this.btnAdminVolunteers.TabIndex = 7;
            this.btnAdminVolunteers.Text = "Volunteers";
            this.btnAdminVolunteers.UseVisualStyleBackColor = true;
            // 
            // btnAdminUsers
            // 
            this.btnAdminUsers.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUsers.Location = new System.Drawing.Point(332, 296);
            this.btnAdminUsers.Name = "btnAdminUsers";
            this.btnAdminUsers.Size = new System.Drawing.Size(507, 127);
            this.btnAdminUsers.TabIndex = 6;
            this.btnAdminUsers.Text = "Users";
            this.btnAdminUsers.UseVisualStyleBackColor = true;
            // 
            // RunnerPage
            // 
            this.RunnerPage.Location = new System.Drawing.Point(10, 48);
            this.RunnerPage.Name = "RunnerPage";
            this.RunnerPage.Padding = new System.Windows.Forms.Padding(3);
            this.RunnerPage.Size = new System.Drawing.Size(1874, 1006);
            this.RunnerPage.TabIndex = 1;
            this.RunnerPage.Text = "RunnerPage";
            this.RunnerPage.UseVisualStyleBackColor = true;
            // 
            // LoginPage
            // 
            this.LoginPage.Controls.Add(this.btnRunnerLogin);
            this.LoginPage.Controls.Add(this.btnRunnerCancel);
            this.LoginPage.Controls.Add(this.btnBack);
            this.LoginPage.Controls.Add(this.txtPassword);
            this.LoginPage.Controls.Add(this.txtEmail);
            this.LoginPage.Controls.Add(this.lblPassword);
            this.LoginPage.Controls.Add(this.lblEmail);
            this.LoginPage.Location = new System.Drawing.Point(10, 48);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Size = new System.Drawing.Size(1874, 1006);
            this.LoginPage.TabIndex = 2;
            this.LoginPage.Text = "LoginPage";
            this.LoginPage.UseVisualStyleBackColor = true;
            // 
            // btnRunnerLogin
            // 
            this.btnRunnerLogin.Location = new System.Drawing.Point(677, 509);
            this.btnRunnerLogin.Name = "btnRunnerLogin";
            this.btnRunnerLogin.Size = new System.Drawing.Size(138, 66);
            this.btnRunnerLogin.TabIndex = 7;
            this.btnRunnerLogin.Text = "Login";
            this.btnRunnerLogin.UseVisualStyleBackColor = true;
            // 
            // btnRunnerCancel
            // 
            this.btnRunnerCancel.Location = new System.Drawing.Point(910, 509);
            this.btnRunnerCancel.Name = "btnRunnerCancel";
            this.btnRunnerCancel.Size = new System.Drawing.Size(138, 66);
            this.btnRunnerCancel.TabIndex = 6;
            this.btnRunnerCancel.Text = "Cancel";
            this.btnRunnerCancel.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(6, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(174, 72);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(678, 430);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(484, 38);
            this.txtPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(677, 353);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(485, 38);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Enter your email address";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(524, 430);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(147, 32);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(576, 353);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(95, 32);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.tabControlPages);
            this.Name = "AdminMenuForm";
            this.Text = "Marathon Skills 2015 - Administrator menu";
            this.tabControlPages.ResumeLayout(false);
            this.RunnerMainMenu.ResumeLayout(false);
            this.RunnerMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminMenuFooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminMenuHeader)).EndInit();
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPages;
        private System.Windows.Forms.TabPage RunnerMainMenu;
        private System.Windows.Forms.Button btnAMenuBack;
        private System.Windows.Forms.Button btnAdminInvent;
        private System.Windows.Forms.Label lblAdminMenu;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DataGridView adminMenuFooter;
        private System.Windows.Forms.DataGridView adminMenuHeader;
        private System.Windows.Forms.Button btnAdminCharities;
        private System.Windows.Forms.Button btnAdminVolunteers;
        private System.Windows.Forms.Button btnAdminUsers;
        private System.Windows.Forms.TabPage RunnerPage;
        private System.Windows.Forms.TabPage LoginPage;
        private System.Windows.Forms.Button btnRunnerLogin;
        private System.Windows.Forms.Button btnRunnerCancel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAdminLogout;
        private System.Windows.Forms.Label lblAdminHeader;
    }
}