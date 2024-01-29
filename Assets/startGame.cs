using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    public void gameStart() 
    {
        SceneManager.LoadScene("ProgrammerScene");
    }
    public void gameExit() 
    {
        Application.Quit();
    }
    public void Main()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
