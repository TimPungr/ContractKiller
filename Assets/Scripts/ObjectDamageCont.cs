using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDamageCont : MonoBehaviour {


    public float HP = 100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided with ");
        if (collision.collider.tag == "bullet")
        {
            HP -= collision.collider.GetComponent<Bulletcript>().dmg;
            Destroy(collision.collider.gameObject);
        }

        if (HP <= 0)
        {
            Destroy(gameObject);
        }

    }
}
