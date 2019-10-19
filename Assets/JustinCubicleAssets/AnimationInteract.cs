using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class AnimationInteract : MonoBehaviour
{
    public VRTK.Prefabs.Interactions.Interactors.InteractorFacade interactor;
    public GameObject touching;
    public Animation Animation;
    public AudioSource ringtone;
    public AudioSource phonecall;

    // Start is called before the first frame update
    void Start()
    {
        Animation = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        Animation.Play();
        if(interactor.GrabbedObjects.Count != 0)
        {
            
            IReadOnlyList<GameObject> items = interactor.GrabbedObjects;
            foreach (var x in items)
                Debug.Log(x.ToString());

            if (items[0] == touching)
            {
                Animation.Stop();
                ringtone.Stop();
                if(!phonecall.isPlaying)
                    phonecall.Play();
            }
        }
    
    }
}

