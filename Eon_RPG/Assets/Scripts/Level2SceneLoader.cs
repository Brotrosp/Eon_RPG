using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneScript.Level2();
        }
    }
}
