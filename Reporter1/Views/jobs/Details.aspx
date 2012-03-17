<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Reporter1.Models.jobs>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Details</h2>

    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">Jid</div>
        <div class="display-field"><%: Model.Jid %></div>
        
        <div class="display-label">Jname</div>
        <div class="display-field"><%: Model.Jname %></div>
        
        <div class="display-label">Date</div>
        <div class="display-field"><%: String.Format("{0:g}", Model.Date) %></div>
        
        <div class="display-label">Jtimeh</div>
        <div class="display-field"><%: Model.Jtimeh %></div>
        
        <div class="display-label">Uid</div>
        <div class="display-field"><%: Model.Uid %></div>
        
        <div class="display-label">Jtid</div>
        <div class="display-field"><%: Model.Jtid %></div>
        
    </fieldset>
    <p>

        <%: Html.ActionLink("Edit", "Edit", new { id=Model.Jid }) %> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

