<?php

function registerUser() {
    if (isset($_POST['submit'])) {
        
    
        $name = filter_input(INPUT_POST, 'name', FILTER_SANITIZE_STRING);
        $email = filter_input(INPUT_POST, 'Email', FILTER_SANITIZE_EMAIL);
        $password = filter_input(INPUT_POST, 'Password', FILTER_SANITIZE_STRING);
        $confirmPassword = filter_input(INPUT_POST, 'confirmPassword', FILTER_SANITIZE_STRING);
        
    
        if (empty($name) || empty($email) || empty($password) || empty($confirmPassword)) {
            echo "All fields are required.";
            return;
        }
        
        if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
            echo "Invalid email address.";
            return;
        }
        
        if ($password !== $confirmPassword) {
            echo "Passwords do not match.";
            return;
        }
        
    
        
        echo "User registered successfully!";
    }
}
?>