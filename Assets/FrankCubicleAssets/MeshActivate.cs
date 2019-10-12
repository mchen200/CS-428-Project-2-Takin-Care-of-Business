using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshActivate : MonoBehaviour
{
    public MeshRenderer screen;
    public Material changedMesh;
    private Material baseMesh;

    // Start is called before the first frame update
    void Start()
    {
        baseMesh = screen.material;
        screen.material = changedMesh;
        screen.material.color = Color.black;
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }


}