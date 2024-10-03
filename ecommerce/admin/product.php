<?php
session_start();
include('includes/header.php');
include('includes/navbar.php');

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Assuming you have a directory named "product_images" to store the uploaded images
    $targetDir = "../others/img/";
    $targetFile = $targetDir . basename($_FILES["productImage"]["name"]);
    $uploadOk = 1;
    $imageFileType = strtolower(pathinfo($targetFile, PATHINFO_EXTENSION));

    // Check if the file is an actual image or a fake image
    $check = getimagesize($_FILES["productImage"]["tmp_name"]);
    if($check === false) {
        $uploadOk = 0;
    }

    // Check if the file already exists
    if (file_exists($targetFile)) {
        $uploadOk = 0;
    }

    // Check the file size (you can modify the limit according to your requirements)
    if ($_FILES["productImage"]["size"] > 500000) {
        $uploadOk = 0;
    }

    // Allow only certain file formats (you can modify the allowed formats as needed)
    if($imageFileType != "jpg" && $imageFileType != "jpeg" && $imageFileType != "png") {
        $uploadOk = 0;
    }

    if ($uploadOk == 0) {
        // Return an error response if the file upload failed
        $response = array(
            "success" => false,
            "message" => "Sorry, your file was not uploaded."
        );
        echo json_encode($response);
    } else {
        // Move the uploaded file to the target directory
        if (move_uploaded_file($_FILES["productImage"]["tmp_name"], $targetFile)) {
            // Store the product data in your database or wherever you want
            // Here, we are simply returning a success response
            $response = array(
                "success" => true,
                "message" => "Product added successfully."
            );
            echo json_encode($response);
        } else {
            // Return an error response if the file move operation failed
            $response = array(
                "success" => false,
                "message" => "Sorry, there was an error uploading your file."
            );
            echo json_encode($response);
        }
    }
}
?>

<form id="addProductForm" method="POST" enctype="multipart/form-data">
  <div class="form-group">
    <label for="productName">Product Name</label>
    <input type="text" class="form-control" id="productName" name="productName" placeholder="Enter product name" required>
  </div>
  <div class="form-group">
    <label for="productImage">Product Image</label>
    <input type="file" class="form-control" id="productImage" name="productImage" accept="image/*" required>
  </div>
  <div class="form-group">
    <label for="productDesc">Product Description</label>
    <textarea class="form-control" id="productDesc" name="productDesc" rows="3" placeholder="Enter product description"></textarea>
  </div>
  <button type="submit" class="btn btn-primary">Add Product</button>
</form>

<div id="card"></div>



<?php
include('includes/scripts.php');
?>

</body>
</html>
