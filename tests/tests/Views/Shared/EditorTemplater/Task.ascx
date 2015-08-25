<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<tests.Models.Tasks>" %>
<div class="editor-label">
    <%: Html.LabelFor(model => model.Name) %>
</div>
<div class="editor-field">
    <%: Html.TextBoxFor(model => model.Name) %>
    <%: Html.ValidationMessageFor(model => model.Name) %>
</div>
<div class="editor-label">
    <%: Html.LabelFor(model => model.Article) %>
</div>
<div class="editor-field">
    <%: Html.EditorFor(model => model.Article) %>
    <%: Html.ValidationMessageFor(model => model.Article) %>
</div>

