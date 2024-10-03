<?php
  include "connection.php"
?>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="test.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-aFq/bzH65dt+w6FI2ooMVUpc+21e0SRygnTpmBvdBgSdnuTN7QbdgL+OapgHtvPp" crossorigin="anonymous">    <script defer src="https://use.fontawesome.com/releases/v5.15.4/js/all.js" integrity="sha384-rOA1PnstxnOBLzCLMcre8ybwbTmemjzdNlILg8O7z1lUkLXozs4DHonlDtnE7fpc" crossorigin="anonymous"></script>
    <script type="text/javascript">
      function preventBack(){window.history.forward()};
      setTimeout("preventBack()",0);
       window.onunload=function(){null;}

    </script>
</head>
<body>
<nav class="navbar navbar-expand-lg navbar-light bg-light py-3 fixed-top">
    <div class="container">
      <a href="#">
      <img src="./others/img/brand.png" alt="" class="logo">
    </a>
    <h1 class="brand2">DRINK</h1>
    <h1 class="brand2">RESPONSIBLY </h1>
      <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse nav-buttons" id="navbarSupportedContent">
        <ul class="navbar-nav me-auto mb-2 mb-lg-0">
          <li class="nav-item">
            <a class="nav-link" href="test.php">Home</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="search.html">Shop</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="about.html">About</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="contact.html">Contact</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="cart.html">
              <i class="fas fa-shopping-bag"></i>
            </a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="account.php">
              <i class="fas fa-user"></i>
            </a>
          </li>
        </ul>
      </div>
    </div>
  </nav>
        
     
      <section class="my-5 pt-5">
        <div class="container text-center mt-3 pt-5">
            <h2 class="form-weight-bold">Login</h2>
            <hr class="max-auto">
        </div>
        <div class="mx-auto container">
    <form id="login-form" method="POST">
        <div class="form-group">
            <label>Username</label>
            <input type="text" class="form-control" id="login-email" name="Email" placeholder="Email" required>
        </div>
        <div class="form-group">
            <label>Password</label>
            <input type="password" class="form-control" id="login-password" name="Password" placeholder="Password" required>
        </div>
        <div class="form-group">
            <input type="submit" class="btn" id="login-btn" name="submit" value="Login">
        </div>
        <div class="form-group">
            <a id="register-url" class="btn" href="register.php">Don't Have an Account? Register</a>
        </div>
    </form>
</div>
<?php
session_start();

if (isset($_SESSION['Email'])) {
  header("Location: account.php");
  exit();
}

if (isset($_POST["submit"])) {
  $email = $_POST["Email"];
  $password = $_POST["Password"];
 
  $sql = "SELECT * FROM user_login WHERE email=? AND password=?";
  $stmt = mysqli_prepare($conn, $sql);
  mysqli_stmt_bind_param($stmt, "ss", $email, $password);
  mysqli_stmt_execute($stmt); 
  $res = mysqli_stmt_get_result($stmt);

  if (mysqli_num_rows($res) == 1) {
    $row = mysqli_fetch_assoc($res);
    if ($row['status'] == 0) {
      $_SESSION['Email'] = $email;
      
      mysqli_stmt_close($stmt);
      mysqli_close($conn);
      
      header('Location: account.php');
      exit();
    } else {
      $error = "Your account is currently deactivated.";
      // Prevent login if the account is deactivated
      echo "<p style='color:red'>$error</p>";
    }
  } else {
    echo "<p style='color:red'>Incorrect email or password</p>";
  }

  mysqli_stmt_close($stmt);
  mysqli_close($conn);
}
?>







 
      <footer class="mt-5 py-5">

        <div class="row container mx-auto pt-3">
          <div class="footer-one col-lg-3 col-md-6 col-sm-12">
            <img src="./others/img/brand.png" alt="" class="logo">
            <p class="pt-3">We provide the best food for the most affordable prices</p>
          </div>
          <div class="footer-one col-lg-3 col-md-6 col-sm-12">
            <h5 class="pb-2">Featured</h5>
            <ul class="text-uppercase">
              <li><a href="#">Best Liqour Foods</a></li>
              <li><a href="#">Awesome Liqours</a></li>
              <li><a href="#">Tasty Liqours</a></li>
              <li><a href="#">Exotic Liqours</a></li>
              <li><a href="admin.php">Admin Login</a></li>
              
            </ul>
          </div>
          <div class="footer-one col-lg-3 col-md-6 col-sm-12">
            <h5 class="pb-2">Contact Us</h5>
            <div>
              <h6 class="text-uppercase">Address</h6>
              <p>1234 Bankerohan, Davao City</p>
            </div>
            <div>
              <h6 class="text-uppercase">Phone</h6>
              <p>09613866827</p>
            </div>
            <div>
              <h6 class="text-uppercase">Email</h6>
              <p>alfred.hat21@gmail.com <br> a.melencion.530710@umindanao.edu.ph</p>
            </div>
          </div>
          <div class="footer-one col-lg-3 col-md-6 col-sm-12">
            <h5 class="pb-2">Instagram</h5>
            <div class="row">
              <img src="./others/img/rhlogo.png" class="img-fluid w-25 h-100 m-2">
              <img src="./others/img/ginlogo.png" class="img-fluid w-25 h-100 m-2">
              <img src="./others/img/tanduaylogo.png" class="img-fluid w-25 h-100 m-2">
              <img src="./others/img/brand.png" class="img-fluid w-25 h-100 m-2">
            </div>
          </div>
        </div>
  
        <div class="copyright mt-5">
          <div class="row container mx-auto">
            <div class="col-lg-3 col-md-5 col-sm-12 mb-4 ">
              <img src="/others/img/payment.jpg" alt="">
            </div>
            <div class="col-lg-3 col-md-5 col-sm-12 mb-4 text-nowrap mb-2">
              <p>eCommerce @ 2023 All Rights Reserved</p>
            </div>
            <div class="col-lg-3 col-md-5 col-sm-12 mb-4">
           <a href="#"><i class="fab fa-facebook"></i></a>
           <a href="#"><i class="fab fa-twitter"></i></a>
           <a href="#"><i class="fab fa-instagram"></i></a>
         
            </div>
          </div>
        </div>
      
      </footer>

      <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
</body>
</html>