// String repeat
/*
 Write a function called repeatStr which repeats the given string string exactly n times.

 repeatStr(6, "I") // "IIIIII"
 repeatStr(5, "Hello") // "HelloHelloHelloHelloHello"
*/

func repeatStr(_ n: Int, _ string: String) -> String {
  // Code here:
    var i = 1
    var str: String = ""

    while i <= n {
        str += string
        i += 1
    }

    return str
    
    // Or
    // return String(repeating: string, count: n)
}

print(repeatStr(6, "I")) // "IIIIII"
print(repeatStr(5, "Hello")) // "HelloHelloHelloHelloHello"
