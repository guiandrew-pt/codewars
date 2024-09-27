import UIKit

// Calculate BMI
/*
 Write function bmi that calculates body mass index (bmi = weight / height2).

 if bmi <= 18.5 return "Underweight"

 if bmi <= 25.0 return "Normal"

 if bmi <= 30.0 return "Overweight"

 if bmi > 30 return "Obese"
*/

func bmi(_ weight: Int, _ height: Double) -> String {
    // bmi = weight / height^2
    // your code
    
    let bmi = Double(weight) / pow(height, 2)
    var result = ""
    
    switch bmi {
    case 0...18.5:
        result = "Underweight"
    case 18.6...25.0:
        result = "Normal"
    case 25.01...30.0:
        result = "Overweight"
    default:
        result = "Obese"
    }
    
    return result
}

print("Underweight", bmi(50, 1.80))
print("Normal", bmi(80, 1.80))
print("Overweight", bmi(90, 1.80))
print("Obese", bmi(110, 1.80))
print("Normal", bmi(50, 1.50))

