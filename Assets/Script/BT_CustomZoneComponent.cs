using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BT_CustomZoneComponent : MonoBehaviour
{

    //A unique List of The BT_Player And BT_Projectile
    [SerializeField] protected BT_Player player = null;
    [SerializeField] protected BT_Projectile projectile;
    [SerializeField] protected string playerTag = "Player";
    [SerializeField] protected string projectileTag = "Bullet";


    // Start is called before the first frame update
    protected virtual void Start()
    {
        Init();
    }

    void Init()
    {
        //Find the BT_Player and BT_Projectile in the scene
        player = FindObjectOfType<BT_Player>();
        projectile = GetComponent<BT_Projectile>();
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void OnTriggerEnter(Collider other)
    {


    }


    protected virtual void OnTriggerStay(Collider other)
    {

    }

    protected virtual void OnTriggerExit(Collider other)
    {

    }
}
