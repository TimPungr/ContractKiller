using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class civilian : MonoBehaviour {

    public NavMeshAgent agent;
    public float distance;
    public float wanderTime = 0f;
    private float wanderTimer;
    private bool scared = false;
    public LayerMask mask;
    
	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        wanderTimer = wanderTime;
	}
	
	// Update is called once per frame
	void Update () {
        wanderTimer -= Time.deltaTime;
        if(wanderTimer <= 0 && !scared)
        {
            wanderTimer = wanderTime;
            agent.SetDestination(Wander(transform.position, distance, mask));
            //Debug.Log(agent.destination);
        }
	}

    public Vector3 Wander(Vector3 origin, float distance, int layermask)
    {
        Vector3 randomDirection = Random.insideUnitSphere * distance;

        randomDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randomDirection, out navHit, distance, layermask);

        //Debug.Log(navHit.position);

        return navHit.position;
    }
}
