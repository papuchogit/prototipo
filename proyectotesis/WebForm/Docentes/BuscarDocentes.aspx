<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="BuscarDocentes.aspx.vb" Inherits="WebForm_Docentes_BuscarDocentes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Consultar docentes:</h1>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <img alt="" class="style2" src="http://localhost:1104/Pictures/clientes.jpg" /></p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Ingrese el Nombre o Apellido del docnete que desea consultar"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Buscar" />
    </p>
    <p>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="DeleteDocentes" InsertMethod="InsertDocente" OldValuesParameterFormatString="original_{0}" SelectMethod="GetdocentebyApellido" TypeName="docenteBLL" UpdateMethod="UpdateDocente">
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
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox1" Name="Apellido" PropertyName="Text" Type="String" />
            </SelectParameters>
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
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="CI" DataSourceID="ObjectDataSource1" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="CI" HeaderText="CI" ReadOnly="True" SortExpression="CI" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="Especialidad" HeaderText="Especialidad" SortExpression="Especialidad" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
    </p>
    <p>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DeleteMethod="DeleteDocentes" InsertMethod="InsertDocente" OldValuesParameterFormatString="original_{0}" SelectMethod="GetdocentebyNombre" TypeName="docenteBLL" UpdateMethod="UpdateDocente">
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
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox1" Name="Nombre" PropertyName="Text" Type="String" />
            </SelectParameters>
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
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="CI" DataSourceID="ObjectDataSource2" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="CI" HeaderText="CI" ReadOnly="True" SortExpression="CI" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="Especialidad" HeaderText="Especialidad" SortExpression="Especialidad" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>

