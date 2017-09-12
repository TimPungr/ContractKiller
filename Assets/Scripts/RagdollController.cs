using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollController : MonoBehaviour
{

    Collider[] rigColliders;
    Rigidbody[] rigRigidbodies;
    Transform[] transforms;
    Vector3[] rotations;
    Vector3[] positions;
    private float disTimer = 0f;

    // Use this for initialization
    void Start()
    {


        {
            rigColliders = GetComponentsInChildren<Collider>();
            rigRigidbodies = GetComponentsInChildren<Rigidbody>();
            
        }


        
        Disable();
    }

    public void Disable()
    {
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

    public void Enable(float time)
    {

        disTimer = time;
        foreach (Collider col in rigColliders)
        {
            /* if (col.transform.tag != "col")
             {
                 col.enabled = false;
             }*/
        }

        foreach (Rigidbody rb in rigRigidbodies)
        {
            rb.isKinematic = false;
        }
    }


    // Update is called once per frame
    void Update()
    {
        disTimer -= Time.deltaTime;
        if(disTimer <= 0)
        {
            Disable();
        }
    }
}
