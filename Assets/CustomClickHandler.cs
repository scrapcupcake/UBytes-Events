using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class CustomClickHandler : MonoBehaviour, IPointerClickHandler
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void IWasClicked ()
		{
				Debug.Log ("I was hit by, struck by, a smooth mouse click in IWasClicked() on " + gameObject.name);
		}
	
	#region IPointerClickHandler implementation
		public void OnPointerClick (PointerEventData eventData)
		{
				Debug.Log (string.Format ("OnPointerClick, are you ok?\r\n{0} are you ok? Are you ok {0}?", gameObject.name));
		}
	#endregion
}
