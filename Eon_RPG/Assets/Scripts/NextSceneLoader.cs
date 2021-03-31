using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneLoader : MonoBehaviour
{
    public int nextScene;
    // Start is called before the first frame update
    void Start()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;

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
                SceneManager.LoadScene(nextScene);

                //set indice
                if (nextScene > PlayerPrefs.GetInt("levelAt"))
                {
                    PlayerPrefs.SetInt("levelAt", nextScene);
                }
            }

           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
