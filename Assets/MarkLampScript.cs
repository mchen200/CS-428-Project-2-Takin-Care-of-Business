using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkLampScript : MonoBehaviour
{
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
      if (isLetGo == true)
      {
        sound.PlayOneShot(quip);
        isLetGo = false;
      }
    }
    else
    {
      sound.Stop();
      isLetGo = true;
    }
  }
}
