using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path_Position : MonoBehaviour
{
    
    float x;
    float y;
    float z = 0;
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
            y = Random.Range(1, 3);
            pos = new Vector3(x, y, z);
            transform.position = pos;
            checkCheck = 2;
            }
            else if(Variables.check == 2){
            x = Random.Range(1, 6);
            y = Random.Range(1, 3);
            pos = new Vector3(x, y, z);
            transform.position = pos;
            checkCheck = 1;
            }
        }
    }
}
   
    // Start is called before the first frame update
    

