using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class DebugLog : MonoBehaviour
{
    public VRTK.Prefabs.Interactions.Interactables.InteractableFacade facade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(facade.IsGrabbed);
    }
}
