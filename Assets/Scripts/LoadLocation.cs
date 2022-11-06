using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LoadLocation : MonoBehaviour
{
    public GameObject player;
    public Vector3 loc;

    private float[] coords = new float[3];
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        using (StreamReader sr = new StreamReader("SavedLocation.txt"))
        {
            string line;
            string[] csv;
            if ((line = sr.ReadLine()) != null)
            {
                Debug.Log("Loaded location = " + line);
                csv = line.Split(',');
                
                for (int i = 0; i < 3; i++)
                {
                    coords[i] = float.Parse(csv[i]);
                }
                // use csv in stream writer to separate coordinate values so they're easily readable
            }
            player.transform.position = new Vector3(coords[0], coords[1], coords[2]);

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
