using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TestScript : MonoBehaviour {

	public Text tex;

	public void TestFunction(float f)
	{
		tex.text=f.ToString();
	}
}
