// Disemvowel Trolls
/*
 Trolls are attacking your comment section!

 A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.

 Your task is to write a function that takes a string and return a new string with all vowels removed.

 For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".

 Note: for this kata y isn't considered a vowel.
*/

import UIKit

func disemvowel(_ s: String) -> String {
    // This will be the pattern
    let regex = try! NSRegularExpression(pattern: "[aeiou]+", options: NSRegularExpression.Options.caseInsensitive)
    
    // This will be the range
    let range = NSMakeRange(0, s.count)
    
    // Here will replace the pattern (in this case the vowels) with the empty string
    let modString = regex.stringByReplacingMatches(in: s, options: [], range: range, withTemplate: "")
    
    return modString
    
    //Or:
//    return s.replacingOccurrences(of: "[aeiou]", with: "", options: [.regularExpression, .caseInsensitive])
}

print(disemvowel("This website is for losers LOL!"))
print(disemvowel("No offense but,\nYour writing is among the worst I've ever read"))
print(disemvowel("What are you, a communist?"))
