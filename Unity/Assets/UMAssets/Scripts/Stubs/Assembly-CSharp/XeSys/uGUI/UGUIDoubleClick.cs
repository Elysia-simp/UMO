using UnityEngine;
using UnityEngine.Events;

namespace XeSys.uGUI
{
	public class UGUIDoubleClick : MonoBehaviour
	{
		public float interval;
		public UnityEvent onDoubleClick;
		private void Awake()
		{
			UnityEngine.Debug.LogError("Implement Monobehaviour");
		}
	}
}
