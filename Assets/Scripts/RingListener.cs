using UnityEngine;
using UnityEngine.Events;

public class RingListener : MonoBehaviour
{
    [SerializeField] private UnityEvent getRingEvent = null, loseRingEvent = null;
    private void Awake()
    {
        GameObject.FindWithTag("Player").GetComponent<Inventory>().Notify += OnGetRing;
    }
    private void OnGetRing(Inventory.Item item)
    {
        if (item.name == "Кольцо Всевластья")
        {
            if (item.count > 0)
            {
                getRingEvent.Invoke();
            }
            else
            {
                loseRingEvent.Invoke();
            }
        }
    }
}
