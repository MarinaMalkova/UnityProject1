using System.Collections;

using System.Collections.Generic;
using UnityEngine;

public class TalkInteraction : MonoBehaviour, IInteraction
{
    private InteractOnDialogue dialogue;

    public void InteractWith(GameObject obj)
    {
        if (obj)
        {
            dialogue = obj.GetComponent<InteractOnDialogue>();
            if (dialogue)
            {
                dialogue.Register(gameObject);
            }
        }
        else
        {
            if (dialogue != null)
            {
                dialogue.Unregister(gameObject);
            }
        }
    }
}
