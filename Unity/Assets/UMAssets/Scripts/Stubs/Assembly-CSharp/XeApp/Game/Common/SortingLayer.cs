using UnityEngine;

namespace XeApp.Game.Common
{
	public class SortingLayer : MonoBehaviour
	{
		[SerializeField]
		private string m_layerName;
		[SerializeField]
		private int m_orderInLayer;
		private void Awake()
		{
			UnityEngine.Debug.LogError("Implement Monobehaviour");
		}
	}
}
