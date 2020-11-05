using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
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
       // Debug.Log("in triger");
        if(other.tag == "Player")
        {
            other.transform.rotation = gameObject.transform.rotation;
            other.GetComponent<Animator>().SetTrigger("IsSitting");
            other.GetComponent<BoxCollider>().enabled = false;
            SitOn.instance.isWalkingTowards = false;
            SitOn.instance.sittinOn = true;
        }
    }
}
