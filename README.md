# Back-End

<h2> Framework </h2>
In general terms, a framework is a conceptual structure or a set of rules and guidelines that provides a foundation for building something specific. It acts as a support system or scaffolding to help organize, develop, and streamline various aspects of a project or system. Frameworks can be found in various fields and disciplines, such as software development, architecture, education, and more.
In the context of software development, a framework is a pre-established software environment that provides a structured approach to building applications. It includes a collection of tools, libraries, and components that developers can use to accelerate the development process and adhere to best practices.
Key characteristics of a software framework include:
<table> <tr> <th>Abstraction </th> <th>Reusability </th> <th> Extensibility </th> <th>Inversion of Control</th> <th>Standardization </th> <th>Community Support</th> </tr>
<tr> <td> A framework offers high-level abstractions that allow developers to focus on specific functionalities without worrying about low-level details. </td> <td> Frameworks promote code reuse through pre-built components and modules, saving developers time and effort. </td> <td> They allow developers to extend and customize the framework to meet specific project requirements. </td> <td> A framework often follows the "Inversion of Control" principle, meaning the framework controls the flow of the application rather than the developers themselves. </td> <td> Frameworks often adhere to industry standards and best practices, making it easier for developers to work collaboratively and understand each other's code. </td> <td> Popular frameworks often have active communities that provide support, documentation, and updates. </td> </tr> </table>
Some examples of well-known software frameworks are:
<table> <tr> <th> Web Development </th> <th> Mobile App Development </th> <th> Desktop Application Development </th> <th> Backend Development </th> </tr>
 <tr> <td> React, Angular, Django, Ruby on Rails. </td> <td> React Native, Flutter. </td> <td> Electron, PyQt, JavaFX. </td> <td> Express.js, Spring Framework, Flask. </td>   </tr> </table>
By using a framework, developers can build applications more efficiently, maintain a consistent structure, and benefit from the collective wisdom of the community that supports and contributes to the framework.
<h3> C# </h3>
C# is a programming language developed by Microsoft. It was introduced in the early 2000s as part of the Microsoft .NET initiative. C# is a versatile, object-oriented language that is widely used for building a variety of applications, including desktop applications, web applications, mobile apps, games, and more. It is known for its simplicity, strong type-checking, and extensive support for modern programming paradigms.
C# is similar in syntax to other C-based programming languages like C++ and Java. It has a rich standard library, and developers can create additional libraries and frameworks to extend its functionality further. C# is typically used in conjunction with the .NET framework to build and run applications.
<h3> .NET </h3>
.NET is a software framework developed by Microsoft. It provides a runtime environment and a set of libraries that enable developers to build, deploy, and run applications on various platforms. The .NET framework was originally designed for Windows, but in recent years, Microsoft has expanded its support to other operating systems like macOS and Linux through .NET Core and .NET 5+.
The .NET framework includes the Common Language Runtime (CLR), which is responsible for managing the execution of code written in various languages, including C#. It also includes a vast standard library called the Base Class Library (BCL), which provides a wide range of functionalities like input/output, data access, networking, and more.
.NET supports multiple programming languages, and C# is one of the primary languages used with the framework. Other languages include VB.NET (Visual Basic .NET), F# (functional programming language), and more recently, languages like TypeScript and Python through the .NET 5+ ecosystem.
In summary, C# is a programming language, while .NET is a framework that includes the Common Language Runtime (CLR) and a rich set of libraries. C# is often used in combination with the .NET framework to build powerful and versatile applications on various platforms.
<h2> CLR </h2>
The CLR (Common Language Runtime) is a crucial component of the Microsoft .NET framework. It is a runtime environment that provides various services for executing and managing applications written in different languages that target the .NET platform. The CLR is responsible for handling many tasks necessary for running .NET applications, including memory management, security, exception handling, and more.
Here are some key features and responsibilities of the Common Language Runtime:
<table><tr> <th> Execution and Compilation </th> <th> Memory Management </th> <th> Security </th> <th> Exception Handling </th> <th> Type Safety and Verification </th> <th> Code Access Security </th> <th> Cross-Language Interoperability </th></tr>
<tr> <td> When a .NET application is executed, the CLR is responsible for just-in-time (JIT) compilation. It translates the intermediate language (IL) code, which is generated by the .NET compiler during the build process, into machine code specific to the target platform. This compilation happens at runtime, optimizing the code for the current hardware and providing performance improvements. </td> <td> The CLR manages memory allocation and garbage collection. It automatically allocates memory for objects at runtime and releases memory that is no longer needed (garbage collection). This helps developers avoid manual memory management and reduces the risk of memory-related bugs like memory leaks. </td> <td> The CLR enforces various security mechanisms to ensure the safety of the code and data. It uses a permission-based security model that restricts the actions an application can perform based on its trust level and the permissions granted to it. </td> <td> The CLR provides a robust mechanism for handling exceptions in .NET applications. It ensures that exceptions are caught and dealt with properly, preventing crashes and allowing developers to write reliable and resilient code. </td> <td> The CLR enforces type safety by ensuring that operations performed on objects are valid and that they adhere to the rules defined in the .NET type system. It also performs type verification to ensure that IL code is valid and well-formed before it is executed. </td> <td> The CLR enforces code access security to prevent unauthorized code from performing sensitive operations. It uses code access permissions to control what code can and cannot do, based on the origin and trust level of the code. </td> <td> The CLR enables different .NET languages, such as C#, VB.NET, and F#, to work together seamlessly. It provides a common runtime environment and type system that allows objects created in one language to be used by code written in another. </td> </tr> </table>

Overall, the CLR plays a critical role in making the .NET platform a powerful and flexible environment for building applications that run efficiently, securely, and reliably across various operating systems and devices.

<h4> IL </h4>
IL stands for Intermediate Language, also known as Microsoft Intermediate Language (MSIL) or Common Intermediate Language (CIL). 
It is a low-level, platform-independent, and CPU-independent programming language used in the .NET framework.
When you write code in a .NET-supported language like C#, VB.NET, or F#, the source code is compiled into IL during the build process. 
IL is a human-readable assembly-like language, but it is not directly executable by the computer's CPU like machine code. Instead, IL is designed to be executed by the Common Language Runtime (CLR), which is part of the .NET framework.
IL serves as an intermediate step between the high-level source code and the native machine code specific to the target platform. When a .NET application is executed, the CLR uses a just-in-time (JIT) compiler to convert the IL code into native machine code that can be executed by the computer's CPU. This compilation happens at runtime, allowing the CLR to optimize the code based on the actual hardware it is running on.

The use of IL and the CLR provides several advantages:
<table> <tr> <th> Platform Independence </th> <th> Language Interoperability </th> <th> Security </th> <th> Performance </th> </tr> 
<tr> <td> IL allows .NET applications to be compiled once and run on any platform that has a compatible implementation of the CLR, such as Windows, macOS, and Linux. </td> <td> Since all .NET languages compile to IL, code written in one .NET language can seamlessly interact with code written in another .NET language, promoting language interoperability. </td> <td> IL is designed with security in mind. Code access security and type safety are enforced by the CLR when executing IL code. </td> <td> The CLR's just-in-time compilation of IL to native code allows for platform-specific optimizations, leading to efficient execution on the target system. </td> </tr> </table>

Overall, IL is a fundamental component of the .NET framework, enabling cross-platform support and promoting language interoperability while providing a secure and efficient runtime environment for .NET applications.

![clr il jit](https://github.com/NigarValikhanova/Just-For-Me/assets/140783772/46f2d3c1-daec-41f8-b7fa-a17b455a2030)


<h3> DLL </h3>
A DLL (Dynamic Link Library) is a file format used in Windows operating systems to store and organize code, data, and resources that can be shared among multiple programs. DLLs contain compiled code that can be loaded and executed by applications, providing a way to modularize and reuse code while reducing redundancy and improving maintenance.
Key features of DLLs include:
<table> <tr> <th>Code Reusability </th> <th> Modularity </th> <th>Reduced Memory Usage </th> <th> Versioning </th> <th> Late Binding </th> <th> Performance Optimization </th> <th> Resource Sharing </th> </tr>
<tr> <td>DLLs enable developers to create shared libraries of code that can be used by multiple applications. This promotes code reusability, as the same functionality can be shared across different software projects. </td> <td>By separating functionality into individual DLLs, software can be developed and maintained more modularly. This means that updates or bug fixes to a specific module can be applied without affecting the entire application.</td> <td>When multiple applications use the same DLL, the operating system loads the DLL into memory once and shares its code among the applications. This can result in reduced memory usage compared to having duplicated code in each application. </td> <td>DLLs support versioning, allowing different versions of a DLL to coexist on the system. This enables applications to use specific versions of a DLL even if newer versions are available. </td> <td>Some programming languages and environments allow for dynamic loading and linking of DLLs at runtime, known as late binding. This allows for more flexible and extensible software design. </td> <td>Since code in a DLL is compiled and linked separately, performance-critical sections of an application can be compiled with specific optimizations and settings tailored to that DLL's purpose. </td> <td>Besides code, DLLs can also contain resources such as icons, images, strings, and configuration data. These resources can be shared across multiple applications, reducing the duplication of these resources in every executable. </td></tr>
</table>
While DLLs provide several benefits, they also come with considerations:
<table><tr><th>Dependency Management</th> <th>DLL Hell</th> <th>Security Considerations</th> </tr> <tr> <td>Applications using DLLs are dependent on the availability of those DLLs. Changes to a DLL can impact multiple applications, necessitating careful version control and testing.</td> <td>DLL conflicts can arise if different applications or versions of an application require different versions of the same DLL. This can lead to compatibility issues and instability.</td> <td>Shared DLLs need to be maintained securely to prevent unauthorized modifications that could affect multiple applications. </td> </tr> </table>
DLLs play a significant role in modular software design, enabling developers to create more efficient, maintainable, and extensible applications by separating code and resources into reusable components.

<h3> Namespace, Class, Method, Assembly </h3>

<table> <tr> <th> Namespace </th> <th> Class </th> <th> Method </th> <th> Assembly </th> </tr>
<tr> <td> A namespace in C# is a way to organize and group related classes, interfaces, and other types. It helps to avoid naming conflicts and provides a clear hierarchical structure for your code. Namespaces are used to partition your code into logical units and enable you to create more modular and maintainable applications. </td> <td> A class is a blueprint or template for creating objects. It defines the properties (attributes) and methods (functions) that the objects of the class will have. Classes are fundamental to object-oriented programming and encapsulate data and behavior into a single unit. You can create multiple instances (objects) of a class, each with its own set of data and the ability to perform actions through its methods. </td> <td> A method is a block of code that performs a specific task or action. It is a member of a class and defines the behavior of objects created from that class. Methods can take input parameters, perform calculations, and return results. They encapsulate functionality and allow you to create reusable and modular code. </td> <td> An assembly in .NET is a compiled unit of code that contains one or more namespaces, classes, and other types. It's the fundamental unit of deployment and version control in .NET applications. An assembly can be a dynamically linked library (DLL) or an executable (EXE). Assemblies contain metadata that describes the types and resources they contain, enabling runtime execution and interaction. </td> </tr>
</table>

To give you a better context, here's a simple example:

![3 1](https://github.com/NigarValikhanova/Just-For-Me/assets/140783772/b666468b-cc91-4223-b43a-e41dac8536b6)

In this example:

MyNamespace is a namespace that contains the MyClass class.
MyClass is a class with a property (MyProperty) and a method (MyMethod).
Program is another class with a Main method, where we create an instance of MyClass, set its property, call its method, and display the property's value.
These concepts are fundamental to programming in C# and other object-oriented languages.

Variables:
A variable is a named storage location in a computer's memory where you can store data values. Variables are used to hold and manipulate data within a program. They have a name, a data type, and a value. Variables are an essential concept in programming as they allow you to work with data dynamically, enabling your programs to perform various tasks.

Here are some key aspects of variables:

Declaration:
Declaring a variable means defining its name and data type. For example:

![3 2](https://github.com/NigarValikhanova/Just-For-Me/assets/140783772/657be9f7-c82e-46f8-89c4-645e1a773446)

Initialization:
Initialization is the process of assigning an initial value to a variable at the time of declaration. Not all programming languages require explicit initialization, but it's good practice to do so:

![3 3](https://github.com/NigarValikhanova/Just-For-Me/assets/140783772/04bc4c0b-2d54-4ac1-aff7-5636d9879252)

Data Types:
Variables have data types that define the kind of data they can hold. Common data types include integers, floating-point numbers, characters, strings, boolean values, and more. The data type affects the memory allocated to the variable and the operations you can perform on it:

![3 4](https://github.com/NigarValikhanova/Just-For-Me/assets/140783772/8c35aff3-ffde-454e-aacc-b2cba636d631)

Scope:
The scope of a variable defines where in the code the variable is accessible and where it can be used. Variables declared within a method or block are usually local to that scope. Global variables are accessible throughout the entire program, but they can lead to complications in larger programs:

![3 5](https://github.com/NigarValikhanova/Just-For-Me/assets/140783772/53040272-47ea-4910-a9a9-429551f8acbe)

Lifetime:
The lifetime of a variable is the period during which the variable is allocated and holds a valid value. Local variables have a shorter lifetime as they are created when the block is entered and destroyed when it's exited. Global variables often have a longer lifetime, lasting throughout the program's execution.

Mutability (for some languages):
Some programming languages allow variables to be mutable (modifiable), while others treat them as immutable (unchangeable) once a value is assigned. Immutable variables can help prevent unintended changes and simplify debugging.

Naming Conventions:
Variables are usually named according to certain naming conventions that help improve code readability. Common practices include using descriptive names, using camelCase or snake_case, and avoiding reserved keywords.

Type Inference (for some languages):
Some programming languages support type inference, which allows the compiler to automatically determine the data type based on the assigned value. This can make the code more concise.

<table> <tr> <th> Data Type </th> <th> Size </th> <th> Description </th>     </tr>
<tr> <td> int </td> <td> 4 bytes </td> <td> Stores whole numbers from -2,147,483,648 to 2,147,483,647 </td> </tr>
<tr> <td> long </td> <td> 8 bytes </td> <td> Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 </td> </tr>
<tr> <td> float </td> <td> 4 bytes </td> <td> Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits </td> </tr>
<tr> <td> double </td> <td> 8 bytes </td> <td> Stores fractional numbers. Sufficient for storing 15 decimal digits </td> </tr>
<tr> <td> bool </td> <td> 1 bit </td> <td> Stores true or false values </td></tr>
<tr> <td> char </td> <td> 2 bytes </td> <td> Stores a single character/letter, surrounded by single quotes </td> </tr>
<tr> <td> string </td> <td> 2 bytes per character </td> <td> Stores a sequence of characters, surrounded by double quotes </td> </tr>
</table>

<h4> Naming Conventions </h4>
Naming conventions are a set of rules and guidelines that dictate how you should name various elements in your code, such as variables, functions, classes, and more. Consistently following naming conventions enhances code readability, maintainability, and collaboration within a development team. Different programming languages and communities often have their own specific naming conventions, but some general principles apply widely. Here are some common naming conventions:

<table> <tr> <th> Name </th> <th> Description </th> <th> Examples </th> </tr>
<tr> <td> Camel Case </td> <td> In camel case, each word in the name starts with an uppercase letter except for the first word, which starts with a lowercase letter. There are no spaces or punctuation between words. This convention is commonly used for naming variables and functions in languages like C#, Java, and JavaScript. </td> <td> myVariable, calculateTotalAmount, firstName </td> </tr>
<tr> <td> Pascal Case (Upper Camel Case) </td> <td> Pascal case is similar to camel case, but every word starts with an uppercase letter. Pascal case is often used for naming classes, structs, and other types in C#, Java, and .NET languages. </td> <td> MyClass, PersonDetails, CalculateTotal </td> </tr>
<tr> <td> Snake Case </td> <td> In snake case, words are separated by underscores (_) and all letters are lowercase. This convention is frequently used for naming variables, functions, and constants in languages like Python, Ruby, and some other scripting languages. </td> <td> user_name, calculate_total_amount, first_name </td> </tr>
<tr> <td> Kebab Case </td> <td> Kebab case is similar to snake case, but words are separated by hyphens (-) instead of underscores. It's commonly used for naming files and URLs. </td> <td> user-name.html, calculate-total-amount.js </td> </tr>
<tr> <td> Hungarian Notation (Less Common) </td> <td> Hungarian notation prefixes variable names with a short code that indicates the variable's data type. While it was popular in older programming languages, it's less common in modern languages with strong type systems. </td> <td> intCounter, strName </td>         </tr>
<tr> <td> Prefixes and Suffixes </td> <td> Some conventions use prefixes or suffixes to provide additional context. </td> <td> is or has as prefixes for boolean variables (e.g., isReady, hasPermission), _ as a prefix for private members, or I as a prefix for interfaces. </td> </tr> </table>

![smegxg2g30i11](https://github.com/NigarValikhanova/Just-For-Me/assets/140783772/5779799e-7ebd-47c6-8200-7e79f9a205a0)

<h3> Constants and Literals </h3>
<h4> Constants </h4>
Constants are values that are assigned once and cannot be changed during the execution of a program. They provide a way to give meaningful names to fixed values and make the code more readable and maintainable. In C#, constants are declared using the const keyword.

![3 10](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/7bf12057-6db3-45eb-a10f-7dda10ab4d01)

Key points about constants:
<table> <tr> <th> Value Assignment </th> <th> Data Types </th> <th> Scope </th> <th> Compile-Time Values </th> <th> Naming Convention </th>  </tr> <tr> <td>Constants must be assigned a value at the time of declaration, and this value cannot be modified later. </td> <td>Constants can have various data types such as integers, floating-point numbers, characters, strings, and more. </td> <td>Constants are typically defined at the class level and are accessible within that class and, if appropriate, within derived classes. </td> <td>Constants are evaluated at compile time, which means their values are substituted directly into the code during compilation. This can lead to increased performance in some scenarios. </td> <td>By convention, constants are usually named using uppercase letters and underscores to separate words (e.g., MAX_VALUE). </td></tr></table>

<h4> Literals </h4>

Literals are the actual values used in code to represent data. They are direct representations of fixed values and are used to initialize variables and constants. In other words, a literal is a specific value that appears directly in the code.

![3 11](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/a9586eb1-6a76-45de-98ad-c22d5ddcb75c)

Key points about literals:
<table>
<tr> <th>Implicit Data Types </th> <th> Suffixes </th> <th> String Literals </th> <th> Character Literals </th> <th> Boolean Literals </th> <th> Null Literal </th> </tr>
<tr> <td> The data type of a literal is determined implicitly based on its form and the context in which it's used. For example, 25 is an integer literal, and 98.6 is a double literal. </td> <td> You can use suffixes to specify the data type of certain literals explicitly. For example, 5L represents a long integer, and 3.14F represents a float.
 </td> <td> String literals are sequences of characters enclosed in double quotes. They can include escape sequences to represent special characters (e.g., \n for newline, \" for double quote). </td> <td> Character literals are enclosed in single quotes and represent a single character. </td> <td> In C#, true and false are boolean literals representing true and false values, respectively. </td> <td> null is a special literal used to represent a reference that does not point to any object. </td> </tr>  
</table>

Escape sequences in C# are special combinations of characters that are used to represent characters that are difficult or impossible to enter directly into a string or character literal. They are used to represent characters that have special meanings or to include characters that are not easily typed on a keyboard. Escape sequences are preceded by a backslash \. Here are some common escape sequences in C#:

<table> <tr> <th> \\ (Backslash) </th> <th> \" (Double Quote) </th> <th> \' (Single Quote) </th> <th> \n (Newline) </th> <th> \r (Carriage Return) </th> <th> \t (Tab) </th> <th> \b (Backspace) </th> <th> \f (Form Feed) </th> <th> \v (Vertical Tab) </th> <th> \0 (Null Character) </th> <th> \uXXXX (Unicode Escape) </th> <th> \xXX (Hexadecimal Escape) </th> </tr>
<tr> <td> Represents a single backslash character. </td> <td> Represents a double quote character within a string literal. </td> <td> Represents a single quote character within a character literal. </td> <td> Represents a newline character, moving the cursor to the beginning of the next line. </td>  <td> Represents a carriage return character, moving the cursor to the beginning of the current line. </td> <td> Represents a tab character, causing horizontal tabulation. </td> <td> Represents a backspace character, moving the cursor one position to the left. </td> <td> Represents a form feed character, which advances the printer to the next page. </td> <td> Represents a vertical tab character. </td> <td> Represents the null character, commonly used to terminate C-style strings. </td> <td> Represents a Unicode character where XXXX is the hexadecimal code point of the character. </td> <td> Represents a character in hexadecimal notation, where XX is the hexadecimal value. </td> </tr> </table>

Escape sequences are used in string literals and character literals to represent characters that have special significance, such as newline, tab, and special characters like quotes. Here are some examples:

![3 12](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/9cbe09fe-ee7f-4545-af06-b1dfb3f10419)

In the above examples, the escape sequence \n is used to insert a newline, \" is used to insert a double quote, and the verbatim string @ is used to avoid interpreting escape sequences, which is useful for file paths.

<h3> OPERATORS </h3>

In C#, operators are symbols or keywords that perform various operations on variables and values. Operators allow you to manipulate data, perform calculations, compare values, and more within your C# code. Here's an overview of some common categories of operators in C#:

1. Arithmetic Operators:
<table>
 <tr> <th> Operator </th> <th> Description </th> <th> Explain</th></tr>
 <tr> <td> + </td> <td> Addition </td> <td> Adds two numeric values together </td></tr>
 <tr> <td> - </td> <td> Subtraction </td> <td> Subtracts the right operand from the left operand. </td> </tr>
 <tr> <td> * </td> <td> Multiplication </td> <td> Multiplies two numeric values. </td> </tr>
 <tr> <td> / </td> <td> Division </td> <td> Divides the left operand by the right operand. </td> </tr>
 <tr> <td> % </td> <td> Modulus </td> <td> Returns the remainder of the division of the left operand by the right operand. </td> </tr>
</table>

2. Assignment Operators:
<table> <tr> <th> Operator </th> <th> Description </th> <th> Explain </th></tr>
<tr> <td> = </td> <td> Assignment </td> <td> Assigns a value to a variable. </td> </tr>
<tr> <td> += </td> <td> Addition Assignment </td> <td> Adds the right operand to the left operand and assigns the result to the left operand. </td> </tr>
<tr> <td> -= </td> <td> Subtraction Assignment </td> <td> Subtracts the right operand from the left operand and assigns the result to the left operand. </td> </tr>
<tr> <td> *= </td> <td> Multiplication Assignment </td> <td> Multiplies the left operand by the right operand and assigns the result to the left operand. </td> </tr>
<tr> <td> /= </td> <td> Division Assignment </td> <td> Divides the left operand by the right operand and assigns the result to the left operand. </td> </tr>
<tr> <td> %= </td> <td> Modulus Assignment </td> <td> Performs a modulus operation on the left operand and assigns the result to the left operand. </td> </tr>
</table>

3. Comparison or Relational Operators:
<table> <tr> <th> Operator </th> <th> Description </th> <th> Explain </th></tr>
<tr> <td> == </td> <td> Equal to </td> <td> Checks if two values are equal. </td> </tr> 
<tr> <td> != </td> <td> Not equal to </td> <td> Checks if two values are not equal. </td> </tr>
<tr> <td> < </td> <td> Less than </td> <td> Checks if the left operand is less than the right operand. </td> </tr>
<tr> <td> > </td> <td> Greater than </td> <td> Checks if the left operand is greater than the right operand. </td> </tr>
<tr> <td> <= </td> <td> Less than or equal to </td> <td> Checks if the left operand is less than or equal to the right operand. </td> </tr>
<tr> <td> >= </td> <td> Greater than or equal to </td> <td> Checks if the left operand is greater than or equal to the right operand. </td> </tr> 
</table>

4. Logical Operators:
<table> <tr> <th> Operator </th> <th> Description </th> <th> Explain </th></tr>
<tr> <td> && </td> <td> Logical AND </td> <td> Performs a logical AND operation on boolean values. </td> </tr> 
<tr> <td> || </td> <td> Logical OR </td> <td> Performs a logical OR operation on boolean values. </td> </tr>  
<tr> <td> ! </td> <td> Logical NOT </td> <td> Negates a boolean value. </td> </tr> 
 </table>

5. Bitwise Operators:
<table> <tr> <th> Operator </th> <th> Description </th> <th> Explain </th></tr>
<tr> <td> & </td> <td> Bitwise AND </td> <td> Performs a bitwise AND operation. </td> </tr> 
<tr> <td> | </td> <td> Bitwise OR </td> <td> Performs a bitwise OR operation. </td> </tr>  
<tr> <td> ^ </td> <td> Bitwise XOR </td> <td> Performs a bitwise XOR (exclusive OR) operation. </td> </tr> 
<tr> <td> ~ </td> <td> Bitwise NOT </td> <td> Inverts the bits of a value. </td> </tr>
<tr> <td> << </td> <td> Left Shift </td> <td> Shifts bits to the left. </td> </tr>
<tr> <td> >> </td> <td> Right Shift </td> <td> Shifts bits to the right. </td> </tr>
 </table>
 
6. Conditional Operator:
<table> <tr> <th> Operator </th> <th> Description </th> <th> Explain </th></tr>
<tr> <td> ? : </td> <td> Conditional Operator or Ternary Operator </td> <td> Provides a concise way to return one of two values based on a condition. </td> </tr>
</table>
7. Increment and Decrement Operators:
<table> <tr> <th> Operator </th> <th> Description </th> <th> Explain </th></tr>
<tr> <td> ++ </td> <td> Increment </td> <td> Increases the value of a variable by 1. </td> </tr>
<tr> <td> -- </td> <td> Decrement </td> <td> Decreases the value of a variable by 1. </td> </tr>
</table>

8. Type Cast Operators:
<table> <tr> <th> Operator </th> <th> Description </th> <th> Explain </th></tr>
<tr> <td> type </td> <td> Explicit Type Cast </td> <td> Converts a value to a specific data type. </td> </tr>
</table>

9. Other Operators:

<table> <tr> <th> Operator </th> <th> Description </th> </tr>
<tr> <td> sizeof </td> <td> Returns the size, in bytes, of a data type. </td> </tr>
<tr> <td> typeof </td> <td> Returns the Type object for a given type. </td> </tr>
<tr> <td> is </td> <td> Checks if an object is of a specific type. </td> </tr>
</table>

<h3> For & FOR EACH </h3>

In C#, both the for and foreach loops are used for iterating over collections of data, such as arrays, lists, and other enumerable objects. They have slightly different use cases and syntax, but they serve similar purposes.

1. for Loop:
The for loop is a more traditional loop that provides precise control over the iteration process. It is commonly used when you know the exact number of iterations you want to perform. The syntax of a for loop is as follows:

![loop1](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/a3ca82ed-cf4d-4d8c-9923-cb5c51a53398)

<table> <tr> <th> Initialization </th> <th> Condition </th> <th> Iteration </th> </tr> <tr> <td> This part is executed before the loop starts. You typically initialize a loop counter variable here. </td> <td> The loop continues as long as this condition is true. It is evaluated before each iteration. </td> <td> This part is executed after each iteration. You usually update the loop counter variable here. </td> </tr> </table>

Example of a for loop:

![loop2](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/981d4fea-646f-4454-9cbc-713c85ba2d1a)

3. foreach Loop:
The foreach loop is used when you want to iterate through all elements of a collection without concerning yourself with the index or counter. It simplifies the process of iterating over arrays, lists, and other collections. The syntax of a foreach loop is as follows:

![loop3](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/d3853a11-5645-4850-a48d-ccee280ed2dd)

<table> <tr> <th> item </th> <th> collection </th> </tr> <tr> <td> This is a temporary variable that holds the current item from the collection in each iteration. </td> <td> The collection you want to iterate through. </td> </tr> </table>

Example of a foreach loop:

![loop4](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/9e505772-052e-4394-a403-9992227103fd)

<table> <tr> <th> Use the for loop when </th> <th> Use the foreach loop when </th> </tr> <tr> <td> You need to iterate a specific number of times. </td> <td> You want to iterate through all elements of a collection without needing to manipulate indices. </td> </tr> <tr> <td> You require fine control over the iteration process, such as skipping or repeating iterations based on complex conditions. </td> <td> You want cleaner and more readable code for simple iterations. </td> </tr> <tr> <td> You need to iterate through arrays, lists, or collections using an index. </td> <td> You're working with collections that implement the IEnumerable or IEnumerable<T> interface. </td> </tr> </table>

<h4> Break & Continue</h4>

In C#, break and continue are control flow statements used within loops (such as for, while, and do-while) to control the flow of the loop execution. They serve different purposes:

break Statement:

The break statement is used to exit the current loop prematurely. When executed, it immediately terminates the loop and continues with the code following the loop.

It is often used when a specific condition is met, and you want to exit the loop before it reaches its natural end.

![4 01](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/6a2683a7-673c-4006-bfa3-17031489ee4a)

In this example, the loop exits when i equals 3, and the output will be 0, 1, and 2.

continue Statement:

The continue statement is used to skip the current iteration of a loop and proceed with the next iteration. When executed, it jumps to the next iteration, bypassing any code that follows it within the current iteration.

It is often used when you encounter a condition that should cause you to skip the current iteration but continue with the remaining iterations.

![4 02](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/7cfaa597-f4e6-48eb-8a47-354f64fd4314)

In this example, the loop skips the iteration when i equals 2, and the output will be 0, 1, 3, and 4.
<table> <tr> <th> Key Points</th></tr>
<tr> <td> break is used to exit the entire loop, while continue is used to skip the current iteration and move to the next one. </td></tr>
<tr> <td> Both break and continue can be used with for, while, and do-while loops, as well as within nested loops. </td> </tr>
<tr> <td> The use of break and continue should be carefully considered to ensure that the program behaves as intended and to avoid unintended consequences. </td> </tr>
<tr> <td> break can also be used in switch statements to exit the switch block prematurely. </td> </tr>
<tr> <td> These control flow statements are essential for controlling the flow of loops and making your code more flexible and responsive to specific conditions during execution. </td> </tr> </table>

<h4>If/Else If/Else Statement </h4>

In C#, the if, else if, and else statements are used for conditional branching, allowing you to execute different blocks of code based on various conditions. They are part of the control flow structures in C# and are essential for building decision-making logic in your programs. Here's how they work:

if Statement:

The if statement is used to execute a block of code if a specified condition evaluates to true. If the condition is false, the code block is skipped.

The basic syntax of the if statement is as follows:

![4 05](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/77e500bc-62fa-4362-ad51-d3bf149b7072)

Example:

![4 06](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/f05d3e8c-09a0-426e-a851-3b15f6505099)

else if Statement:

The else if statement allows you to test multiple conditions sequentially after the initial if condition. It is used when you have multiple conditions to check.

The basic syntax of the else if statement is as follows:

![4 07](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/3d6e5a09-4676-4e04-b58a-f99cc92952d9)

Example:

![4 08](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/e31a7c44-4c08-43ee-8443-8a425940f163)

else Statement:

The else statement is used to provide a default block of code to execute when none of the preceding conditions (in if and else if statements) are met.

The basic syntax of the else statement is as follows:

![4 09](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/051a5a68-095b-47f0-a951-3c2220a1a53c)

Example:

![4 10](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/e02a2a09-a803-44db-a550-e3485ac3f8fa)

<table>
 <tr> <th> Key Points </th></tr>
 <tr> <td> else if and else statements are optional and can follow an if statement to create more complex conditional logic.</td></tr>
 <tr> <td> Conditions are evaluated sequentially in if, else if, and else statements. Once a true condition is found, the associated code block is executed, and the rest of the conditions are skipped. </td> </tr>
 <tr> <td> You can have multiple else if branches to handle different cases. </td> </tr>
 <tr> <td> The else statement provides a fallback code block that is executed when none of the preceding conditions is true. </td> </tr>
 <tr> <td> It's essential to choose the appropriate conditional structure (if, else if, else) based on the logic you want to implement in your program. </td> </tr>
</table>

These conditional statements allow you to create decision-making logic in your C# programs, enabling your code to respond dynamically to different situations and conditions.

<h4> Switch Statement </h4>

The switch statement in C# is a control flow statement that allows you to select one of many code blocks to execute based on the value of an expression. It provides an efficient way to handle multiple conditional branches without the need for multiple if statements. Here's the basic syntax of a switch statement:

![4 03](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/ef529cb1-87d2-40a1-a56f-d9578422e3c9)


Here's an explanation of the components of the switch statement:

expression: An expression whose value is compared against the values in the case labels. This expression can be of any data type that is compatible with the data types used in the case labels (e.g., integers, characters, enums).

case value1, case value2, etc.: These are the individual cases or labels that represent specific values that expression can match. When expression matches a case, the corresponding block of code is executed.

break: This is an optional keyword used to exit the switch statement after a case is matched and its code block is executed. If you omit the break statement, execution will continue into the next case until a break statement is encountered or the switch block ends.

default: This is also an optional case that is executed when none of the previous cases match the expression. It's similar to the else block in an if-else statement.

Here's an example of a switch statement in action:

![4 04](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/74de6471-2c93-4bba-970f-df56a78200b5)

In this example, the switch statement evaluates the value of the day variable and assigns the corresponding day name to the dayName variable. The break statements ensure that only the code for the matching case is executed.

The switch statement is a powerful tool for handling multiple branches of code based on a single expression, making your code more concise and readable.

<h5> Differences between If and Switch Statement </h5>

The switch statement and the if statement in C# are both used for making decisions in your code based on certain conditions, but they have some key differences:

<table> <tr> <th>   </th> <th>  If Statement </th> <th> Switch Statement </th> </tr>
<tr> <th> Structure and Syntax </th> <td> The if statement is a conditional statement that evaluates a Boolean expression. It can be used to execute a block of code if a condition is true. It has a straightforward syntax. </td> <td> The switch statement is used for multi-way branching. It allows you to select one of many code blocks to execute based on the value of an expression. It has a more structured syntax with case labels. </td> </tr>
<tr> <th> Use Cases </th> <td> if statements are versatile and can handle a wide range of conditions, including complex Boolean expressions. They are well-suited for conditions that don't have a fixed set of values to check against. </td> <td> switch statements are designed for scenarios where you want to compare a single expression against a set of known values (constants) and execute code based on the matching value. They are particularly useful when you have a fixed set of options or cases to handle.</td> </tr>
<tr> <th> Value Matching </th> <td> if statements evaluate conditions that can be any Boolean expression. They are not limited to comparing a single value against a set of constants. </td> <td> switch statements compare the value of an expression against a set of constant values defined in case labels. They perform value matching. </td> </tr>
<tr> <th> Fall-Through </th> <td> if statements execute a block of code if the condition is true, and they do not automatically "fall through" to subsequent conditions. </td> <td> switch statements do not automatically "fall through." Once a matching case is found and executed, the break statement is required to exit the switch block. Without break, execution will continue to the next case. </td>  </tr>
</table>

Here's a general guideline for choosing between if and switch:

Use if when you have complex conditions or when you need more flexibility in your decision-making process.

Use switch when you have a single expression to compare against a fixed set of values (constants) and want to make your code more concise and structured.

In practice, you'll often use both if and switch statements in your code, depending on the specific requirements of different scenarios.

<h3> Arrays </h3>
In C#, an array is a data structure that allows you to store a collection of elements of the same data type in a contiguous block of memory. Arrays are one of the fundamental data structures and are used extensively in programming for tasks that involve managing collections of items. Here are some key characteristics of arrays in C#:

<table> <tr> <th> Homogeneous Elements </th> <th> Fixed Size </th> <th> Zero-Based Indexing </th> <th> Contiguous Memory Allocation </th> <th> Initialization </th> </tr>
<tr> <td> All elements in an array must be of the same data type. This means that if you create an array of integers, all elements in that array must be integers. </td>  
<td> Once you define the size of an array, it cannot be changed. This size is determined at the time of array creation. </td> <td> Array elements are accessed using an index, and C# uses zero-based indexing. This means that the first element of an array has an index of 0, the second element has an index of 1, and so on. </td> <td> Array elements are stored in contiguous memory locations, which allows for efficient access based on the index. </td> <td> Arrays can be initialized when they are declared, or you can assign values to individual elements after declaration. </td> </tr> </table>

Here's how you declare and initialize an array in C#:

![4 11](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/59003357-7ae4-42f0-8460-41fa743c7038)

You can also use array initializer syntax to declare and initialize an array in a single line:

![4 12](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/97c35eab-0ef9-4e9c-882a-cb2ce05e025e)

Accessing elements of an array:

![4 13](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/44e27ab2-2138-4fe2-a254-8145cdbe3f25)

Iterating through an array:

![4 14](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/ea353178-aa71-4b05-b0ac-9f975148ef2c)

Arrays are widely used for tasks such as storing collections of data, implementing data structures like lists and queues, and performing various algorithms and computations. C# provides various types of arrays, including single-dimensional arrays, multi-dimensional arrays, and jagged arrays, to suit different programming needs.

<h3> Value & Reference Type </h3>

In C#, variables can be categorized into two main types based on how they store and reference data in memory: value types and reference types. Understanding the distinction between these two types is crucial for efficient memory management and proper program behavior. 

Here's an overview of value types and reference types in C#:

<table> <tr> <th>  </th> <th> Value Type </th> <th> Reference Type </th> </tr>
<tr> <th> Stored Value </th> <td> Value types store the actual data values directly in memory where the variable is declared. They hold the data itself, not a reference or pointer to the data. Value types include primitive types like integers (int, char, double), enumerations (enum), and structures (struct). </td> <td> Reference types store a reference or a pointer to the data in memory, not the actual data itself. They represent objects created on the heap (a managed memory region). Reference types include classes, interfaces, delegates, and strings. </td> </tr>
<tr> <th> Memory Allocation </th> <td> Value types are typically allocated on the stack or inline within another object (e.g., within a class or struct). They have a fixed memory size determined by their data type. </td> <td> Objects of reference types are allocated on the heap, which is managed by the Common Language Runtime (CLR). They have a dynamic memory size determined by the object's structure and the data it contains. </td> </tr>
<tr> <th> Assignment Behavior </th> <td> When a value type is assigned to another variable or passed as a method argument, a copy of the data is made. Changes to one variable do not affect the others, as they each have their own independent copy of the data. </td> <td> When a reference type is assigned to another variable or passed as a method argument, both variables refer to the same object in memory. Changes to one variable can affect others that reference the same object.
 </td> </tr>
<tr> <th> Examples </th> <td> int x = 5;   char c = 'A';   struct Point { int X, Y; } </td> <td> string str = "Hello, World!";  List<int> numbers = new List<int>();  class Person { string Name; int Age; } </td> </tr>
 
</table>

Key Takeaways:

Value types store data directly, have a fixed memory size, and exhibit value semantics (independent copies).
Reference types store references to data, are allocated on the heap, have dynamic memory sizes, and exhibit reference semantics (multiple variables can reference the same object).
Choosing between value types and reference types depends on your program's requirements, memory considerations, and desired behavior.
It's essential to be aware of these distinctions when designing and debugging your C# programs to avoid unexpected behavior and optimize memory usage.

<h3> ArrayList</h3>

In C#, ArrayList is a dynamically resizing array-like collection provided by the .NET Framework. It's part of the System.Collections namespace and allows you to store and manipulate a collection of objects of different types. Unlike traditional arrays, ArrayList can grow or shrink in size as needed, making it versatile for various programming scenarios. 

Here are some key characteristics and information about ArrayList:

<table> <tr> <th> Heterogeneous Elements </th> <th> Dynamic Sizing </th> <th> Zero-Based Indexing </th> <th> Methods for Manipulation </th> <th> Type Safety </th> <th> Performance Considerations </th>  </tr>
<tr> <td> Unlike arrays, ArrayList can store elements of different data types in the same collection. This flexibility is possible because ArrayList stores objects of type object. </td> <td> ArrayList dynamically resizes itself to accommodate the number of elements you add. When it reaches its capacity, it automatically increases its size. </td> <td> Similar to arrays, ArrayList uses zero-based indexing for accessing elements. </td> <td> ArrayList provides numerous methods for adding, removing, searching, and manipulating elements. Some commonly used methods include Add, Remove, RemoveAt, Insert, IndexOf, Contains, and more. </td> <td> Since ArrayList stores objects of type object, you may need to use explicit casting ((type)) when retrieving elements. This lack of type safety can lead to runtime errors if you try to cast objects to incompatible types. </td> <td> Because of the use of boxing and unboxing (converting value types to reference types and vice versa), ArrayList can have performance overhead when working with value types. </td> </tr>
 
</table>

Here's how you can create and use an ArrayList:

![5 01](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/3545e514-6d19-4f0f-8dfe-7deb913ac162)

![5 02](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/b0225331-e5b8-4141-8c8e-36f5a7660cb3)

It's important to note that due to the lack of type safety, you should consider using generic collections like List<T> when possible, as they provide better type checking and performance for strongly typed collections. However, ArrayList can still be useful in scenarios where you need to work with heterogeneous data or when dealing with legacy code.

<h4> Differences between Array and ArrayList </h4>

Arrays and ArrayLists are both used to store collections of data in C#, but they have significant differences in terms of functionality and usage. 

Here's a comparison of arrays and ArrayLists:
<table> <tr> <th> </th> <th> Array </th> <th> ArrayList </th></tr>
<tr> <th> Data Type </th> <td> Arrays are fixed-size and store elements of a specific data type. All elements in an array must have the same data type. </td> <td> ArrayLists are dynamically resizable and can store elements of different data types. They store objects of type object, so you can add elements of various data types. </td> </tr>
<tr> <th> Size </th> <td> Arrays have a fixed size, determined at the time of creation. You cannot change the size of an array once it's created. </td> <td> ArrayLists can dynamically grow or shrink in size as elements are added or removed. They don't have a fixed size. </td> </tr> 
<tr> <th> Initialization </th> <td> Arrays must be initialized with a specified size when declared, e.g., int[] numbers = new int[5];. </td> <td> ArrayLists can be initialized with or without specifying an initial capacity, and you don't need to specify a size in advance, e.g., ArrayList list = new ArrayList(); or ArrayList list = new ArrayList(10);. </td> </tr> 
<tr> <th> Type Safety </th> <td> Arrays are type-safe, meaning they enforce type consistency because all elements must be of the same data type. </td> <td> ArrayLists are not type-safe due to storing objects of type object. Casting may be required when retrieving elements, which can lead to runtime errors if not done correctly. </td> </tr> 
<tr> <th> Performance </th> <td> Arrays generally have better performance for read and indexed access because they are stored in contiguous memory locations. They are more efficient for value types. </td> <td> ArrayLists can have slightly lower performance due to the overhead of storing objects (boxing and unboxing) and the non-contiguous memory allocation. </td> </tr>
<tr> <th> Methods and Flexibility </th> <td> Arrays have limited built-in methods and cannot easily change size. You need to create a new array if you want to resize it. </td> <td> ArrayLists provide various methods for adding, removing, and manipulating elements, making them more flexible for dynamic data. </td> </tr>
<tr> <th> Compatibility </th> <td> Arrays are part of the core C# language and are widely used. </td> <td> ArrayLists are part of the .NET Framework's collection classes and are somewhat older. They have been largely replaced by generic collections like List<T> for better type safety and performance. </td>  </tr>
<tr> <th> Strongly Typed Collections </th> <td> C# offers strongly typed arrays for value types, e.g., int[], string[], etc. </td> <td> ArrayLists do not have strongly typed counterparts for value types. For strongly typed collections, use generic collections like List<T>. </td> </tr> </table>

![5 03](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/28e1bddc-21b6-44f9-80ed-4dab9532cfc5)

<h3> Boxing & Unboxing </h3>

Boxing and unboxing are concepts in C# related to the conversion between value types and reference types. They are primarily used when dealing with value types (e.g., integers, characters, structs) in scenarios where reference types (e.g., objects) are expected. Here's an explanation of boxing and unboxing:

<h4> Boxing </h4>

Boxing is the process of converting a value type into a reference type (object).
When you box a value type, a new object is created on the heap, and the value of the value type is copied into this object.
The original value type remains unchanged.
Boxing is typically done implicitly when you assign a value type to a variable of a reference type (e.g., assigning an int to an object variable).

![6 01](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/9d68b1a9-aaf1-4043-aab6-513ea18d25e6)

<h4> Unboxing </h4>

Unboxing is the process of converting a boxed value (reference type) back to its original value type.
It's the reverse of boxing, where the value is extracted from the boxed object and converted back to the value type.
Unboxing requires explicit casting to the appropriate value type, as the compiler doesn't know the original type of the object.

![6 02](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/3ed780ae-a53c-4162-a8cd-4a12041e557c)

Performance Implications:

Boxing and unboxing operations can have performance implications because they involve creating objects on the heap and type casting.
They are relatively slow compared to direct operations on value types.
Frequent boxing and unboxing in performance-critical code can lead to performance bottlenecks.

Use Cases:

Boxing and unboxing are often encountered when working with non-generic collections like ArrayList or when interfacing with APIs that expect reference types.
They are commonly used in scenarios where you need to store value types in data structures designed for reference types, such as lists or dictionaries.

![6 03](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/81cd6fff-2afd-46ba-ba76-cc770b3506eb)

Generics Alternative:

In modern C# programming, it's recommended to use generic collections (e.g., List<T>) and nullable value types (int?, double?) when possible to avoid boxing and unboxing.
Generics provide type safety and better performance, as they work directly with value types without the need for boxing.

![6 04](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/f0dde623-da04-4c1e-b0be-8b5a9089b214)

In summary, boxing and unboxing are mechanisms for converting between value types and reference types. While they are useful in certain scenarios, they should be used judiciously, as they can impact performance. Whenever possible, consider using generics and value types directly to avoid the overhead of boxing and unboxing.

<h3> Casting </h3>

Casting in C# is the process of converting a value from one data type to another. It allows you to explicitly change the data type of a value, variable, or expression. Casting is often necessary when you want to perform operations or assignments involving different data types. There are two main types of casting in C#: implicit casting (also known as widening or type conversion) and explicit casting (also known as narrowing or type casting).

<h4> Implicit Casting (Widening) </h4>

Implicit casting occurs when a value of a smaller data type is automatically converted to a larger data type without the risk of losing data.
The conversion is done by the compiler, and you don't need to use any special syntax.
Implicit casting is always safe because it involves converting to a larger storage type.

![6 05](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/3bf37059-df3b-44b3-98cb-802bd8b166c5)

<h4> Explicit Casting (Narrowing) </h4>

Explicit casting is required when you want to convert a value from a larger data type to a smaller data type, or when you need to specify the casting operation explicitly.

This type of casting may result in data loss or overflow, so it requires you to use the cast operator ((type)) to indicate the intended conversion.

![6 06](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/fe72b0de-9ec9-45c6-a642-5b8008aa7c01)

<h4> Casting Between Related Types </h4>

In some cases, you may need to cast between related data types, such as casting between base and derived classes, or between interfaces and their implementing classes.
These casts are often performed implicitly or with explicit casting based on the type hierarchy.

![6 07](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/9fe0f12a-7554-44b1-baf8-7cafe77aa910)

<h4> Casting with User-Defined Types </h4>

You can define custom casting operations for your own types by implementing explicit and implicit conversion operators in your classes or structs.
These custom operators allow you to control how objects of your types are converted to and from other types.

![6 08](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/d1002e13-87bd-4041-ad8a-760b1ebe05a2)

<h4> Checking for Invalid Casts </h4>

When performing explicit casts, you should use exception handling (try-catch) or methods like as and is to check whether the cast is valid before performing it.
This helps prevent runtime errors due to invalid casts.

![6 09](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/82c471ce-9151-409f-9a1a-ff60dfa44929)

Casting is a powerful feature in C# that allows you to work with different data types in a flexible manner. However, it should be used with caution, especially when performing explicit casts, to avoid unexpected runtime errors and data loss.

<h3> Generic and Non-generic Collection </h3>

C# includes specialized classes that store series of values or objects are called collections.

There are two types of collections available in C#: non-generic collections and generic collections.

The System.Collections namespace contains the non-generic collection types and System.Collections.Generic namespace includes generic collection types.

In most cases, it is recommended to use the generic collections because they perform faster than non-generic collections and also minimize exceptions by giving compile-time errors.

<h4> Generic Collections </h4>


C# includes the following generic collection classes in the System.Collections.Generic namespace.

<table> <tr> <th> Generic Collections </th> <th> Description </th> </tr>
<tr> <td> List (T) </td> <td> Generic List(T) contains elements of specified type. It grows automatically as you add elements in it. </td> </tr> <tr> <td> Dictionary (TKey,TValue) </td> <td> Dictionary (TKey,TValue) contains key-value pairs. </td> </tr> <tr> <td> Queue (T) </td> <td> Queue(T) stores the values in FIFO style (First In First Out). It keeps the order in which the values were added. It provides an Enqueue() method to add values and a Dequeue() method to retrieve values from the collection. </td> </tr> <tr> <td> SortedList(TKey,TValue) </td> <td> SortedList stores key and value pairs. It automatically adds the elements in ascending order of key by default. </td> 
</tr> <tr> <td> Stack (T) </td> <td> Stack(T) stores the values as LIFO (Last In First Out). It provides a Push() method to add a value and Pop() & Peek() methods to retrieve values. </td> </tr> <tr> <td> Hashset(T) </td> <td> Hashset(T) contains non-duplicate elements. It eliminates duplicate elements. </td> </tr> </table>

<h4> Non-generic Collections </h4>
<table> <tr> <th> Non-generic Collections </th> <th> Usage </th> </tr> <tr> <td> ArrayList </td> <td> ArrayList stores objects of any type like an array. However, there is no need to specify the size of the ArrayList like with an array as it grows automatically. </td> </tr> <tr> <td> SortedList </td> <td> SortedList stores key and value pairs. It automatically arranges elements in ascending order of key by default. C# includes both, generic and non-generic SortedList collection. </td> </tr> <tr> <td> Stack </td> <td> Stack stores the values in LIFO style (Last In First Out). It provides a Push() method to add a value and Pop() & Peek() methods to retrieve values. C# includes both, generic and non-generic Stack. </td> </tr> <tr> <td> Queue </td> <td> Queue stores the values in FIFO style (First In First Out). It keeps the order in which the values were added. It provides an Enqueue() method to add values and a Dequeue() method to retrieve values from the collection. C# includes generic and non-generic Queue. </td> </tr> <tr> <td> Hashtable </td> <td> Hashtable stores key and value pairs. It retrieves the values by comparing the hash value of the keys. </td> </tr> <tr> <td> BitArray </td> <td> BitArray manages a compact array of bit values, which are represented as Booleans, where true indicates that the bit is on (1) and false indicates the bit is off (0). </td> </tr>
 
</table>


<h3> Ref & Out </h3>

In C#, ref and out are two keywords used to pass arguments to methods by reference rather than by value. 
They are used when you want to modify the value of a variable within a method and have those changes reflected in the calling code. However, there are some differences in how ref and out work:

ref Keyword:

Used to pass a variable by reference to a method.
Requires that the variable be initialized before passing it to the method.
Allows both read and write access to the variable within the method.
The method can use the existing value of the variable or assign a new value to it.

![16 03](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/4dbf7e8a-50b6-43e7-be8a-40f2051ea650)

out Keyword:

Used to indicate that a method returns a value through its parameter.
Does not require the variable to be initialized before passing it to the method.
Does not allow reading the value of the variable before it's assigned within the method.
The method must assign a value to the variable before it returns.

![16 04](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/bcd35a21-994d-42e0-bb3f-3c4e6626085c)

Key Points:

Both ref and out allow a method to modify the value of a variable in the calling code. However, out is typically used when the method is expected to return a value through the parameter.

When using ref or out, it's essential to ensure that the variable being passed is appropriately initialized or assigned within the method to prevent potential runtime errors.

You can use either ref or out with value types (e.g., int, float) or reference types (e.g., classes) as method parameters.

When you use out, the method is not required to assign a value to the parameter before returning, but it must do so at some point within the method. Failure to assign a value will result in a compilation error.

When using ref, the variable must have a value assigned before being passed to the method.

In summary, ref and out are useful for passing arguments by reference when you need to modify variables in a method and have those modifications affect the calling code. The choice between them depends on whether you want to use the existing value of the variable or have the method assign a new value to it.

<h3> Undefined and Null </h3>

In C#, "undefined" and "null" are two distinct concepts related to variables and values. It's essential to understand the differences between them:

<h4> Undefined </h4>

An "undefined" variable refers to a variable that has been declared but has not been assigned a value.

In C#, when you declare a variable without initializing it, it's considered "undefined" because it doesn't have a specific value.

Accessing an undefined variable will result in a compilation error.

Example:

![8 01](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/aabb78b9-3539-4fb8-a223-9c7864e292d9)

<h4> Null </h4>

"Null" is a special value that represents the absence of an object or a value.

In C#, reference types (objects) can have the value "null" to indicate that they don't point to any valid object in memory.

Value types (e.g., integers, booleans) cannot have a "null" value because they always contain a value.

To assign a "null" value to a reference type, you can use the null keyword.

Example:

![8 02](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/bd526dc8-5acc-4c78-9e07-6071559701be)

<table> <tr> <th> Key Differences </th></tr>
<tr> <td> Undefined variables are variables that have not been given a value at all and will result in compilation errors when accessed. </td></tr>
<tr> <td> Null is a specific value assigned to reference type variables to indicate the absence of an object. </td> </tr>
<tr> <td> You can explicitly set a reference type variable to null, but you cannot set a value type variable to null. </td> </tr>
<tr> <td> You can use checks like if (variable == null) to test whether a reference type variable is null or not. </td> </tr>
 
</table>

![8 03](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/0e239b14-7b60-468c-946e-c5e8067cb9de)


<h4>Enum </h4>

In C# and many other programming languages, an enum, short for "enumeration," is a data type used to define a set of named integral constants, often referred to as enumerators or members. Enums are primarily used to make code more readable, self-explanatory, and less error-prone when working with a predefined set of related values.

Here's the basic syntax for defining an enum in C#:

![12 01](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/d3838eab-03da-447c-a853-3b4bcf6d7e9d)

In this example, DaysOfWeek is an enum that represents the days of the week. The members of the enum (Sunday, Monday, etc.) are constant values with default underlying integer values starting from 0.

Enums in C# offer several benefits:
<table> <tr> <th> Improved Readability </th> <th> Type Safety </th> <th> Intellisense Support </th> <th> Avoid Magic Numbers </th> </tr>
<tr> <td> Enums make your code more readable because you can use meaningful names (like DaysOfWeek.Monday) instead of numeric constants (like 1 for Monday). </td> <td> Enums provide type safety because the compiler checks that you only use valid enum values. You can't assign arbitrary integers or other types to an enum variable. </td> <td> Most development environments, like Visual Studio, provide intellisense and autocomplete support when working with enums, making it easier to use them correctly. </td> <td> Enums help eliminate "magic numbers" in your code, which are unexplained numeric constants that might be confusing for other developers. </td>   </tr> 
</table>
Here's how you can use an enum in C#:

![12 02](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/734676d7-287c-4c00-9820-6255f2da6dba)

Enums can also have explicitly assigned values:

![12 03](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/1ee5fc0c-103f-4385-9676-318778f191be)

In this case, you can assign specific integer values to the enum members, and these values don't need to be sequential or unique.

Enums are a powerful tool for improving code readability and reducing errors when working with predefined sets of related values, like days of the week, status codes, or menu options.

<h3> IS vs AS </h3>

In C#, both is and as are used for type checking and type casting, but they serve different purposes and have different behaviors:

is Operator:

The is operator is primarily used for type checking. It allows you to determine whether an object is an instance of a specific type or a type derived from it.
It returns a boolean value (true or false) based on whether the object can be cast to the specified type without throwing an exception.
Here's an example of how is is used:

![16 01](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/99e1cb13-bed7-4930-a489-d912b25826ae)

as Operator:

The as operator is used for explicit type casting (conversion) of reference types. If the cast is not possible, it returns null instead of throwing an exception.
It's primarily used when you want to convert an object to a specific type, and if the conversion isn't possible, you can gracefully handle the null result.
Here's an example of how as is used:

![16 02](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/8c1170ac-a192-4f1e-81fd-2f03b7bfe831)

To summarize, is is used for type checking and returns a boolean, while as is used for type casting and returns either a reference to the object of the target type or null if the cast is not possible. Choosing between them depends on your specific use case and how you want to handle type-related operations in your code.

<h3> Delegate </h3>

In C#, a delegate is a type that represents references to methods with a specific parameter list and return type. Delegates are often used to create method pointers or function pointers, allowing you to treat methods as objects that can be assigned to variables, passed as parameters to other methods, and invoked like regular methods.

Here are some key points about delegates in C#:

Type-Safe Function Pointers:

Delegates provide type safety because they specify the signature of the methods they can reference. This prevents you from attempting to call a method with the wrong signature through the delegate.

Declaration and Signature:

To declare a delegate, you specify the delegate type's signature, including the return type and parameter types. For example, a delegate that points to a method taking two integers and returning an integer would be declared as follows:

![20 01](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/820d9aa3-0448-4547-a172-b260b2dab2a6)

Creating Instances:

Delegate instances are created by associating them with a method that has a matching signature. This is often done using delegate inference or explicitly specifying the method.

![20 02](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/09a11335-ad4f-4acc-997c-be8bf29c6454)

Invoking Delegates:

Delegates can be invoked just like regular methods using the delegate instance and passing the required arguments.

![20 03](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/7f91e46a-e918-4b2b-ac3e-6a1775d6f865)

Multicast Delegates:

Delegates can reference multiple methods through a feature called multicast delegates. When a multicast delegate is invoked, it calls all the methods it references in the order they were added.

![20 04](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/e5d30d2b-1109-4537-95ef-6fc4e672b414)

Event Handling:

Delegates are commonly used for event handling in C#. Events are a special type of multicast delegate used to handle notifications in response to specific actions or conditions.

![20 05](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/0bee0242-3056-44b1-83b5-54fe9020a1e4)

Lambda Expressions:

C# supports lambda expressions, which allow you to create anonymous methods that match a delegate's signature. This is particularly useful for concise, in-place delegate assignments.

![20 06](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/73f0b102-62bf-4417-acf3-d716ac2de0e7)

Delegates are a fundamental part of C# and are used extensively in scenarios such as event handling, callback mechanisms, and implementing flexible and extensible software architectures. They provide a powerful way to encapsulate and pass behavior in a type-safe manner.

<h4> Action and Func </h4>

In C#, both Action and Func are delegate types that allow you to define and work with methods as first-class objects. They are commonly used in scenarios where you need to pass methods as parameters or store them as variables. Here's a brief explanation of each:

Action:

Action is a delegate type that represents a method that does not return a value (i.e., it has a void return type).
It can take zero or more input parameters, specified as generic type arguments.
Action is commonly used for defining and passing around methods that perform some action or have side effects but do not produce a result.

Example of Action usage:

![20 1](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/ce16e253-da8c-4459-b907-98d4897fb342)


Func:

Func is a delegate type that represents a method that returns a value of a specified type.
It can take zero or more input parameters, specified as generic type arguments. The last type argument specifies the return type.
Func is commonly used for defining and passing around methods that produce a result.

Example of Func usage:

![20 2](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/24465bc6-25ec-4bfb-a694-3a17c578e0af)


Both Action and Func can be very handy when working with delegates, event handling, LINQ, and other scenarios where you need to work with methods as data. They provide a way to encapsulate method signatures and use them in a more flexible manner.

Here's a summary of the generic type parameters for Func and Action:

Func<T1, T2, ..., TResult>: Represents a method that takes parameters of types T1, T2, etc., and returns a result of type TResult.

Action<T1, T2, ...>: Represents a method that takes parameters of types T1, T2, etc., and does not return a result (i.e., void).

You can customize the number and types of parameters as needed for your specific use case when defining Func and Action instances.

<h3> Threads </h3>

In C#, "threading" typically refers to the process of creating and managing threads within a multi-threaded application. Threads are lightweight, independent execution units that allow your program to perform multiple tasks concurrently. Threading can be used to improve the responsiveness and performance of your C# applications, particularly in scenarios where you want to perform time-consuming operations without blocking the main (UI) thread.

Here's a basic overview of how threading works in C#:

Creating Threads:
You can create threads in C# using the Thread class, which is part of the System.Threading namespace. Here's an example of how to create a new thread:

[21 01](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/e11d2375-a2ba-4024-87c3-101de6b58dc4)

Thread Synchronization:
When multiple threads access shared resources, you may encounter issues like race conditions. You can use techniques like locks (lock keyword), mutexes, semaphores, and other synchronization primitives to ensure that threads access shared data safely.

Thread Pooling:
C# also provides a thread pool for efficiently managing and reusing threads for short-lived tasks. You can use the ThreadPool class to queue tasks for execution on available threads from the pool.

![21 02](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/2ec977ec-49fa-4be8-a052-aae9bb391c54)

Async and Await:
For asynchronous programming, C# provides the async and await keywords, which simplify working with threads and asynchronous operations. They are commonly used in scenarios like I/O-bound or network-bound tasks.

![21 03](https://github.com/NigarValikhanova/IT-Brains-Academy/assets/140783772/c2c6b68b-23b7-4e48-95c0-366c50cec416)

It's important to note that working with threads directly can be complex and error-prone. Careful consideration should be given to thread safety, resource management, and avoiding deadlocks when designing multi-threaded applications. Additionally, modern C# features like Task Parallel Library (TPL) and async/await provide higher-level abstractions that simplify many multi-threading scenarios.

<h4> More info about Threading </h4>

Certainly! Threading in C# allows developers to create and manage threads for concurrent execution within an application. Here's a detailed explanation:

### What is a Thread?
A thread is the smallest unit of a process that can be scheduled for execution. In C#, threads are managed by the operating system and can run independently, enabling the application to perform multiple tasks simultaneously.

### Basic Thread Creation:
In C#, threads are managed through the `Thread` class in the `System.Threading` namespace. Here's a basic example of how to create and start a thread:

```csharp
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Creating a new thread and specifying the method to be executed by the thread.
        Thread thread = new Thread(DoWork);

        // Starting the thread.
        thread.Start();
    }

    static void DoWork()
    {
        // Code to be executed by the new thread.
        Console.WriteLine("Thread is doing some work.");
    }
}
```

### Thread Synchronization:
When multiple threads access shared resources, synchronization is crucial to prevent race conditions and ensure data integrity. Techniques like locks (`lock` keyword), mutexes, semaphores, and other synchronization primitives help in ensuring thread safety.

### Parallelism with Task Parallel Library (TPL):
C# provides the Task Parallel Library (TPL) that simplifies the creation of parallel tasks. `Task` objects represent asynchronous operations and can run concurrently. The `Parallel` class provides methods for parallel loops and operations.

### Asynchronous Programming with async/await:
The `async` and `await` keywords simplify asynchronous programming by allowing the execution of long-running tasks without blocking the main (UI) thread. This is commonly used for I/O-bound or CPU-bound tasks.

### Thread Pool:
C# includes a thread pool managed by the runtime, which allows the reuse of threads for short-lived tasks. The `ThreadPool` class provides methods for queuing work items to be processed by the available threads in the pool.

### Thread Lifecycle:
Threads go through various states during their lifecycle, including `Unstarted`, `Running`, `WaitSleepJoin`, `Suspended`, and `Stopped`.

### Thread Priorities:
Threads can be assigned priorities such as `Lowest`, `BelowNormal`, `Normal`, `AboveNormal`, and `Highest` to determine their scheduling preference.

### Thread Safety and Race Conditions:
When multiple threads access shared resources, care should be taken to prevent race conditions. Techniques like locking critical sections and using synchronization constructs help maintain thread safety.

### Deadlocks and Resource Contention:
Improper synchronization or resource contention among threads can lead to deadlocks, where threads are unable to proceed due to waiting for resources indefinitely.

### Best Practices:
- Understand thread safety and utilize synchronization techniques.
- Use thread pool or TPL for managing parallel tasks.
- Minimize the use of low-level thread manipulation in favor of higher-level abstractions like TPL and async/await.

Threading in C# allows developers to create efficient, responsive, and concurrent applications. However, working with threads directly requires a good understanding of synchronization, thread safety, and potential issues like deadlocks and race conditions. It's recommended to leverage higher-level abstractions provided by the Task Parallel Library (TPL) and async/await for most multi-threading scenarios.

<h3> SQL </h3>

SQL, or Structured Query Language, is a domain-specific programming language used for managing and manipulating relational databases. SQL provides a standardized way to interact with databases, and it's essential for storing, retrieving, updating, and managing data. Here's some key information about SQL:

1. **Relational Databases:** SQL is most commonly associated with relational database management systems (RDBMS), which are used to organize and store data in a structured way. Examples of popular RDBMS software include MySQL, PostgreSQL, Microsoft SQL Server, Oracle Database, and SQLite.

2. **Data Manipulation:** SQL is used to perform various operations on data within a database, including:
   - **Querying:** Retrieving data from one or more database tables using SELECT statements.
   - **Inserting:** Adding new records to a table with the INSERT statement.
   - **Updating:** Modifying existing records in a table with the UPDATE statement.
   - **Deleting:** Removing records from a table using the DELETE statement.

3. **Data Definition:** SQL is also used to define and manage the structure of a database. This includes creating, altering, and dropping database objects such as tables, indexes, views, and constraints using statements like CREATE, ALTER, and DROP.

4. **Data Retrieval:** SQL provides powerful tools for retrieving and filtering data from one or more tables. The SELECT statement, for example, allows you to specify which columns to retrieve, filter data based on conditions (WHERE clause), and sort the results.

5. **Data Integrity:** SQL allows you to define constraints to maintain data integrity, such as unique constraints, primary keys, foreign keys, and check constraints. These constraints help ensure that data in the database remains accurate and consistent.

6. **Data Relationships:** SQL supports the creation of relationships between tables through foreign keys. This enables the establishment of connections between related pieces of data, allowing for more complex data models.

7. **Transactions:** SQL provides support for database transactions, which are sequences of SQL statements that are executed as a single unit. This ensures data consistency by either committing or rolling back the entire transaction.

8. **Stored Procedures and Functions:** SQL allows you to create reusable, server-side procedures and functions that can be invoked within SQL queries. These are often used for data validation, complex data manipulation, and business logic.

9. **Aggregate Functions:** SQL provides various aggregate functions like SUM, AVG, COUNT, MAX, and MIN for performing calculations on data sets, which is useful for generating summaries and reports.

10. **Security:** SQL databases have built-in security features to control who can access, modify, and manage data. User roles and access permissions are used to restrict and manage database access.

11. **Normalization:** SQL encourages the practice of database normalization, which is the process of organizing data in a way that minimizes data redundancy and ensures data consistency.

12. **Standardized Language:** SQL is a standardized language with an ANSI (American National Standards Institute) standard. While there are some variations and extensions in different database systems, the core SQL syntax and concepts are consistent across implementations.

SQL is a fundamental tool for working with data in a structured and organized manner, and it is a crucial skill for developers, database administrators, data analysts, and anyone involved in managing and extracting insights from data stored in relational databases.


<h4> CRUD </h4>

CRUD is an acronym that stands for Create, Read, Update, and Delete. It represents the four basic operations or functions that can be performed on data in most database systems. These operations are fundamental in the context of database management and are often associated with SQL and database applications. Here's a brief overview of each CRUD operation:

1. **Create (C):**
   - **Function:** The "Create" operation is used to add new records or data entries to a database.
   - **SQL Statement:** To perform the "Create" operation, you typically use the SQL `INSERT` statement. This statement allows you to add a new row of data to a table.

   Example:
   
   INSERT INTO users (first_name, last_name, email) VALUES ('John', 'Doe', 'johndoe@example.com');
   

2. **Read (R):**
   - **Function:** The "Read" operation is used to retrieve data from a database, often for viewing, analysis, or reporting.
   - **SQL Statement:** To perform the "Read" operation, you use the SQL `SELECT` statement. This statement allows you to query and retrieve data from one or more tables.

   Example:
   
   SELECT * FROM users WHERE last_name = 'Doe';
 
3. **Update (U):**
   - **Function:** The "Update" operation is used to modify or change existing data in a database.
   - **SQL Statement:** To perform the "Update" operation, you use the SQL `UPDATE` statement. This statement allows you to change the values of existing records in a table.

   Example:

   UPDATE users SET email = 'newemail@example.com' WHERE last_name = 'Doe';


4. **Delete (D):**
   - **Function:** The "Delete" operation is used to remove data from a database.
   - **SQL Statement:** To perform the "Delete" operation, you use the SQL `DELETE` statement. This statement allows you to remove specific records or data from a table.

   Example:

   DELETE FROM users WHERE last_name = 'Doe';
  

CRUD operations are at the core of database interactions, and they are essential for building and maintaining applications that work with data. In most software applications, you'll find these operations used extensively to manage and manipulate data in a database. They provide the basic framework for creating, retrieving, updating, and deleting data, which are foundational tasks in many information systems and software applications.

