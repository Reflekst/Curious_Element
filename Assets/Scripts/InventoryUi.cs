using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUi : MonoBehaviour
{
    [SerializeField] private List<Image> inventroySlots;
    
    public void UpdateInventorySlots(List<Item> items)
    {
        for (var i = 0; i < items.Count; i++)
        {
            inventroySlots[i].sprite = items[i].itemIcon;
        }
    }
}
