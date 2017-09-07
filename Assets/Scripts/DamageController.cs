using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour {


    public int hp = 100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided with " + collision.collider.name);
        if (collision.collider.tag == "bullet")
        {
            hp -=collision.collider.GetComponentInParent<GunScript>().dmg;
            Destroy(collision.collider.gameObject);
        }

        if(hp == 0)
        {
            Destroy(gameObject);
        }
        
    }


}
