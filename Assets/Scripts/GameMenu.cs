using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{   

    public static bool isOnePlayerGame = true;

    //przycisk do wlaczenia trybu jednego gracza
    public void StartOnePlayer()
    {
        GameBoard.playerOneLevel = 1;
        GameBoard.playerOneScore = 0;
        GameBoard.livesPlayerOne = 3;
        //zabepieczenie przed wlaczeniem drugiego gracza
        GameBoard.livesPlayerTwo = 0;
        isOnePlayerGame = true;
    SceneManager.LoadScene(1);
    }

    //przycisk do wlaczenia trybu dla dwóch graczy
    public void StartTwoPlayers()
    {
        GameBoard.playerOneLevel = 1;
        GameBoard.playerOneScore = 0;
        GameBoard.livesPlayerOne = 3;

        GameBoard.playerTwoLevel = 1;
        GameBoard.playerTwoScore = 0;
        GameBoard.livesPlayerTwo = 3;
        isOnePlayerGame = false;
        //wczytanie sceny 1 (docelowej gry)
    SceneManager.LoadScene(1);
    }
}
