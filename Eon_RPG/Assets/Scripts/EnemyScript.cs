using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{

    public List<Transform> passaggi;
    NavMeshAgent agente;
    int contapassaggi = 0;
    bool miStaiInseguendo = false;
    bool miStoMuovendo = false;
    int vitaNemico = 5;

    Transform player;

    public Animator animator;

    int vitaEnemy = 1;


    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        agente.destination = passaggi[contapassaggi].position;
        animator.SetBool("walk", true);
        player = GameObject.Find("Wizard Male 03").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (agente.remainingDistance < 0.1f)
        {
            Debug.Log("SONO ARRIVATO A  DESTINAZIONE");
            contapassaggi++;
            if (contapassaggi >= passaggi.Count)
            {
                contapassaggi = 0;
            }
            Debug.Log("Prossimo passaggio: " + contapassaggi);
            agente.destination = passaggi[contapassaggi].position;
        }
        if (miStaiInseguendo == true)
        {
            agente.destination = player.position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Proiettile")
        {
            Destroy(collision.gameObject);
            vitaEnemy--;
            if (vitaEnemy <= 0)
            {
                Destroy(this.gameObject, 0.1f);
                //gameManager.HaiVinto();
            }

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Wizard Male 03")
        {
            Debug.Log("ADESSO TI INSEGUO!!!!");
            miStaiInseguendo = true;
            agente.destination = other.transform.position;
            animator.SetBool("isAttacking", true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Wizard Male 03")
        {
            Debug.Log("ADESSO NON TI INSEGUO PIU'!!!!");
            miStaiInseguendo = false;
            agente.destination = passaggi[contapassaggi].position;
        }
    }
}
