using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BT_MovementComponent),typeof(BT_InputComponent),typeof(BT_AttackComponent))]
[RequireComponent(typeof(BT_CharacterAnimation))]
public class BT_Player : MonoBehaviour
{
    [SerializeField] BT_MovementComponent movement = null;
    [SerializeField] BT_InputComponent input = null;
    [SerializeField] BT_AttackComponent attack = null;
    [SerializeField] new BT_CharacterAnimation animation = null;

    public BT_MovementComponent Movement => movement;
    public BT_InputComponent Input => input;
    public BT_AttackComponent Attack => attack;
    public BT_CharacterAnimation Animation => animation;
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    void Init()
    {
        movement = GetComponent<BT_MovementComponent>();
        input = GetComponent<BT_InputComponent>();
        attack = GetComponent<BT_AttackComponent>();
        animation = GetComponent<BT_CharacterAnimation>();

        //input.Attack.performed += attack.Attack;
        input.AutoAttack.performed += attack.SetIsAttacking;
        input.Sprint.performed += movement.SetIsSprinting;
        input.Crouch.performed += movement.SetIsCrouching;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
