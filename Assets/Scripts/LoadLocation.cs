using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LoadLocation : MonoBehaviour
{
    public Vector3 loc;
    [SerializeField]
    private Buttons m_buttons;

    public static float[] coords = new float[3];
    // Start is called before the first frame update
    void Start()
    {
        using (StreamReader sr = new StreamReader("SavedLocation.txt"))
        {
            string line;
            if ((line = sr.ReadLine()) != null)
            {
                m_buttons.loadedSceneName = line;
            }
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
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
