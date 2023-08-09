using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] int Damage = 100;
    
    public int GetDamage()
    {
        Destroy(gameObject);
        return Damage;
    }

    public void Hit()
    {
        Destroy(gameObject);
    }
}
