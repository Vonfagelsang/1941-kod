using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Shooting_Script : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody projectile;
    //private bool IsShooting = true;
    //private IEnumerator Shooting()
    //{
    //    IsShooting = false;
//        yield return new WaitForSeconds(3);
    //    IsShooting = true;
   // }

    void Start()
    {
        //StartCoroutine(Shooting());
    }

    // Update is called once per frame
    void Update()
    {
        //if(IsShooting == false) return;
        if(Input.GetMouseButtonDown(1))
        {
            Rigidbody clone;
            clone = Instantiate(projectile, GameObject.Find("Enemy").transform.position, transform.rotation);
            clone.velocity = new Vector3(0, 0, 6.4f);
        }
        
        //StartCoroutine(Shooting());
    }
}
