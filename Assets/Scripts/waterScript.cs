using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class waterScript : MonoBehaviour {

    float jumpInit;
    GameObject contact;
    public float jumpMulti = 2;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Player entered water");
            contact = other.gameObject;
            other.gameObject.GetComponent<Rigidbody>().useGravity = false;
            jumpInit = contact.GetComponent<FirstPersonController>().GetJumpSpeed();
            contact.GetComponent<FirstPersonController>().SetJumpSpeed(jumpInit * jumpMulti);
            contact.GetComponent<FirstPersonController>().inWater = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player exited water");
            contact = other.gameObject;
            other.gameObject.GetComponent<Rigidbody>().useGravity = true;
            //jumpInit = contact.GetComponent<FirstPersonController>().GetJumpSpeed();
            contact.GetComponent<FirstPersonController>().SetJumpSpeed(jumpInit);
            contact.GetComponent<FirstPersonController>().inWater = false;
        }
    }

}
