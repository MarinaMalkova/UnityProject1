using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeChase : Chase
{
    protected override void ChaseProcedure()
    {
        Vector3 lookTarget = _target.position;
        lookTarget.y = transform.position.y;
        transform.LookAt(lookTarget);
    }
}
