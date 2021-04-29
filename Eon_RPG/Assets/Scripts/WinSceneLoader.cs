using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinSceneLoader : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneScript.YouWin();
        }
        else if (other.gameObject.tag == "NextScene")
        {
            SceneScript.Restart();
        }
    }
}
