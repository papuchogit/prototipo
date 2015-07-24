<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="ActualizarDocentes.aspx.vb" Inherits="WebForm_Docentes_ActualizarDocentes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CI" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="CI" HeaderText="CI" ReadOnly="True" SortExpression="CI" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
            <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
            <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
            <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
            <asp:BoundField DataField="Especialidad" HeaderText="Especialidad" SortExpression="Especialidad" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="DeleteDocentes" InsertMethod="InsertDocente" OldValuesParameterFormatString="original_{0}" SelectMethod="Getdocentes" TypeName="docenteBLL" UpdateMethod="UpdateDocente">
        <DeleteParameters>
            <asp:Parameter Name="CI" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="CI" Type="Int32" />
            <asp:Parameter Name="Nombre" Type="Int32" />
            <asp:Parameter Name="Apellido" Type="Int32" />
            <asp:Parameter Name="Direccion" Type="Int32" />
            <asp:Parameter Name="Telefono" Type="Int32" />
            <asp:Parameter Name="email" Type="Int32" />
            <asp:Parameter Name="Especialidad" Type="Int16" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="CI" Type="Int32" />
            <asp:Parameter Name="Nombre" Type="Int32" />
            <asp:Parameter Name="Apellido" Type="Int32" />
            <asp:Parameter Name="Direccion" Type="Int32" />
            <asp:Parameter Name="Telefono" Type="Int32" />
            <asp:Parameter Name="email" Type="Int32" />
            <asp:Parameter Name="Especialidad" Type="Int16" />
        </UpdateParameters>
    </asp:ObjectDataSource>
</asp:Content>

