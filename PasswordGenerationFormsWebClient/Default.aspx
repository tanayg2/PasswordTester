<%@ Page Title="String Analyzer" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PasswordGenerationFormsWebClient._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>String Analyzer</h1>
        Please enter a string:<br />
        <asp:TextBox ID="txtInput" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:Button ID="submitBtn" runat="server" OnClick="submit_Click" Text="Submit" />
        <br />
        Vowel Count:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="vowelCtOutLbl" runat="server" Text=" "></asp:Label>
        <br />
        Upper Case Count:&nbsp;&nbsp;&nbsp; <asp:Label ID="upperCtOutLbl" runat="server" Text=" "></asp:Label>
        <br />
        Reverse:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="reverseOutLbl" runat="server" Text=" "></asp:Label>
        <br />
        <br />
        <asp:Label ID="ErrorLbl" runat="server" Text=" "></asp:Label>
    </div>

    </asp:Content>
