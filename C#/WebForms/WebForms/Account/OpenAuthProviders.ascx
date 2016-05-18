<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OpenAuthProviders.ascx.cs" Inherits="WebForms.Account.OpenAuthProviders" %>
<%@ Import Namespace="Microsoft.AspNet.Membership.OpenAuth" %>
<fieldset class="open-auth-providers">
    <legend>Iniciar sesión con otro servicio</legend>
    
    <asp:ListView runat="server" ID="providersList" ViewStateMode="Disabled">
        <ItemTemplate>
            <button type="submit" name="provider" value="<%# HttpUtility.HtmlAttributeEncode(Item<ProviderDetails>().ProviderName) %>"
                title="Iniciar sesión con su <%# HttpUtility.HtmlAttributeEncode(Item<ProviderDetails>().ProviderDisplayName) %> cuenta.">
                <%# HttpUtility.HtmlEncode(Item<ProviderDetails>().ProviderDisplayName) %>
            </button>
        </ItemTemplate>
    
        <EmptyDataTemplate>
            <div class="message-info">
                <p>No hay ningún servicio de autenticación externa configurado. Consulte <a href="http://go.microsoft.com/fwlink/?LinkId=252803">este artículo</a> para obtener más detalles sobre la configuración de esta aplicación ASP.NET para que admita el inicio de sesión a través de servicios externos.</p>
            </div>
        </EmptyDataTemplate>
    </asp:ListView>
</fieldset>