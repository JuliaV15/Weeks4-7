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
        bbutton = GetComponent<Button>();
        bbutton.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        Debug.Log("Clicked!");

        purpleprefab.SetActive(true);

        Instantiate(purpleprefab, new Vector3(0, 0, 0), Quaternion.identity);

        purpleprefab.SetActive(false);
    }
}
