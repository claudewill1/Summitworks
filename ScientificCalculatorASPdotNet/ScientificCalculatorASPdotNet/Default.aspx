<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ScientificCalculatorASPdotNet._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET Scientific Calculator</h1>

        

    </div>
    <div class="container">
        <asp:Panel ID="Panel1" runat="server" GroupingText="Calculator" Width="410px" Height="400px" style="margin-top: 0px">
            <asp:Table ID="Calculator" runat="server">
                <asp:TableRow runat="server">
                    
                    <asp:TableCell style="align-content: center" >
                        <asp:TextBox ID="TextBox1" runat="server" align="Center" Width="400px" MARGIN-LEFT="auto" Margin-RIGHT="auto"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                
            </asp:Table>
            <br />
            <asp:Table runat="server" Width="54px">
                <asp:TableRow runat="server">
                    <asp:TableCell ID="calcTable1" runat="server">
                        <asp:TableRow runat="server" Height="10px">
                            
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell style="align-content:center" Width="60px" Height="60px">
                                <asp:Button ID="btn1" Text="1" runat="server" align="center" Width="50px" Height="50px" />
                            </asp:TableCell>
                            <asp:TableCell style="align-content:center" Width="60px" Height="60px">
                                <asp:Button ID="btn2" Text="2" runat="server" Width="50" Height="50" align="center" />
                            </asp:TableCell>
                            <asp:TableCell style="align-content:center" Width="60px" Height="60px">
                            </asp:TableCell>
                            <asp:TableCell style="align-content:center" Width="60px" Height="60px">
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </asp:Panel>
     </div>



</asp:Content>
