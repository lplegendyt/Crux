
# Crux Programming Language

Crux is a beginner-friendly programming language designed with a simple and accessible syntax. It is a compiled language that allows users to write clear and concise code, making it an ideal choice for both new programmers and those looking to develop simple applications.

## File Extension

Crux source files use the `.crx` file extension, which distinguishes them within development environments.

## Current Status

The Crux compiler is being developed in C# as I learn the language. The project is open-source, and contributions are welcome. You can view and contribute to the project on GitHub: [Crux GitHub Repository](https://github.com/lplegendyt/Crux).

## Basic Syntax

The syntax of Crux is designed to be intuitive and easy to understand. Below are key elements of the Crux syntax:

### 1. Comments
```plaintext
// This is a comment
```
Comments begin with `//`, allowing users to include explanations or notes within their code.

### 2. Outputting Text
```plaintext
txout("Hello World!");                  // Prints "Hello World!"
```
The `txout` function is used to output text to the console.

### 3. Variable Initialization
```plaintext
name;                                   // Initializes the variable name
```
This line initializes a variable called `name`.

### 4. Inputting Text
```plaintext
name = txin("What is your name?:")      // Reads input and assigns it to name
```
The `txin` function prompts the user for input.

### 5. String Interpolation
```plaintext
txout($"Hello {name}!");                 // Outputs "Hello Alice!" if name is "Alice"
```
String interpolation allows variables to be included within strings.

### 6. Returning from the Program
```plaintext
return 0;                               // Ends the program with exit code 0
```
This statement signifies the successful termination of the program.

## Proposed Syntax Extensions

As Crux evolves, several features may be added to enhance its capabilities:

1. **Data Structures**:
   - **Lists and Arrays**: Syntax for creating and manipulating lists.
     ```plaintext
     myList = [1, 2, 3, 4, 5]; // Initializing a list
     ```

   - **Objects/Dictionaries**: Enable key-value pairs.
     ```plaintext
     person = { "name": "Alice", "age": 30 }; // Creating an object
     ```

2. **Control Structures**:
   - **Conditional Statements**:
     ```plaintext
     if (age >= 18) {
         txout("You are an adult.");
     }
     ```

   - **Loops**: Introduction of for and while loops.
     ```plaintext
     for (i = 0; i < 10; i++) {
         txout(i);
     }
     ```

3. **Functions**:
   - **Function Definitions**:
     ```plaintext
     function greet(name) {
         txout($"Hello, {name}!");
     }
     ```

4. **Error Handling**:
   - **Try-Catch Blocks**:
     ```plaintext
     try {
         // Code that may throw an error
     } catch (Exception e) {
         txout($"Error: {e.Message}");
     }
     ```

5. **Modules and Imports**:
   - **Modularization**:
     ```plaintext
     import MyLibrary; // Importing a module
     ```

6. **Multi-line Comments**:
   ```plaintext
   /* 
   This is a multi-line comment 
   that can span multiple lines. 
   */
   ```

## Conclusion

Crux aims to provide a clear and accessible programming experience, making it suitable for both beginners and experienced developers. The proposed syntax extensions will further enhance its functionality, enabling users to create more complex applications while maintaining an intuitive coding environment.

Feel free to explore the repository, provide feedback, and contribute to the development of Crux!

---
