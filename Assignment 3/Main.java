import org.junit.Assert;
import org.junit.Test;

public class Main {
    public static String triangleType(int a, int b, int c) {
        if (a < 1 || a > 200) {
            return "Value of a is not in the range of permitted values.";
        }
        if (b < 1 || b > 200) {
            return "Value of b is not in the range of permitted values.";
        }
        if (c < 1 || c > 200) {
            return "Value of c is not in the range of permitted values.";
        }
        if (a >= b + c || b >= a + c || c >= a + b) {
            return "NotATriangle";
        }
        if (a == b && b == c) {
            return "Equilateral";
        }
        if (a == b || b == c || c == a) {
            return "Isosceles";
        }
        return "Scalene";
    }
    // Equivalence Partitioning Test Cases
    @Test
    public void testTriangleType_Equilateral() {
        Assert.assertEquals("Equilateral", triangleType(3, 3, 3));
    }

    @Test
    public void testTriangleType_Isosceles() {
        Assert.assertEquals("Isosceles", triangleType(5, 5, 7));
        Assert.assertEquals("Isosceles", triangleType(5, 7, 5));
        Assert.assertEquals("Isosceles", triangleType(7, 5, 5));
    }

    @Test
    public void testTriangleType_Scalene() {
        Assert.assertEquals("Scalene", triangleType(3, 4, 5));
        Assert.assertEquals("Scalene", triangleType(5, 6, 7));
    }

    @Test
    public void testTriangleType_NotATriangle() {
        Assert.assertEquals("NotATriangle", triangleType(1, 2, 3));
        Assert.assertEquals("NotATriangle", triangleType(2, 3, 5));
    }

    // Error Guessing Test Cases
    @Test
    public void testTriangleType_ValueOutOfRange() {
        Assert.assertEquals("Value of a is not in the range of permitted values.", triangleType(0, 2, 3));
        Assert.assertEquals("Value of b is not in the range of permitted values.", triangleType(1, 201, 3));
        Assert.assertEquals("Value of c is not in the range of permitted values.", triangleType(1, 2, 0));
    }

    // Branch Coverage Test Cases
    @Test
    public void testTriangleType_BranchCoverage() {
        Assert.assertEquals("NotATriangle", triangleType(1, 2, 3));
        Assert.assertEquals("NotATriangle", triangleType(2, 3, 1));
        Assert.assertEquals("NotATriangle", triangleType(3, 1, 2));
        Assert.assertEquals("Isosceles", triangleType(5, 5, 7));
        Assert.assertEquals("Scalene", triangleType(3, 4, 5));
        Assert.assertEquals("Equilateral", triangleType(3, 3, 3));
    }

    // Condition Coverage Test Cases
    @Test
    public void testTriangleType_ConditionCoverage() {
        Assert.assertEquals("Value of a is not in the range of permitted values.", triangleType(0, 2, 3));
        Assert.assertEquals("Value of b is not in the range of permitted values.", triangleType(1, 201, 3));
        Assert.assertEquals("Value of c is not in the range of permitted values.", triangleType(1, 2, 0));
        Assert.assertEquals("NotATriangle", triangleType(1, 2, 3));
        Assert.assertEquals("NotATriangle", triangleType(2, 3, 1));
        Assert.assertEquals("NotATriangle", triangleType(3, 1, 2));
        Assert.assertEquals("Isosceles", triangleType(5, 5, 7));
        Assert.assertEquals("Isosceles", triangleType(5, 7, 5));
        Assert.assertEquals("Isosceles", triangleType(7, 5, 5));
        Assert.assertEquals("Scalene", triangleType(3, 4, 5));
        Assert.assertEquals("Equilateral", triangleType(3, 3, 3));
    }
}