using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ClickableObject : MonoBehaviour, IPointerClickHandler
{

	[SerializeField] public Button button1;
	[SerializeField] public Button button2;
     
	public int currentArrayValue = 0;
	private string[] NPC_Text_Array = new string[]
	{
		"Man: Oh wat leuk dat je langskomt! Ik heb me de laatste tijd zo eenzaam gevoelt. ", "Speler: Waarom voelt u zich zo eenzaam? Er wonen zoveel mensen hier in de wijk die vast wel wat leuks willen gaan doen.", "Man: Ja dat klopt, maar ik vind het zo lastig om die stap te zetten. ", "Speler: Zou ik u daarmee kunnen helpen?",
		"Man: Ik zou dat erg waarderen, hoe wil je dit doen?", 
	};

	[SerializeField] public TextMeshProUGUI NPC_Text;

	public void OnPointerClick(PointerEventData eventData)
	{
		if (eventData.button == PointerEventData.InputButton.Left && currentArrayValue >= 4)
		{
			button1.gameObject.SetActive(true);
			button2.gameObject.SetActive(true);
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
