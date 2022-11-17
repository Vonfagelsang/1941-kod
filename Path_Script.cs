using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Variables{
    public static float check;
    //Gör private med property
}
public class Path_Script : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 targetPosition;
    
    private float moveSpeed;
    
    

    void Start()
    {
        Variables.check = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a = GameObject.Find("Path1").transform.position;
        Vector3 b = GameObject.Find("Cube").transform.position;
        Vector3 c = GameObject.Find("Path2").transform.position;
        if(Variables.check == 1){
            Vector3 directionToMove = a - transform.position;
            directionToMove = directionToMove.normalized * Time.deltaTime * moveSpeed;
            float maxDistance = Vector3.Distance(transform.position, targetPosition);
            transform.position = transform.position + Vector3.ClampMagnitude(directionToMove, maxDistance);
            if(a == b){
                Variables.check = 2;
            }
        }
        else if(Variables.check == 2){
            Vector3 directionToMove = c - transform.position;
            directionToMove = directionToMove.normalized * Time.deltaTime * moveSpeed;
            float maxDistance = Vector3.Distance(transform.position, targetPosition);
            transform.position = transform.position + Vector3.ClampMagnitude(directionToMove, maxDistance);
            if(b == c){
                Variables.check = 1;
            }
        }
    }
}