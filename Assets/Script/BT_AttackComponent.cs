using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BT_AttackComponent : BT_CustomComponent
{
    [SerializeField] BT_Projectile toSpawn = null;
    [SerializeField] float currentTime = 0;
    [SerializeField] float maxTime = .5f;
    [SerializeField] float spawnForwardOffset = 2;
    [SerializeField] float spawnUpOffset = 1;
    [SerializeField] bool canAttack = true;
    [SerializeField] Vector3 spawnPosition = Vector3.zero;
    [SerializeField] bool isAttacking = false;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if (!canAttack)
        {
            currentTime = IncreaseTime(currentTime, maxTime);
        }
        AutoAttack();
    }

    public void Attack(InputAction.CallbackContext context)
    {
        if (!canAttack) return;
        SpawnProjectile();
        canAttack = false;
    }

    void AutoAttack()
    {
        if (!canAttack || !isAttacking) return;
        SpawnProjectile();
        canAttack = false;
    }

    void SpawnProjectile()
    {
        spawnPosition = transform.position + transform.forward * spawnForwardOffset + transform.up * spawnUpOffset;
        BT_Projectile _projectile = Instantiate(toSpawn, spawnPosition, transform.rotation);
    }

    float IncreaseTime(float _current, float _max)
    {
        _current += Time.deltaTime;
        if (_current >= _max)
        {
            _current = 0;
            canAttack = true;
        }
        return _current;
    }

    public void SetIsAttacking(InputAction.CallbackContext _context)
    {
        isAttacking = _context.ReadValueAsButton();

    }
}
