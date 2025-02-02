using UnityEngine;
using XeSys.Gfx;
using UnityEngine.UI;

namespace XeApp.Game.Menu
{
	public class BingoRewardContents : MonoBehaviour
	{
		[SerializeField]
		private RawImageEx SceneIcon;
		[SerializeField]
		private RawImageEx DivaIcon;
		[SerializeField]
		private Text SceneDetailText;
		[SerializeField]
		private Text BingoDetailText;
		[SerializeField]
		private Text CostumeName;
		[SerializeField]
		private Text explanationText;
		private void Awake()
		{
			TodoLogger.LogError(0, "Implement Monobehaviour");
		}
	}
}
