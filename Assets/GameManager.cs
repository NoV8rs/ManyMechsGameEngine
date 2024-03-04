using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameState { MainMenu, GamePlay, Opitions, Pause, GameWin, GameOver}
    public GameState gameState;
    private UIManager UIManager;
    private LoadScene loadScene;

   //public void Awake()
   //{
   //    Cursor.visible = true;
   //    UIManager.MainMenu();
   //}

    public void Update()
    {
        switch (gameState)
        {
            case GameState.MainMenu: UIManager.MainMenu(); break;
            case GameState.GamePlay: UIManager.GamePlay(); break;
            case GameState.Opitions: UIManager.GameOpitions(); break;
            case GameState.Pause: UIManager.GamePause(); break;
            case GameState.GameWin: UIManager.GameWin(); break;
            case GameState.GameOver: UIManager.GameOver(); break;
        }
    }
}
