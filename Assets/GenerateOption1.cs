using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GenerateOption1 : MonoBehaviour
{
    
    public class ClickableObject : MonoBehaviour, IPointerClickHandler
    {
        
     
        public int currentArrayValue = 0;
        private string[] NPC_Text_Array = new string[] {};

        [SerializeField] public TextMeshProUGUI NPC_Text;

        public void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left && currentArrayValue >= 4)
            {
            }
            if (eventData.button == PointerEventData.InputButton.Left)
            {
                if (currentArrayValue < 5)
                {
                    currentArrayValue++;
                    Debug.Log(currentArrayValue);
                    Debug.Log("Left click");
                    NPC_Text.text = NPC_Text_Array[currentArrayValue];
                }
            }
            if (eventData.button == PointerEventData.InputButton.Right)
            {
                if (currentArrayValue > 0)
                {
                    Debug.Log("Right click");
                    currentArrayValue--;
                    Debug.Log(currentArrayValue);
                    NPC_Text.text = NPC_Text_Array[currentArrayValue];
                }
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
