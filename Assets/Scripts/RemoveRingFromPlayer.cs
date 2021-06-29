using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveRingFromPlayer : MonoBehaviour
{
    public void Work()
    {
        FindObjectOfType<Inventory>().RemoveAll("Кольцо Всевластья");
    }
}
