using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject gamePlay;
    public GameObject gameOpitions;
    public GameObject gamePause;
    public GameObject gameOver;
    public GameObject gameWin;
    
    public void MainMenu()
    {
        Cursor.visible = true;
        mainMenu.SetActive(true);
        gamePlay.SetActive(false);
        gameOpitions.SetActive(false);
        gamePause.SetActive(false);
        gameOver.SetActive(false);
        gameWin.SetActive(false);
    }

    public void GamePlay()
    {
        mainMenu.SetActive(false);
        gamePlay.SetActive(true);
        gameOpitions.SetActive(false);
        gamePause.SetActive(false);
        gameOver.SetActive(false);
        gameWin.SetActive(false);
    }

    public void GameOpitions()
    {
        mainMenu.SetActive(false);
        gamePlay.SetActive(false);
        gameOpitions.SetActive(true);
        gamePause.SetActive(false);
        gameOver.SetActive(false);
        gameWin.SetActive(false);
    }

    public void GamePause()
    {
        mainMenu.SetActive(false);
        gamePlay.SetActive(false);
        gameOpitions.SetActive(false);
        gamePause.SetActive(true);
        gameOver.SetActive(false);
        gameWin.SetActive(false);
    }

    public void GameOver()
    {
        mainMenu.SetActive(false);
        gamePlay.SetActive(false);
        gameOpitions.SetActive(false);
        gamePause.SetActive(false);
        gameOver.SetActive(true);
        gameWin.SetActive(false);
    }

    public void GameWin()
    {
        mainMenu.SetActive(false);
        gamePlay.SetActive(false);
        gameOpitions.SetActive(false);
        gamePause.SetActive(false);
        gameOver.SetActive(false);
        gameWin.SetActive(true);
    }
}
