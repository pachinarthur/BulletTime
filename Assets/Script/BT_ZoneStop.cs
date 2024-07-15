using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BT_ZoneStop : BT_CustomZoneComponent
{
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        if (other.gameObject.tag == playerTag)
        {
            player.Movement.SetMoveSpeed(0);
        }
        if (other.gameObject.tag == projectileTag)
        {
            other.gameObject.GetComponent<BT_Projectile>().SetMoveSpeed(0);
        }
    }

    protected override void OnTriggerStay(Collider other)
    {
        base.OnTriggerStay(other);
        if (other.gameObject.tag == playerTag)
        {
            player.Movement.SetMoveSpeed(0);
        }
        if (other.gameObject.tag == projectileTag)
        {
            other.gameObject.GetComponent<BT_Projectile>().SetMoveSpeed(0);
        }
    }

    protected override void OnTriggerExit(Collider other)
    {
        base.OnTriggerExit(other);
        if (other.gameObject.tag == playerTag)
        {
            player.Movement.SetMoveSpeed(2);
        }
        if (other.gameObject.tag == projectileTag)
        {
            other.gameObject.GetComponent<BT_Projectile>().SetMoveSpeed(10);
        }
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
