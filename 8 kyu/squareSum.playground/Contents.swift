// Square(n) Sum
/*
    Complete the square sum function so that it squares each number passed into it and then sums the results together.

    For example, for [1, 2, 2] it should return 9 because 1^2 + 2^2 + 2^2 = 9.
*/

func squareSum(_ vals: [Int]) -> Int {
    var result = 0

    for val in vals {
        result += val * val
    }

    return result

    // With reduce
    // return vals.reduce(0, {$0 + $1 * $1})
}

print(squareSum([]), 0)
print(squareSum([1]), 1)
print(squareSum([1, 2]), 5)
print(squareSum([3, 4]), 25)
print(squareSum([-3, -4]), 25)
print(squareSum([1, 2, 3]), 14)
print(squareSum([5, 3, 4]), 50)
print(squareSum([-3, -4, 0]), 25)
