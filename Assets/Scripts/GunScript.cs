using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour {

    public int dmg;
    public Rigidbody bullet;
    public Transform exit;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            Rigidbody clone;
        clone = Instantiate(bullet, exit.position, exit.rotation) as Rigidbody;
            clone.velocity = transform.TransformDirection(Vector3.forward * 100);
            clone.transform.parent = gameObject.transform;
        }
    }
}
