using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{
    private string UrlBotones = "http://tadeolabhack.com:8081/test/Datos/mamappdb/PostSelect.php"; //http://soymariaojeda.com/

    private int IDitem = 0;
    private int IdUser = 3;

    public void SelectItem (int temp)
    {
        IDitem = temp;

        StartCoroutine(sendItem());
    }

    private IEnumerator sendItem()
    {
        print(IDitem + " " + IdUser);

        WWWForm form = new WWWForm();

        form.AddField("userID", IdUser);
        form.AddField("itemID", IDitem);

        WWW retroalimentacion = new WWW(UrlBotones, form);

        yield return retroalimentacion;
        print(retroalimentacion.text);


    }
















}
