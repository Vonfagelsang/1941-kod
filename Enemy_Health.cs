using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
   
    
    void Start()
    {
    }
    private bool isInvincible = false;
    
    private IEnumerator Invincible()
    {
        isInvincible = true;
        yield return new WaitForSeconds(0);
        isInvincible = false;
    }

    [SerializeField] int health = 3;
    private void Damage(){
        if(isInvincible) return;
        health--;
        if(health <= 0){
            Destroy(this.gameObject);
        }
        StartCoroutine(Invincible());
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Cube")){
           Damage();
           if(!isInvincible){
            StartCoroutine(Invincible());
           }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
