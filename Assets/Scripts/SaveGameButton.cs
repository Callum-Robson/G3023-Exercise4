using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveGameButton : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clicked()
    {
        using (StreamWriter sw = new StreamWriter("SavedLocation.txt"))
        {
            sw.WriteLine(player.transform.position);
        }

    }
}
