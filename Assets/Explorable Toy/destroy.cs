using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3); // destroy the clones 3 sec after they are spawned
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
