using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Script : MonoBehaviour
{
    // Start is called before the first frame update
   
    private void OnTriggerEnter3D(Collider other)
    {
        Enemy_Health enemy = other.transform.GetComponent<Enemy_Health>();
        enemy.Damage();
    }
        
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
