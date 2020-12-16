using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float damage = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AttackHitEvent()
    {
        if (target == null) return;
        target.GetComponent<PlayerHealth>().TakeDamage(damage);
        target.GetComponent<DisplayDamage>().ShowDamageCanvas();
    }
}
