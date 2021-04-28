using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossController : MonoBehaviour
{
    public GameObject moneta;
    public Animator anim;
    public float lookRadius = 10f;
    public float attackRadious = 2.5f;
    Transform target;
    NavMeshAgent agent;
    GameManager gameManager;

    int vitaBoss = 5;

    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        gameManager = GameObject.Find("MANAGERS").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
        }
        if (distance <= attackRadious)
        {
            anim.SetBool("isAttacking",true);
        }
        else
        {
            anim.SetBool("isAttacking",false);
        }

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, attackRadious);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject obj = collision.gameObject;
        if (obj.name == "Sphere(Clone)")
        {
            Debug.Log("colpito");
            vitaBoss--;
            if (vitaBoss == 0)
            {
                Destroy(this.gameObject, 0.1f);
                moneta.SetActive(true);

            }
            Destroy(obj);
        }

        if (collision.gameObject.name == "Wizard Male 03")
        {
            Debug.Log("Player colpito");
            gameManager.ModificaEnergia(-5);
        }
    }
}
