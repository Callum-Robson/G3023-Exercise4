using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attribute allows right click->Create
[CreateAssetMenu(fileName = "New Item", menuName = "Item/New Item")]
public class Item : ScriptableObject    //Extending SO allows us to have an object which exists in the project, not in the scene
{
    public Sprite icon;
    public string description = "This is an item";
    public bool isConsumable = false;
  
    public void Use()
    {
        Debug.Log("used item: " + name + " - " + description);
    }

}
