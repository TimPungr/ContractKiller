using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{

    public int maxAmmo = 100;
    public int magCap = 10;
    public int currAmmo;
    public int currAmmoMag;
    public float reloadTime = 6f;
    private float relTimer;
    private bool needReload = false;
    public Rigidbody bullet;
    public Transform exit;
    public float speed = 100f;
    public float deviation = 1f;
    public int projectiles = 1;
    public bool automatic = false;
    public float shotDelay = 0.3f;
    public float shotTimer;

    // Use this for initialization
    void Start()
    {
        exit = transform.Find("Exit").transform;
        shotTimer = 0;
        currAmmo = maxAmmo;
        relTimer = reloadTime;
        currAmmoMag = magCap;

    }

    // Update is called once per frame
    void Update()
    {

        //relTimer -= Time.deltaTime;

        /*if (relTimer <= 0 && needReload)
        {
            currAmmo = magCap;
            needReload = false;
        }*/

        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody clone;
            for (int i = 0; i < projectiles; i++)
            {
                float randomNumberX = Random.Range(-deviation * 10, deviation * 10);
                float randomNumberY = Random.Range(-deviation, deviation);
                float randomNumberZ = Random.Range(-deviation, deviation);
                clone = Instantiate(bullet, exit.position, exit.rotation) as Rigidbody;
                clone.transform.Rotate(randomNumberX, randomNumberY, randomNumberZ);
                clone.velocity = transform.TransformDirection(Vector3.forward * speed);
                
                //clone.AddForce(clone.transform.forward * speed);
                //clone.transform.parent = gameObject.transform;
               // clone.velocity = transform.TransformDirection(clone.transform.forward * speed);
            }
            currAmmoMag--;
        }

        if (Input.GetButton("Fire1"))
        {
            if (automatic)
            {
                shotTimer -= Time.deltaTime;
               // if (currAmmo > 0)
               // {
                    if (shotTimer <= 0)
                    {
                        Rigidbody clone;
                        for (int i = 0; i < projectiles; i++)
                        {
                            float randomNumberX = Random.Range(-deviation, deviation);
                            float randomNumberY = Random.Range(-deviation, deviation);
                            float randomNumberZ = Random.Range(-deviation, deviation);
                            clone = Instantiate(bullet, exit.position, exit.rotation) as Rigidbody;
                            clone.transform.Rotate(randomNumberX, randomNumberY, randomNumberZ);
                            clone.velocity = transform.TransformDirection(Vector3.forward * speed);
                            //clone.AddForce(clone.transform.forward * speed);
                            //clone.velocity = transform.TransformDirection(clone.transform.forward * speed);
                            currAmmoMag--;
                        }

                        shotTimer = shotDelay;

                    }
               // } else
               // {
               //     needReload = true;
               //     relTimer = reloadTime;
               // }
            }
        }
    }
}
