namespace SaoPauloWindowsForms
{
    partial class CoordinatorMenuForm
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
            this.lblCoordHeader = new System.Windows.Forms.Label();
            this.btnCLogout = new System.Windows.Forms.Button();
            this.btnCMenuBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dgHeader = new System.Windows.Forms.DataGridView();
            this.btnCoordSponsorship = new System.Windows.Forms.Button();
            this.btnCoordRunners = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHeader)).BeginInit();
            this.LoginPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPages
            // 
            this.tabControlPages.Controls.Add(this.RunnerMainMenu);
            this.tabControlPages.Controls.Add(this.RunnerPage);
            this.tabControlPages.Controls.Add(this.LoginPage);
            this.tabControlPages.Location = new System.Drawing.Point(-3, -61);
            this.tabControlPages.Name = "tabControlPages";
            this.tabControlPages.SelectedIndex = 0;
            this.tabControlPages.Size = new System.Drawing.Size(1894, 1075);
            this.tabControlPages.TabIndex = 2;
            // 
            // RunnerMainMenu
            // 
            this.RunnerMainMenu.Controls.Add(this.lblCoordHeader);
            this.RunnerMainMenu.Controls.Add(this.btnCLogout);
            this.RunnerMainMenu.Controls.Add(this.btnCMenuBack);
            this.RunnerMainMenu.Controls.Add(this.label1);
            this.RunnerMainMenu.Controls.Add(this.lblTime);
            this.RunnerMainMenu.Controls.Add(this.dataGridView2);
            this.RunnerMainMenu.Controls.Add(this.dgHeader);
            this.RunnerMainMenu.Controls.Add(this.btnCoordSponsorship);
            this.RunnerMainMenu.Controls.Add(this.btnCoordRunners);
            this.RunnerMainMenu.Location = new System.Drawing.Point(10, 48);
            this.RunnerMainMenu.Name = "RunnerMainMenu";
            this.RunnerMainMenu.Padding = new System.Windows.Forms.Padding(3);
            this.RunnerMainMenu.Size = new System.Drawing.Size(1874, 1017);
            this.RunnerMainMenu.TabIndex = 0;
            this.RunnerMainMenu.Text = "RunnerMainMenu";
            this.RunnerMainMenu.UseVisualStyleBackColor = true;
            // 
            // lblCoordHeader
            // 
            this.lblCoordHeader.AutoSize = true;
            this.lblCoordHeader.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblCoordHeader.Location = new System.Drawing.Point(220, 40);
            this.lblCoordHeader.Name = "lblCoordHeader";
            this.lblCoordHeader.Size = new System.Drawing.Size(752, 70);
            this.lblCoordHeader.TabIndex = 25;
            this.lblCoordHeader.Text = "MARATHON SKILLS 2015";
            // 
            // btnCLogout
            // 
            this.btnCLogout.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCLogout.Location = new System.Drawing.Point(1677, 34);
            this.btnCLogout.Name = "btnCLogout";
            this.btnCLogout.Size = new System.Drawing.Size(179, 78);
            this.btnCLogout.TabIndex = 17;
            this.btnCLogout.Text = "Logout";
            this.btnCLogout.UseVisualStyleBackColor = true;
            // 
            // btnCMenuBack
            // 
            this.btnCMenuBack.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCMenuBack.Location = new System.Drawing.Point(25, 34);
            this.btnCMenuBack.Name = "btnCMenuBack";
            this.btnCMenuBack.Size = new System.Drawing.Size(179, 78);
            this.btnCMenuBack.TabIndex = 16;
            this.btnCMenuBack.Text = "Back";
            this.btnCMenuBack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(793, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "Coordinator menu";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(681, 932);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(61, 32);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "test";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 898);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.Size = new System.Drawing.Size(1874, 113);
            this.dataGridView2.TabIndex = 11;
            // 
            // dgHeader
            // 
            this.dgHeader.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.dgHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHeader.Location = new System.Drawing.Point(-3, 0);
            this.dgHeader.Name = "dgHeader";
            this.dgHeader.RowTemplate.Height = 40;
            this.dgHeader.Size = new System.Drawing.Size(1874, 155);
            this.dgHeader.TabIndex = 10;
            // 
            // btnCoordSponsorship
            // 
            this.btnCoordSponsorship.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoordSponsorship.Location = new System.Drawing.Point(1014, 296);
            this.btnCoordSponsorship.Name = "btnCoordSponsorship";
            this.btnCoordSponsorship.Size = new System.Drawing.Size(507, 127);
            this.btnCoordSponsorship.TabIndex = 7;
            this.btnCoordSponsorship.Text = "Sponsorship";
            this.btnCoordSponsorship.UseVisualStyleBackColor = true;
            // 
            // btnCoordRunners
            // 
            this.btnCoordRunners.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoordRunners.Location = new System.Drawing.Point(332, 296);
            this.btnCoordRunners.Name = "btnCoordRunners";
            this.btnCoordRunners.Size = new System.Drawing.Size(507, 127);
            this.btnCoordRunners.TabIndex = 6;
            this.btnCoordRunners.Text = "Runners";
            this.btnCoordRunners.UseVisualStyleBackColor = true;
            // 
            // RunnerPage
            // 
            this.RunnerPage.Location = new System.Drawing.Point(10, 48);
            this.RunnerPage.Name = "RunnerPage";
            this.RunnerPage.Padding = new System.Windows.Forms.Padding(3);
            this.RunnerPage.Size = new System.Drawing.Size(1874, 1017);
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
            this.LoginPage.Size = new System.Drawing.Size(1874, 1017);
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
            // CoordinatorMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.tabControlPages);
            this.Name = "CoordinatorMenuForm";
            this.Text = "Marathon Skills 2015 - Coordinator menu";
            this.tabControlPages.ResumeLayout(false);
            this.RunnerMainMenu.ResumeLayout(false);
            this.RunnerMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHeader)).EndInit();
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPages;
        private System.Windows.Forms.TabPage RunnerMainMenu;
        private System.Windows.Forms.Button btnCMenuBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dgHeader;
        private System.Windows.Forms.Button btnCoordSponsorship;
        private System.Windows.Forms.Button btnCoordRunners;
        private System.Windows.Forms.TabPage RunnerPage;
        private System.Windows.Forms.TabPage LoginPage;
        private System.Windows.Forms.Button btnRunnerLogin;
        private System.Windows.Forms.Button btnRunnerCancel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnCLogout;
        private System.Windows.Forms.Label lblCoordHeader;
    }
}