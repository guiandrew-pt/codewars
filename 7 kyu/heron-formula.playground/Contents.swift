// Heron's formula
/*
 Write function heron which calculates the area of a triangle with sides a, b, and c.

 Heron's formula: sqrt (s * (s - a) * (s - b) * (s - c)), where s = (a + b + c) / 2. Output should have 2 digits precision.
*/
import UIKit

func heron(_ a: Double, _ b: Double, _ c: Double) -> Double {
    let s = (a + b + c) / 2
    
    let formatter = Double(String(format: "%.2f", s)) ?? 0.0
    
    return formatter
}

print(heron(9.1, 8.6, 6.6))
