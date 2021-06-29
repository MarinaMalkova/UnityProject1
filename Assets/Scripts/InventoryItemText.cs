using UnityEngine;
using UnityEngine.UI;


public class InventoryItemText : MonoBehaviour
{
    [SerializeField] private Text text = null;
    [SerializeField] private string trackItemName = "Монетка";
    private void Awake()
    {
        if (!text) text = GetComponentInChildren<Text>();
        GameObject.FindWithTag("Player").GetComponent<Inventory>().Notify += ItemCountToText;
    }
    void ItemCountToText(Inventory.Item item)
    {
        if (item.name == trackItemName)
        {
            text.text = item.count.ToString();
        }
    }
}
