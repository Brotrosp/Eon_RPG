using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    GameManager gm;

    void Awake()
    {
        gm = GameManager.Instance;
        gm.OnStateChange += HandleOnStateChange;

        Debug.Log("Current game state when Awakes: " + gm.gameState);
    }

    void Start()
    {
        Debug.Log("Current game state when Starts: " + gm.gameState);
    }

    public void HandleOnStateChange()
    {
        //gm.SetGameState(GameState.INTRO);
        Debug.Log("Handling state change to: " + gm.gameState);
        Invoke("LoadLevel", 3f);
    }

    public void StartGame()
    {
        //start game scene
        //gm.SetGameState(GameState.GAME);
        Debug.Log(gm.gameState);
    }


    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }


}

