using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public string loadedSceneName;
    private LocationLoader locationLoader;

    private void Start()
    {
        locationLoader = FindObjectOfType<LocationLoader>();
    }

    public void MenuContinue()
    {
        string sceneName = locationLoader.Load();
        if (locationLoader.Load() != "0")
        SceneManager.LoadScene(locationLoader.Load());
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
