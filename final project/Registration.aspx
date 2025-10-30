<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Regstrison" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link  rel ="stylesheet" href="style.css"/>

</asp:Content>
                  
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 










 
<script type="text/javascript">
    function IsValid() {
        var inname = document.getElementById('inname');
        var fname = document.getElementById('fname');
        var male = document.getElementById('male');
        var female = document.getElementById('female');
        var num = document.getElementById('num');
        var mail = document.getElementById('mail');
        var name = document.getElementById('name');
        var pwd = document.getElementById('pwd');
        var ipwd = document.getElementById('ipwd');
        var addres = document.getElementById('addres');
        var errorSummary = document.getElementById('ErrorSummary');

        // איפוס צבעים
        [inname, fname, num, mail, name, pwd, ipwd, addres].forEach(function (el) {
            if (el) el.style.backgroundColor = "white";
        });

        var Msg = "";
        var valid = true;

        if (inname.value.trim() === "") {
            Msg += "נא להזין שם פרטי<br/>";
            valid = false;
            inname.style.backgroundColor = "red";
        }

        if (fname.value.trim() === "") {
            Msg += "נא להזין שם משפחה<br/>";
            valid = false;
            fname.style.backgroundColor = "red";
        }

        if (!male.checked && !female.checked) {
            Msg += "בחר מין<br/>";
            valid = false;
        }

        if (num.value.trim() === "") {
            Msg += "נא להזין מס' טלפון<br/>";
            valid = false;
            num.style.backgroundColor = "red";
        } else if (isNaN(num.value) || num.value.length != 7) {
            Msg += "נא להזין מספר טלפון תקין<br/>";
            valid = false;
            num.style.backgroundColor = "red";
        }

        var emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        if (mail.value.trim() === "") {
            Msg += "נא להזין כתובת מייל<br/>";
            valid = false;
            mail.style.backgroundColor = "red";
        } else if (!emailPattern.test(mail.value)) {
            Msg += "נא להזין כתובת מייל תקינה<br/>";
            valid = false;
            mail.style.backgroundColor = "red";
        }

        if (name.value.trim() === "") {
            Msg += "נא להזין שם משתמש<br/>";
            valid = false;
            name.style.backgroundColor = "red";
        }

        if (pwd.value.trim() === "") {
            Msg += "נא להזין סיסמה<br/>";
            valid = false;
            pwd.style.backgroundColor = "red";
        }

        

        if (addres.value.trim() === "") {
            Msg += "נא להזין כתובת<br/>";
            valid = false;
            addres.style.backgroundColor = "red";
        }

        errorSummary.innerHTML = Msg;

        if (valid) {
            return confirm("אתה בטוח בפרטיך?");
        } else {
            return false;
        }
    }
</script>

  <div class="ex1">  
  <h1> hello this is Registration</h1> 
 
   <form  onsubmit ="return IsValid()" action ="registrationCheck.aspx" name="form" id="form" method="post" class="form-container"> 

      <label>username :</label> <input name="userName_2" type="text" id="name"/> <br /> 
        <label>password :</label> <input name="passWord_2" type="password" id="pwd"/><br />
        <label>email :</label> <input  name="email_2" type="email"id="mail"/> <br />
        <label>firstname :</label> <input name="firstName_2" type="text" id="inname"/> <br />
        <label>lastname :</label> <input name="lastName_2" type="text" id="fname"/> <br /> 
       <label>addres :</label> <input name="addres_2" type="text" id="addres"/> <br /> 
         <label> brithdate : </label><input name="date_2" type="date" /><br />
      
       <label> gander select :</label>
       <input name="Gender" type="radio" value="0" id="male" class="radio-group" /> male
         <input name="Gender" type="radio" value="1"id="female" class="radio-group"/> female <br />

       <label> phone number : </label>  <select name ="phone_select"> <%=kidometSelector.GetPhoneOption() %> </select> 
       <input name="phoneNumber" type="text" id="num" /><br />

       <label> city : </label> <select name ="ctiy_selcet"> <%=citySelector.GetCityOption() %> </select><br />

      <input name="Submit_reg" action="submit2" type="submit" value="send"/>
       <div class="ErrorSummary" id="ErrorSummary"></div>
   </form>
      </div>
    





</asp:Content>


