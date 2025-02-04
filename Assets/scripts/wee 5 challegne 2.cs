using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wee5challegne2 : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    int movementspeed = 5;
    Vector3 vector3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (audioSource.isPlaying == false)
        {
            audioSource.PlayOneShot(clip);
        }

        if (audioSource.isPlaying == true)
        {
            transform.Rotate(movementspeed * Time.deltaTime * vector3);
        }
    }
}
