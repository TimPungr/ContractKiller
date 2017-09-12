using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push : MonoBehaviour {

    private float timer = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("f"))
        {
            GetComponent<Collider>().enabled = true;
            timer = 0.25f;
        }
        timer -= Time.deltaTime;
       /* if(timer < 0)
        {
            GetComponent<Collider>().enabled = false;
        }*/
	}

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.collider.tag == "human")
       // {
            Debug.Log("collided with human");
        //}
    }
}
