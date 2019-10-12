using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PFInteraction : MonoBehaviour
{
    public GameObject changeObject;
    public Material sad;
    public Material happy;
    public Rigidbody rigidBody;
    public AudioSource sound;
  public AudioClip quip;
  bool isLetGo;

    // Start is called before the first frame update
    void Start()
    {
    isLetGo = true;
    }

    // Update is called once per frame
    void Update()
    {
      if (rigidBody.isKinematic == true)
      {
      changeObject.GetComponent<MeshRenderer>().material = happy;
        if(isLetGo == true)
        {
          sound.PlayOneShot(quip);
        isLetGo = false;
        }
      }
      else
      {
      changeObject.GetComponent<MeshRenderer>().material = sad;
      sound.Stop();
      isLetGo = true;
    }
    }
}
