<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForms._Default" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">    

    <br/>
    <h2>Consumir Servicios Rest</h2>    
    <hr>        
        <asp:Button ID="btnHttpWebRequest" runat="server" Text="Consumir con HttpWebRequest" OnClick="btnHttpWebRequest_Click" Width="198px" BackColor="#99CCFF" />  
        <asp:Button ID="btnWebClient" runat="server" Text="Consumir con WebClient" OnClick="btnWebClient_Click" Width="171px" BackColor="#66FF66" />
        <asp:Button ID="btnBorrar" runat="server" Text="BorrarGrid" OnClick="btnBorrar_Click" Width="93px" BackColor="Red" ForeColor="White" />
    <hr />
    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
        <Columns>
            <asp:BoundField DataField="ruc" HeaderText="Ruc" SortExpression="ruc" />
            <asp:BoundField DataField="estado" HeaderText="Estado" SortExpression="estado" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
            <asp:BoundField DataField="calle" HeaderText="Calle" SortExpression="calle" />
            <asp:BoundField DataField="numero" HeaderText="Numero" SortExpression="numero" />
        </Columns>
        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#594B9C" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#33276A" />
    </asp:GridView>
   
    
    </asp:Content>

<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    </asp:Content>


