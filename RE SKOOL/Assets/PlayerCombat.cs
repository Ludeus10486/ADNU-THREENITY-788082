using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;

    [SerializeField] private AudioSource SwordAttackSound;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwordAttackSound.Play();
            Attack();
        }
    }

    void Attack()
    {
        //Play an attak animation
        animator.SetTrigger("Attack");

        //Detect enemies in range of attack

        //Damage them
    }
}
