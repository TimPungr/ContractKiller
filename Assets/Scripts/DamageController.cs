using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour {

    public GameObject person;
    public float multiplier;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Collided with " + collision.collider.name);
        if (collision.collider.tag == "bullet")
        {
            person.GetComponent<HPController>().hp -= collision.collider.GetComponentInParent<GunScript>().dmg * multiplier;
            Destroy(collision.collider.gameObject);
        }

        if (person.GetComponent<HPController>().hp == 0)
        {
            Destroy(person);
        }

    }
}
