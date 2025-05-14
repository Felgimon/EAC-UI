using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ParImpar : MonoBehaviour
{
    public TMP_InputField inputNum1;
    public TextMeshProUGUI result;
    float num1;

    private void Start()
    {
        result.text = string.Empty;
    }

    public void esPar()
    {
        if (inputNum1.text ==  "")
        {
            result.text = "El campo está vacío";
            return;
        }
        num1 = float.Parse(inputNum1.text);
        if (num1 <= 0)
        {
            result.text = "El número tiene que ser mayor a 0";
            return;
        }
        if (num1 % 2 == 0)
        {
            result.text = "El número es par";
            return;
        }
        result.text = "El número es impar";
    }
}
