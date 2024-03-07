using SaoPauloWindowsForms.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaoPauloWindowsForms
{
    public partial class RunnerMenuForm : Form
    {
        public RunnerMenuForm()
        {
            InitializeComponent();

            this.Load += RunnerMenuForm_Load;
        }

        DateTime datetime = new DateTime(2018, 09, 05);
        private void RunnerMenuForm_Load(object sender, EventArgs e)
        {
            Size = new Size(720, 480);
            StartPosition = FormStartPosition.CenterScreen;

            //for countdown
            Timer t = new Timer();
            t.Interval = 500;
            t.Tick += new EventHandler(t_Tick);
            TimeSpan ts = datetime.Subtract(DateTime.Now);
            lblTime.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            //for RegistForAnEvent
            lblRegistAnEventBackCd.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            //for RegistForAnEventCfmPage
            lblRegistForEventCfmCd.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            //For EditProfilePage
            lblEditProfileCd.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");

            t.Start();

            // OPEN DATABASE CONNECTION
            String strConnection = @"Data Source=localhost\SQLExpress;Initial Catalog=MarathonSkills2015;Integrated Security=True";
            SqlConnection con = new SqlConnection(strConnection);
            //------------------------For Charity Details DropDown------------------------
            try
            {
                con.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT CharityName FROM [dbo].[Charity]";

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);
                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                cbRegistAnEventCharity.DataSource = dtRecord;
                cbRegistAnEventCharity.DisplayMember = "CharityName";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Condition ? True : false; INLINE IF Operator
            //tbUsername.Text = 1 < 5 ? "less than 5" : "more than 5";

            tbEditProfileEmail.Text = LoginViewModel.Email.ToString();

            //For Runner Edit Profile First Name
            ActiveControl = lblEditProfileFName;
            tbEditProfileFName.GotFocus += new EventHandler(TextGotFocusFN);
            tbEditProfileFName.LostFocus += new EventHandler(TextLostFocusFN);

            //For Runner Edit Profile Last name
            ActiveControl = lblEditProfileLName;
            tbEditProfileLName.GotFocus += new EventHandler(TextGotFocusLN);
            tbEditProfileLName.LostFocus += new EventHandler(TextLostFocusLN);

        }

        //AUTO GENERATED FOR DROPDOWN.
        private void RunnerMenuForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marathonSkills2015DataSet.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.marathonSkills2015DataSet.Country);
            // TODO: This line of code loads data into the 'marathonSkills2015DataSet.Gender' table. You can move, or remove it, as needed.
            this.genderTableAdapter.Fill(this.marathonSkills2015DataSet.Gender);

        }
        public void t_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = datetime.Subtract(DateTime.Now);
            lblTime.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            //for RegistForAnEvent
            lblRegistAnEventBackCd.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            //for RegistForAnEventCfmPage
            lblRegistForEventCfmCd.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            //For EditProfilePage
            lblEditProfileCd.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");

            //END
        }

        //FOR FIRST AND LASTNAME PlaceHolder
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
        //-----------------END----------------- FOR FIRST AND LASTNAME PlaceHolder

        private void dgHeader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRMenuBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 mainMenuForm = new Form1();
            mainMenuForm.Size = new Size(720, 480);
            mainMenuForm.StartPosition = FormStartPosition.CenterScreen;
            mainMenuForm.tabControlPages.SelectTab("LoginPage");
            mainMenuForm.Show();
        }

        private void btnRunnerLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 mainMenuForm = new Form1();
            mainMenuForm.Size = new Size(720, 480);
            mainMenuForm.StartPosition = FormStartPosition.CenterScreen;
            mainMenuForm.tabControlPages.SelectTab("LoginPage");
            mainMenuForm.Show();
        }

        //BUTTONS IN FORM
        private void btnRegisterEvent_Click(object sender, EventArgs e)
        {
            tabRMenuControlPages.SelectedTab = RegistForEventPage;
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            tabRMenuControlPages.SelectedTab = RunnerEditProfilePage;
        }

        private void btnContactInfoRunner_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For more information about Marathon Skills, please " + "\n" +
                "contact the coordinators using these contact details" + "\n" + "\n" +
                "Phone: +55 11 9988 7766" + "\n" + "\n" + "Email: coordinators@marathonskills.org",
                "Contact Information", MessageBoxButtons.OK);
        }

        //Runner's Register for an event Form

        //Calculation Of PRICING in Runner's Event Form
        int totalCost = 0;
        int[] checkBoxStatus = { 0, 0, 0 };
        int[] radioBtnStatus = { 0, 0, 0 };
        private void CalculatePrice()
        {
            if (chBRegistAnEventFM.Checked && checkBoxStatus[0] == 0)
            {
                totalCost += 145;
                checkBoxStatus[0] = 1;
                UpdateCost(totalCost);
            }
            else if (!chBRegistAnEventFM.Checked && checkBoxStatus[0] == 1)
            {
                totalCost -= 145;
                checkBoxStatus[0] = 0;
                UpdateCost(totalCost);
            }
            if (chBRegistAnEventHM.Checked && checkBoxStatus[1] == 0)
            {
                totalCost += 75;
                checkBoxStatus[1] = 1;
                UpdateCost(totalCost);
            }
            else if (!chBRegistAnEventHM.Checked && checkBoxStatus[1] == 1)
            {
                totalCost -= 75;
                checkBoxStatus[1] = 0;
                UpdateCost(totalCost);
            }
            if (chBRegistAnEventFR.Checked && checkBoxStatus[2] == 0)
            {
                totalCost += 20;
                checkBoxStatus[2] = 1;
                UpdateCost(totalCost);
            }
            else if (!chBRegistAnEventFR.Checked && checkBoxStatus[2] == 1)
            {
                totalCost -= 20;
                checkBoxStatus[2] = 0;
                UpdateCost(totalCost);
            }

            if (rbRegistAnEventOA.Checked && radioBtnStatus[0] == 0)
            {
                totalCost += 0;
                radioBtnStatus[0] = 1;
                UpdateCost(totalCost);
            }
            else if (!rbRegistAnEventOA.Checked && radioBtnStatus[0] == 1)
            {
                totalCost -= 0;
                radioBtnStatus[0] = 0;
                UpdateCost(totalCost);
            }
            if (rbRegistAnEventOB.Checked && radioBtnStatus[1] == 0)
            {
                totalCost += 20;
                radioBtnStatus[1] = 1;
                UpdateCost(totalCost);
            }
            else if (!rbRegistAnEventOB.Checked && radioBtnStatus[1] == 1)
            {
                totalCost -= 20;
                radioBtnStatus[1] = 0;
                UpdateCost(totalCost);
            }
            if (rbRegistAnEventOC.Checked && radioBtnStatus[2] == 0)
            {
                totalCost += 45;
                radioBtnStatus[2] = 1;
                UpdateCost(totalCost);
            }
            else if (!rbRegistAnEventOC.Checked && radioBtnStatus[2] == 1)
            {
                totalCost -= 45;
                radioBtnStatus[2] = 0;
                UpdateCost(totalCost);
            }
        }

        private void UpdateCost(int totalCost)
        {
            lblRegistAnEventRegCostAmt.Text = "$" + totalCost.ToString();
        }

        //Rest of the buttons, such as Event Buttons, Back, Logout.
        // -- EVENT BUTTONS
        private void chBRegistAnEventFM_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }
        private void chBRegistAnEventHM_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }
        private void chBRegistAnEventFR_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }
        private void rbRegistAnEventOA_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }
        private void rbRegistAnEventOB_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }
        private void rbRegistAnEventOC_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }
        // -- END --
        // Other buttons
        private void btnRegistAnEventBack_Click(object sender, EventArgs e)
        {
            tabRMenuControlPages.SelectedTab = RunnerMainMenu;
        }

        private void btnRegistAnEventLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Form1 fm1 = new Form1();
            fm1.Size = new Size(720, 480);
            fm1.StartPosition = FormStartPosition.CenterScreen;
            fm1.tabControlPages.SelectTab("LoginPage");
            fm1.Show();
        }

        private void btnRegistAnEventReg_Click(object sender, EventArgs e)
        {
            tabRMenuControlPages.SelectedTab = RegistForEventCfmPage;
        }

        private void btnRegistAnEventCancel_Click(object sender, EventArgs e)
        {
            tabRMenuControlPages.SelectedTab = RunnerMainMenu;
        }

        //REGISTER AN EVENT CONFIRMATION SCREEN.
        private void btnRegistForEventCfmBack_Click(object sender, EventArgs e)
        {
            tabRMenuControlPages.SelectedTab = RunnerMainMenu;
        }

        private void btnRegistForEventCfmLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 mainMenuForm = new Form1();
            mainMenuForm.Size = new Size(720, 480);
            mainMenuForm.StartPosition = FormStartPosition.CenterScreen;
            mainMenuForm.tabControlPages.SelectTab("LoginPage");
            mainMenuForm.Show();
        }
        private void btnRegistForEventCfmOK_Click(object sender, EventArgs e)
        {
            tabRMenuControlPages.SelectedTab = RunnerMainMenu;
        }

        //For EditProfilePage
        private void btnEditProfileBack_Click(object sender, EventArgs e)
        {
            tabRMenuControlPages.SelectedTab = RunnerMainMenu;
        }

        private void btnEditProfileLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 mainMenuForm = new Form1();
            mainMenuForm.Size = new Size(720, 480);
            mainMenuForm.StartPosition = FormStartPosition.CenterScreen;
            mainMenuForm.tabControlPages.SelectTab("LoginPage");
            mainMenuForm.Show();
        }

        //HTTP UPDATE
        private void btnEditProfileSave_Click(object sender, EventArgs e)
        {
            string EditProfileCountryString = cbEditProfileCountry.SelectedValue.ToString();
            string EditProfileGenderString = cbEditProfileGender.SelectedValue.ToString();
            string DateOfBirthString = dtpEditProfileDOB.Value.ToString();

            String strConnection = @"Data Source=localhost\SQLExpress;Initial Catalog=MarathonSkills2015;Integrated Security=True";

            string query = "UPDATE [dbo].[User] SET Email='" + this.tbEditProfileEmail.Text +
                "',FirstName='" + this.tbEditProfileFName.Text + "',LastName='" +
                this.tbEditProfileLName.Text + "', Password='" + this.tbEditProfilePass.Text +
                "' WHERE Email='" + this.tbEditProfileEmail.Text + "'; ";

            string query2 = "UPDATE [dbo].[Runner] SET Email='" + this.tbEditProfileEmail.Text +
            "',Gender='" + EditProfileGenderString + "',DateOfBirth='" +
            DateOfBirthString + "',CountryCode='" + EditProfileCountryString +
            "' WHERE Email='" + this.tbEditProfileEmail.Text + "'; ";

            string query3 = "UPDATE [dbo].[User] SET Email='" + this.tbEditProfileEmail.Text +
                "',FirstName='" + this.tbEditProfileFName.Text + "',LastName='" +
                this.tbEditProfileLName.Text +
                "' WHERE Email='" + this.tbEditProfileEmail.Text + "'; ";

            //string query3 = "UPDATE [dbo].[User] SET Email='" + this.tbEditProfileEmail.Text +
            //    "',FirstName='" + this.tbEditProfileFName.Text + "',LastName='" +
            //    this.tbEditProfileLName.Text + "', Password='" + this.tbEditProfilePass.Text +
            //    "' WHERE Email='" + this.tbEditProfileEmail.Text + "'; ";

            //string query4 = "UPDATE [dbo].[Runner] SET Email='" + this.tbEditProfileEmail.Text +
            //"',Gender='" + EditProfileGenderString + "',DateOfBirth='" +
            //DateOfBirthString + "',CountryCode='" + EditProfileCountryString +
            //"' WHERE Email='" + this.tbEditProfileEmail.Text + "'; ";

            SqlConnection con = new SqlConnection(strConnection);
            //SqlCommand cmdDataBase = new SqlCommand(query, con);
            SqlDataReader myReader;
            SqlDataReader myReader2;

            try
            {
                con.Open();
                //Without password
                if (tbEditProfilePass.Text == "")
                {
                    SqlCommand cmdDataBase3 = new SqlCommand(query3, con);
                    myReader = cmdDataBase3.ExecuteReader();
                    MessageBox.Show("Saved. Password remains the same.");
                }

                //With Password
                else if (tbEditProfilePass.Text == tbEditProfilePassAgain.Text)
                {
                    SqlCommand cmdDataBase = new SqlCommand(query, con);
                    myReader = cmdDataBase.ExecuteReader();

                    MessageBox.Show("Data are successfully updated. " +
                        "Password is updated on " + DateTime.Now);
                    while (myReader.Read())
                    { }
                }

                //Query2 with Country and Gender
                else if (EditProfileGenderString != "")
                {
                    SqlCommand cmdDataBase2 = new SqlCommand(query2, con);
                    myReader2 = cmdDataBase2.ExecuteReader();
                    MessageBox.Show("Saved. All fields are updated.");
                }
            }
            catch (Exception ex)
            { }

        }

        //----------------------------END---------------------
    }
}
