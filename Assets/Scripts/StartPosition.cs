using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPosition : MonoBehaviour
{
    private static int ID = 0;

    public void SetID(int id)
    {
        ID = id;
    }

    [SerializeField] private Transform[] positions;

    private void Awake()
    {
        if (ID != 0)
        {
            if ((positions.Length >= ID) && (ID > 0))
            {
                transform.SetPositionAndRotation(positions[--ID].position, positions[ID].rotation);
            }
            ID = 0;
        }
    }
}
