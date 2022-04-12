using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasenia : MonoBehaviour
{
    string contraseniaCorrecta;
    string contraseniaUsuario;
    public Text ingresoUsuario;
    
    void Start()
    {
        contraseniaCorrecta = "12345";

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void validarContrasenia()
    {
        Debug.Log("Test");
        contraseniaUsuario = ingresoUsuario.text;
        if (contraseniaUsuario == contraseniaCorrecta)
        {
            Debug.Log("Bienvenido");
        }
        else
        {
            Debug.Log("Incorrecta");
        }
    }
}
