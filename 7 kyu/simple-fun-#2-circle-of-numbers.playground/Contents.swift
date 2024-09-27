// Simple Fun #2: Circle of Numbers
/*
 Consider integer numbers from 0 to n - 1 written down along the circle in such a way that the distance between any two neighbouring numbers is equal (note that 0 and n - 1 are neighbouring, too).

 Given n and firstNumber/first_number, find the number which is written in the radially opposite position to firstNumber.

 Example

 For n = 10 and firstNumber = 2, the output should be

 circleOfNumbers(n, firstNumber) == 7


 Input/Output

 [input] integer n

 A positive even integer.

 Constraints: 4 ≤ n ≤ 1000.

 [input] integer firstNumber/first_number

 Constraints: 0 ≤ firstNumber ≤ n - 1

 [output] an integer
*/

func circleOfNumbers(_ n: Int, _ fst: Int) -> Int {
    // your code here
    
    // First we divide n by 2, next sum the fst, then we find the remainder to give the value between 0 and n
    let opposite = ((n / 2) + fst) % n
    
    return opposite
}

print(circleOfNumbers(10, 2), 7)
print(circleOfNumbers(10, 7), 2)
print(circleOfNumbers(4, 1), 3)
print(circleOfNumbers(6, 3), 0)
print(circleOfNumbers(20, 0), 10)
