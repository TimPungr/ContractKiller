using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setChildren : MonoBehaviour {

    Transform[] kids;

    // Use this for initialization
    void Start () {
        kids = GetComponentsInChildren<Transform>();

        foreach (Transform tr in kids)
        {
            tr.tag = tr.root.tag;
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
