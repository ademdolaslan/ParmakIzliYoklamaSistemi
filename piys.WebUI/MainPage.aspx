<%@ Page Title="Ana Sayfa" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Bitirme_Web.MainPage"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">      
    <div class="row" style="width:100%;">
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
    <hr />
    &nbsp;  
    &nbsp;  
    &nbsp;  
    &nbsp;  
    <div class="row" style="width:100%;">        
        <asp:DataList ID="dtlLessons" runat="server" Width="100%" OnItemCommand="dtlLessons_ItemCommand">
            <HeaderTemplate>
                <table style="width: 100%">
                    <tr>
                        <td style="text-align: left; width: 15%">
                            <asp:Label runat="server" CssClass="col-md-10 control-label">Ders Kodu</asp:Label>
                        </td>
                        <td style="text-align: left; width: 25%">
                            <asp:Label runat="server" CssClass="col-md-10 control-label">Ders Adı</asp:Label> 
                        </td>
                        <td style="text-align: left; width: 20%">
                            <asp:Label runat="server" CssClass="col-md-10 control-label">Hafta Bilgisi</asp:Label>                             
                        </td>
                        <td style="text-align: left; width: 20%">
                            <asp:Label runat="server" CssClass="col-md-10 control-label">Gün Bilgisi</asp:Label>                             
                        </td>
                        <td style="text-align: left; width: 20%">
                             &nbsp;    
                        </td>
                    </tr>
                </table>
                <hr />
            </HeaderTemplate>
            <ItemTemplate>                 
                <table style="width: 100%">
                    <tr>
                        <td style="text-align: left; width: 15%">
                            <asp:Label runat="server" CssClass="col-md-4 control-label" Text=""><%# Eval("LessonID") %></asp:Label>
                        </td>
                        <td style="text-align: left; width: 25%">
                            <asp:Label runat="server" CssClass="col-md-10 control-label"><%# Eval("LessonName") %></asp:Label> 
                        </td>
                        <td style="text-align: left; width: 20%">
                            <asp:DropDownList ID="ddlweek" runat="server" CssClass="form-control" Width="159px" OnSelectedIndexChanged="ddlweek_SelectedIndexChanged" >
                                <asp:ListItem Value="0">Hafta Seçiniz</asp:ListItem>
                                <asp:ListItem Value="1">Hafta 1</asp:ListItem>
                                <asp:ListItem Value="2">Hafta 2</asp:ListItem>
                                <asp:ListItem Value="3">Hafta 3</asp:ListItem>
                                <asp:ListItem Value="4">Hafta 4</asp:ListItem>
                                <asp:ListItem Value="5">Hafta 5</asp:ListItem>
                                <asp:ListItem Value="6">Hafta 6</asp:ListItem>
                                <asp:ListItem Value="7">Hafta 7</asp:ListItem>
                                <asp:ListItem Value="8">Hafta 8</asp:ListItem>
                                <asp:ListItem Value="9">Hafta 9</asp:ListItem>
                                <asp:ListItem Value="10">Hafta 10</asp:ListItem>
                                <asp:ListItem Value="11">Hafta 11</asp:ListItem>
                                <asp:ListItem Value="12">Hafta 12</asp:ListItem>
                                <asp:ListItem Value="13">Hafta 13</asp:ListItem>
                                <asp:ListItem Value="14">Hafta 14</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td style="text-align: left; width: 20%">
                            <asp:DropDownList ID="ddlday" runat="server" CssClass="form-control"  Width="159px" OnSelectedIndexChanged="ddlday_SelectedIndexChanged">
                                <asp:ListItem Value="0">Gün Seçiniz</asp:ListItem>
                                <asp:ListItem Value="1">Pazartesi</asp:ListItem>
                                <asp:ListItem Value="2">Salı</asp:ListItem>
                                <asp:ListItem Value="3">Çarşamba</asp:ListItem>
                                <asp:ListItem Value="4">Perşembe</asp:ListItem>
                                <asp:ListItem Value="5">Cuma</asp:ListItem>
                                <asp:ListItem Value="6">Cumartesi</asp:ListItem>
                                <asp:ListItem Value="7">Pazar</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td style="text-align: left; width: 20%">
                                <asp:Button ID="btnview" runat="server" Text="Görüntüle" CssClass="btn btn-default" CommandName="göster" CommandArgument='<%# Eval("LessonID") %>'/>
                        </td>
                    </tr>
                </table>
                <hr />
                 &nbsp;  
                 &nbsp;
            </ItemTemplate>
        </asp:DataList>        
    </div>  
</asp:Content>
