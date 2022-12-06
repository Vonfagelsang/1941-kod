using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Projectile_Script : MonoBehaviour
{
     //Start is called before the first frame update
    private void OnCollisionEnter(Collision other) {
        if(other.body.CompareTag("Enemy")){
            return;
        } 
        Destroy(this.gameObject);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics.IgnoreCollision(this.gameObject.GetComponent<Collider>(), GameObject.Find(name: "Enemy").GetComponent<Collider>());
    }
}
