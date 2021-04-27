using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask IsGround, IsPlayer;

    public Vector3 walkpoint;
    bool walkPointSet;
    public float walkPointRange;

    public float Range;
    public bool playerInRange;

    public Animator anim;

    int vitaNemico = 1;

    private void Awake()
    {
        player = GameObject.Find("Wizard Male 03").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        playerInRange = Physics.CheckSphere(transform.position, Range, IsPlayer);

        if (!playerInRange)
        {
            Patroling();
            anim.SetBool("isAttacking", false);
        } 
        else if (playerInRange)
        {
            FollowPlayer();
            anim.SetBool("isAttacking", true);
        }
       
    }

    void Patroling()
    {
        if (!walkPointSet) SearchWalkPoint();

        if (walkPointSet)
        {
            agent.SetDestination(walkpoint);
        }

        Vector3 distanceToWalkPoint = transform.position - walkpoint;

        if(distanceToWalkPoint.magnitude < 1f)
        {
            walkPointSet = false;
        }
    }

    void SearchWalkPoint()
    {
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkpoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if(Physics.Raycast(walkpoint, -transform.up, 2f, IsGround))
        {
            walkPointSet = true;
        }
    }

    void FollowPlayer()
    {
        agent.SetDestination(player.position);

    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject obj = collision.gameObject;
        if(obj.name == "Sphere(Clone)")
        {
            Debug.Log("colpito");
            vitaNemico--;
            if(vitaNemico == 0)
            {
                Destroy(this.gameObject, 0.1f);
            }
            Destroy(obj);
        }
    }
}
