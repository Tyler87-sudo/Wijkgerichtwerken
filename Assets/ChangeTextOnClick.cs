using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;

public class ChangeTextOnClick : MonoBehaviour
{

	public int currentArrayValue = 0;
	public string[] NPC_Text_Array = new string[] { "Hello", "Hoe gaat het", "MOI" };

	[SerializeField] public TextMeshProUGUI NPC_Text;
	[SerializeField] private GameObject canvas;
	
	public void MouseClick()
	{
		if (Input.GetMouseButton(0))
		{
			Debug.Log(currentArrayValue);
			if (currentArrayValue <= 3)
			{
				Debug.Log("The left mouse button is being held down.");
				currentArrayValue++;
				NPC_Text.text = NPC_Text_Array[currentArrayValue];
			}
		}
		if (Input.GetMouseButton(1))
		{
			Debug.Log(currentArrayValue);
			if (currentArrayValue >= 0)
			{
				Debug.Log("The right mouse button is being held down.");
				currentArrayValue--;
				NPC_Text.text = NPC_Text_Array[currentArrayValue];
			}
		}
	}

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}
}
