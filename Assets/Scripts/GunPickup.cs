using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "FPSController")
        {
            GetComponent<GunScript>().enabled = true;
            GetComponent<Transform>().SetParent(GameObject.Find("Contact_R").transform);
            GetComponent<Transform>().position = GameObject.Find("Contact_R").transform.position;
            GetComponent<Transform>().rotation = GameObject.Find("Contact_R").transform.rotation;
            this.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
