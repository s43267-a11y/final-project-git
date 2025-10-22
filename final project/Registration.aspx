<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Regstrison" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link  rel ="stylesheet" href="style.css"/>

</asp:Content>
                  
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 










     <h1> hello this is Registration</h1> 
  
    <form action ="registrationCheck.aspx" method="post" class="form-container"> 

       <label>username :</label> <input name="userName_2" type="text"/> <br /> 
         <label>password :</label> <input name="passWord_2" type="password"/><br />
         <label>email :</label> <input  name="email_2" type="email" /> <br />
         <label>firstname :</label> <input name="firstName_2" type="text"/> <br />
         <label>lastname :</label> <input name="lastName_2" type="text"/> <br /> 
        <label>addres :</label> <input name="addres_2" type="text"/> <br /> 
          <label> brithdate : </label><input name="date_2" type="date"/><br />
       
        <label> gander select :</label>
        <input name="Gender" type="radio" value="0" class="radio-group" /> male
          <input name="Gender" type="radio" value="1" class="radio-group"/> female <br />

        <label> phone number : </label>  <select name ="phone_select"> <%=kidometSelector.GetPhoneOption() %> </select> 
        <input name="phoneNumber" type="text" /><br />
 
        <label> city : </label> <select name ="ctiy_selcet"> <%=citySelector.GetCityOption() %> </select><br />

       <input name="Submit_reg" action="submit2" type="submit" value="send"/>
    </form>
   
   





</asp:Content>


