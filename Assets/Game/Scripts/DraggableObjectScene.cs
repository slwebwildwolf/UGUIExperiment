using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class DraggableObjectScene : MonoBehaviour {



	public void Dragging()
	{
		GetComponent<RectTransform>().pivot.Set(0,0);
		transform.position=Input.mousePosition;
	}
	
	public void Clicked()
	{
		transform.localScale=new Vector3(0.7f,0.7f,0.7f);
	}

	public void UnClicked()
	{
		transform.localScale=new Vector3(1f,1f,1f);
	}
}
