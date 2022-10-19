using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void MenuContinue()
    {
        SceneManager.LoadScene("NightTown");
    }

    public void MenuNewGame()
    {
        SceneManager.LoadScene("NightTown");
    }

    public void MenuExit()
    {
        Application.Quit();
    }

    public void Flee()
    {
        SceneManager.LoadScene("NightTown");
    }    
}
