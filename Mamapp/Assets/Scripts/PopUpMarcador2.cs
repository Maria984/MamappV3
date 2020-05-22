using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Vuforia;

public class PopUpMarcador2 : MonoBehaviour, ITrackableEventHandler
{

    private TrackableBehaviour mTrackableBehaviour;

    private bool mostrar2 = false;
    [SerializeField] private GameObject consecuencias;
    [SerializeField] private GameObject consecuenciasOcultar;
    public GameObject bebe;


    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED)
        {
            mostrar2 = true;
        }
        else
        {
            mostrar2 = false;
        }
    }

    void OnGUI()
    {
        if (mostrar2 == true)
        {
            consecuencias.gameObject.SetActive(true);
            consecuenciasOcultar.gameObject.SetActive(false);
            bebe.gameObject.GetComponent<Animator>().enabled = true;
        }
        if (mostrar2 == false)
        {
            consecuencias.gameObject.SetActive(false);
            consecuenciasOcultar.gameObject.SetActive(true);
        }
    }
}