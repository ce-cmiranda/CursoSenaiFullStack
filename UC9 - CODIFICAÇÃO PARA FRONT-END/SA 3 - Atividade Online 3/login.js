// https://www.simplilearn.com/tutorials/javascript-tutorial/email-validation-in-javascript
function ValidateEmail(input) {

    var validRegex = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
  
    if (input.match(validRegex)) {
  
      alert("Valid email address!");
  
    //   document.form1.text1.focus();
  
      return true;
  
    } else {
  
      alert("Email inválido. Tente novamente!");
  
    //   document.form1.text1.focus();
  
      return false;
  
    }
  
  }

function ValidatePassword(password)
{
    testPass = password != ""
    if (testPass)
    {
        return true
    }
    else
    {
        alert("Senha inválida!")
        return false
    }
}
function login()
{
    alert("Login realizado com sucesso");
    email = document.forms[0].elements[0].value
    password = document.forms[0].elements[1].value
    if (ValidateEmail(email) && ValidatePassword(password))
    {
        
        document.getElementById("loginForm").style.display = "none";
        document.getElementById("loggedInPage").style.visibility = "";
        document.getElementById("loggedInPage").children[0].innerHTML = document.getElementById("loggedInPage").children[0].innerHTML.replace("{{user}}",email)
    }
}