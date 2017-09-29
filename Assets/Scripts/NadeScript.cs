using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NadeScript : MonoBehaviour
{

    public float damage = 200f;
    public float thrust = 2500f;
    public GameObject pin;
    public GameObject body;
    public GameObject expl;
    public float timeToDetonate = 6f;
    public float ExplosionLife = 1f;
    private float expTimer;
    private float detonationTimer;
    private bool thrown = false;
    private bool detonated = false;

    // Use this for initialization
    void Start()
    {
        expl = transform.Find("Explosion").gameObject;
        body = transform.Find("body").gameObject;
        pin = transform.Find("pin").gameObject;
        expTimer = ExplosionLife;
        detonationTimer = timeToDetonate;
    }

    // Update is called once per frame
    void Update()
    {
        
        detonationTimer -= Time.deltaTime;
        if (Input.GetButtonDown("Fire1"))
        {
            transform.parent = null;
            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<Rigidbody>().AddForce(transform.forward * thrust);
            Destroy(pin);
            thrown = true;
            expTimer = ExplosionLife;
            detonationTimer = timeToDetonate;
        }

        if (detonationTimer <= 0  && thrown == true)
        {
            Destroy(body);
            expl.GetComponent<SphereCollider>().enabled = true;
            detonated = true;
            Destroy(gameObject, expTimer);

        }

    }

    
}
