<?php
session_start();

include('security.php');

if(isset($_POST['registerbtn']))
{
    $username = $_POST['username'];
    $email = $_POST['email'];
    $password = $_POST['password'];
    $cpassword = $_POST['confirmpassword'];

    $email_query = "SELECT * FROM user_login WHERE email='$email' ";
    $email_query_run = mysqli_query($connection, $email_query);
    if(mysqli_num_rows($email_query_run) > 0)
    {
        $_SESSION['status'] = "Email Already Taken. Please Try Another one.";
        $_SESSION['status_code'] = "error";
        header('Location: register.php');  
    }
    else
    {
        if($password === $cpassword)
        {
            $query = "INSERT INTO user_login (username,email,password) VALUES ('$username','$email','$password')";
            $query_run = mysqli_query($connection, $query);
            
            if ($query_run) {
                $_SESSION['success'] = "Admin Profile Added";
                header('Location: register.php');
            }
            else 
            {
                $_SESSION['status'] = "Admin Profile Not Added";
                header('Location: register.php');  
            }
        }
        else 
        {
            $_SESSION['status'] = "Password and Confirm Password Does Not Match";
            header('Location: register.php');  
        }
    }

}

if (isset($_POST['updatebtn'])) {
    $id = $_POST['edit_id'];
    $username = $_POST['edit_username'];
    $email = $_POST['edit_email'];
    $password = $_POST['edit_password'];

    $query = "UPDATE user_login SET username='$username', email='$email', password='$password' WHERE id='$id'";
    $query_run = mysqli_query($connection, $query);

    if ($query_run) {
        $_SESSION['success'] = "Admin Profile Updated";
        header('Location: register.php');
    } else {
        $_SESSION['status'] = "Admin Profile Not Updated";
        header('Location: register.php');
    }
}

if (isset($_POST['delete_btn'])) {
    $id = $_POST['delete_id'];

    $query = "DELETE FROM user_login WHERE id='$id'";
    $query_run = mysqli_query($connection, $query);

    if ($query_run) {
        $_SESSION['success'] = "Admin Profile Deleted";
        header('Location: register.php');
    } else {
        $_SESSION['status'] = "Admin Profile Not Deleted";
        header('Location: register.php');
    }
}


if (isset($_POST["login_btn"])) {

    $email = $_POST["email"];
    $password = $_POST["password"];
  
    $sql = "SELECT * FROM admin_user WHERE email=? AND password=?";
    $stmt = mysqli_prepare($connection, $sql);
    mysqli_stmt_bind_param($stmt, "ss", $email, $password);
    mysqli_stmt_execute($stmt); 
    $res = mysqli_stmt_get_result($stmt);
  
    if (mysqli_num_rows($res) == 1) {
      $_SESSION['username'] = $email;
      header("Location: index.php");
      exit();
    } else {
      $_SESSION['status'] = "Email / Password is Invalid";
      header("Location: login.php");
      exit();
    }
    
    mysqli_stmt_close($stmt);
    mysqli_close($connection);
  }
  $id = $_GET['id'] ?? null;
  $status = $_GET['status'] ?? null;
  
  if ($id !== null && $status !== null) {
    // Sanitize the input values (assuming you're using mysqli)
    $id = mysqli_real_escape_string($connection, $id);
    $status = mysqli_real_escape_string($connection, $status);
  
    // Determine the new status
    $newStatus = ($status == 0) ? 1 : 0;
  
    // Perform the update query
    $updatequery1 = "UPDATE user_login SET status = '$newStatus' WHERE id = '$id'";
    if (mysqli_query($connection, $updatequery1)) {
      header('Location: register.php');
      exit();
    } else {
      // Handle query error
      echo "Failed to update user status: " . mysqli_error($connection);
    }
  } else {
    // Handle missing parameters
    echo "Missing parameters: id or status";
  }
  


?>