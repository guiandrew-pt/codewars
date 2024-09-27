// Mumbling
/*
 This time no story, no theory. The examples below show you how to write function accum:

 Examples:

 accum("abcd") -> "A-Bb-Ccc-Dddd"
 accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
 accum("cwAt") -> "C-Ww-Aaa-Tttt"
 The parameter of accum is a string which includes only letters from a..z and A..Z.
*/

import UIKit

func accum(_ s: String) -> String {
    if s.count == 0 {
        return s
    }
    
    let arrString = Array(s)
    var result = ""
    
    result = arrString[0].uppercased()
    
    for i in 1..<arrString.count {
        result += "-"
        result += String(arrString[i]).uppercased()
        
        for _ in 1...i {
            result += String(arrString[i]).lowercased()
        }
    }
    
    return result
}

print(accum("abcd"))// , "A-Bb-Ccc-Dddd")
print(accum("RqaEzty"))// , "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy")
print(accum("cwAt"))// , "C-Ww-Aaa-Tttt")
print(accum("d"))// , "D")
print(accum(""))// , "")

