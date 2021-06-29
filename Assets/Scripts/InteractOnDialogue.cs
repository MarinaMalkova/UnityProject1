using System;
using UnityEngine;

public class InteractOnDialogue : MonoBehaviour
{
    private GameObject currentPartner = null;
    private Action<GameObject> OnWithGameObject = null;

    private void Start()
    {
        var dialogObject = GameObject.Find("Dialog");
        if (dialogObject != null)
        {
            var dialog = dialogObject.GetComponent<IInteraction>();
            if (dialog != null) OnWithGameObject = dialog.InteractWith;
        }
        else
        {
            Debug.LogWarning(name + " не нашёл объект Dialog.");
            OnWithGameObject = PrintDialog;
        }
    }
    private void PrintDialog(GameObject obj) => print("Диалог " + obj);


    public void Register(GameObject partner)
    {
        if (!currentPartner)
        {
            OnWithGameObject(currentPartner = partner);
        }
    }
    public void Unregister(GameObject partner)
    {
        if (currentPartner == partner)
        {
            OnWithGameObject(currentPartner = null);
        }
    }
}
