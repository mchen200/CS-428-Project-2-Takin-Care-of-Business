using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class interact : MonoBehaviour
{
    public VRTK.Prefabs.Interactions.Interactors.InteractorFacade Interactor;
    public GameObject touching;
    public GameObject interaction;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Interactor.ActiveTouchedObject == touching)
        {
            IReadOnlyList<GameObject> list = Interactor.GrabbedObjects;

            if (list[0])
            {
                if (interaction.activeSelf == true)
                {
                    interaction.SetActive(false);
                    audio.Pause();
                }

                else
                {
                    interaction.SetActive(true);
                    audio.Play();
                }
            }

        }
    }
}

