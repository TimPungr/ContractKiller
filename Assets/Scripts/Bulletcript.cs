using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletcript : MonoBehaviour {
    public int dmg;
    public float lifetime = 5f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, lifetime);
	}

   /*public void OnCollisionEnter(Collision collision)
    {
        //Destroy(gameObject);
    }*/
}
