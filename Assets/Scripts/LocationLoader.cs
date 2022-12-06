using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LocationLoader : MonoBehaviour
{
    [SerializeField]
    private Buttons m_buttons;

    public static float[] coords = new float[3];
    public static bool dataLoaded;
    public static string loadedSceneName;

    // Start is called before the first frame update
    public string Load()
    {
        if (File.Exists("SavedLocation.txt"))
        {
            using (StreamReader sr = new StreamReader("SavedLocation.txt"))
            {
                string line;
                if ((line = sr.ReadLine()) != null)
                {
                    loadedSceneName = line;
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
            dataLoaded = true;
            return loadedSceneName;
        }
        else
        {
            return "0";
        }
    }

}
