using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable 
{
    bool ApllyDamage(Rigidbody rigidbody, float force);
}
