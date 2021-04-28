using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneScript
{
    public static void Restart()
    {
        SceneManager.LoadScene("Main");
    } 
    public static void QuitGame()
    {
        SceneManager.LoadScene("Start");
    }
    public static void GameOver()
    {
        SceneManager.LoadScene("GAME_OVER");
    }

    public static void YouWin()
    {
        SceneManager.LoadScene("Win");
    }

    public static void Level1()
    {
        SceneManager.LoadScene("EASY_BOSS");
    }

    public static void Level2()
    {
        SceneManager.LoadScene("HARD_BOSS");
    }
}
