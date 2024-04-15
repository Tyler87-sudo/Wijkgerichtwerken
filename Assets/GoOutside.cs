using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoOutside : MonoBehaviour
{
    
	[SerializeField] private string newLevel;
	// Start is called before the first frame update
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			SceneManager.LoadScene("Scenes/Scene1");
		}
	}

	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		Scene scene = SceneManager.GetActiveScene();
		Console.WriteLine(scene.name);
	}
}
