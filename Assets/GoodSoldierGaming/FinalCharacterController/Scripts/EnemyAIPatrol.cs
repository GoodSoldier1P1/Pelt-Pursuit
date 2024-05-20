using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAIPatrol : MonoBehaviour
{
    GameObject player;

    public NavMeshAgent agent;
    public Animator animator;

    [SerializeField] LayerMask groundLayer, playerLayer;
    [SerializeField] float walkingSpeed = 1.5f;
    [SerializeField] float runningSpeed = 5f;
    [SerializeField] float runAwayDistance = 10f;

    // Patrol
    Vector3 destPoint;
    bool walkpointSet;
    [SerializeField] float range;

    private static int horizontalMove = Animator.StringToHash("horizontal");

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
        animator = GetComponent<Animator>();
        animator.SetFloat(horizontalMove, 0); // Set initial horizontal movement to 0
    }

    // Update is called once per frame
    void Update()
    {
        Patrol();
        UpdtateAnimatorSpeed();
    }

    private void Patrol()
    {
        if (!walkpointSet) SearchForDest();
        if (walkpointSet) agent.SetDestination(destPoint);
        if (Vector3.Distance(transform.position, destPoint) < 10) walkpointSet = false;
    }

    private void SearchForDest()
    {
        float z = Random.Range(-range,range);
        float x = Random.Range(-range,range);

        Vector3 randomDirection = new Vector3(x, 0, z).normalized;
        destPoint = transform.position + randomDirection * range;

        RaycastHit hit;
        if (Physics.Raycast(destPoint, Vector3.down, out hit, Mathf.Infinity, groundLayer))
        {
            destPoint = hit.point;
            walkpointSet = true;
        }
    }

    private void UpdtateAnimatorSpeed()
    {
        // Calculate the agent's speed
        float speed = agent.velocity.magnitude;

        // Set the animator's horizontal movement based on the agent's speed
        animator.SetFloat(horizontalMove, speed);

        // Check if player is nearby
        if (Vector3.Distance(transform.position, player.transform.position) < runAwayDistance)
        {
            // Player is nearby, make the deer run away
            agent.speed = runningSpeed;
        }
        else
        {
            // No player nearby, resume walking
            agent.speed = walkingSpeed;
        }
    }
}
