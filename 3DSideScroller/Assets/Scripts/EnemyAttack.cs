using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private Health playerHealth;
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GetComponent<Health>();
    }

    void OnCollisionEnter(Collision collision)
    {
        print("Yeehaw");
        playerHealth.TakeDamage(damage);
        print("Player Takes "+ damage + " points of damage.");
    }
}
