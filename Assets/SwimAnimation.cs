using UnityEngine;


public class SwimAnimation : MonoBehaviour
{
    private Animator _animator;
    private const string animatorSwim = "Swimming";

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerSwim>(out var _))
        {
            _animator.SetBool(animatorSwim, true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<PlayerSwim>(out var _))
        {
            _animator.SetBool(animatorSwim, false);
        }
    }
}
