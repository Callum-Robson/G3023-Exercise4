using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This object type will transport any traveler to a scene specified by the ovject's tag and location within that scene.

public class Portal : MonoBehaviour
{
    [SerializeField]
    private string destinationSpawn = "";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Portal entered by " + collision.gameObject.name);
        //Find out if it is a traveler
        Traveler traveler = collision.GetComponent<Traveler>();
        if(traveler != null)
        {
            traveler.LastSpawnPointName = gameObject.name;
            SceneManager.LoadScene(gameObject.tag, LoadSceneMode.Single);
        }
    }
}
