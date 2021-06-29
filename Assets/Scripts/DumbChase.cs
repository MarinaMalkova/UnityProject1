using UnityEngine;


public class DumbChase : Chase
{
    protected override void ChaseProcedure()
    {
        Vector3 lookTarget = _target.position;
        lookTarget.y = transform.position.y;
        transform.LookAt(lookTarget);
    }
}

public abstract class Chase: MonoBehaviour
{
    [SerializeField] protected Transform _target;

    public void Begin(Transform chaseTarget)
    {
        _target = chaseTarget;
    }

    public void Stop()
    {
        _target = null;
    }

    private void Update()
    {
        if (_target)
        {
            ChaseProcedure();
        }
        else
        {
            Stop();
        }
    }

    protected abstract void ChaseProcedure();
}