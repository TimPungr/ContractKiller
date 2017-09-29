using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPController : MonoBehaviour {

    public float DamageSpeed = -1f;
    public float fallMultiplier = 1f;
    public float verticalSpeed;
    public Rigidbody rb;
    public float hp = 100;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
        verticalSpeed = rb.velocity.y;
		if(hp <= 0)
        {
            Destroy(gameObject);
        }
	}

    


}
