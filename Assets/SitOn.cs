using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitOn : MonoBehaviour
{
    public GameObject character;
    Animator anim;
    public bool isWalkingTowards = false;
    public bool sittinOn = false;
    public static SitOn instance;
   // public GameObject rightHand;
    private void Awake()
    {
        instance = this;
        
    }
    private void OnMouseDown()
    {
        Debug.Log("in mouse");
        if (!sittinOn)
        {
            Debug.Log("in if");
            anim.SetTrigger("IsWalking");
            isWalkingTowards = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        anim = character.GetComponent<Animator>();
       // character.GetComponent<Animation>().Play();
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(rightHand.transform.position);
        if (isWalkingTowards)
        {
           // Debug.Log("in walking towards");
            Vector3 targetDir;
            targetDir = new Vector3(transform.position.x - character.transform.position.x, 0f,
                transform.position.z - character.transform.position.z);
            Quaternion rot = Quaternion.LookRotation(targetDir);
            character.transform.rotation = Quaternion.Slerp(character.transform.rotation, rot, 0.05f);
            character.transform.Translate(Vector3.forward * 0.01f);
         

        }
       if(sittinOn)
        {
           // Debug.Log("is sitting" + sittinOn);
            if (Input.GetKeyDown(KeyCode.B))
            {
                anim.SetTrigger("RubArm");
            }
        }
        
    }
}
