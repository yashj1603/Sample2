<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Products/ProductMaster.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Sample2.Views.Products.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SampleApplication" runat="server">
    <div class="row">
        <div class="col bg-warning">
            <h4 class="text-center">Manage Products</h4>
        </div>
    </div>
    <div class="row">
        <div class="col-5">
            <div class="row mt-2">
                <div class="col">
                     <div class="mb-2">
     <label>Product ID</label>
     <input type="text" runat="server" id="PIdTb" class="form.control"/>
 </div>
                </div>
                               <div class="col">
                    <div class="mb-2">
    <label>Product Name</label>
    <input type="text" runat="server" id="PNameTb" class="form.control"/>
</div>
               </div>
            </div>
            <div class="row mt-2">
                <div class="col">
                     <div class="mb-2">
     <label>Product Description</label>
     <input type="text" runat="server" id="PDescriptionTb" class="form.control"/>
 </div>
                                        <div class="mb-2">
    <label>User Name</label>
    <input type="text" runat="server" id="UNameTb" class="form.control"/>
</div>
                </div>
                               <div class="col">
                    <div class="mb-2">
    <label>Category Name</label>
    <input type="text" runat="server" id="CNameTb" class="form.control"/>
</div>
               </div>
            </div>
            <div class="row">
                <label class="text-center text-danger" id="ErrMsg" runat="server"></label>
                <div class="col d-grid">
                    <asp:Button Text="Save" runat="server" Class="btn btn-warning btn-block" OnClick="Unnamed1_Click" />
                </div>
                <div class="col d-grid">
    <asp:Button Text="Edit" runat="server" ID="EditBtn" Class="btn btn-primary btn-block" OnClick="EditBtn_Click" />
</div>
                <div class="col d-grid">
    <asp:Button Text="Delete" runat="server" ID="DeleteBtn" Class="btn btn-danger btn-block" OnClick="DeleteBtn_Click" />
</div>
                <div class="col d-grid">
    <asp:Button Text="Search" runat="server" Class="btn btn-success btn-block" OnClick="Unnamed2_Click" />
</div>
            </div>
        </div>
        <div class="col-7">
            <div class="row">
                <div class="col"><h6 class="text-center text-primary">Products List</h6></div>
            </div>
            <asp:GridView runat="server" ID="ProductsList" class="table" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="ProductsList_SelectedIndexChanged" >
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
        </div>
    </div>
</asp:Content>
