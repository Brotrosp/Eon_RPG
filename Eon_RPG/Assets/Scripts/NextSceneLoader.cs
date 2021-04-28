using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneLoader : MonoBehaviour
{
    public int nextScene;
    public int numeroscena;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(numeroscena);
        nextScene = numeroscena;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //TODO  inidice da decidere in base alle scene progetto
            if(SceneManager.GetActiveScene().buildIndex == 4)
            {
                Debug.Log("You win all bosses!");
            }
            else
            {
                //set indice
                if (nextScene > PlayerPrefs.GetInt("levelAt"))
                {
                    PlayerPrefs.SetInt("levelAt", nextScene);
                }
            }
        }
    }
}
