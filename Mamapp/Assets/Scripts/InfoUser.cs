using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoUser : MonoBehaviour
{
    //private string UrlPosition = "http://tadeolabhack.com:8081/test/Datos/mamappdb/MostrarDatosUsuario.php"; //http://soymariaojeda.com/
    private string UrlPosition = "http://soymariaojeda.com/mamappdb/leer.php"; //

    public Text TextoNombre;
    public Text TextoCorreo;
    public Text TextoContrasena;

    private string nom;
    private string cor;
    private string con;


    private string rta;

    void Start()
    {
        
    }

    public void obtenerInfo()
    {
        StartCoroutine(datos());
    }

    public IEnumerator datos()
    {
        
        string info = UrlPosition + "?id=" + PlayerPrefs.GetInt("idIngreso"); ;

         WWW resultInfo = new WWW(info);

         yield return resultInfo;
       

        print(resultInfo.text);
        rta = resultInfo.text.Trim();

        string[] datosArray = rta.Split(" "[0]);

        if (datosArray.Length == 3)
        {
            nom = (datosArray[0]);
            cor = (datosArray[1]);
            con = (datosArray[2]);

            TextoNombre.GetComponent<Text>().text = nom;
            TextoCorreo.GetComponent<Text>().text = cor;
            TextoContrasena.GetComponent<Text>().text = con;
        }



        

    }






}