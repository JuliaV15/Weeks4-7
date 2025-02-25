using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    public GameObject purpleprefab;
    Button bbutton;

    // Start is called before the first frame update
    void Start()
    {
        bbutton = GetComponent<Button>(); // references the button component
        bbutton.onClick.AddListener(OnClick); // adds the on click to the button component
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick() // this is so that all the instantiating only happens when the button is clicked
    {
        Debug.Log("Clicked!");

        purpleprefab.SetActive(true);

        Instantiate(purpleprefab, new Vector3(0, 0, 0), Quaternion.identity); // instantiates the prefab and spawns it at a set location every time

        purpleprefab.SetActive(false); // deactivates the prefab so that it does not spawn infintie purple clnoes (I accidentally did that and blew up my pc)
    }
}
