using UnityEngine;
using System.Collections.Generic;

public class GiveItemsInteraction : MonoBehaviour, IInteraction
{
    [SerializeField] private List<Inventory.Item> itemsToGive = null;

    public void AddToList(Inventory.Item item)
    {
        if (itemsToGive == null) itemsToGive = new List<Inventory.Item>();
        itemsToGive.Add(item);
    }

    public void InteractWith(GameObject obj) 
    {
        var inv = obj?.GetComponent<Inventory>();
        if (inv)
        {
            foreach (var item in itemsToGive)
            {
                inv.Add(item.name, item.count);
            }
            itemsToGive.Clear();
        }
    }
}
