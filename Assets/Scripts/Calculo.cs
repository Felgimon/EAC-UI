using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Calculo : MonoBehaviour
{
    private float num1;
    private float num2;
    public TMP_InputField inputNum1;
    public TMP_InputField inputNum2;
    public TextMeshProUGUI txtResultado;
    private float resultado;

    void Start()
    {
        txtResultado.text = string.Empty;
    }

    public void SumarYMostrarResultado()
    {
        num1 = float.Parse(inputNum1.text);
        num2 = float.Parse(inputNum2.text);
        resultado = num1 + num2;
        txtResultado.text = resultado.ToString();

    }

    // Update is called once per frame
    void Update()
    {
       if (txtResultado.text == "10")
       {
           txtResultado.text = "Ben 10, un capo";
       }
    }
}
