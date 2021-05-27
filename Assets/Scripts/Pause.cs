using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject uiPause;
    GameObject pacman, Blinky, Pinky, Clyde, Inky;

    private void Start()
    {
        pacman = GameObject.Find("PacMan");
        Blinky = GameObject.Find("Blinky");
        Pinky = GameObject.Find("Pinky");
        Clyde = GameObject.Find("Clyde");
        Inky = GameObject.Find("Inky");
    }

    public void Pausse()
    {
        uiPause.SetActive(true);
        pacman.SetActive(false);
        Blinky.SetActive(false);
        Pinky.SetActive(false);
        Clyde.SetActive(false);
        Inky.SetActive(false);
    }

    public void UnPause()
    {
        uiPause.SetActive(false);
        pacman.SetActive(true);
        Blinky.SetActive(true);
        Pinky.SetActive(true);
        Clyde.SetActive(true);
        Inky.SetActive(true);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
