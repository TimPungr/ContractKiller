using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableRagDoll : MonoBehaviour
{

    Collider[] rigColliders;
    Rigidbody[] rigRigidbodies;

    // Use this for initialization
    void Start()
    {


        {
            rigColliders = GetComponentsInChildren<Collider>();
            rigRigidbodies = GetComponentsInChildren<Rigidbody>();
        }


        //wait 2-3 seconds.
        foreach (Collider col in rigColliders)
        {
           /* if (col.transform.tag != "col")
            {
                col.enabled = false;
            }*/
        }

        foreach (Rigidbody rb in rigRigidbodies)
        {
            rb.isKinematic = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
