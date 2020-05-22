using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class InfoTest : MonoBehaviour
{
    private string UrlPosition = "http://tadeolabhack.com:8081/test/Datos/mamappdb/MostrarDatosTest.php"; //http://soymariaojeda.com/

    public Text TextoTest;

    public int idUser = 4;

    public void obtenerInfo()
    {
        StartCoroutine(datos());
    }

    public IEnumerator datos()
    {
        string info = UrlPosition + "?IDuser=" + idUser;

        WWW resultInfo = new WWW(info);

        yield return resultInfo;

        print(resultInfo.text);


        TextoTest.text = resultInfo.text;


    }






}