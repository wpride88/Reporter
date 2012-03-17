<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Reporter1.Models.jobs>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Create</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Jid) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Jid) %>
                <%: Html.ValidationMessageFor(model => model.Jid) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Jname) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Jname) %>
                <%: Html.ValidationMessageFor(model => model.Jname) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Date) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Date) %>
                <%: Html.ValidationMessageFor(model => model.Date) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Jtimeh) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Jtimeh) %>
                <%: Html.ValidationMessageFor(model => model.Jtimeh) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Uid) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Uid) %>
                <%: Html.ValidationMessageFor(model => model.Uid) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Jtid) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Jtid) %>
                <%: Html.ValidationMessageFor(model => model.Jtid) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

