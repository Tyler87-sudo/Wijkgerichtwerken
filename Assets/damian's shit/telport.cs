using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class telport : MonoBehaviour
{

    public bool isComplete = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isComplete = true;
            SceneManager.LoadScene("Scenes/Scene1");
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
