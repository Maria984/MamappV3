using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Vuforia;

public class PopUpMarcador : MonoBehaviour, ITrackableEventHandler
{

    private TrackableBehaviour mTrackableBehaviour;

    private bool mostrar = false;
    [SerializeField] private GameObject control;
    [SerializeField] private GameObject controlOcultar;
    public GameObject bebe;

    private Animator anim;


    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
        anim = GetComponent<Animator>();
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED)
        {
            mostrar = true;
        }
        else
        {
            mostrar = false;
        }
    }

    void OnGUI()
    {
        if (mostrar == true)
        {
            control.gameObject.SetActive(true);
            controlOcultar.gameObject.SetActive(false);
            anim.Play("Mano1");
            bebe.gameObject.GetComponent<Animator>().enabled = false;
        }
        if (mostrar == false)
        {
            control.gameObject.SetActive(false);
            controlOcultar.gameObject.SetActive(true);
            anim.Play("");
        }
    }
}