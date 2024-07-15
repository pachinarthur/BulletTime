using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BT_MovementComponent : BT_CustomComponent
{
    [SerializeField] float rotateSpeed = 100;
    [SerializeField] float moveSpeed = 5;
    [SerializeField] bool isCrouching = false;
    [SerializeField] bool isSprinting = false;
    [SerializeField] bool isShooting = false;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
    }

    public void SetMoveSpeed(float _value)
    {
        moveSpeed = _value;
    }

    void Move()
    {
        if (!playerRef) return;
        Vector2 _moveDir = playerRef.Input.Move.ReadValue<Vector2>();
        transform.position += transform.forward * _moveDir.y * moveSpeed * Time.deltaTime; //interdit pour le RootMotion
        transform.position += transform.right * _moveDir.x * moveSpeed * Time.deltaTime;
        playerRef.Animation.UpdateForwardAnimatorParam(_moveDir.y);
        playerRef.Animation.UpdateRightAnimatorParam(_moveDir.x);
    }

    void Rotate()
    {
        if (!playerRef) return;
        float _rotateVal = playerRef.Input.Rotate.ReadValue<float>();
        transform.eulerAngles += transform.up * _rotateVal * rotateSpeed * Time.deltaTime;
    }

    public void SetIsCrouching(InputAction.CallbackContext _context)
    {
        if (!playerRef || !playerRef.Animation) return;
        isCrouching = !isCrouching;
        isSprinting = false;
        playerRef.Animation.UpdateCrouchAnimatorParam(isCrouching);
        playerRef.Animation.UpdateSprintAnimatorParam(isSprinting);
    }

    public void SetIsSprinting(InputAction.CallbackContext _context)
    {
        if (!playerRef || !playerRef.Animation) return;
        isSprinting = !isSprinting;
        isCrouching = false;
        playerRef.Animation.UpdateSprintAnimatorParam(isSprinting);
        playerRef.Animation.UpdateCrouchAnimatorParam(isCrouching);
    }
    
    public void SetIsShooting(InputAction.CallbackContext _context)
    {
        if (!playerRef || !playerRef.Animation) return;
        isShooting = !isShooting;
        playerRef.Animation.UpdateShootAnimatorParam(isShooting);
    }
}
