using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path_Position : MonoBehaviour
{
    
    float x;
    float y = 2.2f;
    float z;
    float checkCheck = 1;
    Vector3 pos;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Variables.check == 1){
            if(checkCheck == 1){
                x = Random.Range(1, 6);
                z = Random.Range(-10, -15);
                pos = new Vector3(x, y, z);
                transform.position = pos;
                checkCheck = 2;
            }
            else if(Variables.check == 2){
                x = Random.Range(1, 6);
                z = Random.Range(-10, -15);
                pos = new Vector3(x, y, z);
                transform.position = pos;
                checkCheck = 1;
            }
        }
    }
}