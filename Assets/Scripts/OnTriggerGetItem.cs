    using UnityEngine;


public class OnTriggerGetItem : MonoBehaviour
{
    [SerializeField] private string itemName = "Монетка";
    [SerializeField] private int itemCount = 1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            other.GetComponent<Inventory>().Add(itemName, itemCount);
        }
    }
}
