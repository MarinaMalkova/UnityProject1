using UnityEngine;
using UnityEngine.UI;
public class ShowInventory : MonoBehaviour
{
    [SerializeField] private Text inventoryText = null;
    private void Awake()
    {
        GameObject.FindWithTag("Player").GetComponent<Inventory>().Notify += ShowNewItem;
    }
    private void Start()
    {
        inventoryText.text = GameObject.FindWithTag("Player").GetComponent<Inventory>().ToString();
    }
    void ShowNewItem(Inventory.Item item)
    {
        Start();
    }
}
