using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration.Install;
using System.Configuration;
using System.Globalization;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

namespace Finance_Management_System
{
    public partial class Admin_Dashboard : MetroForm
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["newcon"].ConnectionString);
        ReportDocument crystal = new ReportDocument();
        public Admin_Dashboard()
        {
            InitializeComponent();
            timer.Start();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabPage1;
            crystal.Load(@"C:\Users\Soni\documents\visual studio 2015\Projects\Finance_Management_System\Finance_Management_System\CrystalReport_SingleCustomer.rpt");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //This is For Genereal Date and Time In Admin Dashboard
            DateTime dateTime = DateTime.Now;
            this.lbl_Timer.Text = dateTime.ToString();
        }

        private void pictureBox_operations_Add_User_Click(object sender, EventArgs e)
        {
            metroTabControl_Operation_Inside.SelectedTab = Add_Cust_Metro;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            metroTabControl_Operation_Inside.SelectedTab = Del_Cust_Metro;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            metroTabControl_Operation_Inside.SelectedTab = Update_Cust_Metro;
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(@"Select * from [Customer] ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_Update.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            metroTabControl_Operation_Inside.SelectedTab = View_Cust_Metro;
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(@"Select * FROM [Customer]", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_ViewAll.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void pictureBox_Collection_Single_Cust_Click(object sender, EventArgs e)
        {
            metroTabControl_Collection.SelectedTab = Metro_Page_Single_Customer;
        }

        private void pictureBox_Collection_Bulk_Click(object sender, EventArgs e)
        {
            metroTabControl_Collection.SelectedTab = Metro_Page_Bulk_Customer;
        }

        private void pictureBox_Collection_Full_Payment_Click(object sender, EventArgs e)
        {
            metroTabControl_Collection.SelectedTab = Metr_Page_Full_Payment;
            try
            {
                DateTime thisDay = DateTime.Today;

                conn.Open();
                SqlDataAdapter da1 = new SqlDataAdapter(@"Select * from [Transaction] where Attendance = @att AND Transaction_Date=@date", conn); //Query Extend -> AND DATE=TODAYS DATE FROM TRANSACTION TABLE WITH HELP OF CID
                da1.SelectCommand.Parameters.AddWithValue("@att", false);
                da1.SelectCommand.Parameters.AddWithValue("@date", thisDay.ToString("d"));
                da1.TableMappings.Add("Table", "Transaction");
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView_Full_Payment_Settlement.DataSource = dt1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void pictureBox_Report_Cust_Detail_Click(object sender, EventArgs e)
        {
            metroTabControl_Report.SelectedTab = metro_Page_Cust_detail;
        }

        private void pictureBox_Report_Daily_Consolidate_Click(object sender, EventArgs e)
        {
            metroTabControl_Report.SelectedTab = metro_Page_Daily_Consolidated;
        }

        private void pictureBox_Individual_Cust_Report_Click(object sender, EventArgs e)
        {
            metroTabControl_Report.SelectedTab = metro_Page_Indivudal;
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Finance_Login obj = new Finance_Login();
            //Very Important Line Below :D :) 
            obj.Closed += (s, args) => this.Close();
            obj.Show();
        }

        private void btn_Register_Cancel_Click(object sender, EventArgs e)
        {
            //KIND OF REFRESH
            txbox_Username.Text = txtbox_Address.Text=txtBox_Garantor_Name.Text=txtbox_Gaurantor_Address.Text=txtbox_Gaurantor_Mobile.Text=txtbox_Mobile.Text=txtBox_Occupation.Text=txtbox_Period.Text=txtbox_Principal.Text=txtbox_ROI.Text=txtbox_Total_Amount.Text=metroTextBox1.Text="";
            Radio_Male.Checked = Radio_Female.Checked = false;
            IssueDate_Picker.ResetText();
        }
        String Value = null;
        private void btn_Register_Save_Click(object sender, EventArgs e)
        {
            try
            {
                //All the Details will be stored into two tables - Customer and Financer (AutoIncremented) ID's 
                if (txbox_Username.Text!=null && txtbox_Address.Text!=null && txtBox_Garantor_Name.Text!=null && txtbox_Gaurantor_Address.Text!=null && txtbox_Gaurantor_Mobile.Text!=null && txtbox_Mobile.Text!=null && txtBox_Occupation.Text!=null && txtbox_Period.Text!=null && txtbox_Principal.Text!=null && metroTextBox1.Text!=null && (Radio_Male.Checked==true || Radio_Female.Checked==true))
                {
                    MessageBox.Show("You Have Vaildated All Of the Criteria Given!! Now Your Data Will be Procceded");
                    if (Radio_Male.Checked)
                    {
                        Value = Radio_Male.Text;
                    }
                    else
                    {
                        Value = Radio_Female.Text;
                    }
                    
                    //Calculation Would be Done Here and Stored into Float Data Types and then Inserted into DB
                    //Rate & TA Should be Calculated based on P N and EMI(Daily) and Stored into DB
                    float p = float.Parse(txtbox_Principal.Text);
                    float n = float.Parse(txtbox_Period.Text);
                    float edi = float.Parse(metroTextBox1.Text);
                    float ta = (edi*n); //This is Our TA(P+I)=EDI*N = 125*100=12500 -> DONE
                    float i = (ta-p); //Total Interest in Rs. 12500-10000 = 2500 If Divided by n Will Give Daily Interest
                    float roi = (i*100)/p;
                    float lr = ta; //Loan_Remain - LR = principal outstanding = TA-edi //Loan_Paid = EDI = Amount_Paid - Initially it Would be equal to TA
                    DateTime sd = IssueDate_Picker.Value.Date.AddDays(1); //Start_Date - SD = Issue Date + Next Day
                    DateTime ed = IssueDate_Picker.Value.Date.AddDays(n); //End_Date - ED = Issue Date + Loan_Period
                    float lf = 0;
                    float lp = ta - lr;
                    //End of Calculation

                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"Insert into [Customer] (C_Name,Gender,Mobile,Address,Occupation,G_Name,G_Mobile,G_Address,principal,rate,Loan_Period,EDI,Total_Amount,Loan_Remain,Late_Fine,issue_Date,Start_Date,End_Date,Status,Loan_Paid) values (@name,@gen,@mob,@add,@occ,@gname,@gmob,@gadd,@p,@r,@n,@edi,@ta,@lr,@lf,@date,@sd,@ed,@stat,@lp);SELECT SCOPE_IDENTITY()", conn);
                    cmd.Parameters.AddWithValue("name", txbox_Username.Text);
                    cmd.Parameters.AddWithValue("gen", Value);
                    cmd.Parameters.AddWithValue("mob", txtbox_Mobile.Text);
                    cmd.Parameters.AddWithValue("add", txtbox_Address.Text);
                    cmd.Parameters.AddWithValue("occ", txtBox_Occupation.Text);
                    cmd.Parameters.AddWithValue("gname", txtBox_Garantor_Name.Text);
                    cmd.Parameters.AddWithValue("gmob", txtbox_Gaurantor_Mobile.Text);
                    cmd.Parameters.AddWithValue("gadd", txtbox_Gaurantor_Address.Text);
                    cmd.Parameters.AddWithValue("p", p);
                    cmd.Parameters.AddWithValue("r", roi); //Value of ROI
                    cmd.Parameters.AddWithValue("n", n);
                    cmd.Parameters.AddWithValue("edi", edi);
                    cmd.Parameters.AddWithValue("ta", ta); 
                    cmd.Parameters.AddWithValue("lr", lr); 
                    cmd.Parameters.AddWithValue("lf", lf); 
                    cmd.Parameters.AddWithValue("date", IssueDate_Picker.Value.Date);
                    cmd.Parameters.AddWithValue("sd", sd);
                    cmd.Parameters.AddWithValue("ed", ed);
                    cmd.Parameters.AddWithValue("stat", false); //Status Bit - Set Status bit to False - unpaid customer initialyy
                    cmd.Parameters.AddWithValue("lp", lp);
                    //LOGIC FOR TRANSACTION TABLE---------------->
                    int cid = Convert.ToInt32(cmd.ExecuteScalar());
                    DateTime temp ;
                    //To Have A Loop Inside Insert Query we Have ---> Declare @cnt int;SET @cnt = 0;while @cnt < 100  begin INSERT INTO[Transaction] (C_id, Transaction_Date, Attendance) VALUES (@cid, @temp, @att); SET @cnt = @cnt + 1; end;"
                    //But We will use Insert Query inside for Loop
                    for (temp = sd; temp.Date <= ed.Date; temp = temp.AddDays(1))
                    {
                        SqlCommand cmd1 = new SqlCommand(@"Insert into [Transaction] (C_id, Transaction_Date, Attendance,C_Name) values (@cid, @temp, @att,@name);", conn);
                        cmd1.Parameters.AddWithValue("@cid", cid);
                        cmd1.Parameters.AddWithValue("@temp", temp);
                        //By Default they are not coming - so Unpaid would be defined based on their T_DATE not ATTENDANCE - if come then attendance is true else false
                        cmd1.Parameters.AddWithValue("@att", false);
                        cmd1.Parameters.AddWithValue("@name", txbox_Username.Text);
                        cmd1.ExecuteNonQuery();
                    }
                    txtbox_ROI.Text = roi.ToString();
                    txtbox_Total_Amount.Text = ta.ToString();
                    MessageBox.Show("Account Created Sucessfully!!Click On Reset Button To Reset Values");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void TxtBox_Searchbox_Del_Click(object sender, EventArgs e) //Only Name is Different - Will Work as Textchanged Event
        {
            try
            {
                conn.Open();
                if (ComboBox_Del_Cust.Text == "ID")
                {
                string query = @"SELECT C_id,C_name,Gender,Mobile,Address,Occupation FROM [Customer] WHERE C_id LIKE @tags";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("tags", TxtBox_Searchbox_Del.Text+"%");
                //"%" +TxtBox_Searchbox_Del.Text+ "%"
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                //Dataset ds = new DataSet(); - You Could Use This One Also and just pass ds below => A DataSet holds one or more DataTables.
                da.Fill(dt);
                dataGridView_Del_Cust.DataSource = dt;
                }

                else if (ComboBox_Del_Cust.Text == "Name")
                {
                    string query = @"SELECT C_id,C_name,Gender,Mobile,Address,Occupation FROM [Customer] WHERE C_Name LIKE @tags";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("tags", TxtBox_Searchbox_Del.Text + "%");
                    //"%" +TxtBox_Searchbox_Del.Text+ "%"
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    //Dataset ds = new DataSet(); - You Could Use This One Also and just pass ds below => A DataSet holds one or more DataTables.
                    da.Fill(dt);
                    dataGridView_Del_Cust.DataSource = dt;
                }

                else if (ComboBox_Del_Cust.Text == "Gender")
                {
                    string query = @"SELECT C_id,C_name,Gender,Mobile,Address,Occupation FROM [Customer] WHERE Gender LIKE @tags";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("tags", TxtBox_Searchbox_Del.Text + "%");
                    //"%" +TxtBox_Searchbox_Del.Text+ "%"
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    //Dataset ds = new DataSet(); - You Could Use This One Also and just pass ds below => A DataSet holds one or more DataTables.
                    da.Fill(dt);
                    dataGridView_Del_Cust.DataSource = dt;
                }

                else if (ComboBox_Del_Cust.Text == "Mobile")
                {
                    string query = @"SELECT C_id,C_name,Gender,Mobile,Address,Occupation FROM [Customer] WHERE Mobile LIKE @tags";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("tags", TxtBox_Searchbox_Del.Text + "%");
                    //"%" +TxtBox_Searchbox_Del.Text+ "%"
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    //Dataset ds = new DataSet(); - You Could Use This One Also and just pass ds below => A DataSet holds one or more DataTables.
                    da.Fill(dt);
                    dataGridView_Del_Cust.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Btn_Display_Everything_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(@"Select * FROM [Customer]", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_Del_Cust.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Radio_Paid_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open(); 
                //True - 1 - Paid
                //False - 0 - Not Paid
                string query = @"SELECT * FROM [Customer] WHERE Status='True'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_Del_Cust.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Radio_Unpaid_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                //True - 1 - Paid
                //False - 0 - Not Paid
                string query = @"SELECT * FROM [Customer] WHERE Status='False'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_Del_Cust.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        int global;
        private void dataGridView_Del_Cust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_Del_Cust.Rows[e.RowIndex];
                global = (int)row.Cells["C_id"].Value;
                
                
            }
        }
        
        private void Btn_Del_Customer_Click(object sender, EventArgs e)
        {
            //QUERY - Delete from Customer where C_id = '43';Delete from Finance where C_id = '43';
            try
            {
                
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("Delete from [Customer] where C_id = @num", conn);//If any error comes addd semicolon at the end of sql query
                da.SelectCommand.Parameters.AddWithValue("@num", global);
                da.TableMappings.Add("Table", "Customer");
                //da.TableMappings.Add("Table1", "Finance");
                da.Fill(ds);
                dataGridView_Del_Cust.Refresh();
                Btn_Display_Everything.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            //Nothing Here - USELESS
        }

        private void Btn_Daily_Display_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime thisDay = DateTime.Today;
                
                conn.Open();
                SqlDataAdapter da1 = new SqlDataAdapter(@"Select * from [Transaction] where Attendance = @att AND Transaction_Date=@date", conn); //Query Extend -> AND DATE=TODAYS DATE FROM TRANSACTION TABLE WITH HELP OF CID
                da1.SelectCommand.Parameters.AddWithValue("@att", false);
                da1.SelectCommand.Parameters.AddWithValue("@date", thisDay.ToString("d"));
                da1.TableMappings.Add("Table", "Transaction");
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView_Daily.DataSource = dt1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Btn_Daily_Save_Click(object sender, EventArgs e)
        {
            //Nothing Goes Here 
        }
        int global_daily_cons;
        private void dataGridView_Daily_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_Daily.Rows[e.RowIndex];
                global_daily_cons = (int)row.Cells["C_id"].Value;
                //We will use this global_daily_cons Value into Save Button Also
            }
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from [Customer] where C_id=@custid;", conn);
                cmd.Parameters.AddWithValue("custid",global_daily_cons);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    txtbox_Daily_Name.Text = rdr[1].ToString();
                    txtbox_Daily_Gender.Text = rdr[2].ToString();
                    txtbox_Daily_Mobile.Text = rdr[3].ToString();
                    txtbox_Daily_Address.Text = rdr[4].ToString();
                    txtbox_Daily_Occupation.Text = rdr[5].ToString();
                    txtbox_Daily_PRincipal.Text = rdr[9].ToString();
                    txtbox_Daily_ROI.Text = rdr[10].ToString();
                    txtbox_Daily_Loan_Period.Text = rdr[11].ToString();
                    txtbox_Daily_EDI.Text = rdr[12].ToString();
                    txtbox_Daily_Total_Amount.Text = rdr[13].ToString();
                    txtbox_Daily_Laon_Remain.Text = rdr[14].ToString();
                    txtbox_Daily_Fine.Text = rdr[15].ToString();
                    txtbox_ID.Text = rdr[16].ToString();
                    txtbox_Daily_SD.Text = rdr[17].ToString();
                    txtbox_Daily_ED.Text = rdr[18].ToString();
                    txtbox_Daily_Loan_Paid.Text = rdr[20].ToString();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            finally {
                rdr.Close();
                conn.Close();
            }
        }

        private void btn_Save_Daily_Click(object sender, EventArgs e)
        {
            SqlDataReader myrdr = null;
            SqlCommand mycmd = null;
            DateTime today = DateTime.Today; //Stores Todays Date with Timing
            DateTime tdate = today.Date; // Todays Date 
            DateTime pdate = tdate.AddDays(-1); // yesterday Date  - Not Important Right Now
            DateTime sdate = DateTime.MinValue;//Will Store Start Date of That CID selected - You have to Set at Least a Minimum Value 
            DateTime edate = DateTime.MinValue;//Will Store End Date of That CID selected - You have to Set at Least a Minimum Value 
            DateTime idate = DateTime.MinValue; //To Store Issue Date
            int cid = global_daily_cons; //Stored Cid Value of Particular Selected Row in Datagridview
            float lp = 0; 
            float lf = 0;
            float lr = 0;
            float ta = 0;
            float edi = 0;

            try
            { //#THE FETCHER FROM DB :) :D 
                conn.Open();
                mycmd = new SqlCommand(@"SELECT EDI,Total_Amount,Loan_Remain,Late_Fine,issue_Date,Start_Date,End_Date,Loan_Paid FROM [Customer] Where C_id=@cid", conn);
                mycmd.Parameters.AddWithValue("cid", cid);
                myrdr = mycmd.ExecuteReader();
                while (myrdr.Read())
                {
                    edi= (float)myrdr.GetDouble(myrdr.GetOrdinal("EDI"));
                    ta = (float)myrdr.GetDouble(myrdr.GetOrdinal("Total_Amount"));
                    lr = (float)myrdr.GetDouble(myrdr.GetOrdinal("Loan_Remain"));
                    lf = (float)myrdr.GetDouble(myrdr.GetOrdinal("Late_Fine"));
                    lp = (float)myrdr.GetDouble(myrdr.GetOrdinal("Loan_Paid"));
                    idate = (DateTime)myrdr["issue_Date"];
                    sdate = (DateTime)myrdr["Start_Date"]; 
                    edate = (DateTime)myrdr["End_Date"];
                }

              
                myrdr.Close();
                //PART 1 BEGINS HERE 
                if (tdate.Equals(sdate)) //Is Start Date = Todays Date - 1st Condition (Regular Customer)
                {
                    MessageBox.Show("Yes this is the Start Date of this particular CID");
                    //Update attendance=True in [Transaction] && Update LP/LF/LR  in [Customer]

                    lp = lp + edi; //Main Logic Starts From Here
                    lf = lf + 0;
                    lr = ta - lp;
                    mycmd = new SqlCommand(@"UPDATE [Transaction] SET Attendance=@att WHERE C_id=@cid AND Transaction_Date=@trans ", conn);
                    mycmd.Parameters.AddWithValue("cid", cid);
                    mycmd.Parameters.AddWithValue("att", true);
                    mycmd.Parameters.AddWithValue("trans", tdate);
                    mycmd.ExecuteNonQuery();

                    mycmd = new SqlCommand(@"UPDATE [Customer] SET Loan_Remain=@lr,Late_Fine=@lf,Loan_Paid=@lp WHERE C_id=@cid ", conn);
                    mycmd.Parameters.AddWithValue("cid", cid);
                    mycmd.Parameters.AddWithValue("lr", lr);
                    mycmd.Parameters.AddWithValue("lf", lf);
                    mycmd.Parameters.AddWithValue("lp", lp);
                    mycmd.ExecuteNonQuery();
                    MessageBox.Show("Succesfully Update The Attendance in [Transaction] & Value IN [CUSTOMER]for this CID Check DB!! ");
                }


                //PART 2 BEGINS HERE 
                else if ((!tdate.Equals(sdate)) && (!tdate.Equals(edate)))
                {
                    MessageBox.Show("This is not the Starting Date of this particular CID and also it is not even the last date");
                    //Loop to Count How Many Days Was there Before this Date Whose Attendance was False for this CID
                    int final = 0;
                    for (DateTime loop = sdate.AddDays(1); loop.Date < tdate; loop = loop.AddDays(1))
                    {
                        //MessageBox.Show(loop.ToString("d"));
                        SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) FROM [Transaction] WHERE C_id=@cid AND Transaction_Date=@trans AND Attendance=@att;", conn);
                        cmd.Parameters.AddWithValue("@cid", cid);
                        cmd.Parameters.AddWithValue("@trans", loop);
                        cmd.Parameters.AddWithValue("@att", false);
                        final = Convert.ToInt32(cmd.ExecuteScalar());

                    }
                    // MessageBox.Show(final.ToString());

                    if (final == 0)
                    {
                        //that means customer is regular and hence todays operation wud be done as regular(Same Code Here)
                        MessageBox.Show("Well !! This Customer Seems to Be Regular Uptil Now!!");

                        mycmd = new SqlCommand(@"UPDATE [Transaction] SET Attendance=@att WHERE C_id=@cid AND Transaction_Date=@trans ", conn);
                        mycmd.Parameters.AddWithValue("cid", cid);
                        mycmd.Parameters.AddWithValue("att", true);
                        mycmd.Parameters.AddWithValue("trans", tdate);
                        mycmd.ExecuteNonQuery();

                        mycmd = new SqlCommand(@"UPDATE [Customer] SET Loan_Remain=@lr,Late_Fine=@lf,Loan_Paid=@lp WHERE C_id=@cid ", conn);
                        mycmd.Parameters.AddWithValue("cid", cid);
                        mycmd.Parameters.AddWithValue("lr", lr);
                        mycmd.Parameters.AddWithValue("lf", lf);
                        mycmd.Parameters.AddWithValue("lp", lp);
                        mycmd.ExecuteNonQuery();
                        MessageBox.Show("Succesfully Update The Attendance in [Transaction] & Value IN [CUSTOMER]for this CID Check DB!! ");

                    }
                    if (!(final == 0) && final > 0)
                    {
                        //it means Customer wasn't regular before and was absent for (Final) Times so Charge Wud be Imparted on him/ her
                        MessageBox.Show("Your Customer Was Not Regular - So Fine of 20Rs. Would Be Imparted on it.");

                        lf += (final * 20); //Rs 20. FINE IS CHARGED FROM HERE :D 
                        ta += lf;
                        lr += lf;
                        float tedi = final * edi; //(ex:- 2*125=250 Rs. Till Now EDI Only Which is not Paid)

                        //We Have to Set the Attendance True For All the False Ones
                        for (DateTime loop = sdate.AddDays(1); loop.Date < tdate; loop = loop.AddDays(1))
                        {
                            SqlCommand cmd = new SqlCommand(@"UPDATE [Transaction] SET Attendance=@up WHERE C_id=@cid AND Transaction_Date=@trans AND Attendance=@att;", conn);
                            cmd.Parameters.AddWithValue("@cid", cid);
                            cmd.Parameters.AddWithValue("@trans", loop);
                            cmd.Parameters.AddWithValue("@up", true);
                            cmd.Parameters.AddWithValue("@att", false);
                            cmd.ExecuteNonQuery();

                        }
                        //After That We Will perform Attendance And Calculation for today Date as Follows
                        lp += edi + lf + tedi;
                        lf = 0;
                        lr = ta - lp;
                        //Updating Todays Attendance in the [Transaction] - Table
                        mycmd = new SqlCommand(@"UPDATE [Transaction] SET Attendance=@att WHERE C_id=@cid AND Transaction_Date=@trans ", conn);
                        mycmd.Parameters.AddWithValue("cid", cid);
                        mycmd.Parameters.AddWithValue("att", true);
                        mycmd.Parameters.AddWithValue("trans", tdate);
                        mycmd.ExecuteNonQuery();

                        //Updating the Caluclations in the DB Table - [Customer]
                        mycmd = new SqlCommand(@"UPDATE [Customer] SET Total_Amount=@ta,Loan_Remain=@lr,Late_Fine=@lf,Loan_Paid=@lp WHERE C_id=@cid ", conn);
                        mycmd.Parameters.AddWithValue("cid", cid);
                        mycmd.Parameters.AddWithValue("ta", ta);
                        mycmd.Parameters.AddWithValue("lr", lr);
                        mycmd.Parameters.AddWithValue("lf", lf);
                        mycmd.Parameters.AddWithValue("lp", lp);
                        mycmd.ExecuteNonQuery();
                        MessageBox.Show("Succesfully Update The Attendance in [Transaction] & Calculation In [CUSTOMER]for this CID Check DB!! ");

                    }

                }

                //PART 3 BEGINS HERE --> Checking for Chello divase chatki gyo evo customer 
                else if (tdate==edate)
                {

                    //Remember this is the last date...here also you should calculate the The Previous False Customer absent
                    //as you have done above...the Only Difference is that it will prompt a Message box
                    
MessageBox.Show("This is the Last Date of Collection for This Customer And Hence If He Didnt Pay The Amount to Be Collected Today to You. Then Kindly Collect These Money From him/her and Also Extra Charge of 20Rs. Till It Would be Unpaid Customer.So Make Him Paid Customer Go To Full Payment Settlement Section");
                    int final = 0;
                    for (DateTime loop = sdate.AddDays(1); loop.Date < tdate; loop = loop.AddDays(1))
                    {
                        //MessageBox.Show(loop.ToString("d"));
                        SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) FROM [Transaction] WHERE C_id=@cid AND Transaction_Date=@trans AND Attendance=@att;", conn);
                        cmd.Parameters.AddWithValue("@cid", cid);
                        cmd.Parameters.AddWithValue("@trans", loop);
                        cmd.Parameters.AddWithValue("@att", false);
                        final = Convert.ToInt32(cmd.ExecuteScalar());
                        if (final == 0)
                        {
                            //that means customer is regular and hence todays operation wud be done as regular(Same Code Here)
                            MessageBox.Show("Well !! This Customer Seems to Be Regular Uptil Now!!");

                            mycmd = new SqlCommand(@"UPDATE [Transaction] SET Attendance=@att WHERE C_id=@cid AND Transaction_Date=@trans ", conn);
                            mycmd.Parameters.AddWithValue("cid", cid);
                            mycmd.Parameters.AddWithValue("att", true);
                            mycmd.Parameters.AddWithValue("trans", tdate);
                            mycmd.ExecuteNonQuery();

                            mycmd = new SqlCommand(@"UPDATE [Customer] SET Loan_Remain=@lr,Late_Fine=@lf,Loan_Paid=@lp WHERE C_id=@cid ", conn);
                            mycmd.Parameters.AddWithValue("cid", cid);
                            mycmd.Parameters.AddWithValue("lr", lr);
                            mycmd.Parameters.AddWithValue("lf", lf);
                            mycmd.Parameters.AddWithValue("lp", lp);
                            mycmd.ExecuteNonQuery();
                            MessageBox.Show("Thats It Done.Now Your Customer Is Paid Customer.Full Amount Has been Recieved.");
                            
                        }
                        if (!(final == 0) && final > 0)
                        {
                            //it means Customer wasn't regular before and was absent for (Final) Times so Charge Wud be Imparted on him/ her
                            MessageBox.Show("Your Customer Was Not Regular - So Fine of 20Rs. Would Be Imparted on it.");

                            lf += (final * 20); //Rs 20. FINE IS CHARGED FROM HERE :D 
                            ta += lf;
                            lr += lf;
                            float tedi = final * edi; //(ex:- 2*125=250 Rs. Till Now EDI Only Which is not Paid)

                            //We Have to Set the Attendance True For All the False Ones
                            for (DateTime loop1 = sdate.AddDays(1); loop1.Date < tdate; loop1 = loop1.AddDays(1))
                            {
                                SqlCommand cmd1 = new SqlCommand(@"UPDATE [Transaction] SET Attendance=@up WHERE C_id=@cid AND Transaction_Date=@trans AND Attendance=@att;", conn);
                                cmd1.Parameters.AddWithValue("@cid", cid);
                                cmd1.Parameters.AddWithValue("@trans", loop);
                                cmd1.Parameters.AddWithValue("@up", true);
                                cmd1.Parameters.AddWithValue("@att", false);
                                cmd1.ExecuteNonQuery();

                            }
                            //After That We Will perform Attendance And Calculation for today Date as Follows
                            lp += edi + lf + tedi;
                            lf = 0;
                            lr = ta - lp;
                            //Updating Todays Attendance in the [Transaction] - Table
                            mycmd = new SqlCommand(@"UPDATE [Transaction] SET Attendance=@att WHERE C_id=@cid AND Transaction_Date=@trans ", conn);
                            mycmd.Parameters.AddWithValue("cid", cid);
                            mycmd.Parameters.AddWithValue("att", true);
                            mycmd.Parameters.AddWithValue("trans", tdate);
                            mycmd.ExecuteNonQuery();

                            //Updating the Caluclations in the DB Table - [Customer]
                            mycmd = new SqlCommand(@"UPDATE [Customer] SET Total_Amount=@ta,Loan_Remain=@lr,Late_Fine=@lf,Loan_Paid=@lp WHERE C_id=@cid ", conn);
                            mycmd.Parameters.AddWithValue("cid", cid);
                            mycmd.Parameters.AddWithValue("ta", ta);
                            mycmd.Parameters.AddWithValue("lr", lr);
                            mycmd.Parameters.AddWithValue("lf", lf);
                            mycmd.Parameters.AddWithValue("lp", lp);
                            mycmd.ExecuteNonQuery();
                            MessageBox.Show("Succesfully Update The Attendance in [Transaction] & Calculation In [CUSTOMER]for this CID Check DB!! ");

                        }
                    }



                }
                //PART 4 BEGINS HERE --> WHEN NO HOPE REMAINs
                else {
                    MessageBox.Show("Sorry DUDE Can't Figure Out Whether The Problem is With You or My Software :P :D :P ");
                }
                //PART 5 BEGINS HERE  --> CHECKING WHETHER THIS CUSTOMER IS NOW GOING TO BE A PAID CUSTOMER
                if (lp == ta || lr == 0)
                {
                    MessageBox.Show("This Customer is Now A Paid Customer Officially !! ");
                    mycmd = new SqlCommand(@"UPDATE [Customer] SET Status=@st WHERE C_id=@cid ", conn);
                    mycmd.Parameters.AddWithValue("cid", cid);
                    mycmd.Parameters.AddWithValue("st", true);
                    mycmd.ExecuteNonQuery();
                }
                
                

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally { 
            conn.Close();
            }

        }

        private void TxtBox_Searchbox_Del_Click_1(object sender, EventArgs e)
        {
            //Nothing Grows here :D :D 
            //MessageBox.Show(temp.ToString("d"));
            //MessageBox.Show(sdate.ToString("d"));
            //MessageBox.Show(edate.ToString("d"));
        }

        private void TxtBox_Searchbox_Update_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (ComboBox_Upd_Cust.Text == "ID")
                {
                    string query = @"SELECT C_id,C_name,Gender,Mobile,Address,Occupation FROM [Customer] WHERE C_id LIKE @tags";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("tags", txtbox_Update_Search.Text + "%");
                    //"%" +TxtBox_Searchbox_Del.Text+ "%"
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    //Dataset ds = new DataSet(); - You Could Use This One Also and just pass ds below => A DataSet holds one or more DataTables.
                    da.Fill(dt);
                    dataGridView_Update.DataSource = dt;
                }

                else if (ComboBox_Upd_Cust.Text == "Name")
                {
                    string query = @"SELECT C_id,C_name,Gender,Mobile,Address,Occupation FROM [Customer] WHERE C_Name LIKE @tags";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("tags", txtbox_Update_Search.Text + "%");
                    //"%" +TxtBox_Searchbox_Del.Text+ "%"
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    //Dataset ds = new DataSet(); - You Could Use This One Also and just pass ds below => A DataSet holds one or more DataTables.
                    da.Fill(dt);
                    dataGridView_Update.DataSource = dt;
                }

                else if (ComboBox_Upd_Cust.Text == "Gender")
                {
                    string query = @"SELECT C_id,C_name,Gender,Mobile,Address,Occupation FROM [Customer] WHERE Gender LIKE @tags";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("tags", txtbox_Update_Search.Text + "%");
                    //"%" +TxtBox_Searchbox_Del.Text+ "%"
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    //Dataset ds = new DataSet(); - You Could Use This One Also and just pass ds below => A DataSet holds one or more DataTables.
                    da.Fill(dt);
                    dataGridView_Update.DataSource = dt;
                }

                else if (ComboBox_Upd_Cust.Text == "Mobile")
                {
                    string query = @"SELECT C_id,C_name,Gender,Mobile,Address,Occupation FROM [Customer] WHERE Mobile LIKE @tags";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("tags", txtbox_Update_Search.Text + "%");
                    //"%" +TxtBox_Searchbox_Del.Text+ "%"
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    //Dataset ds = new DataSet(); - You Could Use This One Also and just pass ds below => A DataSet holds one or more DataTables.
                    da.Fill(dt);
                    dataGridView_Update.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Btn_Upd_Changes_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE [Customer] SET C_Name=@name,Gender=@gen,Mobile=@mob,Address=@add,Occupation=@occ WHERE C_id=@cid ;SELECT SCOPE_IDENTITY()", conn);
                cmd.Parameters.AddWithValue("cid", globalupdate);
                cmd.Parameters.AddWithValue("name", txtbox_Update_Name.Text);
                cmd.Parameters.AddWithValue("gen", txtbox_Update_Gender.Text);
                cmd.Parameters.AddWithValue("mob", txtbox_Update_Mobile.Text);
                cmd.Parameters.AddWithValue("add", txtbox_Update_Address.Text);
                cmd.Parameters.AddWithValue("occ", txtbox_Update_Occupation.Text);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        int globalupdate;
        private void dataGridView_Update_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.dataGridView_Update.Rows[e.RowIndex];

                txtbox_Update_Name.Text = row.Cells["C_Name"].Value.ToString();
                txtbox_Update_Gender.Text = row.Cells["Gender"].Value.ToString();
                txtbox_Update_Mobile.Text = row.Cells["Mobile"].Value.ToString();
                txtbox_Update_Occupation.Text = row.Cells["Occupation"].Value.ToString();
                txtbox_Update_Address.Text = row.Cells["Address"].Value.ToString();
                globalupdate = (int)row.Cells["C_id"].Value;
            }

            
        }

        private void dataGridView_Update_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Khali Fokat
        }

        private void Btn_Refresh_Update_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(@"Select * FROM [Customer]", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_Update.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Make Entry Of this Customer Collection Go To Daily Consolidated Section And Update Their");
        }

        private void btn_Daily_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime thisDay = DateTime.Today;

                conn.Open();
                SqlDataAdapter da1 = new SqlDataAdapter(@"Select * from [Transaction] where Attendance = @att AND Transaction_Date=@date", conn); //Query Extend -> AND DATE=TODAYS DATE FROM TRANSACTION TABLE WITH HELP OF CID
                da1.SelectCommand.Parameters.AddWithValue("@att", true);
                da1.SelectCommand.Parameters.AddWithValue("@date", thisDay.ToString("d"));
                da1.TableMappings.Add("Table", "Transaction");
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView_Daily.DataSource = dt1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Btn_Full_Pay_Daily_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Should Go to Different Section In Collection Module - For Full Payment Settlement");
        }

        private void dataGridView_Full_Payment_Settlement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_Full_Payment_Settlement.Rows[e.RowIndex];
                global_daily_cons = (int)row.Cells["C_id"].Value; //Use global_daily_cons Value into Full Payment Recieved Button Click Event
            }
            SqlDataReader rdr = null;
            SqlCommand cmd = null;
            try
            {
                conn.Open();
                cmd = new SqlCommand("select * from [Customer] where C_id=@custid;", conn);
                cmd.Parameters.AddWithValue("custid", global_daily_cons);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    metroTextBox28.Text = rdr[1].ToString();
                    metroTextBox29.Text = rdr[2].ToString();
                    metroTextBox30.Text = rdr[3].ToString();
                    metroTextBox34.Text = rdr[4].ToString();
                    metroTextBox32.Text = rdr[5].ToString();
                    metroTextBox33.Text = rdr[9].ToString();
                    metroTextBox31.Text = rdr[10].ToString();
                    metroTextBox27.Text = rdr[11].ToString();
                    metroTextBox38.Text = rdr[12].ToString();
                    metroTextBox40.Text = rdr[13].ToString();
                    metroTextBox35.Text = rdr[14].ToString();
                    metroTextBox36.Text = rdr[15].ToString();
                    metroTextBox42.Text = rdr[16].ToString();
                    metroTextBox41.Text = rdr[17].ToString();
                    metroTextBox39.Text = rdr[18].ToString();
                    metroTextBox37.Text = rdr[20].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            rdr.Close();
            conn.Close();
        }

        private void btn_FullPay_Display_Click(object sender, EventArgs e)
        {
            //We Need To Check The Past of this CID and if he is regular then normal operation else Calculate Loan with Fine & Update Attendance = true for all falses
            //We Need to Check the Future of this CID and if is there any future then calculate the Charges w/o fine and Update Attendance
            //Also Store the Above two into Present = Past + Future.
            //Calculate The Todays Charge and attendance=true and mix it with Present and Display.
            //Update this PRESENT info. into CID .Delete the future entry(Optional - Because their attendance is already Done true)

            SqlDataReader rdr = null;
            SqlCommand cmd = null;
            DateTime today = DateTime.Today; //Stores Todays Date with Timing
            DateTime tdate = today.Date; // Todays Date 
            DateTime sdate = DateTime.MinValue;//Will Store Start Date of That CID selected - You have to Set at Least a Minimum Value 
            DateTime edate = DateTime.MinValue;//Will Store End Date of That CID selected - You have to Set at Least a Minimum Value 
            DateTime idate = DateTime.MinValue; //To Store Issue Date
            int cid = global_daily_cons; //Stored Cid Value of Particular Selected Row in Datagridview
            float lp = 0;
            float lf = 0;
            float lr = 0;
            float ta = 0;
            float edi = 0;
            int prefinal = 0; //Just Store the Number of Days Which are False(Past & Future)
            float fedi = 0; //For Calculating the Future EDI's
            int postfinal = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand(@"SELECT EDI,Total_Amount,Loan_Remain,Late_Fine,issue_Date,Start_Date,End_Date,Loan_Paid FROM [Customer] Where C_id=@cid", conn);
                cmd.Parameters.AddWithValue("cid", cid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    edi = (float)rdr.GetDouble(rdr.GetOrdinal("EDI"));
                    ta = (float)rdr.GetDouble(rdr.GetOrdinal("Total_Amount"));
                    lr = (float)rdr.GetDouble(rdr.GetOrdinal("Loan_Remain"));
                    lf = (float)rdr.GetDouble(rdr.GetOrdinal("Late_Fine"));
                    lp = (float)rdr.GetDouble(rdr.GetOrdinal("Loan_Paid"));
                    idate = (DateTime)rdr["issue_Date"];
                    sdate = (DateTime)rdr["Start_Date"];
                    edate = (DateTime)rdr["End_Date"];
                }
                rdr.Close();

                //Part 1 ----> SD=TD
                if (sdate.Equals(tdate))
                {
                    MessageBox.Show("This is the Start Date !! Wow Your Customer is So Rich That It Pays You Fully On Starting Date only");
                    //Calculate Future Days and Make their Attendance True.
                    for (DateTime loop = sdate.AddDays(1); loop.Date <= edate;loop=loop.AddDays(1))
                    {
                        //For Storing All the Future Days
                        cmd = new SqlCommand(@"SELECT COUNT(*) FROM [Transaction] WHERE C_id=@cid AND Transaction_Date=@trans AND Attendance=@att;", conn);
                        cmd.Parameters.AddWithValue("@cid", cid);
                        cmd.Parameters.AddWithValue("@trans", loop);
                        cmd.Parameters.AddWithValue("@att", false);
                        prefinal += Convert.ToInt32(cmd.ExecuteScalar());
                        //MessageBox.Show(prefinal.ToString()); Eg:- we get 5 Days

                        //For Making Attendance True for Future
                        cmd = new SqlCommand(@"UPDATE [Transaction] SET Attendance=@up WHERE C_id=@cid AND Transaction_Date=@trans AND Attendance=@att;", conn);
                        cmd.Parameters.AddWithValue("@up", true);
                        cmd.Parameters.AddWithValue("@cid", cid);
                        cmd.Parameters.AddWithValue("@trans", loop);
                        cmd.Parameters.AddWithValue("@att", false);
                        cmd.ExecuteNonQuery();

                        //For Making Attendance True for Today
                        cmd = new SqlCommand(@"UPDATE [Transaction] SET Attendance=@up WHERE C_id=@cid AND Transaction_Date=@trans AND Attendance=@att;", conn);
                        cmd.Parameters.AddWithValue("@up", true);
                        cmd.Parameters.AddWithValue("@cid", cid);
                        cmd.Parameters.AddWithValue("@trans", tdate);
                        cmd.Parameters.AddWithValue("@att", false);
                        cmd.ExecuteNonQuery();
                    }
                    //Main Logic - Only these Will Change in the Below Given Two Parts
                    lf = 0;
                    lp = ta;
                    lr = 0;
                    
                    cmd = new SqlCommand(@"UPDATE [Customer] SET Total_Amount=@ta,Loan_Remain=@lr,Late_Fine=@lf,Loan_Paid=@lp WHERE C_id=@cid ", conn);
                    cmd.Parameters.AddWithValue("cid", cid);
                    cmd.Parameters.AddWithValue("ta", ta);
                    cmd.Parameters.AddWithValue("lr", lr);
                    cmd.Parameters.AddWithValue("lf", lf);
                    cmd.Parameters.AddWithValue("lp", lp);
                    cmd.ExecuteNonQuery();
                    
                }

                //Part 2 ----> SD < TD < ED
                else if (sdate<tdate && tdate<edate)
                {
                    MessageBox.Show("This is the Middle Date !! Your Customer is Middle Class.You Should Not Cheat him/her.");
                    
                    // 1) FUTURE - Calculate Future Days and Make their Attendance True.
                    for (DateTime loop = tdate.AddDays(1); loop.Date <=edate; loop = loop.AddDays(1))
                    {
                        //For Storing All the Future Days Attendance
                        cmd = new SqlCommand(@"SELECT COUNT(*) FROM [Transaction] WHERE C_id=@cid AND Transaction_Date=@trans AND Attendance=@att;", conn);
                        cmd.Parameters.AddWithValue("@cid", cid);
                        cmd.Parameters.AddWithValue("@trans", loop);
                        cmd.Parameters.AddWithValue("@att", false);
                        prefinal += Convert.ToInt32(cmd.ExecuteScalar());

                        //For Making Attendance True for Future
                        cmd = new SqlCommand(@"UPDATE [Transaction] SET Attendance=@up WHERE C_id=@cid AND Transaction_Date=@trans AND Attendance=@att;", conn);
                        cmd.Parameters.AddWithValue("@up", true);
                        cmd.Parameters.AddWithValue("@cid", cid);
                        cmd.Parameters.AddWithValue("@trans", loop);
                        cmd.Parameters.AddWithValue("@att", false);
                        cmd.ExecuteNonQuery();
                    }

                    fedi = prefinal * edi; //Eg:- 2 Days are there in Future with 110 EDI - So 220 Future Payment

                    // 2) PAST - Calculate Past Days and Make their Attendance True.
                    for (DateTime loop = sdate; loop.Date < tdate; loop = loop.AddDays(1))
                    {
                        //For Storing All the Past Days Attendance
                        cmd = new SqlCommand(@"SELECT COUNT(*) FROM [Transaction] WHERE C_id=@cid AND Transaction_Date=@trans AND Attendance=@att;", conn);
                        cmd.Parameters.AddWithValue("@cid", cid);
                        cmd.Parameters.AddWithValue("@trans", loop);
                        cmd.Parameters.AddWithValue("@att", false);
                        postfinal += Convert.ToInt32(cmd.ExecuteScalar()); //Here this Postfinal variable was to be taken for future but i have taken it for past in this PART 2 so just Swap them if u have any confusion

                        //For Making Attendance True for Past
                        cmd = new SqlCommand(@"UPDATE [Transaction] SET Attendance=@up WHERE C_id=@cid AND Transaction_Date=@trans AND Attendance=@att;", conn);
                        cmd.Parameters.AddWithValue("@up", true);
                        cmd.Parameters.AddWithValue("@cid", cid);
                        cmd.Parameters.AddWithValue("@trans", loop);
                        cmd.Parameters.AddWithValue("@att", false);
                        cmd.ExecuteNonQuery();
                    }
                    if (postfinal == 0) //Regular Customer - Uptil Now Also Regular
                    {
                        //FUTURE + PRESENT WILL BE DONE HERE
                        lf = 0;
                        lp = ta;
                        lr = 0;

                    }
                    else
                    {
                        //PAST+PRESENT+FUTURE
                        lf += (postfinal * 20); //Rs 20. FINE IS CHARGED FROM HERE :D 
                        ta += lf;
                        lr += lf;
                        float pedi = postfinal * edi; //ex:- 2*125=250 Rs. Till Now EDI Only Which is not Paid Without Fine

                        //After That We Will perform Attendance And Calculation for PRESENT as Follows
                        lp += edi + lf + pedi + fedi;
                        lf = 0;
                        lr = ta - lp;
                        //I think Above Logic Will Do RESETS --> TA=LP OR LR =0
                    }
                    
                    //For Making Attendance True for Today
                    cmd = new SqlCommand(@"UPDATE [Transaction] SET Attendance=@up WHERE C_id=@cid AND Transaction_Date=@trans AND Attendance=@att;", conn);
                    cmd.Parameters.AddWithValue("@up", true);
                    cmd.Parameters.AddWithValue("@cid", cid);
                    cmd.Parameters.AddWithValue("@trans", tdate);
                    cmd.Parameters.AddWithValue("@att", false);
                    cmd.ExecuteNonQuery();
                    //This Will Remain Same
                    cmd = new SqlCommand(@"UPDATE [Customer] SET Total_Amount=@ta,Loan_Remain=@lr,Late_Fine=@lf,Loan_Paid=@lp WHERE C_id=@cid ", conn);
                    cmd.Parameters.AddWithValue("cid", cid);
                    cmd.Parameters.AddWithValue("ta", ta);
                    cmd.Parameters.AddWithValue("lr", lr);
                    cmd.Parameters.AddWithValue("lf", lf);
                    cmd.Parameters.AddWithValue("lp", lp);
                    cmd.ExecuteNonQuery();
                }

                //Part 3 ----> TD=ED
                else if (edate.Equals(tdate))
                {
                    MessageBox.Show("This is the Last Date !! It Seems Your Customer is Always Paying You in the Last !! Right :P");
                    //Calculate Past Days and Make their Attendance True.
                    for (DateTime loop = sdate;loop.Date < edate; loop = loop.AddDays(1))
                    {
                        //For Storing All the Past Days Attendance
                        cmd = new SqlCommand(@"SELECT COUNT(*) FROM [Transaction] WHERE C_id=@cid AND Transaction_Date=@trans AND Attendance=@att;", conn);
                        cmd.Parameters.AddWithValue("@cid", cid);
                        cmd.Parameters.AddWithValue("@trans", loop);
                        cmd.Parameters.AddWithValue("@att", false);
                        prefinal += Convert.ToInt32(cmd.ExecuteScalar());
                        //MessageBox.Show(prefinal.ToString()); Eg:- we get 5 Days

                        //For Making Attendance True for Past
                        cmd = new SqlCommand(@"UPDATE [Transaction] SET Attendance=@up WHERE C_id=@cid AND Transaction_Date=@trans AND Attendance=@att;", conn);
                        cmd.Parameters.AddWithValue("@up", true);
                        cmd.Parameters.AddWithValue("@cid", cid);
                        cmd.Parameters.AddWithValue("@trans", loop);
                        cmd.Parameters.AddWithValue("@att", false);
                        cmd.ExecuteNonQuery();

                        //For Making Attendance True for Today
                        cmd = new SqlCommand(@"UPDATE [Transaction] SET Attendance=@up WHERE C_id=@cid AND Transaction_Date=@trans AND Attendance=@att;", conn);
                        cmd.Parameters.AddWithValue("@up", true);
                        cmd.Parameters.AddWithValue("@cid", cid);
                        cmd.Parameters.AddWithValue("@trans", tdate);
                        cmd.Parameters.AddWithValue("@att", false);
                        cmd.ExecuteNonQuery();
                    }
                    if (prefinal == 0) //Regular Customer - Last Day Also Regular So Just Collected the Money
                    {
                        lf = 0;
                        lp = ta;
                        lr = 0;
                    }
                    else
                    {
                        lf += (prefinal * 20); //Rs 20. FINE IS CHARGED FROM HERE :D 
                        ta += lf;
                        lr += lf;
                        float tedi = prefinal * edi; //(ex:- 2*125=250 Rs. Till Now EDI Only Which is not Paid)

                        //After That We Will perform Attendance And Calculation for today Date as Follows
                        lp += edi + lf + tedi;
                        lf = 0;
                        lr = ta - lp;
                    }

                    //This Will Remain Same
                    cmd = new SqlCommand(@"UPDATE [Customer] SET Total_Amount=@ta,Loan_Remain=@lr,Late_Fine=@lf,Loan_Paid=@lp WHERE C_id=@cid ", conn);
                    cmd.Parameters.AddWithValue("cid", cid);
                    cmd.Parameters.AddWithValue("ta", ta);
                    cmd.Parameters.AddWithValue("lr", lr);
                    cmd.Parameters.AddWithValue("lf", lf);
                    cmd.Parameters.AddWithValue("lp", lp);
                    cmd.ExecuteNonQuery();
                }

                //Part 4 ----> No Hopes Remain
                else {
                    MessageBox.Show("Seriously Man !! I Can't Understand What is the Problem with You.");
                }

                if (lp == ta || lr == 0) //MAKING STATUS=TRUE
                {
                    MessageBox.Show("This Customer is Now A Paid Customer Officially !! ");
                    cmd = new SqlCommand(@"UPDATE [Customer] SET Status=@st WHERE C_id=@cid ", conn);
                    cmd.Parameters.AddWithValue("cid", cid);
                    cmd.Parameters.AddWithValue("st", true);
                    cmd.ExecuteNonQuery();
                }
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                rdr.Close();
                conn.Close();
            }


        }

        private void metroButton_show_INDI_Click(object sender, EventArgs e)
        {
          //Same Code that is Below :) 

        }

        private void Btn_Report_Cust_Detail_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"Select * from [Customer];", conn);
            //sda.TableMappings.Add("Table", "Customer");
            DataSet ds = new DataSet();
            sda.Fill(ds, "Customer");
            crystal.SetDataSource(ds);
            crystalReportViewer_Report_Single_Customer.ReportSource = crystal;
        }
    }
}
