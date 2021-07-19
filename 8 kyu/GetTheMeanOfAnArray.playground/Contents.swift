// Get the mean of an array
/*
 It's the academic year's end, fateful moment of your school report. The averages must be calculated. All the students come to you and entreat you to calculate their average for them. Easy ! You just need to write a script.

 Return the average of the given array rounded down to its nearest integer.

 The array will never be empty.
*/

func getAverage(_ marks: [Int]) -> Int {
    var totalGrades = 0
    var total = 0
    var result = 0

    for mark in marks {
    total += mark
        totalGrades += 1
    }

    result = total / totalGrades

    return result
    
    // With reduce
    // return marks.reduce(0, +) / marks.count
}

print(getAverage([2,2,2,2]),2);
print(getAverage([1,2,3,4,5,]),3);
print(getAverage([1,1,1,1,1,1,1,2]),1);
