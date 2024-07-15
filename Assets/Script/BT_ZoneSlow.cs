using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BT_ZoneSlow : BT_CustomZoneComponent
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        if(other.gameObject.tag == playerTag)
        {
            player.Movement.SetMoveSpeed(2);
        }
        if (other.gameObject.tag == projectileTag)
        {
            Debug.Log("OnTriggerExit");
            other.gameObject.GetComponent<BT_Projectile>().SetMoveSpeed(5);
        }
    }

    protected override void OnTriggerStay(Collider other)
    {
        base.OnTriggerStay(other);
        if (other.gameObject.tag == playerTag)
        {
            player.Movement.SetMoveSpeed(2);
        }
        if (other.gameObject.tag == projectileTag)
        {
            Debug.Log("OnTriggerExit");
            other.gameObject.GetComponent<BT_Projectile>().SetMoveSpeed(5);
        }
    }

    protected override void OnTriggerExit(Collider other)
    {
        base.OnTriggerExit(other);
        if (other.gameObject.tag == playerTag)
        {
            player.Movement.SetMoveSpeed(5);
        }
        if (other.gameObject.tag == projectileTag)
        {
            Debug.Log("OnTriggerExit");
            other.gameObject.GetComponent<BT_Projectile>().SetMoveSpeed(10);
        }
    }
}
