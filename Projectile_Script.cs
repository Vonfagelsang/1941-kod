using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Script : MonoBehaviour
{
    // Start is called before the first frame update
   
    
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Cube") || other.CompareTag("Enemy_Projectile")) return;
        Destroy(this.gameObject);
    }
        
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics.IgnoreCollision(this.gameObject.GetComponent<Collider>(), GameObject.Find("Player").GetComponent<Collider>());
    }
}
