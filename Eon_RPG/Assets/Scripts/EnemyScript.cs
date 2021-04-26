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
    int vitaNemico = 5;

    Transform player;


    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        agente.destination = passaggi[contapassaggi].position;
        player = GameObject.Find("Player").transform;
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
        /*if (miStaiInseguendo == true)
        {
            agente.destination = player.position;
        }*/
    }
}
