<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
       <link  rel ="stylesheet" href="style.css"/>
     
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<section class="hero">
  <div class="hero-content">
    <h1>Welcome to <span class="gradient-text">RecipeWorld</span></h1>
    <p>Discover, cook, and share your favorite recipes — all in one place.</p>
    <a href="#carousel-wrapper-id" class="hero-btn">Explore Recipes</a>
  </div>
</section>


<!-- SEARCH BAR SECTION -->
<section class="search-section">
    <h2 class="search-title">Find Your Favorite Recipe</h2>
    <div class="search-wrapper">
        <input
            type="text"
            id="recipeSearch"
            placeholder="Search recipes..."
            onkeyup="filterRecipes()"
        />
        <button type="button" class="search-btn">
            <i class="fas fa-search"></i>
        </button>
    </div>
</section>
    


<div class="carousel-wrapper" id="carousel-wrapper-id">
    <button class="prev-btn">&#8592;</button>
    <div class="scroll-container">


        <div class="recipe-showcase">
            <img  class ="photo-recipe"  src="images/istockphoto-1413553779-612x612.jpg" />
            <h3> the perfect chicken alfredo pasta recipe :</h3>
            <p> Creamy, comforting, and packed with flavor, Chicken Alfredo Pasta is a classic Italian-American dish that brings restaurant-quality taste straight to your kitchen. This recipe features tender, seasoned chicken breasts served over a bed of perfectly cooked fettuccine, all  ...</p>
            <h5> for more click  <a href="recipes.aspx?id=1">here</a></h5>
        </div>

        <div class="recipe-showcase">
            <img  class ="photo-recipe" src="images/Untitled.jpeg" />
            <h3> best smash burger recipe ever</h3>
            <p>The smash burger is a fan favorite thanks to its crispy edges, juicy center, and bold flavor. Unlike thick burgers, smash burgers are flattened on a hot griddle for maximum browning and a crave-worthy crust. Simple, ...</p>
            <h5> for more click  <a href="recipes.aspx?id=2">here</a></h5>
        </div>

        <div class="recipe-showcase">
            <img class="photo-recipe" src="images/Lasagna-PNG-Background.png" />
            <h3> a great lasagna recipe</h3>
            <p>  This classic homemade lasagna recipe features layers of tender pasta, rich and hearty meat sauce, creamy béchamel, and melted cheese, baked to golden perfection.It's the ultimate comfort food—perfect for family dinners, special occasions, or just  when you need a warm, satisfyin ...</p>
           <h5> for more click  <a href="recipes.aspx?id=3">here</a></h5>
        </div>

   <div class="recipe-showcase">
  <img class="photo-recipe" src="images/garlickpasta.jpg" />
  <h3>Creamy Garlic Parmesan Pasta</h3>
  <p>
    This creamy garlic parmesan pasta is rich, comforting, and ready in under 30 minutes. 
    Tender pasta is coated in a silky sauce made with butter, cream, garlic, and Parmesan cheese. 
    Simple to make yet full of flavor — perfect for a cozy dinner.
  </p>
  <h5>for more click <a href="recipes.aspx?id=4">here</a></h5>
</div>



 <div class="recipe-showcase">
  <img class="photo-recipe" src="images/cookie.jpg" />
  <h3>Soft Chocolate Chip Cookies</h3>
  <p>
    These homemade chocolate chip cookies are soft, chewy, and loaded with chocolate chips. 
    Crisp at the edges and tender in the center, they’re the perfect sweet treat for any occasion. 
    Serve warm with a glass of milk for the ultimate comfort.
  </p>
  <h5>for more click <a href="recipes.aspx?id=5">here</a></h5>
</div>

    </div>
    <button class="next-btn">&#8594;</button>
</div>


     <!-- ABOUT SECTION -->
        <section class="about-section">
            <div class="about-content">
                <h2>About RecipeWorld</h2>
                <p>
                    At RecipeWorld, we believe that cooking should be simple, joyful, and shared with others.
                    Our platform connects food lovers from around the world — from beginners to seasoned chefs.
                </p>
                <p>
                    Explore thousands of recipes, save your favorites, and inspire others by sharing your own creations.
                    Whether it’s a family dinner or a new dessert experiment, RecipeWorld is here to make it easy and fun.
                </p>

            </div>
        </section>






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


        function filterRecipes() {
            const searchInput = document.getElementById("recipeSearch").value.toLowerCase();
            const recipes = document.querySelectorAll(".recipe-showcase");

            recipes.forEach((recipe) => {
                const title = recipe.querySelector("h3").textContent.toLowerCase();
                const desc = recipe.querySelector("p").textContent.toLowerCase();
                if (title.includes(searchInput) || desc.includes(searchInput)) {
                    recipe.style.display = "flex";
                } else {
                    recipe.style.display = "none";
                }
            });
        }

        document.addEventListener("DOMContentLoaded", () => {
            const heroBtn = document.querySelector(".hero-btn");

            if (heroBtn) {
                heroBtn.addEventListener("click", (event) => {
                    event.preventDefault(); // stop instant jump

                    const target = document.querySelector(heroBtn.getAttribute("href"));
                    if (target) {
                        const offset = 60; // adjust for navbar height if needed
                        const targetPosition = target.getBoundingClientRect().top + window.scrollY - offset;

                        window.scrollTo({
                            top: targetPosition,
                            behavior: "smooth"
                        });
                    }
                });
            }
        });

       

    </script>


</asp:Content>

