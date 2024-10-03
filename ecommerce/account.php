
<?php
session_start();

if (!isset($_SESSION['Email'])) {
  header("Location: login.php");
  exit();
}
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

</head>
<body><nav class="navbar navbar-expand-lg navbar-light bg-light py-3 fixed-top">
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
  


      <section class="orders container my-5 py-5">
        <div class="row container mx-auto">
            <div class="text-center mt-3 pt-5 col-lg-6 col-md-12 col-sm-12">
                <h3 class="font-weight-bold">Account Info</h3>
                <hr> 
                <div class="account-info">
                    <p>Email <span id="orders-btn"><?php echo $_SESSION['Email']; ?></span></p>
                    
                    <p><a href="" id="orders-btn">Your Orders</a></p>
                    <p><a href="logout.php" id="logout-btn">Logout</a></p>
                </div>
            </div>
            <div class="col-lg-6 col-md-12 col-sm-12">
                <form id="account-form">
                    <h3>Change Password</h3>
                    <hr class="mx-auto">
                    <div class="form-group">
                        <label>Password</label>
                        <input type="password" class="form-control" id="account-password" name="password" placeholder="password">

                    </div>
                    <div class="form-group">
                        <label>Confirm Password</label>
                        <input type="password" class="form-control" id="account-password-confirm" name="confirm-password" placeholder="password">

                    </div>
                    <div class="form-group">
                        <input type="submit" value="Change Password" class="btn" id="change-pass-btn">
                    </div>
                </form>
            </div>
        </div>
      </section>
      <section class="orders container my-2 py-5">
        <div class="container mt-5">
            <h2 class="font-weight-bolde text-center">Your Orders</h2>
            <hr class="mx-auto"
        </div>

        <table class="mt-5 pt-5">
            <tr>
                <th>Product</th>
                <th>Date</th>
               
            </tr>
            <tr>
                <td>
                    <div class="product-info">
                        <img src="./others/img/redhorse.png"/>
                        <div>
                            <p class="mt-3">Red Horse</p>
                        </div>
                    </div>
                </td>

                <td>
                    <span>2023-5-8</span>
                </td>
              
            </tr>
         
        </table>
       
           
      
      </section>



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