using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneScript : MonoBehaviour
{
    GameManager gm;

    private void Awake()
    {
        gm = GameManager.Instance;
        //gm.onStateChange += HandleOnStateChange;

        Debug.Log("Awake: " + gm.gameState);
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start: " + gm.gameState);
    }

    public void HandleOnStateChange()
    {
        //gm.SetGameState(GameState.EASY_BOSS);
        Debug.Log("Handling: " + gm.gameState);

        //3seconds to load
        Invoke("LoadLevel", 3f);
    }

    public static void OpenScene(string nameScene, int numberScene)
    {
        SceneManager.LoadScene(nameScene, (LoadSceneMode)numberScene);
    }
    
}
