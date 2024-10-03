<?php
// Include the database connection file
require_once "connection.php";

// Check if the form has been submitted
if (isset($_POST["submit"])) {
    // Retrieve form data
    $name = $_POST["name"];
    $email = $_POST["email"];
    $password = $_POST["password"];
    $confirmPassword = $_POST["confirmPassword"];

    // Validate form data
    if ($password !== $confirmPassword) {
        // Set an error message in the session
        session_start();
        $_SESSION['error'] = "Passwords do not match";
        // Redirect back to the registration form
        header("Location: register.php");
        exit;
    }

    // Insert form data into the database
    $sql = "INSERT INTO user_login (username, email, password) VALUES (?, ?, ?)";
    $stmt = mysqli_prepare($conn, $sql);
    mysqli_stmt_bind_param($stmt, "sss", $name, $email, $password);
    mysqli_stmt_execute($stmt);


    if (mysqli_stmt_affected_rows($stmt) > 0) {
        header("Location: test.html");
        exit;
    } else {
        session_start();
        $_SESSION['error'] = "Error: " . mysqli_error($conn);
        header("Location: register.php");
        exit;
    }

    mysqli_stmt_close($stmt);
    mysqli_close($conn);
}
?>