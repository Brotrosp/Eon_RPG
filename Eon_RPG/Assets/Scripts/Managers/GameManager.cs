using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]

    private int energy = 0;
    private int healt = 0;

    public enum GameState { EASY_BOSS }

    public delegate void OnStateChangeHandler();

    protected GameManager() { }
    private static GameManager instance = null;
    public event OnStateChangeHandler OnStateChange;
    public GameState gameState { get; private set; }

    public static GameManager Instance
    {
        get
        {
            if(GameManager.instance == null)
            {
                DontDestroyOnLoad(GameManager.instance);
                GameManager.instance = new GameManager();
            }
            return GameManager.instance;
        }
    }



    //public AudioManager audioManager;
    //public UIManager uiManager;

    void Start()
    {
        if(PlayerPrefs.HasKey("healt"))
        {
            healt = PlayerPrefs.GetInt("healt");
        }
        //audioManager = GameObject.Find("Managers").GetComponent<AudioManager>();
        //uiManager = GameObject.Find("Managers").GetComponent<UIManager>();
    }

    public void SetGameState(GameState state)
    {
        this.gameState = state;
        OnStateChange();
    }

    public void WriteOnScreen(int healt)
    {

    }

    public void OnApplicationQuit()
    {
        GameManager.instance = null;
    }
    public void YouWin()
    {
        Debug.Log("Winner!!!");
        SwitchSceneScript.OpenScene("Start");
    }
}




