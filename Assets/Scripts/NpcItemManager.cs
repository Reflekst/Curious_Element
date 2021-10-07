using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class  NpcItemCheckUE : UnityEvent<int,int> { }
public class NpcItemManager : MonoBehaviour
{
    [SerializeField] private int id;
    [SerializeField] private Item wantedItem;
    [SerializeField] private Item transferedItem;

    public NpcItemCheckUE NpcItemCheck;

    private void Start()
    {
        NpcDialog.current.onNpcDialogStart += OnInventoryOpen;
    }
    public void OnInventoryOpen(int id)
    {
        if (id == this.id)
        {
            if (Inventory.instance.items.Any(item => item.itemId == transferedItem.itemId))
            {
                NpcItemCheck.Invoke(id, 0);
            }
            else if (Inventory.instance.items.Any(item => item.itemId == wantedItem.itemId) || wantedItem == null)
            {
                NpcItemCheck.Invoke(id, 1);
                Inventory.instance.AddItem(transferedItem);
            }
            else if (!Inventory.instance.items.Any(item => item.itemId == wantedItem.itemId) && Inventory.instance.items.Count != 0)
            {
                NpcItemCheck.Invoke(id, -1);
            }
        }
    }

    private void OnDestroy()
    {
        NpcDialog.current.onNpcDialogStart -= OnInventoryOpen;
    }
}
