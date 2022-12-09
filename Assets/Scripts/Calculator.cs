using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField firstNumber;
    public InputField secondNumber;
    public Text resultOut;

    public float first, second, result;

    private void DotAndComma()
    {
        firstNumber.text = firstNumber.text.Replace('.', ',');
        secondNumber.text = secondNumber.text.Replace('.', ',');
    }

    public void Convertation()
    {
        DotAndComma();
        first = float.Parse(firstNumber.text);
        second = float.Parse(secondNumber.text);
    }

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
