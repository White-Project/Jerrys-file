<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Item.aspx.cs" Inherits="BestTry.Item" ClientIDMode="Static" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divItem">
        <table>
            <tr>
                <td width="20%"><asp:Image ID="imgItemImage" DataImageUrlFormatString="~\Graphics\{0}" SortExpression="Image" runat="server"/></td>
                <td>
                    <asp:Label ID="LbProductlable" runat="server" Text="Product" Font-Bold="True"></asp:Label>
                    &nbsp;<asp:Label ID="LbProduct" runat="server" Text='<%# Bind("ItemName") %>'></asp:Label>
                    &nbsp;<br />
                    <asp:Label ID="LbPricelable" runat="server" Text="Price" Font-Bold="True"></asp:Label>
                    &nbsp;<asp:Label ID="LbPrice" CssClass="money" runat="server" Text='<%# Bind("Price", "{0:$##.##}") %>'></asp:Label>
                    <br />
                    <asp:Label ID="LbDesclable" runat="server" Text="Description" Font-Bold="True"></asp:Label>
                    &nbsp;<asp:Label ID="LbDesc" runat="server" Text='<%# Bind("Description") %>' ClientIDMode="Static"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
