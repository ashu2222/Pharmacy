<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="pharma.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            text-align: center;
            margin-left: 40px;
        }
        .auto-style4 {
            margin-left: 120px;
        }
        .auto-style5 {
            margin-left: 220px;
        }
        .auto-style6 {
            margin-left: 221px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <tr>
            <td class="auto-style4" style="background-image: url('15.jpg')">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2" style="background-color: #FFFF00">
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink>
                        </td>
                        <td class="auto-style2" style="background-color: #FF0000">
                            <asp:HyperLink ID="HyperLink2" runat="server">Brands</asp:HyperLink>
                        </td>
                        <td class="auto-style2" style="background-color: #0000FF">
                            <asp:HyperLink ID="HyperLink3" runat="server">Products</asp:HyperLink>
                        </td>
                        <td class="auto-style3" style="background-color: #008080">
                            <asp:HyperLink ID="HyperLink4" runat="server">Search</asp:HyperLink>
                        </td>
                        <td class="auto-style2" style="background-color: #C0C0C0">
                            <asp:HyperLink ID="HyperLink5" runat="server">ContactUs</asp:HyperLink>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" ForeColor="#FF6666" Text="Add Brand" PostBackUrl="~/Brand.aspx" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" ForeColor="#6600FF" Text="Add Product" PostBackUrl="~/Product.aspx" />
                <br />
                <br />
                <br />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong>Brand Details<br />
                <br />
                </strong>
 
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Brand Name" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="#FFFF99" CssClass="auto-style5" Width="326px">
                    <Columns>
                        <asp:BoundField DataField="Brand Name" HeaderText="Brand Name" ReadOnly="True" SortExpression="Brand Name" />
                        <asp:BoundField DataField="Number of product" HeaderText="Number of product" SortExpression="Number of product" />
                    </Columns>
                    <RowStyle BackColor="#3399FF" BorderColor="Black" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Database2ConnectionString %>" SelectCommand="SELECT * FROM [HomeBrand]"></asp:SqlDataSource>
                <br />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>Product Details<br />
                </strong>
                <br />
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="#99CCFF" CssClass="auto-style6" DataKeyNames="Brand Name" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" Width="403px">
                    <Columns>
                        <asp:BoundField DataField="Brand Name" HeaderText="Brand Name" ReadOnly="True" SortExpression="Brand Name" />
                        <asp:BoundField DataField="Product Name" HeaderText="Product Name" SortExpression="Product Name" />
                        <asp:BoundField DataField="Available Quantity" HeaderText="Available Quantity" SortExpression="Available Quantity" />
                    </Columns>
                    <RowStyle BackColor="#FF0066" BorderColor="Black" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Database2ConnectionString %>" SelectCommand="SELECT * FROM [ProductTable]"></asp:SqlDataSource>
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>
    </form>
</asp:Content>
