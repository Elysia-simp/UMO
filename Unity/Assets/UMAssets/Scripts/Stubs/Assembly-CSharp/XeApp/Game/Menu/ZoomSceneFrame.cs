using UnityEngine;

namespace XeApp.Game.Menu
{
	public class ZoomSceneFrame : MonoBehaviour
	{
		[SerializeField]
		private RectTransform[] m_rareRoot;
		[SerializeField]
		private RectTransform[] m_frameRoot;
		private void Awake()
		{
			UnityEngine.Debug.LogError("Implement Monobehaviour");
		}
	}
}
