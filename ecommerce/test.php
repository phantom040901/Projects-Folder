<!DOCTYPE html>
<html lang="en">
 
  
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="test.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-aFq/bzH65dt+w6FI2ooMVUpc+21e0SRygnTpmBvdBgSdnuTN7QbdgL+OapgHtvPp" crossorigin="anonymous">    <script defer src="https://use.fontawesome.com/releases/v5.15.4/js/all.js" integrity="sha384-rOA1PnstxnOBLzCLMcre8ybwbTmemjzdNlILg8O7z1lUkLXozs4DHonlDtnE7fpc" crossorigin="anonymous"></script>

    <style>
 

    </style>
    
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

  <section id="home" style="background-image: url('./others/img/bg.jpg');">

        <div class="container">
            <h5 style="font-weight: bold; color: white;">NEW <span style="color: black;"> ARRIVALS</span> </h5>
            <h1 style="font-weight: bold; color: white;">BEST PRICESS THIS <span style="color: black;">SEASON</span></h1>
            <h4 style="font-weight: bold; color: white;">MY MY SHOP OFFERS THE BEST PRODUCT FOR THE MOST <span style="color: black;"> PRICES </h4>
            <button onclick="window.location.href='search.html'">Shop Now</button>

        </div>

      </section>
      
      <hr>
      <section id="brand" class="container">

        <div class="row">
          <img class="img-fluid col-lg-3 col-md-6 col-sm-12" src="./others/img/brand1.png">
          <img class="img-fluid col-lg-3 col-md-6 col-sm-12" src="./others/img/brand2.png">
          <img class="img-fluid col-lg-3 col-md-6 col-sm-12" src="./others/img/brand3.png">
          <img class="img-fluid col-lg-3 col-md-6 col-sm-12" src="./others/img/brand4.png">
        </div>

      </section>

      <hr>


      <section id="new" class="w-100">
        <div class="container-fluid p-0">
          <div class="row no-gutters">
            <div class="col-lg-4 col-md-4 col-sm-12">
              <div class="card">
                <div class="card-img-container">
                  <img class="card-img" src="./others/img/rhlogo.png">
                  <div class="card-hover">
                    <h2 class="card-title">Red Horse</h2>
                    <button class="text-uppercase shop-now-btn" onclick="window.location.href='search.html'">Shop Now</button>

                  </div>
                </div>
              </div>
            </div>
            <div class="col-lg-4 col-md-4 col-sm-12">
              <div class="card">
                <div class="card-img-container">
                  <img class="card-img" src="./others/img/ginlogo.png">
                  <div class="card-hover">
                    <h2 class="card-title">Gin</h2>
                    <button class="text-uppercase shop-now-btn" onclick="window.location.href='search.html'">Shop Now</button>
                  </div>
                </div>
              </div>
            </div>
            <div class="col-lg-4 col-md-4 col-sm-12">
              <div class="card">
                <div class="card-img-container">
                  <img class="card-img" src="./others/img/tanduaylogo.png">
                  <div class="card-hover">
                    <h2 class="card-title">Tanduay</h2>
                    <button class="text-uppercase shop-now-btn" onclick="window.location.href='search.html'">Shop Now</button>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>

      <section id="featured" class="my-5">
        <div class="container text-center mt-5 py-5">
          <h3>Our Featured Products</h3>
          <hr>
          <p>Here you can check out our featured products</p>
        </div>
        <div class="row mx-auto container-fluid">
          <div class="product text-center col-lg-3 col-md-4 col-sm-12">
            <img class="img-fluid mb-3" src="./others/img/TanduayDark.png">
            <i class="fas fa-star"></i>
            <i class="fas fa-star"></i>
            <i class="fas fa-star"></i>
            <i class="fas fa-star"></i>
            <i class="fas fa-star"></i>
            <h5 class="p-name">Tanduay Dark</h5>
            <h4 class="p-price">$199.0</h4>
            <button class="buy-btn" onclick="window.location.href='search.html'">Buy Now</button>

          </div>
          <div class="product text-center col-lg-3 col-md-4 col-sm-12">
            <img class="img-fluid mb-3" src="./others/img/Tanduay.png">
            <i class="fas fa-star"></i>
            <i class="fas fa-star"></i>
            <i class="fas fa-star"></i>
            <i class="fas fa-star"></i>
            <i class="fas fa-star"></i>
            <h5 class="p-name">Tanduay Select</h5>
            <h4 class="p-price">$199.0</h4>
            <button class="buy-btn" onclick="window.location.href='search.html'">Buy Now</button>

          </div>
          <div class="product text-center col-lg-3 col-md-4 col-sm-12">
            <img class="img-fluid mb-3" src="./others/img/gin.png">
            <i class="fas fa-star"></i>
            <i class="fas fa-star"></i>
            <i class="fas fa-star"></i>
            <i class="fas fa-star"></i>
            <i class="fas fa-star"></i>
            <h5 class="p-name">Gin</h5>
            <h4 class="p-price">$199.0</h4>
            <button class="buy-btn" onclick="window.location.href='search.html'">Buy Now</button>

          </div>
          <div class="product text-center col-lg-3 col-md-4 col-sm-12">
            <img class="img-fluid mb-3" src="./others/img/emperador.png">
            <i class="fas fa-star"></i>
            <i class="fas fa-star"></i>
            <i class="fas fa-star"></i>
            <i class="fas fa-star"></i>
            <i class="fas fa-star"></i>
            <h5 class="p-name">Emperador</h5>
            <h4 class="p-price">$199.0</h4>
            <button class="buy-btn" onclick="window.location.href='search.html'">Buy Now</button>

          </div>
          
        </div>
      </section>
      
      <section id="banner" class="my-5 py-5" style="background-image: url(./others/img/newback2.jpg);">
        <div class="container">
          <h4>MID SEASON'S SALE</h4>
          <h1>Liqour Collection <br> UP to 30% OFF</h1>
          <button class="text-uppercase" onclick="window.location.href='search.html'">SHOP NOW</button>
        </div>
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