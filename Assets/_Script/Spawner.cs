using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {

    }
    void Update()
    {
        // Ctrl was pressed, launch a projectile
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(prefab, new Vector3(0, 10, 0), Quaternion.identity);
        }
    }
}
