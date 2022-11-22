using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    [SerializeField] int health = 5;
    public void Damage(){
        health--;
        if(health <= 0){
            Destroy(this.gameObject);
        }
    }
    
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.body.CompareTag("Cube")){
           Damage();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
