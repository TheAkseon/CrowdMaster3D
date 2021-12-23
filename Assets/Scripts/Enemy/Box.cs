using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour, IDamageable
{
    public bool ApllyDamage(Rigidbody rigidbody, float force)
    {
        Debug.Log("Я коробка");
        return true;
    }
}
