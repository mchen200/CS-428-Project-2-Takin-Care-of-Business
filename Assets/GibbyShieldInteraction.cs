using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibbyShieldInteraction : MonoBehaviour
{
  public GameObject changeObject;
  public Rigidbody rigidBody;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (rigidBody.isKinematic == true)
    {
      changeObject.SetActive(true);
    }
    else
    {
      changeObject.SetActive(false);
    }
  }
}
