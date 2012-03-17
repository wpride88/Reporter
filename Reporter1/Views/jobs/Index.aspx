<%@ Page Title="wpride88" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage<IEnumerable<Reporter1.Models.jobs>>" %>
<%@ Import Namespace="Reporter1.Controllers" %>

<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        //System.Web.UI.Page wp = new System.Web.UI.Page();
        ///string firstName = (string)(Session["LgUser"]);
        // Items.Add(firstName);
    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index page of <%: Page.User.Identity.Name %> jobs
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

        <form id="form1" runat="server">

        <h2>Hello,  <%: Page.User.Identity.Name %>. This is Main jobs report creater page.&nbsp;
      <%--<%
                string s = Page.User.Identity.Name.ToString();
                string sss = s; %>
            <%  string firstName = (string)(Session["LgUser"]);   %>   --%>        
           
           <asp:SqlDataSource ID="SqlDataSource1" runat="server"
            ConnectionString="<%$ ConnectionStrings:REPORTERConnectionString %>"
            SelectCommand="SELECT * FROM [SumTimeview2] WHERE ([Login] = @Login)">
                <SelectParameters>
                    <asp:SessionParameter Name="Login" SessionField="LgUser" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                ConnectionString="<%$ ConnectionStrings:REPORTERConnectionString2 %>" 
                SelectCommand="SELECT [Login] FROM [UsersRP]"></asp:SqlDataSource>
        
        </h2>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" 
            GridLines="None" AllowPaging="True">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Date" HeaderText="Дата" SortExpression="Date" />
                <asp:BoundField DataField="JTitle" HeaderText="Тип времени" 
                    SortExpression="JTitle" />
                <asp:BoundField DataField="Login" HeaderText="Имя работника" 
                    SortExpression="Login" />
                <asp:BoundField DataField="SumTime1" HeaderText="Суммарное время" 
                    SortExpression="SumTime1" />
                <asp:BoundField DataField="Jname" HeaderText="Название работы" 
                    SortExpression="Jname" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="Black" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
     <p>
                <%: Html.ActionLink("Create New", "Create") %>

    </p>

        </form>

</asp:Content>

