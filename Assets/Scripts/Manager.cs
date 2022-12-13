using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public InputField firstNumber;
    public InputField secondNumber;
    public Text resultOut;

    public void Convertation()
    {
        DotAndComma();
        first = float.Parse(firstNumber.text);
        second = float.Parse(secondNumber.text);
    }


    private void DotAndComma()
    {
        firstNumber.text = firstNumber.text.Replace('.', ',');
        secondNumber.text = secondNumber.text.Replace('.', ',');
    }

}
