using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class pickup : MonoBehaviour
{
    private static int score = 0; // Static variable to store the score


    // Sbyte is beter dan een int MAIK want dat spaart geheugen -_-
    // [SerializeField] 
    // private sbyte number;

    // [SerializeField]
    // private TMP_Text textComponent; 

    [SerializeField]
    private GameObject corespondantNumber;

    [SerializeField]
    public GameObject teleport;

    // void Start()
    // {
    //     textComponent.text = number.ToString();
    // }

    void Start()
    {
        teleport.SetActive(false);
    }

    void ShowNumber()
    {
        corespondantNumber.SetActive(true);
    }
    void ShowTel()
    {
        teleport.SetActive(true);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            score++;
            ShowNumber();
            Destroy(gameObject);

            Debug.Log("Score: " + score);

            if (score == 5)
            {
                Debug.Log("Ja");
                // startDialog();
                ShowTel();
            }
        }
    }



}