using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Traveler : MonoBehaviour
{
    public string LastSpawnPointName
    {
        get;
        set;
    } = "";
    void Start()
    {
#if UNITY_EDITOR                    //Preprocessor directive
        DestroySelfIfNotOriginal();
#endif
        DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += OnSceneLoadAction;
    }

    private void DestroySelfIfNotOriginal()
    {
        if(SpawnPoint.Player != this)
        {
            Destroy(gameObject);
        }
    }

    void OnSceneLoadAction(Scene scene, LoadSceneMode loadMode )
    {
        if (LastSpawnPointName != "")
        {
            SpawnPoint[] spawnPoints = GameObject.FindObjectsOfType<SpawnPoint>();
            foreach (SpawnPoint spawn in spawnPoints)
            {
                //teleport to that spawn point
                transform.position = spawn.transform.position;
            }
        }
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoadAction;
        Debug.Log("This Geoff " + gameObject.name + ", has been killed");
    }
}
