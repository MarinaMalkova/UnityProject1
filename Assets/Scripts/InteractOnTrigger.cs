using UnityEngine;

public class InteractOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach(var interaction in GetComponents<IInteraction>())
                interaction.InteractWith(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach(var interaction in GetComponents<IInteraction>())
                interaction.InteractWith(null);
        }
    }
}
