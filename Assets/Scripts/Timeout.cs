using UnityEngine;
using UnityEngine.Events;

public class Timeout : MonoBehaviour
{
    public UnityEvent timeout = null;

    public void StartTimer(float time)
    {
        Invoke("OnTime", time);
    }
    private void OnTime() => timeout.Invoke();
}
