using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BT_InputComponent : BT_CustomComponent
{

    [SerializeField] BT_Inputs controls = null;

    [SerializeField] InputAction move = null;
    [SerializeField] InputAction rotate = null;
    [SerializeField] InputAction attack = null;
    [SerializeField] InputAction autoAttack = null;
    [SerializeField] InputAction sprint = null;
    [SerializeField] InputAction crouch = null;

    public InputAction Move => move;
    public InputAction Rotate => rotate;
    public InputAction Attack => attack;
    public InputAction AutoAttack => autoAttack;
    public InputAction Sprint => sprint;
    public InputAction Crouch => crouch;

    private void Awake()
    {
        controls = new BT_Inputs();
    }

    private void OnEnable()
    {
        move = controls.Player.Movement;
        rotate = controls.Player.Rotate;
        attack = controls.Player.Attack;
        autoAttack = controls.Player.AutoAttack;
        sprint = controls.Player.Sprint;
        crouch = controls.Player.Crouch;

        move.Enable();
        rotate.Enable();
        attack.Enable();
        autoAttack.Enable();
        sprint.Enable();
        crouch.Enable();
    }

    private void OnDisable()
    {
        move.Disable();
        rotate.Disable();
        attack.Disable();
        autoAttack.Disable();
        sprint.Disable();
        crouch.Disable();

    }
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
