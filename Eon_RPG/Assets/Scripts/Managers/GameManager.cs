using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int maxVita = 10;
    private int vita;

    public AudioManager audioManager;
    public ScriptVita scriptVita; 

    public GameObject fine;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        vita = maxVita;

        audioManager = GameObject.Find("MANAGERS").GetComponent<AudioManager>();
        scriptVita = GameObject.Find("SliderVita").GetComponent<ScriptVita>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ModificaEnergia(int quantita)
    {
        maxVita += quantita;
        scriptVita.SetEnergia(maxVita);
        //uiManager.ScriviEnergia(maxEnergia);
        //Debug.Log(maxEnergia);
        if (maxVita <= 0)
        {
            Debug.Log("Sei morto!");
            //Time.timeScale = 0;
            SceneScript.GameOver();
        }
    }
}
