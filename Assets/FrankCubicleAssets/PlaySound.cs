using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class PlaySound : MonoBehaviour
{
    public VRTK.Prefabs.Interactions.Interactors.InteractorFacade Interactor;
    public GameObject touching;
    public AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Interactor.ActiveTouchedObject == touching)
        {
                if (!sound.isPlaying)
                {
                    sound.PlayOneShot(sound.clip);
                }

        }
    }
}