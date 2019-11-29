<%@ Page Title="Yoklama Görüntüle" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewInspaction.aspx.cs" Inherits="Bitirme_Web.ViewInspaction" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">   
    <div class="row">
        <div class="col-md-3">
            <asp:Image ID="Image1" runat="server" Height="240px" ImageUrl="~/Images/userimage.png" Width="240px" />
        </div>
        <div class="col-md-8">
            <h1>
                <asp:Label ID="lbl_Usertitle" runat="server" Text="lbl_Usertitle"></asp:Label>
            </h1>         
            <h2>
                <asp:Label ID="lbl_Userdept" runat="server" Text="lbl_Userdept"></asp:Label>
            </h2>           
            <h3>
                <asp:Label ID="lbl_Usermail" runat="server" Text="lbl_Usermail"></asp:Label>
            </h3>
            <h3>
                <asp:Label ID="lbl_Userphone" runat="server" Text="lbl_Userphone"></asp:Label>
            </h3>
        </div>
    </div>
    <hr /> 
    <asp:ImageButton ID="ImageButton1" runat="server" Height="50px" ImageUrl="~/Images/pdf.png" Width="50px" OnClick="ImageButton1_Click" OnClientClick="document.forms[0].target='_blank';" />
    &nbsp;  
    &nbsp;
    <asp:ImageButton ID="ImageButton2" runat="server" Height="50px" ImageUrl="~/Images/excel.jpg" Width="50px" OnClick="ImageButton2_Click" OnClientClick="document.forms[0].target='_blank';" />    
    <hr /> 
    <asp:Panel ID="Panel1" runat="server">
        <hr />
         <asp:Label ID="labelresults" runat="server" Text=""></asp:Label>
        <hr />
         <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="false">
        <ContentTemplate>
             <div class="row" style="width:100%;">
        <asp:DataList ID="DataList1" runat="server" Width="100%">
            <HeaderTemplate>
                    <table style="width: 100%">
                        <tr>
                            <td style="text-align: left; width:19%">
                                <asp:Label runat="server" CssClass="col-md-10 control-label" Text="TCK NO"></asp:Label> 
                            </td>
                            <td style="text-align: left; width:19%">
                                <asp:Label runat="server" CssClass="col-md-10 control-label" Text="Ad"></asp:Label>
                            </td>
                            <td style="text-align: left; width:19%">
                                <asp:Label runat="server" CssClass="col-md-10 control-label" Text="Soyad"></asp:Label> 
                            </td>
                            <td style="text-align: left; width:19%">
                                <asp:Label runat="server" CssClass="col-md-10 control-label" Text="Dönem"></asp:Label>
                            </td>
                            <td style="text-align: left; width:12%">
                                <asp:Label runat="server" CssClass="col-md-10 control-label" Text="1. Yarı"></asp:Label>
                            </td>
                            <td style="text-align: left; width:12%">
                                <asp:Label runat="server" CssClass="col-md-10 control-label" Text="2. Yarı"></asp:Label> 
                            </td>
                        </tr>
                    </table>
                <hr/>
                </HeaderTemplate>
            <ItemTemplate>
                    <table style="width: 100%">
                        <tr>
                            <td style="text-align: left; width:19%">
                                <asp:Label ID="label1" runat="server" CssClass="col-md-10 control-label" Text='<%# Eval("StudentID") %>'></asp:Label>
                            </td>
                            <td style="text-align: left; width:19%">
                                <asp:Label ID="label2" runat="server" CssClass="col-md-10 control-label" Text='<%# Eval("StudentName") %>'></asp:Label>
                            </td>
                            <td style="text-align: left; width:19%">
                                <asp:Label ID="label3" runat="server" CssClass="col-md-10 control-label" Text='<%# Eval("StudentSurname") %>'></asp:Label>
                            </td>
                            <td style="text-align: left; width:19%">
                                <asp:Label ID="label4" runat="server" CssClass="col-md-10 control-label" Text='<%# Eval("StudentPeriod") %>'></asp:Label>
                            </td>
                            <td style="text-align: left; width:12%">
                                <asp:Image ID="Image2" runat="server" Height="15px" ImageUrl='<%# "http://localhost:49173/Images/"+ Eval("InspectionLessonFirstHalf")+".png" %> ' Width="15px" />
                            </td>
                            <td style="text-align: left; width:12%">
                                <asp:Image ID="Image3" runat="server" Height="15px" ImageUrl='<%# "http://localhost:49173/Images/"+ Eval("InspectionLessonLastHalf")+".png" %> ' Width="15px" />
                            </td>
                        </tr>
                    </table>
                <hr/>
                </ItemTemplate>
        </asp:DataList>        
    </div>
        </ContentTemplate>
        <Triggers>           
        </Triggers>
    </asp:UpdatePanel> 
    </asp:Panel>       
 </asp:Content>