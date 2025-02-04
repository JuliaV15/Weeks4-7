using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class week5gym : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Vector3 vectorUp;
    int movementspeed = 10;
   // int MoveSpeed = 0.5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //  transform.Translate(Vector3, MoveSpeed, 0, 0)
            transform.Translate(Vector3.up * movementspeed * Time.deltaTime);
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * movementspeed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * movementspeed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * movementspeed * Time.deltaTime);

        }
    }
}
