using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerResponse : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Player")
        {
            Debug.Log("you got coin");
            Destroy(this.gameObject);
        }
    }
}
