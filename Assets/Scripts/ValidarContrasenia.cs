using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasenia : MonoBehaviour
{
    string contraseniaCorrecta;
    string contraseniaUsuario;
    public Text ingresoUsuario;
    public Text textoMsj;
    public GameObject Panel_msj;

    void Start()
    {
        contraseniaCorrecta = "12345";
        Panel_msj.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void validarContrasenia()
    {
        contraseniaUsuario = ingresoUsuario.text;
        if (contraseniaUsuario == contraseniaCorrecta)
        {
            Debug.Log("Bienvenido");
            Panel_msj.SetActive(true);
            textoMsj.text = "Bienvenido";
        }
        else
        {
            Debug.Log("Incorrecta");
            Panel_msj.SetActive(true);
            textoMsj.text = "Contraseña Incorrecta";
        }
    }
}
