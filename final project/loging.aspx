<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="loging.aspx.cs" Inherits="loging" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link  rel ="stylesheet" href="style.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    
    <form  action="logingcheck.aspx" method="post"  class="form-container">
        <input placeholder ="username"  name ="usernameTxt" type="text" >
        <input  placeholder = "password" name= "passwordTxt" type = "password" >
        <input action="Submit1" type ="submit" value ="submit" />
        <label> this is a label for = <a href ="Registration.aspx">  Registration</a></label>
    </form> 
   
</asp:Content>

