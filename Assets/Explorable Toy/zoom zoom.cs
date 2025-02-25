using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomzoom : MonoBehaviour
{
    float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;

        Vector3 direction = (Vector3)transform.position;
        transform.right = direction;

        transform.position = pos;
    }
}
