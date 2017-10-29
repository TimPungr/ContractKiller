using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class civilian : MonoBehaviour {

    public NavMeshAgent agent;
    public float distance;
    public float wanderTime = 0f;
    private float wanderTimer;
    private bool scared;
    public LayerMask mask;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        wanderTimer = wanderTime;
	}
	
	// Update is called once per frame
	void Update () {
        wanderTime -= Time.deltaTime;
        if(wanderTime == 0 && !scared)
        {
            wanderTime = wanderTimer;
            agent.SetDestination(Wander(transform.position,distance,mask));
        }
	}

    public Vector3 Wander(Vector3 origin, float distance, int layermask)
    {
        Vector3 randomDirection = Random.insideUnitSphere * distance;

        randomDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randomDirection, out navHit, distance, layermask);

        return navHit.position;
    }
}
