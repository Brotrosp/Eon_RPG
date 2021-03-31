using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerLoadLevel1 : MonoBehaviour
{
    public GameObject enterText;
    public string levelToLoad;
    void Start()
    {
        enterText.SetActive(false);
    }

    private void OnTriggerStay(Collider plyr)
    {
        if(plyr.gameObject.tag == "Player")
        {
            enterText.gameObject
        }
    }
}