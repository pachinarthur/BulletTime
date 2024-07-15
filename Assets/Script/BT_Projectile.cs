using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BT_Projectile : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10;
    [SerializeField] float lifeSpan = 5;
    [SerializeField] int damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeSpan);
    }

    void MoveForward()
    {
        transform.position += transform.forward * Time.deltaTime * moveSpeed;
    }

    private void OnTriggerEnter(Collider other) //En isTrigger c'est pour l'overapp donc il va traversé alors que colission il vas juste touché
    {
        BT_Target _target = other.GetComponent<BT_Target>();
        if (!_target) return;
        _target.AddHealth(-damage);
        print("Hit");
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
    }

    public void SetMoveSpeed(float _value)
    {
        moveSpeed = _value;
    }
}
