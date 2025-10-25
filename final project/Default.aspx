<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
       <link  rel ="stylesheet" href="style.css"/>
     
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1> this is the home page</h1>


<div class="carousel-wrapper">
    <button class="prev-btn">&#8592;</button>
    <div class="scroll-container">
        <div class="recipe-showcase">1</div>
        <div class="recipe-showcase">2</div>
        <div class="recipe-showcase">3</div>
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

