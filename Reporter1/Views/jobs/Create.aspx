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

            <div> 
                <asp:Label
                    runat="server"
                    class="editor-label" id="Jname" title="Название работы">Название задания
                </asp:Label>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Jname) %>
                <%: Html.ValidationMessageFor(model => model.Jname) %>
            </div>
            
            <div class="editor-label">
                <asp:Label
                    runat="server"
                    class="editor-label" id="Data" title="Дата">Дата
                </asp:Label>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Date) %>
                <%: Html.ValidationMessageFor(model => model.Date) %>
            </div>
            
            <div class="editor-label">
                <asp:Label
                    runat="server"
                    class="editor-label" id="Timeh" title="Время">Время потраченное на работу (часов)
                </asp:Label>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Jtimeh) %>
                <%: Html.ValidationMessageFor(model => model.Jtimeh) %>
            </div>
            
            <div class="editor-label">
                <asp:Label
                    runat="server"
                    class="editor-label" id="Login" title="Login">Ваше Имя пользователя (Login)
                </asp:Label>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.UsersRP.Login) %>
                <%: Html.ValidationMessageFor(model => model.UsersRP.Login)%>
            </div>
            
            <div class="editor-label">
                                <asp:Label
                    runat="server"
                    class="editor-label" id="TimeID" title="Тип времени">Тип времени (Self time, Rest time etc.)
                </asp:Label>
            </div>

            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.jobtype.JTitle) %>
                <%: Html.ValidationMessageFor(model => model.jobtype.JTitle)%>
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

