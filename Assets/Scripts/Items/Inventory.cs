using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class ShowItemsEvent : UnityEvent<List<Item>> { }

public class Inventory : MonoBehaviour
{
    public ShowItemsEvent showItemsEvent;

    public List<Item> items = new List<Item>();

    #region Singleton
    public static Inventory instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion

    public void AddItem(Item item)
    {
        items.Add(item);
        OnShowItems();
    }

    void OnShowItems()
    {
        if (showItemsEvent != null)
        {
            showItemsEvent.Invoke(items);
        }
    }
}
