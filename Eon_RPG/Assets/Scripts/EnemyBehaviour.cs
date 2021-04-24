using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour
{
    public List<Transform> step;
    NavMeshAgent agent;
    int counter = 0;
    bool isFollow = false;
    Transform player;
    public int shield;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = step[counter].position;
        player = GameObject.Find("Enemy").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.remainingDistance < .1 && isFollow == false)
        {
            counter++;
            if(counter >= step.Count)
            {
                counter = 0;
            }
            agent.destination = step[counter].position;
        }

        if(isFollow == true)
        {
            agent.destination = player.position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Magie")
        {
            Destroy(collision.gameObject);
            shield--;

            if (shield <= 0)
            {
                Destroy(this.gameObject, 0.1f);
            }
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            isFollow = true;
            agent.destination = other.transform.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            isFollow = false;
            agent.destination = step[counter].position;
        }
    }
}
