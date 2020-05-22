using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserData : MonoBehaviour
{
    private string getUrlEscribir = "http://tadeolabhack.com:8081/test/Datos/mamappdb/escribirUsuario.php"; //http://soymariaojeda.com/ //http://tadeolabhack.com:8081/test/Datos

    private string nombre = "";
    private string correo = "";
    private string contrasena = "";

    public Text prueba;

    public InputField campoNombre;
    public InputField campoCorreo;
    public InputField campoContrasena;

    [SerializeField] private GameObject exitoso;
    [SerializeField] private GameObject mensaje;

    public void senData()
    {
        StartCoroutine(enviarDatosUsuario()); 
    }

    private IEnumerator enviarDatosUsuario()
    {
        nombre = campoNombre.text;
        correo = campoCorreo.text;
        contrasena = campoContrasena.text;  

        print(nombre + " " + correo + " " + contrasena);

        if (nombre == "" || correo == "" || contrasena == "") // Los int == 0
        {
            mensaje.SetActive(true);
        }

        else{

            WWWForm formU = new WWWForm();
            formU.AddField("nombre", nombre); // Primero como le puse en el request [], luego como se llama en la tabla
            formU.AddField("correo", correo);
            formU.AddField("contrasena", contrasena);

            WWW retroalimentacion = new WWW(getUrlEscribir, formU);
            yield return retroalimentacion;

            print(retroalimentacion.text);

            prueba.text = (retroalimentacion.text);

            if (retroalimentacion.text == "Usuario agregado")
            {
                prueba.text = retroalimentacion.text;
                //exitoso.SetActive(true);
            }
            if (retroalimentacion.text == "")
            //else
            {
                prueba.text = "No agregado";
                //exitoso.SetActive(true);
            }
        }

       
        
    }
}
