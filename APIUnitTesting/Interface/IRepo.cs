﻿namespace CalculatorAPIUnitTesting.Interface
{
    public interface IRepo
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
        double Divide(int a, int b);
    }
}
