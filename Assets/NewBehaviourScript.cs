using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject sph;
    public Transform plane;
    public float speed = 0.03f;
    public float damp = 0.09f;
    public float yPos = 1;
    // Start is called before the first frame update
    void Start()
    {
        yPos = sph.transform.position.y;
        //if(sph.)
        sph.transform.Translate(new Vector3(0, 1-speed, 0),plane);
    }

    // Update is called once per frame
    void Update()
    {
        if(yPos >= -1f )
        {
            speed *= -1;
        }

        yPos -= (speed+damp);
        sph.transform.Translate(new Vector3(0, yPos, 0));



    }

}
