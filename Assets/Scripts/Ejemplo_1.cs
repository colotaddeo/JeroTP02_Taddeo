using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ejemplo_1 : MonoBehaviour
{
    public int edad;
    public Text mitexto;

    void Start()
    {
        if (edad >= 18)
        {
            mitexto.text = "Es mayor de edad";
            Debug.Log("Es mayor de edad");
        }

        else
        {
            mitexto.text = "Es menor de edad";
            Debug.Log("Es menor de edad");
        }
    }

    void Update()
    {
        
    }
}
