using System;
using System.Collections.Generic;


public struct Money
{
    /* Amount of money is stored as the long integer mval.
     * Money can be added and subtracted, but not multiplied or divided.
     * (Money*Money would not make sense. However, Money*int or Money*double
     *  does make sense and should ideally be implemented, but it was not
     *  necessary for this assignement.)
     * Boolean comparisons between different amounts of money is possible.
     * The unit of money is cents, and 100 cents = 1 dollar,
     * so f.ex. 1525 = $ 15.25 = 15 dollar and 25 cents.
     */

    private long mval;

    public Money(long m)
    {
        mval = m;
    }

    public static implicit operator Money(long value)
    {
        return new Money(value);
    }

    public static Money operator +(Money left, Money right)
    {
        return new Money(left.mval + right.mval);
    }

    public static Money operator -(Money left, Money right)
    {
        return new Money(left.mval - right.mval);
    }

    public static Boolean operator ==(Money left, Money right)
    {
        return left.mval == right.mval;
    }

    public static Boolean operator !=(Money left, Money right)
    {
        return left.mval != right.mval;
    }

    public static Boolean operator >(Money left, Money right)
    {
        return left.mval > right.mval;
    }

    public static Boolean operator <(Money left, Money right)
    {
        return left.mval < right.mval;
    }

    public static Boolean operator >=(Money left, Money right)
    {
        return left.mval >= right.mval;
    }

    public static Boolean operator <=(Money left, Money right)
    {
        return left.mval <= right.mval;
    }

    public override string ToString()
    {
        return string.Format("$ {0}.{1}", mval/100, (mval%100).ToString("00"));
    }
}
