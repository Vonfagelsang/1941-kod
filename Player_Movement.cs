using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.7f;
    public Vector3 target = new Vector3(-2.850275f, 2.34637f, -0.2f);
    private Vector3 origin;
    void Start()
    {
        origin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    transform.position = Vector3.MoveTowards (transform.position, target, speed * Time.deltaTime);
    if(transform.position == target) {
        target = origin;
        origin = new Vector3(-2.850275f, 2.44637f, -0.2f);
    }
    if(transform.position.y == 2.44637f){
        target = new Vector3(-2.850275f, 1.5f, -0.2f);
    }

    }
}
