using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class surprise : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { // if you press space, it will play an audio clip assigned to audio source
        // my audio is broken a bit so not sure if this code is bugged or what because I literally cannot find why there is no audio playing :(
        if (Input.GetKey(KeyCode.Space))
        { 
            audioSource.PlayOneShot(clip); 
        }
    }
}
