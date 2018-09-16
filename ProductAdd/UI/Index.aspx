<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ProductAdd.UI.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Product</title>
    <link rel="stylesheet" type="text/css" href="../Content/bootstrap.css" />
</head>
<body>
    <form id="form1" runat="server">
     <div class="container">
        <div class="row">
            <div class="col-4">
                <div class="list-group">
                  <a href="Display.aspx" class="list-group-item list-group-item-action">Show Product</a>
                </div>
            </div>
            <div class="col-8">
                 <div class="card">
                    <div class="card-header">
                        <strong>Add Book</strong><br/>
                        <strong><asp:Label ID="msgLabel" runat="server"></asp:Label></strong>
                    </div>
                    <div class="card-body">
                         <div class="row form-group">
                             <div class="col-3">Product Code</div>
                             <div class="col-6">
                                 <asp:TextBox runat="server" ID="productCodeTextbox" CssClass="form-control"></asp:TextBox>
                             </div>
                        </div>
                        <div class="row form-group">
                             <div class="col-3">Description</div>
                             <div class="col-6">
                                 <asp:TextBox runat="server" ID="descriptionTextBox" CssClass="form-control"></asp:TextBox>
                             </div>
                          </div>
                             <div class="row form-group">
                                 <div class="col-3">Quantity</div>
                                 <div class="col-6">
                                     <asp:TextBox runat="server" ID="quantityTextBox" CssClass="form-control"></asp:TextBox>
                                 </div>
                             </div>
                        <div class="row form-group">
                            <div class="col-6"></div>
                            <div class="col-3">
                                 <asp:Button runat="server" ID="productAddButton" Text="Add Product" CssClass="btn btn-outline-info btn-block" OnClick="productAddButton_Click"    />
                             </div>
                        </div>
                         </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
