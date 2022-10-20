using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private double attackCooldown;
    private Animator anim;
    private PlayerMovement playerMovement;

    private double coolDownTimer = Mathf.Infinity;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && playerMovement.canAttack() && coolDownTimer > attackCooldown)
        {
            Attack();
        }
        coolDownTimer += Time.deltaTime;
    }

    private void Attack()
    {
        coolDownTimer = 0;
        anim.SetTrigger("attack");
    }
}
