using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class codinggymweek4 : MonoBehaviour
{
    public GameObject go;
    public AudioSource audioSource;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (audioSource.isPlaying == false)
            {
                audioSource.PlayOneShot(clip);
            }
        }

        if (audioSource.isPlaying == false)
        {
            go.SetActive(false);
        }

        if (audioSource.isPlaying == true)
        {
            go.SetActive(true);
        }
    }
}
