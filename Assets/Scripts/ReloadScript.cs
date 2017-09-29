using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadScript : MonoBehaviour {

    private float reloadTime;
    public float relTimer;
    public bool reloading = false;

    // Use this for initialization
    void Start () {
        reloadTime = GetComponent<GunScript>().reloadTime;
        relTimer = reloadTime;

    }
	
	// Update is called once per frame
	void Update () {

        relTimer -= Time.deltaTime;

        if (GetComponent<GunScript>().currAmmoMag == 0 && !reloading)
        {
            GetComponent<GunScript>().enabled = false;
            reloading = true;
            relTimer = reloadTime;
        }

        if (relTimer <= 0 && reloading)
        {
            reloading = false;
            if (GetComponent<GunScript>().currAmmo <= GetComponent<GunScript>().magCap)
            {
                GetComponent<GunScript>().currAmmoMag = GetComponent<GunScript>().currAmmo;
                GetComponent<GunScript>().currAmmo = 0;
            }
            else
            {
                GetComponent<GunScript>().currAmmoMag = GetComponent<GunScript>().magCap;
                GetComponent<GunScript>().currAmmo -= GetComponent<GunScript>().magCap;
            }
            GetComponent<GunScript>().enabled = true;
        }

	}
}
