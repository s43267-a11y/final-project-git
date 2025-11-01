<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="user.aspx.cs" Inherits="home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel ="stylesheet" href="style.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
<h1>My Favorite Recipes</h1>

<div class="favorites-container">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <a href='recipes.aspx?id=<%# Eval("ID") %>' class="favorite-link">
                <div class="favorite-card">
                    <img src='images/<%# Eval("img") %>' alt='<%# Eval("heading") %>' />
                    <h2><%# Eval("heading") %></h2>
                    <p><%# Eval("description").ToString().Length > 80 ? Eval("description").ToString().Substring(0, 80) + "..." : Eval("description") %></p>
                </div>
            </a>
        </ItemTemplate>
    </asp:Repeater>
</div>

    
      
</asp:Content>

