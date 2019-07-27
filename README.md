A hello world example using Dependency Injection in a .Net application

The article is an implementation of **Dependency Injection in .Net** by Mark Seemann

The Pure DI concept is presented in Chapter #3 - DI Containers in the book. Note: This is called as Poorman's DI. 
The term Poorman's DI has gotten a negative connotation to it which as I understand is accidental. Mark Seemann on several other occasion conveyed the message that Poorman's DI is his preferred style of coding and started calling it Pure DI. 

It starts with the simple looking Hello, World program through which developers are introduced to a new programming language. 
It then discusses how this code is very tightly coupled to console and to a specific message.

The rest of the chapter is a refactoring of the initial program by applying different programming constructs, such as interfaces and design principles such as SOLID, are applied to make the program more flexible.

The solution ends with a bunch of files that marks clear seperation between the input and output boundaries.

My solution takes the solution to the next level and applies interception to the already amazing solution.

I have added a logging mechanism to the solution which is integrated in to through Unity Interception. Chapter #9 - Interception discusses this concept at length.

Interception are implementation of the decorator pattern with Framework level support. I am using the Unity Container which is discussed in Chapter #14 - Unity, at length. 

