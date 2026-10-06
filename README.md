# Personalregister

### Please note: This program is a draft and does not compile yet. Thought process is written below

This is a repo for the "Personalregister"-assignment for the Lexicon C#/.NET fullstack program. 
The program contains this far only of a Program.cs-file and an almost empty Employee.cs-file.

The goal of the program is to allow a user to enter employees to a list, along with corresponding salary. A user should also be able to list all empleyees. 
Initially, I figured it should be a literaly list, but I couldn't figure out how to add the salary. 

My next thoughtprocess was to use dictionaries, but what about if we'll keep building on this for future assignments? It would make sense to have uuid for each employee, e-mail, phone number, maybe position and specific admin-rights.
That made me realize the program should consist of a class Employee which has certain attributes. Each specific employee will be an object of the Employee class. 

