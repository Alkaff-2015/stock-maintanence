<%@ Page Title="" Language="C#" MasterPageFile="~/Mainlayout.Master" AutoEventWireup="true" CodeBehind="ProductsEntry.aspx.cs" Inherits="RealTechHub.ProductsEntry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="page-wrapper">
        <div class="tab-content">
            <div class="panel panel-default">
                <div class="panel-body">
                    <div class="form-group">
                        <label class="col-md-2 control-label">Product Name</label>
                        <div class="col-md-6">
                            <div class="input-group in-grp1">
                                <asp:TextBox type="text" runat="server" id="txtproductname" class="form-control1" placeholder="Product Name"></asp:TextBox>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="form-group">
                        <label class="col-md-2 control-label">Supplier ID</label>
                        <div class="col-md-6">
                            <div class="input-group in-grp1">
                                
                                <asp:TextBox runat="server" ID="txtsupplier" class="form-control1" placeholder="SupplierID"></asp:TextBox>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="form-group">
                        <label class="col-md-2 control-label">Category ID</label>
                        <div class="col-md-6">
                            <div class="input-group in-grp1">
                                <asp:TextBox type="text" runat="server" id="txtctegoryid" class="form-control1" placeholder="Category ID"></asp:TextBox>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="form-group">
                        <label class="col-md-2 control-label">Quantity Per Unit</label>
                        <div class="col-md-6">
                            <div class="input-group in-grp1">
                                <asp:TextBox type="text" runat="server" id="txtQuantityPerUnit" class="form-control1" placeholder="Quantity Per Unit"></asp:TextBox>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="form-group">
                        <label class="col-md-2 control-label">Unit Price</label>
                        <div class="col-md-6">
                            <div class="input-group in-grp1">
                                <asp:TextBox type="text" runat="server" id="txtUnitPrice" class="form-control1" placeholder="Unit Price"></asp:TextBox>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <%--<div class="form-group">
                        <label class="col-md-2 control-label">UnitsInStock</label>
                        <div class="col-md-6">
                            <div class="input-group in-grp1">
                                <asp:TextBox type="text" ID="txtUnitsInStock" runat="server" class="form-control1" placeholder="Email Address"></asp:TextBox>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>--%>
                    <div class="form-group">
                        <label class="col-md-2 control-label">Units In Stock</label>
                        <div class="col-md-6">
                            <div class="input-group in-grp1">
                                <asp:TextBox type="text" runat="server" id="txtUnitsInStock" class="form-control1" placeholder="Units In Stock"></asp:TextBox>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="form-group">
                        <label class="col-md-2 control-label">Units On Order</label>
                        <div class="col-md-6">
                            <div class="input-group in-grp1">
                                <asp:TextBox type="text" runat="server" id="txtUnitsOnOrder" class="form-control1" placeholder="Units On Order"></asp:TextBox>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="form-group">
                        <label class="col-md-2 control-label">Reorder Level</label>
                        <div class="col-md-6">
                            <div class="input-group in-grp1">
                                <asp:TextBox type="text" runat="server" id="txtReorderLevel" class="form-control1" placeholder="Reorder Level"></asp:TextBox>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="form-group">
                        <label class="col-md-2 control-label">Discontinued</label>
                        <div class="col-md-6">
                            <div class="input-group in-grp1">
                                <asp:TextBox type="text" runat="server" id="txtDiscontinued" class="form-control1" placeholder="Discontinued"></asp:TextBox>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>    
                    <div class="panel-footer">
							<div class="row">
								<div class="col-sm-8 col-sm-offset-2">
									<asp:Button ID="txtsubmit" OnClick="txtsubmit_Click" runat="server" class="btn-success btn" Text="Submit" />
									<asp:Button ID="txtcancel" runat="server" class="btn-default btn" Text="Cancel" />
								</div>
							</div>
						 </div>                
                </div>
            </div>
        </div>
    </div>
</asp:Content>
