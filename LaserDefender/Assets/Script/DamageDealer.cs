using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] float Damage = 100;
    
    public float GetDamage()
    {
        Destroy(gameObject);
        return Damage;
    }

    public void Hit()
    {
        Destroy(gameObject);
    }
}
