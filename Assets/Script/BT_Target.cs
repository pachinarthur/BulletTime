using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BT_Target : MonoBehaviour
{
    [SerializeField] int health = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddHealth(int _value)
    {
        health += _value;
        health = health <= 0 ? 0 : health >= 5 ? 5 : health;
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
}
