using UnityEngine;
using UnityEngine.Events;

public class OnPlayerEnterExitEvents : MonoBehaviour
{
    [SerializeField] private UnityEvent PlayerEnterEvent;
    [SerializeField] private UnityEvent PlayerExitEvent;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerEnterEvent.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerExitEvent.Invoke();
        }
    }
}
