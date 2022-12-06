using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 mousePosition;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3 newPos = transform.position;
        newPos.x = Input.mousePosition.x;
        newPos.x = Vector2.Lerp(new Vector2(-12.4f, transform.position.y),new Vector2(12.4f, transform.position.y), newPos.x/Screen.width).x * -1;
        transform.position = newPos;
    }
}
