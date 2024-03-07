using SaoPauloWindowsForms.EF;
using SaoPauloWindowsForms.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaoPauloWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime datetime = new DateTime(2018, 09, 05);
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marathonSkills2015DataSet.Charity' table. You can move, or remove it, as needed.
            this.charityTableAdapter.Fill(this.marathonSkills2015DataSet.Charity);
            // TODO: This line of code loads data into the 'marathonSkills2015DataSet.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.marathonSkills2015DataSet.Country);
            // TODO: This line of code loads data into the 'marathonSkills2015DataSet.Gender' table. You can move, or remove it, as needed.
            this.genderTableAdapter.Fill(this.marathonSkills2015DataSet.Gender);



            this.Size = new Size(720, 480);
            this.StartPosition = FormStartPosition.CenterScreen;

            //For Login
            this.ActiveControl = lblEmail;
            txtEmail.GotFocus += new EventHandler(this.TextGotFocus);
            txtEmail.LostFocus += new EventHandler(this.TextLostFocus);

            //For Runner Registration Page Email
            ActiveControl = lblRegisARunnerEmail;
            tbRegisARunnerEmail.GotFocus += new EventHandler(TextGotFocusEmail);
            tbRegisARunnerEmail.LostFocus += new EventHandler(TextLostFocusEmail);

            //For Runner Registration First Name
            ActiveControl = lblRegisARunnerFName;
            tbRegisARunnerFName.GotFocus += new EventHandler(TextGotFocusFN);
            tbRegisARunnerFName.LostFocus += new EventHandler(TextLostFocusFN);

            //For Runner Registration Last name
            ActiveControl = lblRegisARunnerLName;
            tbRegisARunnerLName.GotFocus += new EventHandler(TextGotFocusLN);
            tbRegisARunnerLName.LostFocus += new EventHandler(TextLostFocusLN);

            //For Sponsor a runner page
            ActiveControl = lblSponARunrName;
            tbSponARunrName.GotFocus += new EventHandler(TextGotFocusSponsorName);
            tbSponARunrName.LostFocus += new EventHandler(TextLostFocusSponsorName);

            ActiveControl = lblSponARunrCardNam;
            tbSponARunrCardNam.GotFocus += new EventHandler(TextGotFocusCardName);
            tbSponARunrCardNam.LostFocus += new EventHandler(TextLostFocusCardName);

            ActiveControl = lblSponARunrCC;
            tbSponARunrCC.GotFocus += new EventHandler(TextGotFocusCardNum);
            tbSponARunrCC.LostFocus += new EventHandler(TextLostFocusCardNum);
            //--------------------------END for SponsorRun--------------------------------------

            //for countdown
            Timer t = new Timer();
            t.Interval = 500;
            t.Tick += new EventHandler(t_Tick);
            TimeSpan ts = datetime.Subtract(DateTime.Now);
            lblTime.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");

            //-----------------------------Additional Codes--------------------------------
            //for login page
            lblLoginTime.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            //for RegisterRunnerMenuPage, registerRunnerPage
            lblRRunMenuTime.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            lblRRunnerTime.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            //For SponRunner Page
            lblSponARunrCd.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            //For SponRunnerCfm Page
            lblSponCfmCd.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            //For FindOutMorePage
            lblFindOutMoreCd.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            //For ListOfCharities Page
            lblListOfCharityCd.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            //For FindOutMoreMS2015 Page
            lblFOMMS15Cd.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");

            //--------------------------------END--------------------------------

            t.Start();

            //Data RETRIEVAL ON LOAD.
            String strConnection = @"Data Source=localhost\SQLExpress;Initial Catalog=MarathonSkills2015;Integrated Security=True";
            SqlConnection con = new SqlConnection(strConnection);

            //---------------------Runner Data Retrieval for SponsorRunner--------------------//
            try
            {

                //------------------------For Runner Data------------------------
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText =
                    "SELECT CONCAT (LastName, + ', ', + FirstName, + ' - ', + BibNumber, + ' (', + CountryCode, + ')') AS RunnerData " +
                    "FROM [dbo].[User], [dbo].[Runner], [dbo].[Registration], [dbo].[RegistrationEvent] " +
                    "WHERE [User].Email = [Runner].Email " +
                    "AND [Runner].RunnerId = [Registration].RunnerId " +
                    "AND [Registration].RegistrationId = [RegistrationEvent].RegistrationId";

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);
                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                cbSponARunrRunnerName.DataSource = dtRecord;
                cbSponARunrRunnerName.DisplayMember = "RunnerData";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

            //-----------------------------END-----------------------------//

            //For Picture resizing to fit into the picturebox.
            pBFOMMS15MapPic.SizeMode = PictureBoxSizeMode.StretchImage;
            pBFOMMS15Pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pBFOMMS15Pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            pBFOMMS15Pic3.SizeMode = PictureBoxSizeMode.StretchImage;
            pBFOMMS15Pic4.SizeMode = PictureBoxSizeMode.StretchImage;


        }
        public void t_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = datetime.Subtract(DateTime.Now);
            lblTime.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");

            //for login page
            lblLoginTime.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            //for registerRunnerMenuPage, registerRunnerPage
            lblRRunMenuTime.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            lblRRunnerTime.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            //For SponRunner Page
            lblSponARunrCd.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            //For SponRunnerCfm Page
            lblSponCfmCd.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            //For FindOutMorePage
            lblFindOutMoreCd.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            //For ListOfCharities Page
            lblListOfCharityCd.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            //For FindOutMoreMS2015 Page
            lblFOMMS15Cd.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");

            //--------------------------------END--------------------------------
        }
        // 1st Button on Main Menu
        private void btnRunner_Click(object sender, EventArgs e)
        {
            tabControlPages.SelectedTab = RegisterAsRunnerMenuPage;
        }

        //END 

        private void dgHeader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void TextGotFocus(object sender, EventArgs e)
        {
            // For Login Menu
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Enter your email address")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }
        // For Runner Regis Page
        //Email & Password Validation
        private Boolean ValidateEmail(string password)
        {
            Regex regex = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
            regex.IsMatch(password);
            if (regex.IsMatch(password))
            {
                return true;
            }
            else
            {
                MessageBox.Show("The Email does not follow the correct " +
                    "sequence. For E.g abc@xyz.com");
                return false;
            }
        }

        private Boolean ValidatePassword(string password)
        {
            Regex regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{6,}$");
            regex.IsMatch(password);
            if (regex.IsMatch(password))
            {
                return true;
            }
            else
            {
                MessageBox.Show("The password must follow the sequence: at least 6 characters, " +
                    "one small letter, one capital, a number, a special character. " +
                    "Such as !@#$%^&*. Please check!");
                return false;
            }
        }

        public void TextGotFocusEmail(object sender, EventArgs e)
        {
            TextBox tb2 = (TextBox)sender;
            if (tb2.Text == "Email address")
            {
                tb2.Text = "";
                tb2.ForeColor = Color.Black;
            }
        }
        public void TextGotFocusFN(object sender, EventArgs e)
        {
            TextBox tb3 = (TextBox)sender;
            if (tb3.Text == "First name")
            {
                tb3.Text = "";
                tb3.ForeColor = Color.Black;
            }
        }
        public void TextGotFocusLN(object sender, EventArgs e)
        {
            TextBox tb4 = (TextBox)sender;
            if (tb4.Text == "Last name")
            {
                tb4.Text = "";
                tb4.ForeColor = Color.Black;
            }
        }


        //-------------------------------------------------------------------

        public void TextLostFocus(object sender, EventArgs e)
        {
            // For Login Menu
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = "Enter your email address";
                tb.ForeColor = Color.Gray;
            }
        }
        // For Runner Regis Page
        public void TextLostFocusEmail(object sender, EventArgs e)
        {
            TextBox tb2 = (TextBox)sender;
            if (tb2.Text == "")
            {
                tb2.Text = "Email address";
                tb2.ForeColor = Color.Gray;
            }
        }
        public void TextLostFocusFN(object sender, EventArgs e)
        {
            TextBox tb3 = (TextBox)sender;
            if (tb3.Text == "")
            {
                tb3.Text = "First name";
                tb3.ForeColor = Color.Gray;
            }
        }
        public void TextLostFocusLN(object sender, EventArgs e)
        {
            TextBox tb4 = (TextBox)sender;
            if (tb4.Text == "")
            {
                tb4.Text = "Last name";
                tb4.ForeColor = Color.Gray;
            }
        }
        //-------------------------------------------------------------------
        //----------------------For Sponsor a runner page------------------------------
        public void TextGotFocusSponsorName(object sender, EventArgs e)
        {
            TextBox tb5 = (TextBox)sender;
            if (tb5.Text == "Your name")
            {
                tb5.Text = "";
                tb5.ForeColor = Color.Black;
            }
        }
        public void TextLostFocusSponsorName(object sender, EventArgs e)
        {
            TextBox tb5 = (TextBox)sender;
            if (tb5.Text == "")
            {
                tb5.Text = "Your name";
                tb5.ForeColor = Color.Gray;
            }
        }
        public void TextGotFocusCardName(object sender, EventArgs e)
        {
            TextBox tb6 = (TextBox)sender;
            if (tb6.Text == "Credit card holder")
            {
                tb6.Text = "";
                tb6.ForeColor = Color.Black;
            }
        }
        public void TextLostFocusCardName(object sender, EventArgs e)
        {
            TextBox tb6 = (TextBox)sender;
            if (tb6.Text == "")
            {
                tb6.Text = "Credit card holder";
                tb6.ForeColor = Color.Gray;
            }
        }
        public void TextGotFocusCardNum(object sender, EventArgs e)
        {
            TextBox tb7 = (TextBox)sender;
            if (tb7.Text == "1234 1234 1234 1234")
            {
                tb7.Text = "";
                tb7.ForeColor = Color.Black;
            }
        }
        public void TextLostFocusCardNum(object sender, EventArgs e)
        {
            TextBox tb7 = (TextBox)sender;
            if (tb7.Text == "")
            {
                tb7.Text = "1234 1234 1234 1234";
                tb7.ForeColor = Color.Gray;
            }
        }
        //--------------------------SponsorARunnerFin----------------------------------

        private void btnMainLogin_Click(object sender, EventArgs e)
        {
            tabControlPages.SelectedTab = LoginPage;
        }

        //Login Page Buttons Navigations
        private void btnLoginBack_Click(object sender, EventArgs e)
        {
            tabControlPages.SelectedTab = MSMainPage;
        }
        private void btnRunnerCancel_Click(object sender, EventArgs e)
        {
            tabControlPages.SelectedTab = MSMainPage;
        }
        private void btnRunnerLogin_Click(object sender, EventArgs e)
        {
            LoginViewModel.Email = txtEmail.Text;
            LoginViewModel.Password = txtPassword.Text;

            if (UserValidty.DoLogin(LoginViewModel.Email, LoginViewModel.Password) == true)
            {
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Username/Password is invalid.", "Error",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }

            //SqlConnection sqlcon = new SqlConnection(@"Data Source=localhost\SQLExpress;Initial Catalog=MarathonSkills2015;Integrated Security=True");
            //string query = "SELECT * FROM [dbo].[User] WHERE Email = '" + txtEmail.Text.Trim()
            //    + "' AND Password = '" + txtPassword.Text.Trim() + "'";

            //SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            //DataTable dtbl = new DataTable();
            //sda.Fill(dtbl);
            //if (dtbl.Rows.Count == 1)
            //{
            //    RunnerMenuForm runnerMenuForm = new RunnerMenuForm();
            //    this.Hide();
            //    runnerMenuForm.Size = new Size(720, 480);
            //    runnerMenuForm.StartPosition = FormStartPosition.CenterScreen;
            //    runnerMenuForm.Show();
            //}
        }
        //END

        private void btnRRegisCompete_Click(object sender, EventArgs e)
        {
            tabControlPages.SelectedTab = LoginPage;
        }
        private void btnRRegisLogin_Click(object sender, EventArgs e)
        {
            tabControlPages.SelectedTab = LoginPage;
        }

        private void btnRRegisNewComp_Click(object sender, EventArgs e)
        {
            tabControlPages.SelectedTab = RegisterRunnerPage;
        }

        //Registering as runner
        private void btnRegisAsRunner_Click(object sender, EventArgs e)
        {
            if (tbRegisARunnerPass.Text == tbRegisARunnerPassAgain.Text)
            {
                if (ValidatePassword(tbRegisARunnerPass.Text) && ValidateEmail(tbRegisARunnerEmail.Text))
                {
                    int age = DateTime.Today.Year - dtpRegisARunnerDOB.Value.Year; // CurrentYear - BirthDate
             
                    if (age > 10)
                    {
                        RunnerRegistrationViewModel runnerRegistrationViewModel = new RunnerRegistrationViewModel();
                        runnerRegistrationViewModel.Email = tbRegisARunnerEmail.Text;
                        runnerRegistrationViewModel.Password = tbRegisARunnerPass.Text;
                        runnerRegistrationViewModel.DateOfBirth = dtpRegisARunnerDOB.Value;
                        runnerRegistrationViewModel.FirstName = tbRegisARunnerFName.Text;
                        runnerRegistrationViewModel.LastName = tbRegisARunnerLName.Text;
                        runnerRegistrationViewModel.SelectedGender = cbRegisARunnerGender.SelectedValue.ToString();
                        runnerRegistrationViewModel.SelectedCountry = cbRegisARunnerCountry.SelectedValue.ToString();
                        
                        if (DataAccess.RegisterRunner(runnerRegistrationViewModel))
                        {
                            DialogResult dr = MessageBox.Show("You have successfully registered. " +
                            "Now redirecting you to login page. Please login with your email " +
                            "and password!", "Success!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (dr == DialogResult.OK)
                            {
                                tabControlPages.SelectedTab = LoginPage;
                                //this.Visible = false;
                                //RunnerMenuForm rmf = new RunnerMenuForm();
                                //rmf.Size = new Size(720, 480);
                                //rmf.StartPosition = FormStartPosition.CenterScreen;
                                //rmf.tabRMenuControlPages.SelectTab("RegistForEventPage");
                                //rmf.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email already exists.", "Error");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("You need to be at least 10 years old to participate."
                            , "Age Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    }
                }

            }
            else
            {
                MessageBox.Show("Passwords are not the same. Try again.",
                    "Corresponding Password Error.", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void btnRegisAsRunnerCancel_Click(object sender, EventArgs e)
        {
            tabControlPages.SelectedTab = MSMainPage;
        }

        private void btnRegRunnerBack_Click(object sender, EventArgs e)
        {
            tabControlPages.SelectedTab = MSMainPage;
        }

        // 2nd Button "I want to sponsor a Runner"
        private void btnSponsorRunner_Click(object sender, EventArgs e)
        {
            tabControlPages.SelectedTab = SponsorARunnerPage;
        }
        // 2nd Button "I want to sponsor a Runner"

        private static int i;
        private void btnMinusAmt_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i -= 10;
            }
            lblSponARunrAmt.Text = i.ToString();
        }

        private void btnAmtPlus_Click(object sender, EventArgs e)
        {
            i += 10;
            lblSponARunrAmt.Text = i.ToString();
        }

        private void tbAmtToDonate_TextChanged(object sender, EventArgs e)
        {
            int num = -1;
            if (tbAmtToDonate.Text.ToString() == "")
            {
                //MessageBox.Show("Error. This textbox only accepts positive integers. " +
                //    "Please check again.", "Invalid Number", MessageBoxButtons.RetryCancel,
                //    MessageBoxIcon.Exclamation);
            }

            else if (Int32.Parse(tbAmtToDonate.Text) < 0)
            {
                MessageBox.Show("Error. This textbox only accepts positive integers. " +
                    "Please check again.", "Invalid Number", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Exclamation);
            }

            else if ((Int32.Parse(tbAmtToDonate.Text) > 0))
            {
                lblSponARunrAmt.Text = tbAmtToDonate.Text.ToString();

                tbAmtToDonate.Text = lblSponARunrAmt.Text.ToString();
                tbAmtToDonate.Refresh();
            }
        }

        //For Sponsorship Cfm Page


        private void btnSponARunrBack_Click(object sender, EventArgs e)
        {
            tabControlPages.SelectedTab = MSMainPage;
        }
        private void btnSponARunrPayNow_Click(object sender, EventArgs e)
        {
            lblSponCfmRunrDetails.Text = cbSponARunrRunnerName.Text;
            lblSponCfmAmt.Text = lblSponARunrAmt.Text.ToString();

            tabControlPages.SelectedTab = SponsorshipConfirmationPage;
        }

        private void btnSponARunrCancel_Click(object sender, EventArgs e)
        {
            tabControlPages.SelectedTab = MSMainPage;
        }

        private void btnSponCfmBack_Click(object sender, EventArgs e)
        {
            tabControlPages.SelectedTab = MSMainPage;
        }

        private void btnSponCfmBack2_Click(object sender, EventArgs e)
        {
            tabControlPages.SelectedTab = MSMainPage;
        }
        // ---------------- End of Sponsorship cfm page --------------------

        // 3rd Button "I want to find out more"
        private void btnFindOutMore_Click(object sender, EventArgs e)
        {
            tabControlPages.SelectedTab = FindOutMorePage;
        }
        // 3rd Button "I want to find out more"

        // ---------------------- Find Out More Page --------------------------
        private void btnFindOutMoreBack_Click(object sender, EventArgs e)
        {
            tabControlPages.SelectedTab = MSMainPage;
        }

        private void btnFindOutMoreLoC_Click(object sender, EventArgs e)
        {
            tabControlPages.SelectedTab = FOMListOfCharPage;
        }
        private void btnFindOutMoreMS15_Click(object sender, EventArgs e)
        {
            tabControlPages.SelectedTab = FOMMS15Page;
        }
        // ------------------- End of Find Out More Page -----------------------

        // ---------------------- Find Out More - List Of Charities Page --------------------------
        private void btnListOfCharityBack_Click(object sender, EventArgs e)
        {
            tabControlPages.SelectedTab = FindOutMorePage;
        }
        // ------------------- End of Find Out More - List Of Charities Page -----------------------

        //--------------------- Find Out More - MS2015 Page --------------------------
        private void btnFOMMS15Back_Click(object sender, EventArgs e)
        {
            tabControlPages.SelectedTab = FindOutMorePage;
        }

        //--------------------- End of Find Out More - MS2015 Page --------------------------
    }
}






//-----------------------------------------OLD CODE TO SAVE.-------------------------------------------

//String strConnection = @"Data Source=localhost\SQLExpress;Initial Catalog=MarathonSkills2015;Integrated Security=True";
//SqlConnection con = new SqlConnection(strConnection);
//try
//{
//    con.Open();

//    //------------------------For Gender------------------------
//    SqlCommand sqlCmd = new SqlCommand();
//    sqlCmd.Connection = con;
//    sqlCmd.CommandType = CommandType.Text;
//    sqlCmd.CommandText = "Select * from Gender";

//    SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);
//    DataTable dtRecord = new DataTable();
//    sqlDataAdap.Fill(dtRecord);
//    cbRegisARunnerGender.DataSource = dtRecord;
//    cbRegisARunnerGender.DisplayMember = "Gender";

//    con.Close();
//}
//catch (Exception ex)
//{
//    MessageBox.Show(ex.Message);
//}
//-----------------------------END-----------------------------//