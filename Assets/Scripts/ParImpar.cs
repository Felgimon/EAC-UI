using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ParImpar : MonoBehaviour
{
    public TMP_InputField num1;
    public TextMeshProUGUI result;

    private void Start()
    {
        result.text = string.Empty;
    }

    public void esPar()
    {
        if (float.Parse(num1.text) % 2 == 0)
        {
            result.text = "El número es par";
            return;
        }
        result.text = "El número es impar";
    }
}
