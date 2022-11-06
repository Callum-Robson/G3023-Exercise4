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
            float x = player.transform.position.x;
            float y = player.transform.position.y;
            float z = player.transform.position.z;
            sw.WriteLine(x + "," + y + "," + z);
        }

    }
}
