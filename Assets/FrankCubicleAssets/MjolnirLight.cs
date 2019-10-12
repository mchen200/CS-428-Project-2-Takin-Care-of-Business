using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MjolnirLight : MonoBehaviour
{

    public VRTK.Prefabs.Interactions.Interactors.InteractorFacade Interactor;
    public VRTK.Prefabs.Interactions.Interactables.InteractableFacade hammer;
    public Light light;
    public GameObject mjolnir;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Interactor.ActiveTouchedObject == mjolnir)
        {
            IReadOnlyList<GameObject> list = Interactor.GrabbedObjects;

            if (list[0])
            {

                    light.enabled = true;
                if (!hammer.IsGrabbed)
                {
                    light.enabled = false;
                }
            }
        }
        if (!hammer.IsGrabbed)
        {
            light.enabled = false;
        }
    }
}
