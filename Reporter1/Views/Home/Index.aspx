<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Report creator Home page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    <p>
        This project site create reports of a work time for a programmers department <a href="http://ungvar.dyndns.org/Reporter" title=" Веб-сайт ungvar.dyndns.org Reporter">http://ungvar.dyndns.org/Reporter</a>.
    </p>
</asp:Content>
