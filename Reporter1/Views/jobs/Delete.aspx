<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Reporter1.Models.jobs>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Delete</h2>

    <h3>Are you sure you want to delete this?</h3>
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
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Delete" /> |
		    <%: Html.ActionLink("Back to List", "Index") %>
        </p>
    <% } %>

</asp:Content>

