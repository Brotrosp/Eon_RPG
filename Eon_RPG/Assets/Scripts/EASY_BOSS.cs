using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EASY_BOSS : MonoBehaviour
{
    GameManager gm;

    private void Awake()
    {
        gm = GameManager.Instance;
        gm.OnStateChange += HandleOnStateChange;
    }

    public void HandleOnStateChange()
    {
        Debug.Log("OnStateChange!");
    }

    public void StartGame()
    {
        //gm.SetGameState(GameState.EASY_BOSS);
        Debug.Log(gm.gameState);
    }
    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
