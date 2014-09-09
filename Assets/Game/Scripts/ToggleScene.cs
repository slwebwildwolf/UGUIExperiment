using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ToggleScene : MonoBehaviour {


	[SerializeField] private GameObject bluePanel=null, redPanel=null;

	public void ChangePanel(string color)
	{
		if(color=="red")
		{
			bluePanel.SetActive(false);
			redPanel.SetActive(true);
		}

		else if(color=="blue")
		{
			bluePanel.SetActive(true);
			redPanel.SetActive(false);
		}

	}


}
