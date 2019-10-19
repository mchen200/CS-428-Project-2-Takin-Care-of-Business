using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopIn : MonoBehaviour
{
    public GameObject AllObjects;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("player found");
            AllObjects.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("player left");
            AllObjects.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
