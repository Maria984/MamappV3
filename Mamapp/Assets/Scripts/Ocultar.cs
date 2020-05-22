using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ocultar : MonoBehaviour
{
    
    [SerializeField] private GameObject ocultar2;
    [SerializeField] private GameObject ocultar3;

    [SerializeField] private GameObject img4;
    [SerializeField] private GameObject img5;

    public GameObject textLinea;
    public GameObject textTitulo;

    public float borrar = 1;

    public GameObject bebe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (borrar >= 0)
        {
            textLinea.GetComponent<Text>().text = "Tiempo";
            textTitulo.GetComponent<Text>().text = "Mueve la línea " + "\r\n" + "de tiempo";
            textTitulo.GetComponent<Text>().fontSize = 74;            
            ocultar2.SetActive(false);
            ocultar3.SetActive(false);
            //bebe.gameObject.GetComponent<Animator>().enabled = false;
        }
        if (borrar >= 1)
        {
            textLinea.GetComponent<Text>().text = "8 Semanas";
            textTitulo.GetComponent<Text>().text = "Estrés";
            textTitulo.GetComponent<Text>().fontSize = 150;
            ocultar2.SetActive(true);
            ocultar3.SetActive(false);
            //bebe.gameObject.GetComponent<Animator>().enabled = true;
        }
        if (borrar >= 2)
        {
            textLinea.GetComponent<Text>().text = "20 Semanas";
            textTitulo.GetComponent<Text>().text = "Depresión";
            textTitulo.GetComponent<Text>().fontSize = 125;
            ocultar2.SetActive(true);
            ocultar3.SetActive(false);
        }
        if (borrar >= 3)
        {
            textLinea.GetComponent<Text>().text = "36 Semanas";
            textTitulo.GetComponent<Text>().text = "Ansiedad";
            textTitulo.GetComponent<Text>().fontSize = 125;
            ocultar2.SetActive(true);
            ocultar3.SetActive(false);
        }
        if (borrar >= 4)
        {
            textLinea.GetComponent<Text>().text = "Fin";
            textTitulo.GetComponent<Text>().text = "¿Qué deseas hacer?";
            textTitulo.GetComponent<Text>().fontSize = 74;
            ocultar2.SetActive(false);
            ocultar3.SetActive(true);
        }
        
    }

    public void ToggleAnalog(float newBorrar)
    {
        borrar = newBorrar;
    }
}
