using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowsScript : MonoBehaviour {

    private bool closed = true;
    private Transform window;

	// Use this for initialization
	void Start () {
        window = transform.Find("window").gameObject.transform;
    }

	// Update is called once per frame
	void Update () {
        
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.name == "FPSController")
        {
           
            if (Input.GetKeyDown("e"))
            {
                
                if (closed)
                {
                    window.transform.Translate(Vector3.up * Time.deltaTime * 325, Space.World);
                    closed = false;
                }
                else
                {
                    window.transform.Translate(Vector3.down * Time.deltaTime * 325, Space.World);
                    closed = true;
                }

            }
        }
    }
}
