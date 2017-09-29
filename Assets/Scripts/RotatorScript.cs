using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorScript : MonoBehaviour {

    private bool closed = true;
   


    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("e"))
        {


            if (closed)
            {
                transform.Rotate(0, 0, 90);
                closed = false;
            }
            else
            {
                transform.Rotate(0, 0, -90);
                closed = true;
            }

        }
    }

    


}
