<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="BestTry.Products" ClientIDMode="Static" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="tbContainer">
        <tr>
            <td width="20%" >
                <div id="divListCategories">
                    <asp:BulletedList ID="BLCategories" runat="server" DisplayMode="LinkButton" OnClick="BLCategories_Click"></asp:BulletedList>
                </div>
            </td>
            <td width="80%">
                    <asp:GridView ID="GVProducts" runat="server" AutoGenerateColumns="False" ShowHeader="False" BorderStyle="None" GridLines="None">
                        <Columns>
                            <asp:ImageField DataImageUrlField="Image" DataImageUrlFormatString="~\Graphics\{0}" HeaderText="Image" SortExpression="Image" ShowHeader="False">
                            </asp:ImageField>
                            <asp:TemplateField HeaderText="Price" SortExpression="Price" ShowHeader="False">
                                <ItemTemplate>
                                    <asp:Label runat="server" Text="Product:"></asp:Label>
                                    <a href='Item.aspx?ItemId=<%# Eval("ItemId") %>'><asp:Label ID="LBItemName" runat="server" Text='<%# Bind("ItemName") %>'></asp:Label></br></a>
                                    </br>
                                    <asp:Label runat="server" Text="Description:"></asp:Label></br>
                                    <a href='Item.aspx?ItemId=<%# Eval("ItemId") %>'><asp:Label ID="LBDescription" runat="server" Text='<%# Bind("Description") %>'></asp:Label></a>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Price" SortExpression="Price" ShowHeader="False">
                                <ItemTemplate>
                                    <asp:Label runat="server" Text="Price"></asp:Label>
                                    <asp:Label ID="LBPrice" class="money" runat="server" Text='<%# Bind("Price", "{0:$##.##}") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
