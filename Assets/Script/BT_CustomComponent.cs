using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BT_CustomComponent : MonoBehaviour
{
    [SerializeField] protected BT_Player playerRef = null;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        Init();
    }
    void Init()
    {
        playerRef = GetComponent<BT_Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
