// Grasshopper - Personalized Message
/*
 Create a function that gives a personalized greeting. This function takes two parameters: name and owner.

 Use conditionals to return the proper message:

 case    return
 name equals owner    'Hello boss'
 otherwise    'Hello guest'
*/

func great(_ name: String, _ owner: String) -> String {
    // complete this function
    
    return name == owner ? "Hello boss" : "Hello guest"
}

print(great("Daniel", "Daniel"))
print(great("Greg", "Daniel"))
print(great("Bill", "Daniel"))
print(great("Mary", "Mary"))
print(great("Kate", "Bob"))
