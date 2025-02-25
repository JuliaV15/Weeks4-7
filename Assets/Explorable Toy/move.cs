using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class move : MonoBehaviour
{
    float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { // simple movement code below, makes sprite bounce off screen walls
      // code was learned + written with the help of in class lessons and the required reading
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if(screenPos.x <0)
        {
            Vector3 fixedPos = new Vector3(0, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed = speed * -1;
        }

        if(screenPos.x > Screen.width)
        {
            Vector3 fixedPos = new Vector3(Screen.width, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed = speed * -1;
        }

        transform.position = pos;
    }

    public void Go(float s) // public void so that it can be called in the inspector and Go so that when called it starts the movement
    {
        speed = s;
    }

   public void Stop() // Stop so that when called it stops the movement
    {
        speed = 0;
    }
}
