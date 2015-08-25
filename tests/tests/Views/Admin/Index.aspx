<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<tests.Models.Tasks>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Index</h2>
    <table>
        <tr>
            <th>
            </th>
            <th>
                Name
            </th>
            <th>
                Article
            </th>
        </tr>
        <% foreach (var item in Model)
           { %>
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.TaskId }) %>
                |
                <%: Html.ActionLink("Details", "Details", new { id=item.TaskId })%>
                |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.TaskId })%>
            </td>
            <td>
                <%: item.Name %>
            </td>
            <td>
                <%: item.Article %>
            </td>
        </tr>
        <% } %>
    </table>
    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>
</asp:Content>
