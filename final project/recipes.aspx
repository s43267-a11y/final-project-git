<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="recipes.aspx.cs" Inherits="recipes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      <div class="recipe-page">
        <div class="recipe-container">
            <h1><%= row_3["heading"] %></h1>

            <img src='<%= "images/" + row_3["img"] %>'
                 alt="Recipe Image"
                 class="recipe-image">

            <section class="recipe-description">
           
                <p><%= row_3["description"] %></p>
            </section>

            <section class="recipe-ingredients">
            
                <div class="ingredient-list">
                    <%= row_3["ingredenats-list"] %>
                </div>
            </section>

            <section class="recipe-steps">
            
                <div class="steps-list">
                    <%= row_3["steps"] %>
                </div>
            </section>


         <% if (Session["id"] != null) { %>
        <form method="post" action="AddToFavorites.aspx">
        <input type="hidden" name="recipeId" value="<%= row_3["id"] %>" />
        <button type="submit" class="fav-btn">❤️ Add to Favorites</button>`
        </form>
         <% } else { %>
        <p><a href="loging.aspx">Login</a> to add this recipe to your favorites.</p>
          <% } %>

        <a href="home.aspx" class="back-btn">← Back to Home</a>
        </div>
    </div>

</asp:Content>

