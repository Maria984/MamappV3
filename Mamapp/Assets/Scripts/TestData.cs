using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestData : MonoBehaviour
{
    private string getUrlEscribirTest = "http://tadeolabhack.com:8081/test/Datos/mamappdb/escribirTest.php"; //http://soymariaojeda.com/

    private int idUsuario = 7;
    private string p1 = "";
    private string p2 = "";
    private string p3 = "";
    private string p4 = "";
    private int p5 = 0;
    private int p6 = 0;

    public InputField campoP1;
    public InputField campoP2;
    public InputField campoP3;
    public InputField campoP4;
    public InputField campoP5;
    public InputField campoP6;


    [SerializeField] private GameObject exitoso;
    [SerializeField] private GameObject mensaje;

    public void senTestData()
    {
        StartCoroutine(enviarDatosTest());
    }

    private IEnumerator enviarDatosTest()
    {
        p1 = campoP1.text;
        p2 = campoP2.text;
        p3 = campoP3.text;
        p4 = campoP4.text;

        if(campoP5.text !="" || campoP6.text != "")
        {
            p5 = int.Parse(campoP5.text);
            p6 = int.Parse(campoP6.text);
        }
           
        print(p1 + " " + p2 + " " + p3 + " " + p4 + " " + p5 + " " + p6);

        if (p1 == "" || p2 == "" || p3 == "" || p4 == "" || p5 == 0 || p6 == 0) // Los int == 0
        {
            mensaje.SetActive(true);// LLenar todos los campos
        }

        else
        {

            WWWForm formT = new WWWForm();
            formT.AddField("idUsuario_FK", idUsuario);
            formT.AddField("pregunta1", p1); // Primero como le puse en el request [], luego como se llama en la variable arriba
            formT.AddField("pregunta2", p2);
            formT.AddField("pregunta3", p3);
            formT.AddField("pregunta4", p4);
            formT.AddField("pregunta5", p5);
            formT.AddField("pregunta6", p6);

            WWW retroalimentacion = new WWW(getUrlEscribirTest, formT);
            yield return retroalimentacion;

            print(retroalimentacion.text);

            if (retroalimentacion.text == "Respuestas agregadas")
            {
                exitoso.SetActive(true);
            }
            else
            {
                exitoso.SetActive(true);
            }
        }



    }
}
