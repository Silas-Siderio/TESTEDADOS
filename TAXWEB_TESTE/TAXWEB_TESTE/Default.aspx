<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TAXWEB_TESTE._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ARQUIVO DADOS</h1>
        <p class="lead">Projeto que realiza leitura de um arquivo *.txt e armazena na base de dados.</p>
        <p> 
            <table style="width:100%;">
                <tr>
                    <td>
                        <asp:FileUpload ID="fup" runat="server" onclick="fup_Click" />
                        <asp:Label ID="StatusLabel" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Importar Dados" Width="328px" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3" style="height: 158px">
                        <asp:GridView ID="GridView1" runat="server" CellPadding="4" Font-Size="Small" ForeColor="#333333" GridLines="None" Width="724px" AutoGenerateColumns="False">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                            <Columns>

                             <asp:BoundField DataField="comprador" HeaderText="Comprador" />
                             <asp:BoundField DataField="descricao" HeaderText="Descrição" />
                             <asp:BoundField DataField="preco" HeaderText="Preço" />
                             <asp:BoundField DataField="quantidade" HeaderText="Qtd" />
                             <asp:BoundField DataField="endereco" HeaderText="Endereço" />
                             <asp:BoundField DataField="fornecedor" HeaderText="Fornecedor" />
                            
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>&nbsp;</h2>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
        </div>
        <div class="col-md-4">
            <h2>&nbsp;</h2>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
        </div>
        <div class="col-md-4">
            <h2>&nbsp;</h2>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
        </div>
    </div>

</asp:Content>
