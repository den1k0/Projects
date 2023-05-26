import org.junit.Test;
import static org.junit.Assert.assertEquals;
import static org.mockito.Mockito.*;

public class CalculatorTest {
    @Test
    public void testCalculator() {
        Calculator calculatorMock = mock(Calculator.class);
        when(calculatorMock.sum(2, 3)).thenReturn(5);

        Calculator calculatorStub = mock(Calculator.class);
        when(calculatorStub.sum(2, 3)).thenReturn(5);

        Calculator calculatorFake = new CalculatorFake();

        Calculator calculator = new Calculator();
        Calculator calculatorSpy = spy(calculator);

        assertEquals(5, calculatorMock.sum(2, 3));
        assertEquals(5, calculatorStub.sum(2, 3));
        assertEquals(5, calculatorFake.sum(2, 3));
        assertEquals(5, calculator.sum(2, 3));
        assertEquals(5, calculatorSpy.sum(2, 3));
    }
}