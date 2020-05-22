using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IngresoUser : MonoBehaviour
{
    private string UrlIngreso = "http://soymariaojeda.com/mamappdb/leerIngreso.php"; //http://tadeolabhack.com:8081/test/Datos/


    private int idInPhp;

    private string correo = "";

    public Text mensaje;

    private string rta;

    public InputField campoCorreo;
    
    void Start()
    {
        
    }

    public void Ingreso()
    {
        StartCoroutine(datos());
    }

    public IEnumerator datos()
    {

        correo = campoCorreo.text;

        WWWForm formIU = new WWWForm();

        formIU.AddField("cor", correo); //Primero como en el php, la accion que quiero, después el nombre

        WWW retroalimentacion = new WWW(UrlIngreso, formIU);
        yield return retroalimentacion;

        //print(retroalimentacion.text);
        rta = retroalimentacion.text.Trim(); //Borrar los espacios que hay
        print(rta);

        if (rta == "Error")
        {            
            mensaje.text = "Datos Incorrectos";
        }

        else
        {
            string[] datosArray = rta.Split(char.Parse(","));

            if (datosArray.Length == 2)
            {
                idInPhp = int.Parse(datosArray[1]);
                PlayerPrefs.SetInt("idIngreso", idInPhp);
                Escena4();
            }
        }

        /*if (rta == "Correcto")
        {
            /*string[] datosArray = rta.Split(char.Parse(","));

            if (datosArray.Length == 2) 
            {                
                iddd = int.Parse(datosArray[1]);
                print(iddd);
            }
            
                //mensaje.text = "Ingresó";
                //PlayerPrefs.SetInt("idIngreso", 1);
                //Escena4();
        }*/


    }

    public void Escena4()
    {
        SceneManager.LoadScene("Indicaciones");
    }








}