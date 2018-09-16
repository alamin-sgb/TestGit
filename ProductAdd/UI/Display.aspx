<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="ProductAdd.UI.Display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>All Product</title>
    <link rel="stylesheet" type="text/css" href="../Content/bootstrap.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-4">
                <div class="list-group">
                  <a href="Index.aspx" class="list-group-item list-group-item-action">Add Product</a>
                </div>
            </div>
            <div class="col-8">
                 <div class="card">
                    <div class="card-header">
                        <strong>All Product</strong>
                    </div>
                    <div class="card-body">
                        <asp:PlaceHolder ID="dataViewall" runat="server"></asp:PlaceHolder>
                            <div class="row">
                                <div class="col-4"></div>
                                <div class="col-8">
                                    <div class="row">
                                        <div class="col-8">Total Quantity</div>
                                            <div class="col-4">
                                                <asp:Label ID="total" runat="server"></asp:Label>
                                            </div>
                                    </div>
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
