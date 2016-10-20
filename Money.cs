using System;
using System.Collections.Generic;


public struct Money
{
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
