using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LoadLocation : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        using (StreamReader sr = new StreamReader("SavedLocation"))
        {
            string line;
            if ((line = sr.ReadLine()) != null)
            {
                Debug.Log("Loaded location = " + line);

                // use csv in stream writer to separate coordinate values so they're easily readable
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
