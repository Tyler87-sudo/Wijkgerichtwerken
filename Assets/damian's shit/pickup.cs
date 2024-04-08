using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class pickup : MonoBehaviour
{
    
    // Sbyte is beter dan een int MAIK want dat spaart geheugen -_-
    // [SerializeField] 
    // private sbyte number;

    // [SerializeField]
    // private TMP_Text textComponent; 

    [SerializeField]
    private GameObject corespondantNumber;

    // void Start()
    // {
    //     textComponent.text = number.ToString();
    // }

    void ShowNumber()
    {
        corespondantNumber.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ShowNumber();
            Destroy(gameObject);
        }
    }
}