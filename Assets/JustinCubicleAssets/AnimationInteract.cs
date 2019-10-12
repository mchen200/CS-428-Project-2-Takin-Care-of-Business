using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class AnimationInteract : MonoBehaviour
{
    public VRTK.Prefabs.Interactions.Interactors.InteractorFacade LeftInteractor;
    public VRTK.Prefabs.Interactions.Interactors.InteractorFacade RightInteractor;
    public GameObject touching;
    public GameObject interaction;
    public Animation Animation;

    // Start is called before the first frame update
    void Start()
    {
        Animation = GetComponent<Animation>();

    }

    // Update is called once per frame
    void Update()
    {
        Animation.Play();
        if (LeftInteractor.ActiveTouchedObject == touching || RightInteractor.ActiveTouchedObject == touching)
        {
            IReadOnlyList<GameObject> list = LeftInteractor.GrabbedObjects;

            if (list[0])
            {
                Animation.Stop();
            }

        }
    }
}

