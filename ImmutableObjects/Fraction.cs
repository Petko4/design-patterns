// Represents an immutable fraction (rational number) with integer nominator and denominator.
public class Fraction
{
    private readonly int nominator;
    private readonly int denominator;

    // Constructs a fraction from a nominator and denominator. Throws ArgumentException if denominator is zero.
    public Fraction(int nominator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero");
        }
        int divider = Utils.maxCommonDivider(nominator, denominator);
        if (denominator < 0)
        {
            nominator = -nominator;
            denominator = -denominator;
        }
        this.nominator = nominator / divider;
        this.denominator = denominator / divider;
    }

    // Copy constructor. Creates a new Fraction as a copy of another Fraction.
    public Fraction(Fraction fraction)
    {
        nominator = fraction.nominator;
        denominator = fraction.denominator;
    }

    // Constructs a fraction from an integer (number/1).
    public Fraction(int number)
    {
        nominator = number;
        denominator = 1;
    }

    // Returns the nominator of the fraction.
    public int GetNominator()
    {
        return nominator;
    }

    // Returns the denominator of the fraction.
    public int GetDenominator()
    {
        return denominator;
    }

    // Returns the string representation of the fraction in the form [nominator/denominator].
    public override string ToString()
    {
        return $"[{nominator}/{denominator}]";
    }

    // Returns the integer value of the fraction (integer division).
    public int IntValue()
    {
        return nominator / denominator;
    }

    // Returns the double value of the fraction.
    public double DoubleValue()
    {
        return (double)nominator / denominator;
    }

    // Returns a new Fraction that is the sum of this fraction and another fraction.
    public Fraction Add(Fraction fraction)
    {
        return new Fraction(nominator * fraction.denominator + fraction.nominator * denominator, nominator * fraction.nominator);
    }

    // Returns a new Fraction that is the sum of this fraction and an integer.
    public Fraction Add(int number)
    {
        return new Fraction(nominator + number * denominator, denominator);
    }

    // Returns a new Fraction that is the difference between this fraction and another fraction.
    public Fraction Subtract(Fraction fraction)
    {
        return new Fraction(nominator * fraction.denominator - fraction.nominator * denominator, nominator * fraction.nominator);
    }

    // Returns a new Fraction that is the difference between this fraction and an integer.
    public Fraction Subtract(int number)
    {
        return new Fraction(nominator - number * denominator, denominator);
    }

    // Returns a new Fraction that is the result of subtracting this fraction from an integer.
    public Fraction SubtractFrom(int number)
    {
        return new Fraction(number - denominator, denominator);
    }

    // Returns a new Fraction that is the product of this fraction and another fraction.
    public Fraction Multiply(Fraction fraction)
    {
        return new Fraction(nominator * fraction.nominator, denominator * fraction.denominator);
    }

    // Returns a new Fraction that is the product of this fraction and an integer.
    public Fraction Multiply(int number)
    {
        return new Fraction(nominator * number, denominator);
    }

    // Returns a new Fraction that is the result of dividing this fraction by another fraction.
    public Fraction Divide(Fraction fraction)
    {
        return new Fraction(nominator * fraction.denominator, denominator * fraction.nominator);
    }

    // Returns a new Fraction that is the result of dividing this fraction by an integer.
    public Fraction Divide(int number)
    {
        return new Fraction(nominator, denominator * number);
    }

    // Returns a new Fraction that is the result of dividing the given integer by this fraction (number / this).
    public Fraction DivideNumberByFraction(int number)
    {
        return new Fraction(denominator * number, nominator);
    }

}