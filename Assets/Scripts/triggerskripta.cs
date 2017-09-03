using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerskripta : MonoBehaviour {
    public GameObject kista;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        kista.transform.position = new Vector3(kista.transform.position.x, kista.transform.position.y + 10, kista.transform.position.z);
    }

}
