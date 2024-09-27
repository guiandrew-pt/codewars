// Billiards Triangle
/*
 Remember the triangle of balls in billiards? To build a classic triangle (5 levels) you need 15 balls. With 3 balls you can build a 2-level triangle, etc.

 For more examples,

 pyramid(1) == 1

 pyramid(3) == 2

 pyramid(6) == 3

 pyramid(10) == 4

 pyramid(15) == 5
 Write a function that takes number of balls (≥ 1) and calculates how many levels you can build a triangle.
*/

func pyramid(_ balls: Int) -> Int {
    let result = Int(((Float((balls * 8) + 1).squareRoot()) - 1) / 2)
    
    return result
}

func testExample() {
    print(pyramid(1), 1)
    print(pyramid(4), 2)
    print(pyramid(20), 5)
    print(pyramid(100), 13)
    print(pyramid(9999) , 140)
}

testExample()
