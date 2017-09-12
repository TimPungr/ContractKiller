using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push : MonoBehaviour {

    private float timer = 0.1f;
    public float PushTimer = 5f;
    public float thrust = 10f;

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
        if(timer < 0)
        {
            GetComponent<Collider>().enabled = false;
        }
	}

    private void OnTriggerEnter(Collider other)
    {

      
        if (other.gameObject.tag == "human")
        {
            other.gameObject.transform.GetComponentInParent<RagdollController>().Enable(5f);
            other.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * thrust);
        }
    }
}
