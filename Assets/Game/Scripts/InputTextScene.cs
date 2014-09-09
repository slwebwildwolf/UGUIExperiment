using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InputTextScene : MonoBehaviour {

	[SerializeField] private InputField inputField;
	[SerializeField] private string inputText=" ";

	[SerializeField] private Text textField;

	void Start() {
		inputField.onSubmit.AddListener (OnSubmit);
	}



	void OnSubmit(string line) {
		inputText=inputField.value;

		textField.text= textField.text+" "+inputText;

		inputField.value="";

	}
}
