using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void returnMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
