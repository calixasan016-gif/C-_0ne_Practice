## Discourse Week2
3.1 Reading Input with TextBox Controls
3.2 A First Look at Variables
3.3 Numeric Data Type and Variables
3.4 Performing Calculations
3.5 Inputting and Outputting Numeric Values
3.6 Formatting Numbers with the ToString Method
3.7 Simple Exception Handling
3.8 Using Named Constants

## 3.1 Reading Input with TextBox Control
TextBox control
a rectangular area
can accept keyboard input from the user
located in the Common Control group of the Toolbox
double click to add it to the form
default name is textBoxn

## The Text Property
A TextBox control’s Text property stores the user inputs
Text property accepts only string values, e.g

To clear the content of a TextBox control, assign an empty string("")

## 3.2 A First Look at Variables
A variable is a storage location in memory
A variable name represents the memory location
in a C#, you must declare a variable in a program before using it to store data
The syntax to declare variables is:
     (DataType VariableName;)

## Data Types
A C#, variable must be declared with a proper data type
The data type specifies the type of data a variable can hold
In C#, many data types are known as primitive data types
-- they store fundamental types of data means essential or core
--such as strings and integers

Primitive” means basic / simple / built-in.
In C#, primitive data types are already defined by the language, not created by you.[Primitive](Primitive.png)

## Initializing Variables
In C#, a variable must be assigned a value before it can be used.


## This practice demonstrates how to:

- Use the "var" keyword in Windows Forms
- Display numeric values using controls
- Format output in C#
- Handle exceptions using "try" and "catch"
- Use constant variables

---

1. Using var Keyword

In this step, variables are taken from TextBoxes and stored using "var".

The following screenshot shows how "var" is used in Windows Forms.

"Var Keyword" (Screenshots/Var_Form.png)

var name = txtName.Text;
var age = int.Parse(txtAge.Text);
var price = double.Parse(txtPrice.Text);

lblResult.Text = $"Name: {name}, Age: {age}, Price: {price}";

---

2. Displaying Numeric Values

In this step, numbers are taken from TextBoxes and displayed in a Label.

"Display Numbers" (Screenshots/Display_Form.png)

int num1 = int.Parse(txtNum1.Text);
double num2 = double.Parse(txtNum2.Text);

lblResult.Text = "Sum: " + (num1 + num2);

---

3. Formatting Output

In this step, numeric values are formatted before display.

"Formatting" (![alt text](<Screenshots/Screenshot 2026-09-26 181034.png>))

double price = double.Parse(txtPrice.Text);

lblResult.Text = price.ToString("N2");

---

4. Exception Handling

In this step, errors are handled using "try" and "catch".

try
{
    int x = int.Parse(txtX.Text);
    int y = int.Parse(txtY.Text);

    int result = x / y;
    lblResult.Text = result.ToString();
}
catch (Exception ex)
{
    lblResult.Text = "Error: " + ex.Message;
}

---

5. Constant Variable

In this step, a constant value is used.

"Constant" (Screenshots/Constant_Form.png)

const double PI = 3.14;

lblResult.Text = "PI: " + PI;
