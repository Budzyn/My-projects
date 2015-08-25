<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<tests.Models.Tasks>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Details</h2>
    <fieldset>
        <legend>Fields</legend>
        <div class="display-label">
            Name</div>
        <div class="display-field">
            <%: Model.Name %></div>
        <div class="display-label">
            Article</div>
        <div class="display-field">
            <%: Model.Article %></div>
    </fieldset>
    <p>
        <%: Html.ActionLink("Edit", "Edit", new { id=Model.TaskId }) %>
        |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
</asp:Content>
