using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotX = 1f;
    public float rotY = 1f;
    public float rotZ = 1f;
    
    void FixedUpdate()
    {
        GetComponent<Transform>().Rotate(rotX, rotY, rotZ);
    }
}
