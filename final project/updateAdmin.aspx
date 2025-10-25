<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="updateAdmin.aspx.cs" Inherits="updateAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
       <link  rel ="stylesheet" href="style.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">




       
     <form action ="updateAdminCheck.aspx" method="post" class="form-container" > 

    <label>username :</label> <input name="userName_3" id="userName_3" type="text" value ="<%=row["userName"] %> " /> <br /> 
      <label>password :</label> <input name="passWord_3" type="text" value ="<%=row["passWord"] %>"/><br />
      <label>email :</label> <input  name="email_3" type="text" value ="<%=row["email"] %>"/> <br />
      <label>firstname :</label> <input name="firstName_3" type="text"  value ="<%=row["privateName"] %>"/> <br />
      <label>lastname :</label> <input name="lastName_3" type="text"  value ="<%=row["lastName"] %>"/> <br /> 
     <label>addres :</label> <input name="addres_3" type="text"  value ="<%=row["addres"] %>"/> <br /> 
      <label> birthdate : </label><input name="date_3" type="date" value="<%=date %>"  /> <br/>

     <label> gander select :</label>
     <input name="Gender_2" type="radio" value="0" <% =s0 %> /> male 
       <input name="Gender_2" type="radio" value="1" <%= s1 %> /> female <br />

         <label> is andmin:</label>
         <input name ="admin" type="checkbox" <%=s3 %> /><br />

     <label> phone number : </label>  <select name ="phone_select_2"> <%=userDb.GetPhoneOptions_2((int)row["phoneCode"]) %> </select> 
     <input name="phoneNumber_2" type="text" value ="<%=row["phoneNumber"] %>"/><br />
 
     <label> city : </label> <select name ="ctiy_selcet_2"> <%=userDb.GetCityOptions_2((int)row["city2"])%> </select><br />

    <input name="Submit_upd" action="submit3" type="submit" value="update"/>
 </form>
  
</asp:Content>

