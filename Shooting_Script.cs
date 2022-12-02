using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting_Script : MonoBehaviour
{
    public Rigidbody projectile;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Rigidbody clone;
            clone = Instantiate(projectile, GameObject.Find("Player").transform.position, transform.rotation);
            clone.velocity = new Vector3(0, 0, -6.4f);
        }
    }
}

