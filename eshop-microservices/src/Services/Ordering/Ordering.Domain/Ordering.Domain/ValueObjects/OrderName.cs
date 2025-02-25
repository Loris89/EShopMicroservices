﻿namespace Ordering.Domain.ValueObjects;

public record OrderName
{
    private const int _defaultLength = 5;

    public string Value { get; }

    private OrderName(string value) => Value = value;

    public static OrderName Of(string value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value);
        ArgumentOutOfRangeException.ThrowIfNotEqual(value.Length, _defaultLength);

        return new OrderName(value);
    }
}
