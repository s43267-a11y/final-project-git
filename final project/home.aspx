<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
       <link  rel ="stylesheet" href="style.css"/>
     
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <h1>this is the home page</h1>

 
    


<div class="carousel-wrapper">
    <button class="prev-btn">&#8592;</button>
    <div class="scroll-container">


        <div class="recipe-showcase">
            <img  class ="photo-recipe"  src="images/istockphoto-1413553779-612x612.jpg" />
            <h3> the perfect chicken alfredo pasta recipe :</h3>
            <p> Creamy, comforting, and packed with flavor, Chicken Alfredo Pasta is a classic Italian-American dish that brings restaurant-quality taste straight to your kitchen. This recipe features tender, seasoned chicken breasts served over a bed of perfectly cooked fettuccine, all  ...</p>
            <h5> for more click  <a href="#">here</a></h5>
        </div>

        <div class="recipe-showcase">
            <img  class ="photo-recipe" src="images/Untitled.jpeg" />
            <h3> best smash burger recipe ever</h3>
            <p>The smash burger is a fan favorite thanks to its crispy edges, juicy center, and bold flavor. Unlike thick burgers, smash burgers are flattened on a hot griddle for maximum browning and a crave-worthy crust. Simple, ...</p>
            <h5> for more click  <a href="#">here</a></h5>
        </div>

        <div class="recipe-showcase">
            <img class="photo-recipe" src="images/Lasagna-PNG-Background.png" />
            <h3> a great lasagna recipe</h3>
            <p>  This classic homemade lasagna recipe features layers of tender pasta, rich and hearty meat sauce, creamy béchamel, and melted cheese, baked to golden perfection.It's the ultimate comfort food—perfect for family dinners, special occasions, or just  when you need a warm, satisfyin ...</p>
           <h5> for more click  <a href="#">here</a></h5>
        </div>

        <div class="recipe-showcase">4</div>
        <div class="recipe-showcase">5</div>
    </div>
    <button class="next-btn">&#8594;</button>
</div>






    <script>
        const container = document.querySelector('.scroll-container');
        const nextBtn = document.querySelector('.next-btn');
        const prevBtn = document.querySelector('.prev-btn');

        const cardWidth = 320 + 15; // card width + gap
        let scrollPosition = 0;

        nextBtn.addEventListener('click', () => {
            if (scrollPosition < container.scrollWidth - container.clientWidth) {
                scrollPosition += cardWidth;
                container.scrollTo({ left: scrollPosition, behavior: 'smooth' });
            }
        });

        prevBtn.addEventListener('click', () => {
            if (scrollPosition > 0) {
                scrollPosition -= cardWidth;
                container.scrollTo({ left: scrollPosition, behavior: 'smooth' });
            }
        });

    </script>


</asp:Content>

