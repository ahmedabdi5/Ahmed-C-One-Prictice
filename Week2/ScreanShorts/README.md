# C# – String Concatenation

## Description

This project demonstrates how to combine two strings into a single message using the `+` operator in C#.

## Code

```csharp
string message;

message = "Jamhuuriyada" + " University";

MessageBox.Show(message);
```

## Explanation

* `string message;` declares a string variable named `message`.
* `+` is used to concatenate (join) two strings together.
* `"Jamhuuriyada" + " University"` combines the two text values into one string.
* `MessageBox.Show(message);` displays the combined text in a pop-up message box.

## Output
**Jamhuuriyada University**



# C# – Try, Catch and Parse

## 1. Try

`try` is used to execute code that may cause an error.

It allows the program to attempt an operation safely.

## 2. Catch

`catch` is used to handle errors that occur inside the `try` block.

If an error occurs, the `catch` block executes instead of crashing the program.

## 3. Parse

`double.Parse()` converts a string (text) into a double numeric value.

It is used to convert user input from a TextBox into a number for calculations.

## Example

```csharp
try
{
    double test1 = double.Parse(txttest1.Text);
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
```

## Summary

* `try` – Attempts to execute the code.
* `catch` – Handles errors.
* `double.Parse()` – Converts text into a numeric value.




