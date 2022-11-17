using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    // Start is called before the first frame update
    private int Health = 5;
    public void Damage(){
        Health--;
        if(Health <= 0){
            Destroy(this.gameObject);
        }
    }
        void OnTriggerEnter(Collider other) {
            if(other.CompareTag("Cube")){
                Enemy_Health enemy = other.transform.GetComponent<Enemy_Health>();
                if(enemy != null){
                    enemy.Damage();
                    Destroy(this.gameObject);
                }
            }
        }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
