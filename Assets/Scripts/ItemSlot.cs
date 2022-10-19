using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public Item item = null;
    [SerializeField]
    private int count = 0;
    public int Count
    {
        get
        {
            return count;
        }
        set
        {
            count = value;
            UpdateGraphic();
        }
    }

    [SerializeField]
    Image itemIcon;

    void Start()
    {
        UpdateGraphic();
    }

    void UpdateGraphic()
    {
        if(count < 1)
        {
            item = null;
            itemIcon.gameObject.SetActive(false);
        }
        else
        {
            itemIcon.sprite = item.icon;
            itemIcon.gameObject.SetActive(true);
            //set sprite to the one from the item
        }
    }

    private bool CanUseItem(Item item)
    {
        if(item == null)
            return false;
        if (count < 1)
            return false;
        return true;
    }

    public void UseItemInSlot()
    {
        if(CanUseItem(item))
        {
            item.Use();
            if (item.isConsumable)
            {
                Count--;
            }
        }
    }

}
