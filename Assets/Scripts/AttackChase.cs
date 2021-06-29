using UnityEngine;


public class AttackChase : Chase
{
    [SerializeField] private float attackDistance = 2;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    protected override void ChaseProcedure()
    {
        Vector3 lookTarget = _target.position;
        lookTarget.y = transform.position.y;
        transform.LookAt(lookTarget);

        _animator.SetBool("IsAttacking",
            Vector3.Distance(transform.position, _target.position) < attackDistance);
    }
    public void Hit()
    {
        if (_target.TryGetComponent(out Health health))
        {
            health.TakeDamage(1);
        }
    }
}
