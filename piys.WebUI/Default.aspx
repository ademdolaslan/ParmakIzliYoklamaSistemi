<%@ Page Title="Giriş Yap" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Bitirme_Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
        <div class="row">
            <asp:Image ID="Image1" runat="server" Height="344px" ImageUrl="~/Images/bilecik.jpg" Width="100%" />
            <hr />
          <div class="col-md-10" style="text-align:center;"> 
              <asp:Image ID="Image2" runat="server" Height="200px" Width="200px" ImageUrl="~/Images/user-image.png" />
           </div>
           <div class="col-md-10" >
               <div class="form-horizontal">
                &nbsp;
                &nbsp;                 
                <div  class="form-group"  style="margin-left:200px">                    
                    <asp:Label runat="server" CssClass="col-md-2 control-label">Kullanıcı Adı</asp:Label>
                    <div class="col-md-10">
                      <asp:TextBox runat="server" ID="tbUserName" CssClass="form-control" required />
                    </div>
                </div>
                <div class="form-group"  style="margin-left:200px">
                    <asp:Label runat="server" CssClass="col-md-2 control-label">Şifre</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="tbUserPassword" CssClass="form-control" TextMode="Password" required/>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-offset-5 col-md-10">
                    <asp:Button runat="server"  Text="Oturum Aç" CssClass="btn btn-default" OnClick="Unnamed3_Click"/>
                    </div>
                </div>
            </div>
           </div>  
        </div> 
</asp:Content>
