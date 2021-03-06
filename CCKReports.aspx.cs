using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using GCFDGlobalsNamespace;
using System.Web.UI.WebControls;

public partial class CCKReports : System.Web.UI.Page
{
    public string ReportDate = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (User.Identity.IsAuthenticated)
        {
            if (Session["SessionID"] == null)
            {
                System.Web.Security.FormsAuthentication.SignOut();

                Response.Redirect("~/Account/Login.aspx", false);

                Response.End();
            }
            else
            {
                if (User.IsInRole("Administrator"))
                {
                    LinkButton1.Enabled = true;
                    LinkButton1.ForeColor = System.Drawing.Color.White;

                    LinkButton6.Enabled = true;
                    LinkButton6.ForeColor = System.Drawing.Color.White;

                    LinkButton2.Enabled = true;
                    LinkButton2.ForeColor = System.Drawing.Color.White;

                    LinkButton3.Enabled = true;
                    LinkButton3.ForeColor = System.Drawing.Color.White;

                    LinkButton4.Enabled = true;
                    LinkButton4.ForeColor = System.Drawing.Color.White;

                    LinkButton5.Enabled = true;
                    LinkButton5.ForeColor = System.Drawing.Color.White;

                    LinkButton7.Enabled = true;
                    LinkButton7.ForeColor = System.Drawing.Color.White;

                    //LinkButton8.Enabled = true;
                    //LinkButton8.ForeColor = System.Drawing.Color.White;

                    LinkButton9.Enabled = true;
                    LinkButton9.ForeColor = System.Drawing.Color.White;

                    LinkButton15.Enabled = true;
                    LinkButton15.ForeColor = System.Drawing.Color.White;

                    LinkButton10.Enabled = true;
                    LinkButton10.ForeColor = System.Drawing.Color.White;

                    LinkButton11.Enabled = true;
                    LinkButton11.ForeColor = System.Drawing.Color.White;

                    LinkButton12.Enabled = true;
                    LinkButton12.ForeColor = System.Drawing.Color.White;

                    LinkButton16.Enabled = true;
                    LinkButton16.ForeColor = System.Drawing.Color.White;

                    LinkButton17.Enabled = true;
                    LinkButton17.ForeColor = System.Drawing.Color.White;

                    LinkButton18.Enabled = true;
                    LinkButton18.ForeColor = System.Drawing.Color.White;

                    LinkButton19.Enabled = true;
                    LinkButton19.ForeColor = System.Drawing.Color.White;

                    LinkButton20.Enabled = true;
                    LinkButton20.ForeColor = System.Drawing.Color.White;

                    LinkButton21.Enabled = true;
                    LinkButton21.ForeColor = System.Drawing.Color.White;

                    LinkButton22.Enabled = true;
                    LinkButton22.ForeColor = System.Drawing.Color.White;

                    LinkButton23.Enabled = true;
                    LinkButton23.ForeColor = System.Drawing.Color.White;

                    LinkButton24.Enabled = true;
                    LinkButton24.ForeColor = System.Drawing.Color.White;

                    LinkButton26.Enabled = true;
                    LinkButton26.ForeColor = System.Drawing.Color.White;

                    LinkButton25.Enabled = true;
                    LinkButton25.ForeColor = System.Drawing.Color.White;

                    LinkButton27.Enabled = true;
                    LinkButton27.ForeColor = System.Drawing.Color.White;

                    LinkButton28.Enabled = true;
                    LinkButton28.ForeColor = System.Drawing.Color.White;

                    LinkButton8.Enabled = true;
                    LinkButton8.ForeColor = System.Drawing.Color.White;

                    LinkButton13.Enabled = true;
                    LinkButton13.ForeColor = System.Drawing.Color.White;

                    LinkButton29.Enabled = true;
                    LinkButton29.ForeColor = System.Drawing.Color.White;

                    LinkButton30.Enabled = true;
                    LinkButton30.ForeColor = System.Drawing.Color.White;

                    SiteCountMealTotalReportByRange.Enabled = true;
                    SiteCountMealTotalReportByRange.ForeColor = System.Drawing.Color.White;

                    UnduplicatedParticipationReportByRange.Enabled = true;
                    UnduplicatedParticipationReportByRange.ForeColor = System.Drawing.Color.White;

                    SFSPProgramsLabelReport.Enabled = true;
                    SFSPProgramsLabelReport.ForeColor = System.Drawing.Color.White;

                    CACFPProgramsLabelReport.Enabled = true;
                    CACFPProgramsLabelReport.ForeColor = System.Drawing.Color.White;

                    AverageRecipeCostPerDateRange.Enabled = true;
                    AverageRecipeCostPerDateRange.ForeColor = System.Drawing.Color.White;

                    NutritionEducationReportButton.Enabled = true;
                    NutritionEducationReportButton.ForeColor = System.Drawing.Color.White;
                }

                if (User.IsInRole("Kitchen-Admin"))
                {
                    LinkButton6.Enabled = true;
                    LinkButton6.ForeColor = System.Drawing.Color.White;

                    LinkButton1.Enabled = true;
                    LinkButton1.ForeColor = System.Drawing.Color.White;

                    LinkButton2.Enabled = true;
                    LinkButton2.ForeColor = System.Drawing.Color.White;

                    LinkButton3.Enabled = true;
                    LinkButton3.ForeColor = System.Drawing.Color.White;

                    LinkButton4.Enabled = true;
                    LinkButton4.ForeColor = System.Drawing.Color.White;

                    LinkButton5.Enabled = true;
                    LinkButton5.ForeColor = System.Drawing.Color.White;

                    LinkButton7.Enabled = true;
                    LinkButton7.ForeColor = System.Drawing.Color.White;

                    //LinkButton8.Enabled = true;
                    //LinkButton8.ForeColor = System.Drawing.Color.White;

                    LinkButton26.Enabled = true;
                    LinkButton26.ForeColor = System.Drawing.Color.White;

                    LinkButton25.Enabled = true;
                    LinkButton25.ForeColor = System.Drawing.Color.White;

                    LinkButton15.Enabled = true;
                    LinkButton15.ForeColor = System.Drawing.Color.White;

                    LinkButton10.Enabled = true;
                    LinkButton10.ForeColor = System.Drawing.Color.White;

                    LinkButton14.Enabled = true;
                    LinkButton14.ForeColor = System.Drawing.Color.White;

                    AverageRecipeCostPerDateRange.Enabled = true;
                    AverageRecipeCostPerDateRange.ForeColor = System.Drawing.Color.White;
                }

                if (User.IsInRole("Kitchen-Staff"))
                {
                    LinkButton1.Enabled = true;
                    LinkButton1.ForeColor = System.Drawing.Color.White;

                    LinkButton6.Enabled = true;
                    LinkButton6.ForeColor = System.Drawing.Color.White;

                    LinkButton2.Enabled = true;
                    LinkButton2.ForeColor = System.Drawing.Color.White;

                    LinkButton3.Enabled = true;
                    LinkButton3.ForeColor = System.Drawing.Color.White;

                    LinkButton4.Enabled = true;
                    LinkButton4.ForeColor = System.Drawing.Color.White;

                    LinkButton5.Enabled = true;
                    LinkButton5.ForeColor = System.Drawing.Color.White;

                    LinkButton7.Enabled = true;
                    LinkButton7.ForeColor = System.Drawing.Color.White;

                    //LinkButton8.Enabled = true;
                    //LinkButton8.ForeColor = System.Drawing.Color.White;

                    LinkButton26.Enabled = true;
                    LinkButton26.ForeColor = System.Drawing.Color.White;

                    LinkButton25.Enabled = true;
                    LinkButton25.ForeColor = System.Drawing.Color.White;

                    LinkButton15.Enabled = true;
                    LinkButton15.ForeColor = System.Drawing.Color.White;

                    LinkButton10.Enabled = true;
                    LinkButton10.ForeColor = System.Drawing.Color.White;

                    AverageRecipeCostPerDateRange.Enabled = true;
                    AverageRecipeCostPerDateRange.ForeColor = System.Drawing.Color.White;
                }

                if (User.IsInRole("Transportation"))
                {
                    //LinkButton8.Enabled = true;
                    //LinkButton8.ForeColor = System.Drawing.Color.White;


                    LinkButton6.Enabled = true;
                    LinkButton6.ForeColor = System.Drawing.Color.White;

                    LinkButton26.Enabled = true;
                    LinkButton26.ForeColor = System.Drawing.Color.White;

                    LinkButton25.Enabled = true;
                    LinkButton25.ForeColor = System.Drawing.Color.White;

                    LinkButton9.Enabled = true;
                    LinkButton9.ForeColor = System.Drawing.Color.White;

                    LinkButton15.Enabled = true;
                    LinkButton15.ForeColor = System.Drawing.Color.White;

                    LinkButton10.Enabled = true;
                    LinkButton10.ForeColor = System.Drawing.Color.White;
                }

                if (User.IsInRole("Compliance"))
                {
                    LinkButton16.Enabled = true;
                    LinkButton16.ForeColor = System.Drawing.Color.White;

                    LinkButton22.Enabled = true;
                    LinkButton22.ForeColor = System.Drawing.Color.White;
                }

                if (User.IsInRole("Programs"))
                {
                    LinkButton6.Enabled = true;
                    LinkButton6.ForeColor = System.Drawing.Color.White;

                    //LinkButton8.Enabled = true;
                    //LinkButton8.ForeColor = System.Drawing.Color.White;

                    LinkButton26.Enabled = true;
                    LinkButton26.ForeColor = System.Drawing.Color.White;

                    LinkButton25.Enabled = true;
                    LinkButton25.ForeColor = System.Drawing.Color.White;

                    LinkButton9.Enabled = true;
                    LinkButton9.ForeColor = System.Drawing.Color.White;

                    LinkButton15.Enabled = true;
                    LinkButton15.ForeColor = System.Drawing.Color.White;

                    LinkButton10.Enabled = true;
                    LinkButton10.ForeColor = System.Drawing.Color.White;

                    LinkButton11.Enabled = true;
                    LinkButton11.ForeColor = System.Drawing.Color.White;

                    LinkButton12.Enabled = true;
                    LinkButton12.ForeColor = System.Drawing.Color.White;

                    LinkButton16.Enabled = true;
                    LinkButton16.ForeColor = System.Drawing.Color.White;

                    LinkButton14.Enabled = true;
                    LinkButton14.ForeColor = System.Drawing.Color.White;

                    LinkButton17.Enabled = true;
                    LinkButton17.ForeColor = System.Drawing.Color.White;

                    LinkButton18.Enabled = true;
                    LinkButton18.ForeColor = System.Drawing.Color.White;

                    LinkButton19.Enabled = true;
                    LinkButton19.ForeColor = System.Drawing.Color.White;

                    LinkButton20.Enabled = true;
                    LinkButton20.ForeColor = System.Drawing.Color.White;

                    LinkButton21.Enabled = true;
                    LinkButton21.ForeColor = System.Drawing.Color.White;

                    LinkButton22.Enabled = true;
                    LinkButton22.ForeColor = System.Drawing.Color.White;

                    LinkButton23.Enabled = true;
                    LinkButton23.ForeColor = System.Drawing.Color.White;

                    LinkButton24.Enabled = true;
                    LinkButton24.ForeColor = System.Drawing.Color.White;

                    LinkButton27.Enabled = true;
                    LinkButton27.ForeColor = System.Drawing.Color.White;

                    LinkButton28.Enabled = true;
                    LinkButton28.ForeColor = System.Drawing.Color.White;

                    LinkButton8.Enabled = true;
                    LinkButton8.ForeColor = System.Drawing.Color.White;

                    LinkButton13.Enabled = true;
                    LinkButton13.ForeColor = System.Drawing.Color.White;

                    LinkButton29.Enabled = true;
                    LinkButton29.ForeColor = System.Drawing.Color.White;

                    LinkButton30.Enabled = true;
                    LinkButton30.ForeColor = System.Drawing.Color.White;

                    SiteCountMealTotalReportByRange.Enabled = true;
                    SiteCountMealTotalReportByRange.ForeColor = System.Drawing.Color.White;

                    UnduplicatedParticipationReportByRange.Enabled = true;
                    UnduplicatedParticipationReportByRange.ForeColor = System.Drawing.Color.White;

                    SFSPProgramsLabelReport.Enabled = true;
                    SFSPProgramsLabelReport.ForeColor = System.Drawing.Color.White;

                    CACFPProgramsLabelReport.Enabled = true;
                    CACFPProgramsLabelReport.ForeColor = System.Drawing.Color.White;

                    NutritionEducationReportButton.Enabled = true;
                    NutritionEducationReportButton.ForeColor = System.Drawing.Color.White;
                }
                
                if (!IsPostBack)
                {
                    //ReportStartDateDiv.Style["display"] = "none";
                    //ReportStartDateDiv.Style["visibility"] = "hidden";

                    //ReportEndDateDiv.Style["display"] = "none";
                    //ReportEndDateDiv.Style["visibility"] = "hidden";

                    //MealTypeDiv.Style["display"] = "none";
                    //MealTypeDiv.Style["visibility"] = "hidden";
                    //CommunityAreaDiv.Style["visibility"] = "hidden";
                    //CommunityAreaDiv.Style["display"] = "none";
                    //SiteNameDiv.Style["visibility"] = "hidden";
                    //SiteNameDiv.Style["display"] = "none";
                    //ReportTextDiv.Style["visibility"] = "hidden";
                    //ReportTextDiv.Style["display"] = "none";

                    //ReportFormatDiv.Style["visibility"] = "hidden";
                    //ReportFormatDiv.Style["display"] = "none";

                    //DeliveryReportParametersDiv.Style["visibility"] = "hidden";
                    //DeliveryReportParametersDiv.Style["display"] = "none";

                    ReportTypeRadioButtonList.SelectedValue = "PDF";

                    string m_SQL = "SELECT DISTINCT MealTypeID, MealTypeName FROM MealTypeDict";
                    DataSet mealDeliveryTypeDataSet = GCFDGlobals.m_GCFDPlannerDatabaseLibrary.dbSelectDataSet(m_SQL);

                    MealTypeDropDownList.DataValueField = "MealTypeID";
                    MealTypeDropDownList.DataTextField = "MealTypeName";
                    MealTypeDropDownList.DataSource = mealDeliveryTypeDataSet.Tables[0];
                    MealTypeDropDownList.DataBind();
                    MealTypeDropDownList.Items.Insert(0, new ListItem("SELECT MEAL TYPE", "-1"));
                    MealTypeDropDownList.SelectedIndex = MealTypeDropDownList.Items.IndexOf(MealTypeDropDownList.Items.FindByText("SELECT MEAL TYPE"));

                    m_SQL = "SELECT DISTINCT ScheduleTypeID, ScheduleTypeName FROM ScheduleTypeDict";
                    DataSet scheduleDeliveryTypeDataSet = GCFDGlobals.m_GCFDPlannerDatabaseLibrary.dbSelectDataSet(m_SQL);

                    ScheduleTypeDropDownList.DataValueField = "ScheduleTypeID";
                    ScheduleTypeDropDownList.DataTextField = "ScheduleTypeName";
                    ScheduleTypeDropDownList.DataSource = scheduleDeliveryTypeDataSet.Tables[0];
                    ScheduleTypeDropDownList.DataBind();
                    ScheduleTypeDropDownList.Items.Insert(0, new ListItem("SELECT SCHEDULE TYPE", "-1"));
                    ScheduleTypeDropDownList.SelectedIndex = ScheduleTypeDropDownList.Items.IndexOf(ScheduleTypeDropDownList.Items.FindByText("SELECT SCHEDULE TYPE"));

                    m_SQL = "SELECT DISTINCT CommunityArea FROM Site";
                    DataSet communityAreaDataSet = GCFDGlobals.m_GCFDPlannerDatabaseLibrary.dbSelectDataSet(m_SQL);

                    CommunityAreaDropDownList.DataValueField = "CommunityArea";
                    CommunityAreaDropDownList.DataTextField = "CommunityArea";
                    CommunityAreaDropDownList.DataSource = communityAreaDataSet.Tables[0];
                    CommunityAreaDropDownList.DataBind();
                    CommunityAreaDropDownList.Items.Insert(0, new ListItem("SELECT COMMUNITY AREA", "-1"));
                    CommunityAreaDropDownList.SelectedIndex = CommunityAreaDropDownList.Items.IndexOf(CommunityAreaDropDownList.Items.FindByText("SELECT COMMUNITY AREA"));

                    m_SQL = "SELECT DISTINCT SiteID, SiteName FROM Site ORDER BY SiteName";
                    DataSet siteNameDataSet = GCFDGlobals.m_GCFDPlannerDatabaseLibrary.dbSelectDataSet(m_SQL);

                    SiteNameDropDownList.DataValueField = "SiteName";
                    SiteNameDropDownList.DataTextField = "SiteName";
                    SiteNameDropDownList.DataSource = siteNameDataSet.Tables[0];
                    SiteNameDropDownList.DataBind();
                    SiteNameDropDownList.Items.Insert(0, new ListItem("SELECT SITE NAME", "-1"));
                    SiteNameDropDownList.SelectedIndex = SiteNameDropDownList.Items.IndexOf(SiteNameDropDownList.Items.FindByText("SELECT SITE NAME"));
                }
            }
        }
        else
        {
            Response.Redirect("Default.aspx", false);

            Response.End();
        }
    }

    protected void DeliveryReceiptButton_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Kitchen/Reports/DeliveryReceiptReport.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Date";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["visibility"] = "inline";
        ReportFormatDiv.Style["display"] = "visible";

        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportStartDateTextBox.Text = "";

        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        PutFocusOnStartDate();

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void DeliveryReceiptButtonCold_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Kitchen/Reports/DeliveryReceiptReportCold.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Date";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        mealsPerBoxDiv.Style["display"] = "inline";
        mealsPerBoxDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["visibility"] = "inline";
        ReportFormatDiv.Style["display"] = "visible";

        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportStartDateTextBox.Text = "";

        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        BagBunCountTextBox.Text = txtMealsPerBox.Text;

        PutFocusOnStartDate();

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void ColdLabelsButton_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Kitchen/Reports/labelReportCold.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Date";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        mealsPerBoxDiv.Style["display"] = "inline";
        mealsPerBoxDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["visibility"] = "inline";
        ReportFormatDiv.Style["display"] = "visible";

        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportStartDateTextBox.Text = "";

        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        BagBunCountTextBox.Text = txtMealsPerBox.Text;

        PutFocusOnStartDate();

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void LunchBusLabelsButton_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Kitchen/Reports/labelReportColdBus.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Date";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        mealsPerBoxDiv.Style["display"] = "inline";
        mealsPerBoxDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["visibility"] = "inline";
        ReportFormatDiv.Style["display"] = "visible";

        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportStartDateTextBox.Text = "";

        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        BagBunCountTextBox.Text = txtMealsPerBox.Text;

        PutFocusOnStartDate();

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void PutFocusOnStartDate()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<script type=\"text/javascript\">\n");
        sb.Append("Sys.Application.add_load(modalSetup);\n");
        sb.Append("function modalSetup() {\n");
        sb.Append(String.Format("var modalPopup = $find('{0}');\n", ReportDateModelPopupExtender.BehaviorID));
        sb.Append("modalPopup.add_shown(SetFocusOnControl); }\n");
        sb.Append("function SetFocusOnControl() {\n");
        sb.Append(String.Format("var textBox1 = $get('{0}');\n", ReportStartDateTextBox.ClientID));
        sb.Append("textBox1.focus();}\n");
        sb.Append("</script>\n");
        Page.ClientScript.RegisterStartupScript(Page.GetType(), "Startup", sb.ToString());
    }

    protected void CACFPSiteMealCountForm_Click(object sender, EventArgs e)
    {
        Response.Redirect("Programs/Reports/CACFPSiteMealCountForm.aspx", false);
    }

    protected void SFSPSiteMealCountForm_Click(object sender, EventArgs e)
    {
        Response.Redirect("Programs/Reports/SFSPSiteMealCountForm.aspx", false);
    }

    protected void DeliveryReportButton_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Reports/DeliveryReport.aspx";
        ReportStartDateTextBox.Text = "";
        ReportEndDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Date";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";

        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";
        
        PutFocusOnStartDate();      

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void RecipesReportButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("Kitchen/Reports/AllRecipesReport.aspx", false);
    }

    protected void ProductionSheets_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Kitchen/Reports/ProductionSheetReport.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Date";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        ReportEndDateDiv.Style["display"] = "none";
                    ReportEndDateDiv.Style["visibility"] = "hidden";
                    ReportEndDateTextBox.Text = "";


                    MealTypeDiv.Style["display"] = "none";
                    MealTypeDiv.Style["visibility"] = "hidden";
                    
		    CommunityAreaDiv.Style["visibility"] = "hidden";
                    CommunityAreaDiv.Style["display"] = "none";
                    
		    SiteNameDiv.Style["visibility"] = "hidden";
                    SiteNameDiv.Style["display"] = "none";
                    
		    ReportTextDiv.Style["visibility"] = "hidden";
                    ReportTextDiv.Style["display"] = "none";

                    DeliveryReportParametersDiv.Style["visibility"] = "hidden";
                    DeliveryReportParametersDiv.Style["display"] = "none";


                    mealsPerBoxDiv.Style["display"] = "hidden";
                    mealsPerBoxDiv.Style["visibility"] = "none";

        PutFocusOnStartDate();  

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void NumberPans_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Kitchen/Reports/NumberPansReport.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Date";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        ReportEndDateDiv.Style["display"] = "inline";
        ReportEndDateDiv.Style["visibility"] = "visible";
        ReportEndDateTextBox.Text = "";


        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";


        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        PutFocusOnStartDate();

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }


    protected void DeliveryLabelsButton_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Kitchen/Reports/LabelReport.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Date";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";


        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";


        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportEndDateTextBox.Text = "";


        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";


        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        PutFocusOnStartDate();

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void DeliveryLabelsHotButton_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Kitchen/Reports/LabelReportHot.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Date";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";


        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";


        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportEndDateTextBox.Text = "";


        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";


        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        PutFocusOnStartDate();

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void DeliveryLabelsBreakfastButton_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Kitchen/Reports/LabelReportBreakfast.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Date";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";


        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";


        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportEndDateTextBox.Text = "";


        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";


        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        PutFocusOnStartDate();

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }


    protected void AdjustedRecipesReportButton_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Kitchen/Reports/AdjustedRecipesReport.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Date";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";


        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";


        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportEndDateTextBox.Text = "";


        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";


        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        PutFocusOnStartDate();       
        
        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void PoundageByRangeButton_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Programs/Reports/PoundageReport_ByRange.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Start Date:";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        PutFocusOnStartDate(); 

        ReportEndDateDiv.Style["display"] = "inline";
        ReportEndDateDiv.Style["visibility"] = "visible";


        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";
        
        ReportEndDateTextBox.Text = "";

        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";


        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void SitesReceivingMealsByDateRange_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Programs/Reports/SitesReceivingMealsReport_ByRange.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Start Date:";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        PutFocusOnStartDate();

        ReportEndDateDiv.Style["display"] = "inline";
        ReportEndDateDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        ReportEndDateTextBox.Text = "";

        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";


        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void MissingMealCountsReportByDateRange_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Programs/Reports/MissingMealCountsReport_ByRange.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Start Date:";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        PutFocusOnStartDate();

        ReportEndDateDiv.Style["display"] = "inline";
        ReportEndDateDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        ReportEndDateTextBox.Text = "";

        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";


        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void DailyCountReport_Click(object sender, EventArgs e)
    {

        MealTypeDropDownList.Attributes["onchange"] = "javascript:hideSite()";
        ScheduleTypeDropDownList.Attributes["onchange"] = "javascript:hideSite()";
        CommunityAreaDropDownList.Attributes["onchange"] = "javascript:hideSite()";
        SiteNameDropDownList.Attributes["onchange"] = "javascript:hideMealTypeCommunityArea()";
        
        ReportNameHiddenField.Value = "Programs/Reports/DailyCountReport.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Start Date:";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        PutFocusOnStartDate();

        ReportEndDateDiv.Style["display"] = "inline";
        ReportEndDateDiv.Style["visibility"] = "visible";

        ReportEndDateTextBox.Text = "";

        MealTypeDiv.Style["display"] = "inline";
        MealTypeDiv.Style["visibility"] = "visible";

        ScheduleTypeDiv.Style["display"] = "inline";
        ScheduleTypeDiv.Style["visibility"] = "visible";

        CommunityAreaDiv.Style["display"] = "inline";
        CommunityAreaDiv.Style["visibility"] = "visible";

        SiteNameDiv.Style["display"] = "inline";
        SiteNameDiv.Style["visibility"] = "visible";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";


        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void PoundageReportButton_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Programs/Reports/PoundageReport.aspx";
        ReportStartDateTextBox.Text = "";
        ReportEndDateTextBox.Text = ""; 

        ReportStartDateLabel.Text = "Report Date:";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";

        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";


        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        PutFocusOnStartDate();

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void WeeklyOrderReport_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Programs/Reports/WeeklyOrderReport.aspx";
        ReportStartDateTextBox.Text = "";
        ReportEndDateTextBox.Text = ""; 

        ReportStartDateLabel.Text = "Report Start Date:";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportEndDateTextBox.Text = "";


        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";


        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        PutFocusOnStartDate();

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void ColdMealScheduleButton_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Programs/Reports/ColdMealScheduleReport.aspx";
        ReportStartDateTextBox.Text = "";
        ReportEndDateTextBox.Text = ""; 
        ReportStartDateLabel.Text = "Report Start Date:";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportEndDateTextBox.Text = "";


        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        PutFocusOnStartDate();
        
        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }
    
    protected void InventoryOrderReport_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Kitchen/Reports/InventoryOrderReport.aspx";
        ReportStartDateTextBox.Text = "";
        ReportEndDateTextBox.Text = ""; 
        ReportStartDateLabel.Text = "Report Start Date:";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        PutFocusOnStartDate();

        ReportEndDateDiv.Style["display"] = "inline";
        ReportEndDateDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        ReportEndDateTextBox.Text = "";


        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        ReportTypeRadioButtonList.SelectedValue = "Excel";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void DeliveryReportByRangeButton_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Reports/DeliveryReportByRange.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Start Date:";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        PutFocusOnStartDate();

        ReportEndDateDiv.Style["display"] = "inline";
        ReportEndDateDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        ReportEndDateTextBox.Text = "";


        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void LinkButton6_Click(object sender, EventArgs e)
    {

    }

    protected void InventoryReport_Click(object sender, EventArgs e)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<script>");

        sb.Append("window.open('Kitchen/Reports/InventoryReport.aspx')");
        sb.Append("</script>");

        Page.RegisterStartupScript("a", sb.ToString()); 
    }

    protected void SFSPMealInformationReport_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Programs/Reports/SFSPMealInformationReport.aspx";
        ReportStartDateDiv.Style["display"] = "none";
        ReportStartDateDiv.Style["visibility"] = "hidden";
        ReportStartDateTextBox.Text = "None";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportEndDateTextBox.Text = "";


        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void CACFPMealInformationReport_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Programs/Reports/CACFPMealInformationReport.aspx";
        ReportStartDateDiv.Style["display"] = "none";
        ReportStartDateDiv.Style["visibility"] = "hidden";
        ReportStartDateTextBox.Text = "None";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportEndDateTextBox.Text = "";


        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void CACFPSiteInformationReport_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Programs/Reports/CACFPSiteInformationReport.aspx";
        ReportStartDateDiv.Style["display"] = "none";
        ReportStartDateDiv.Style["visibility"] = "hidden";
        ReportStartDateTextBox.Text = "None";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportEndDateTextBox.Text = "";


        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void SiteCodeAndCommunityAreaReport_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Programs/Reports/SiteCodeAndCommunityAreaReport.aspx";
        ReportStartDateDiv.Style["display"] = "none";
        ReportStartDateDiv.Style["visibility"] = "hidden";
        ReportStartDateTextBox.Text = "None";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportEndDateTextBox.Text = "";


        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void SFSPSiteInformationReport_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Programs/Reports/SFSPSiteInformationReport.aspx";
        ReportStartDateDiv.Style["display"] = "none";
        ReportStartDateDiv.Style["visibility"] = "hidden";
        ReportStartDateTextBox.Text = "None";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportEndDateTextBox.Text = "";


        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void CACFPComplianceSiteInformationButton_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Programs/Reports/CACFPComplianceSiteInformationReport.aspx";
        ReportStartDateDiv.Style["display"] = "none";
        ReportStartDateDiv.Style["visibility"] = "hidden";
        ReportStartDateTextBox.Text = "None";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportEndDateTextBox.Text = "";


        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void SFSPComplianceSiteInformationButton_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Programs/Reports/SFSPComplianceSiteInformationReport.aspx";
        ReportStartDateDiv.Style["display"] = "none";
        ReportStartDateDiv.Style["visibility"] = "hidden";
        ReportStartDateTextBox.Text = "None";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportEndDateTextBox.Text = "";


        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void IndividualSFSPSiteInformationSheet_Click(object sender, EventArgs e)
    {
        
        ReportNameHiddenField.Value = "Programs/Reports/IndividualSFSPSiteInformationSheet.aspx";
        ReportStartDateDiv.Style["display"] = "none";
        ReportStartDateDiv.Style["visibility"] = "hidden";
        ReportStartDateTextBox.Text = "None";
        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportEndDateTextBox.Text = "";


        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void IndividualCACFPSiteInformationSheet_Click(object sender, EventArgs e)
    {
        
        ReportNameHiddenField.Value = "Programs/Reports/IndividualCACFPSiteInformationSheet.aspx";
        ReportStartDateDiv.Style["display"] = "none";
        ReportStartDateDiv.Style["visibility"] = "hidden";
        ReportStartDateTextBox.Text = "None";
        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportEndDateTextBox.Text = "";


        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";
        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }
    
    protected void SFSPDeliveryReportButton_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Reports/SFSPDeliveryReport.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Date:";
        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        DeliveryReportParametersDiv.Style["visibility"] = "visible";
        DeliveryReportParametersDiv.Style["display"] = "inline";

        LoafSliceCountTextBox.Text = "20";
        BagBunCountTextBox.Text = "0";
        LoafCountTextBox.Text = "8";
        BagCountTextBox.Text = "0";

        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportEndDateTextBox.Text = "";


        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";


        PutFocusOnStartDate();

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void CACFPDeliveryReportButton_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Reports/CACFPDeliveryReport.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Date:";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["display"] = "inline";
        ReportFormatDiv.Style["visibility"] = "visible";

        DeliveryReportParametersDiv.Style["visibility"] = "visible";
        DeliveryReportParametersDiv.Style["display"] = "inline";

        LoafSliceCountTextBox.Text = "20";
        BagBunCountTextBox.Text = "0";
        LoafCountTextBox.Text = "8";
        BagCountTextBox.Text = "0";

        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportEndDateTextBox.Text = "";


        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        PutFocusOnStartDate();

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void DistributionByCommunity_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Programs/Reports/CCKDistributionByCommunityReport.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Start Date:";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        PutFocusOnStartDate();

        ReportEndDateDiv.Style["display"] = "inline";
        ReportEndDateDiv.Style["visibility"] = "visible";
        ReportEndDateTextBox.Text = "";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";


        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }
    protected void CACFPWeeklyOrderReport_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Programs/Reports/CACFPWeeklyOrderReport.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Start Date:";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        PutFocusOnStartDate();

        ReportEndDateDiv.Style["display"] = "inline";
        ReportEndDateDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        DeliveryReportParametersDiv.Style["visibility"] = "visible";
        DeliveryReportParametersDiv.Style["display"] = "inline";

        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";
        
        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        LoafSliceCountTextBox.Text = "20";
        BagBunCountTextBox.Text = "10";
        LoafCountTextBox.Text = "8";
        BagCountTextBox.Text = "8";

        ReportEndDateTextBox.Text = "";        

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void CACFPWeeklyOrderReportCold_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Programs/Reports/CACFPWeeklyOrderReportCold.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Start Date:";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        PutFocusOnStartDate();

        ReportEndDateDiv.Style["display"] = "inline";
        ReportEndDateDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        DeliveryReportParametersDiv.Style["visibility"] = "visible";
        DeliveryReportParametersDiv.Style["display"] = "inline";

        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        LoafSliceCountTextBox.Text = "20";
        BagBunCountTextBox.Text = "10";
        LoafCountTextBox.Text = "8";
        BagCountTextBox.Text = "8";

        ReportEndDateTextBox.Text = "";

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }



    protected void SFSPWeeklyOrderReport_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Programs/Reports/SFSPWeeklyOrderReport.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Start Date:";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        PutFocusOnStartDate();

        ReportEndDateDiv.Style["display"] = "inline";
        ReportEndDateDiv.Style["visibility"] = "visible";

        DeliveryReportParametersDiv.Style["visibility"] = "visible";
        DeliveryReportParametersDiv.Style["display"] = "inline";

        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        LoafSliceCountTextBox.Text = "20";
        BagBunCountTextBox.Text = "10";
        LoafCountTextBox.Text = "8";
        BagCountTextBox.Text = "8";

        ReportEndDateTextBox.Text = ""; 

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void CreateReportButton_Click(object sender, EventArgs e)
    {
        if (ReportStartDateTextBox.Text == "")
        {
            MessageBox.Show("Please Choose A Date In The Textbox Provided Before Attempting To Run The Report");

            ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
        }
        else if ((ReportEndDateDiv.Style["visibility"] == "visible" && String.IsNullOrEmpty(ReportEndDateTextBox.Text) == false) && Convert.ToDateTime(ReportStartDateTextBox.Text) > Convert.ToDateTime(ReportEndDateTextBox.Text))
        {
            MessageBox.Show("Please Choose A Range Start Date That Is Before The Range End Date");
            
            ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
        }
        else if (ReportEndDateDiv.Style["visibility"] == "visible" && String.IsNullOrEmpty(ReportEndDateTextBox.Text) == true)
        {
            MessageBox.Show("Please Choose A Range End Date For The Report");

            ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
        }
        else
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<script>");

            sb.Append("window.open('" + ReportNameHiddenField.Value + "?");

            sb.Append("ReportType=" + ReportTypeRadioButtonList.SelectedItem.Text);

            sb.Append("&LabelReportText=" + LabelTextTextBox.Text);

            sb.Append("&ReportStartDate=" + ReportStartDateTextBox.Text);

            sb.Append("&ReportEndDate=" + ReportEndDateTextBox.Text);

            sb.Append("&MealType=" + MealTypeDropDownList.SelectedItem.Value);

            sb.Append("&ScheduleType=" + ScheduleTypeDropDownList.SelectedItem.Value);

            sb.Append("&CommunityArea=" + CommunityAreaDropDownList.SelectedItem.Value);

            sb.Append("&SiteName=" + SiteNameDropDownList.SelectedItem.Value);

            sb.Append("&BagCount=" + BagCountTextBox.Text);

            sb.Append("&LoafCount=" + LoafCountTextBox.Text);

            sb.Append("&SliceCount=" + LoafSliceCountTextBox.Text);

            sb.Append("&BunCount=" + BagBunCountTextBox.Text);

            sb.Append("')");

            sb.Append("</script>");

            Page.RegisterStartupScript("a", sb.ToString());
        }

        ReportTypeRadioButtonList.SelectedValue = "PDF";
        MealTypeDropDownList.SelectedIndex = MealTypeDropDownList.Items.IndexOf(MealTypeDropDownList.Items.FindByText("SELECT MEAL TYPE"));
        SiteNameDropDownList.SelectedIndex = SiteNameDropDownList.Items.IndexOf(SiteNameDropDownList.Items.FindByText("SELECT SITE NAME"));
        CommunityAreaDropDownList.SelectedIndex = CommunityAreaDropDownList.Items.IndexOf(CommunityAreaDropDownList.Items.FindByText("SELECT COMMUNITY AREA"));
    }

    protected void SiteCountMealTotalReportByRange_Click(object sender, EventArgs e)
    {
        CommunityAreaDropDownList.Attributes["onchange"] = "javascript:hideSite()";
        SiteNameDropDownList.Attributes["onchange"] = "javascript:hideMealTypeCommunityArea()";

        ReportNameHiddenField.Value = "Programs/Reports/SiteCountMealTotalReportByRange.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Start Date:";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        PutFocusOnStartDate();

        ReportEndDateDiv.Style["display"] = "inline";
        ReportEndDateDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        CommunityAreaDiv.Style["display"] = "inline";
        CommunityAreaDiv.Style["visibility"] = "visible";

        SiteNameDiv.Style["display"] = "inline";
        SiteNameDiv.Style["visibility"] = "visible";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        ReportEndDateTextBox.Text = "";

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void UnduplicatedParticipationReportByRange_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Programs/Reports/UnduplicatedParticipationReportByRange.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Start Date:";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";


        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        PutFocusOnStartDate();

        ReportEndDateDiv.Style["display"] = "inline";
        ReportEndDateDiv.Style["visibility"] = "visible";

        ReportEndDateTextBox.Text = "";

        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void SFSPProgramsLabelReport_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Programs/Reports/SFSPProgramsLabelReport.aspx";

        ReportTextDiv.Style["display"] = "inline";
        ReportTextDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["display"] = "none";
        ReportFormatDiv.Style["visibility"] = "hidden";

        ReportStartDateDiv.Style["display"] = "none";
        ReportStartDateDiv.Style["visibility"] = "hidden";
        ReportStartDateTextBox.Text = "None";
        LabelTextTextBox.Text = "";

        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportEndDateTextBox.Text = "";

        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void CACFPProgramsLabelReport_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Programs/Reports/CACFPProgramsLabelReport.aspx";

        ReportTextDiv.Style["display"] = "inline";
        ReportTextDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["display"] = "none";
        ReportFormatDiv.Style["visibility"] = "hidden";

        ReportStartDateDiv.Style["display"] = "none";
        ReportStartDateDiv.Style["visibility"] = "hidden";
        ReportStartDateTextBox.Text = "None";
        LabelTextTextBox.Text = "";

        ReportEndDateDiv.Style["display"] = "none";
        ReportEndDateDiv.Style["visibility"] = "hidden";
        ReportEndDateTextBox.Text = "";

        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void AverageRecipeCostPerDateRange_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Kitchen/Reports/AverageRecipeCostPerDateRange.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Start Date:";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        PutFocusOnStartDate();

        ReportEndDateDiv.Style["display"] = "inline";
        ReportEndDateDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";

        ReportEndDateTextBox.Text = "";
        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }

    protected void NutritionEducationCountReport_Click(object sender, EventArgs e)
    {
        ReportNameHiddenField.Value = "Programs/Reports/NutritionEducationCountReport.aspx";
        ReportStartDateTextBox.Text = "";
        ReportStartDateLabel.Text = "Report Start Date:";

        ReportStartDateDiv.Style["display"] = "inline";
        ReportStartDateDiv.Style["visibility"] = "visible";

        ReportEndDateDiv.Style["display"] = "inline";
        ReportEndDateDiv.Style["visibility"] = "visible";

        ReportFormatDiv.Style["display"] = "visible";
        ReportFormatDiv.Style["visibility"] = "inline";
        MealTypeDiv.Style["display"] = "none";
        MealTypeDiv.Style["visibility"] = "hidden";

        CommunityAreaDiv.Style["visibility"] = "hidden";
        CommunityAreaDiv.Style["display"] = "none";

        SiteNameDiv.Style["visibility"] = "hidden";
        SiteNameDiv.Style["display"] = "none";

        ReportTextDiv.Style["visibility"] = "hidden";
        ReportTextDiv.Style["display"] = "none";

        DeliveryReportParametersDiv.Style["visibility"] = "hidden";
        DeliveryReportParametersDiv.Style["display"] = "none";

        mealsPerBoxDiv.Style["display"] = "hidden";
        mealsPerBoxDiv.Style["visibility"] = "none";

        ReportEndDateTextBox.Text = "";

        PutFocusOnStartDate();

        ClientScript.RegisterStartupScript(GetType(), "key", "launchModal();", true);
    }
}
