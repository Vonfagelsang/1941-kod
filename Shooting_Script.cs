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
        if(Input.GetMouseButtonDown(0)){
            Rigidbody clone;
            clone = Instantiate(projectile, new Vector3(0, 1, -7f), transform.rotation);
            clone = Instantiate(projectile, new Vector3(1, 1, -7f), transform.rotation);
            clone = Instantiate(projectile, new Vector3(2, 1, -7f), transform.rotation);
            clone = Instantiate(projectile, new Vector3(-1, 1, -7f), transform.rotation);
            clone = Instantiate(projectile, new Vector3(-2, 1, -7f), transform.rotation);
            clone = Instantiate(projectile, new Vector3(0, 1, -7f), transform.rotation);

            clone.velocity = new Vector3(0, 50, 0);
        }
    }
}
