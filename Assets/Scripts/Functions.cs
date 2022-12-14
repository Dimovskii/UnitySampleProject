using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions
{
    public void Dividing()
    {
        Convertation();
        result = first / second;
        OutPut();
    }

    public void Multiplication()
    {
        Convertation();
        result = first * second;
        OutPut();
    }

    public void Minus()
    {
        Convertation();
        result = first - second;
        OutPut();
    }

    public void Sum()
    {
        Convertation();
        result = first + second;
        OutPut();
    }

    public void Min()
    {
        Convertation();
        result = Mathf.Min(first, second);
        OutPut();
    }

    public void Max()
    {
        Convertation();
        result = Mathf.Max(first, second);
        OutPut();
    }

    public void Exponentiation()
    {
        Convertation();
        result = Mathf.Pow(first, second);
        OutPut();
    }

    public void OutPut()
    {
        resultOut.text = result.ToString();
    }
}