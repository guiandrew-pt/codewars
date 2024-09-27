// Printer Errors
/*
 In a factory a printer prints labels for boxes. For one kind of boxes the printer has to use colors which, for the sake of simplicity, are named with letters from a to m.

 The colors used by the printer are recorded in a control string. For example a "good" control string would be aaabbbbhaijjjm meaning that the printer used three times color a, four times color b, one time color h then one time color a...

 Sometimes there are problems: lack of colors, technical malfunction and a "bad" control string is produced e.g. aaaxbbbbyyhwawiwjjjwwm with letters not from a to m.

 You have to write a function printer_error which given a string will return the error rate of the printer as a string representing a rational whose numerator is the number of errors and the denominator the length of the control string. Don't reduce this fraction to a simpler expression.

 The string has a length greater or equal to one and contains only letters from ato z.

 Examples:

 s="aaabbbbhaijjjm"
 error_printer(s) => "0/14"

 s="aaaxbbbbyyhwawiwjjjwwm"
 error_printer(s) => "8/22"
*/

func printerError(_ s: String) -> String {
    var errors = 0
    let pattern = "nopqrstuvwxyz"

    for i in 0..<s.count {
        for j in 0..<pattern.count {
            let indexS = s.index(s.startIndex, offsetBy: i)
            let indexPattern = pattern.index(pattern.startIndex, offsetBy: j)
            if s[indexS] == pattern[indexPattern] {
                errors += 1
            }
        }
    }
    
    return "\(errors)/\(s.count)"
    
    // OR
//    let errors = s.filter { $0 > "m" }
//    return "\(errors.count)/\(s.count)"
    
    // OR
//    let errors = s.reduce(0) { ("a"..."m").contains($1) ? $0 : $0 + 1 }
//    return "\(errors)/\(s.count)"
}

print(printerError("aaabbbbhaijjjm"))
print(printerError("aaaxbbbbyyhwawiwjjjwwm"))
