<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/bootstrap.js"></script>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:400px;">
            
  <!-- Email input -->
  <div class="form-outline mb-4">
    <%--<input type="email" id="txtEmail" class="form-control" runat="server"  />--%>
      <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server"></asp:TextBox>
    <label class="form-label" for="form2Example1">Email address</label>
  </div>

  <!-- Password input -->
  <div class="form-outline mb-4">
    <%--<input type="password" id="txtPassword" class="form-control" runat="server"/>--%>
      <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
    <label class="form-label" for="form2Example2">Password</label>
  </div>

  <!-- 2 column grid layout for inline styling -->
  <div class="row mb-4">
    <div class="col d-flex justify-content-center">
      <!-- Checkbox -->
      <div class="form-check">
        <input class="form-check-input" type="checkbox" value="" id="check"  runat="server" />

        <label class="form-check-label" for="form2Example31"> Remember me </label>
      </div>
    </div>

    <div class="col">
      <!-- Simple link -->
      <a href="#!">Forgot password?</a>
    </div>
  </div>

  <!-- Submit button -->
  <%--<button type="button" class="btn btn-primary btn-block mb-4">Sign in</button>--%>
            <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary btn-block mb-4" Text="Sign in" OnClick="Button1_Click" />

  <!-- Register buttons -->
  <div class="text-center">
    <p>Not a member? <a href="#!">Register</a></p>
    <p>or sign up with:</p>
    <button type="button" class="btn btn-link btn-floating mx-1">
      <i class="fab fa-facebook-f"></i>
    </button>

    <button type="button" class="btn btn-link btn-floating mx-1">
      <i class="fab fa-google"></i>
    </button>

    <button type="button" class="btn btn-link btn-floating mx-1">
      <i class="fab fa-twitter"></i>
    </button>

    <button type="button" class="btn btn-link btn-floating mx-1">
      <i class="fab fa-github"></i>
    </button>
  </div>
        </div>


        
        
    </form>
</body>
</html>
