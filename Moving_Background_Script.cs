using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Background_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime;
        if(transform.position.z >= 17){
            transform.position = new Vector3(-2.61f, 0.8874321f, -102.2f);
        }
        //if z >= 18 make position = -102.2    
    }
}
