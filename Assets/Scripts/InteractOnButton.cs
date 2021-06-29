using UnityEngine;
using UnityEngine.UI;

public class InteractOnButton : MonoBehaviour
{
    [SerializeField] private Image notify = null;
    private Collider2D playerCollider = null;
    private IInteraction[] interactions = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (interactions == null) interactions = GetComponents<IInteraction>();
            if (interactions.Length > 0)
            {
                playerCollider = collision;
                enabled = true;
                notify.enabled = true;
            }
        }
    }

    private void Update()
    {
        if (playerCollider && Input.GetButtonDown("Submit"))
        {
            enabled = false;
            notify.enabled = false;
            foreach (var interaction in interactions)
            {
                interaction.InteractWith(playerCollider.gameObject);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerCollider = null;
            enabled = false;
            notify.enabled = false;

            foreach (var interaction in interactions)
            {
                interaction.InteractWith(null);
            }
        }
    }
}
