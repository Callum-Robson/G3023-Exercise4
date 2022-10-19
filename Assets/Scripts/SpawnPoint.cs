using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    // Spawns one Player if there is none

    [SerializeField]
    GameObject playerPrefab;

    public static Traveler Player
    {
        get;            // Will return player, no need to do it manually
        private set;
    }

    void Awake()
    {
        if (Player == null)
        {
            GameObject newPlayer = Instantiate(playerPrefab, transform.position, Quaternion.identity); // The Original Player
            Player = newPlayer.GetComponent<Traveler>();
        }
    }
    
}
