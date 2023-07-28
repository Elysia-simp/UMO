using System.Collections;
using System.Collections.Generic;
using XeSys;
using XeSys.Gfx;

namespace XeApp.Game.Menu
{
	public class GrowthConfScene : TransitionRoot
	{
		public enum series
		{
			None = 0,
			Delta = 1,
			Frontia = 2,
			Seven = 3,
			First = 4,
			Others = 5,
		}

		private struct ListData
		{
			public float meta; // 0x0
			public int rewardId; // 0x4
			public int unlockDivaId; // 0x8
			public int unlockMusicId; // 0xC
			public int exp; // 0x10
			public int maxexp; // 0x14
			public short musicNameId; // 0x18
			public short unlockLevel; // 0x1A
			public byte leve; // 0x1C
			public bool isLock; // 0x1D
			public bool isComplete; // 0x1E
			public string lockMessage; // 0x20
		}

		private DivaGrowthTabListWindow m_tabWindow; // 0x48
		private DivaGrowthStatusWindow m_statusWindow; // 0x4C
		private LayoutUGUIRuntime m_layoutRuntime; // 0x50
		private AbsoluteLayout m_windowAnimeLayout; // 0x54
		private series m_seriesType; // 0x58
		private FFHPBEPOMAK_DivaInfo m_divaData; // 0x5C
		private MessageBank m_dataMessageBank; // 0x60
		private MessageBank m_menuMessageBank; // 0x64
		private Dictionary<int, List<ListData>> m_growsList = new Dictionary<int, List<ListData>>(); // 0x68
		private series[] m_seriesTbl = new series[5] { series.First, series.Seven, series.Frontia, series.Delta, series.Others }; // 0x6C

		// RVA: 0xE22C4C Offset: 0xE22C4C VA: 0xE22C4C
		private void Awake()
		{
			this.StartCoroutineWatched(LoadLayoutCoroutine());
		}

		//[IteratorStateMachineAttribute] // RVA: 0x6E19A4 Offset: 0x6E19A4 VA: 0x6E19A4
		//// RVA: 0xE22C70 Offset: 0xE22C70 VA: 0xE22C70
		private IEnumerator LoadLayoutCoroutine()
		{
			TodoLogger.Log(0, "LoadLayoutCoroutine");
			yield return null;
		}

		// RVA: 0xE22D1C Offset: 0xE22D1C VA: 0xE22D1C Slot: 16
		protected override void OnPreSetCanvas()
		{
			GrowthConfArgs arg = Args as GrowthConfArgs;
			m_seriesType = series.First;
			m_divaData = GameManager.Instance.ViewPlayerData.NBIGLBMHEDC[arg.DivaId - 1];
			m_growsList.Clear();
			for(int i = 0; i < IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.IBPAFKKEKNK_Music.EPMMNEFADAP_Musics.Count; i++)
			{
				EONOEHOKBEB_Music e = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.IBPAFKKEKNK_Music.EPMMNEFADAP_Musics[i];
				List<ListData> list;
				if (!m_growsList.TryGetValue(e.AIHCEGFANAM_SerieAttr, out list))
				{
					list = new List<ListData>();
					m_growsList[e.AIHCEGFANAM_SerieAttr] = list;
				}
				if(IsAnyDivaMusicExp(GameManager.Instance.ViewPlayerData, e.DLAEJOBELBH_Id))
				{
					KDOMGMCGHDC.HJNMIKNAMFH data = KDOMGMCGHDC.ODIAFJCPIFO(e.DLAEJOBELBH_Id, m_divaData.AHHJLDLAPAN_DivaId, CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave, m_divaData.PKLPGBKKFOL[e.DLAEJOBELBH_Id - 1]);
					if(data != null)
					{
						int a = data.PBGFIOONCMB_NextLevelMusicExp - data.PMBFNFOCNAJ_CurLevelMusicExp;
						list.Add(new ListData()
						{
							meta = a > 0 ? (m_divaData.HMBECPGHPOE[e.DLAEJOBELBH_Id - 1] - data.PMBFNFOCNAJ_CurLevelMusicExp) * 1.0f / a : 0,
							rewardId = 0,
							unlockDivaId = data.LHBDCGFOKCA_DivaId,
							unlockMusicId = data.CEFHDLLAPDH_MusicId,
							exp = m_divaData.HMBECPGHPOE[e.DLAEJOBELBH_Id - 1] - data.PMBFNFOCNAJ_CurLevelMusicExp,
							maxexp = a,
							musicNameId = e.KNMGEEFGDNI_Nam,
							unlockLevel = (short)data.KDGIHMCBLND_MusicLevel,
							leve = (byte)(data.EHBAJPHFDOK_NextLevel + (data.NBHEBLNHOJO_IsMax ? 1 : 0) - 1),
							isLock = data.HHBJAEOIGIH_IsLocked,
							isComplete = data.NBHEBLNHOJO_IsMax,
							lockMessage = data.ONIAMNAJLKI_LockMessage,
						});
					}
				}
			}
			m_statusWindow.InitializeDecoration();
			m_statusWindow.UpdateContent(m_divaData, GameManager.Instance.ViewPlayerData);
			ChangeList();
			m_tabWindow.OnTabButton(0);
		}

		// RVA: 0xE23864 Offset: 0xE23864 VA: 0xE23864 Slot: 17
		protected override bool IsEndPreSetCanvas()
		{
			if (!MenuScene.Instance.MenuResidentTextureCache.IsLoading())
				return base.IsEndPreSetCanvas();
			return false;
		}

		// RVA: 0xE2393C Offset: 0xE2393C VA: 0xE2393C Slot: 9
		protected override void OnStartEnterAnimation()
		{
			m_windowAnimeLayout.StartChildrenAnimGoStop("go_in", "st_in");
		}

		// RVA: 0xE239C8 Offset: 0xE239C8 VA: 0xE239C8 Slot: 10
		protected override bool IsEndEnterAnimation()
		{
			return !m_windowAnimeLayout.IsPlayingChildren();
		}

		// RVA: 0xE239F8 Offset: 0xE239F8 VA: 0xE239F8 Slot: 12
		protected override void OnStartExitAnimation()
		{
			m_windowAnimeLayout.StartChildrenAnimGoStop("go_out", "st_out");
		}

		// RVA: 0xE23A84 Offset: 0xE23A84 VA: 0xE23A84 Slot: 14
		protected override void OnDestoryScene()
		{
			m_statusWindow.ReleaseDecoration();
		}

		// RVA: 0xE23AB0 Offset: 0xE23AB0 VA: 0xE23AB0 Slot: 13
		protected override bool IsEndExitAnimation()
		{
			return !m_windowAnimeLayout.IsPlayingChildren();
		}

		//// RVA: 0xE23790 Offset: 0xE23790 VA: 0xE23790
		private void ChangeList()
		{
			m_tabWindow.SetItemCount(m_growsList[(int)m_seriesType].Count);
		}

		//// RVA: 0xE23AE0 Offset: 0xE23AE0 VA: 0xE23AE0
		//private void OnUpdateList(int index, SwapScrollListContent content) { }

		//// RVA: 0xE234FC Offset: 0xE234FC VA: 0xE234FC
		private bool IsAnyDivaMusicExp(DFKGGBMFFGB_PlayerInfo viewPlayerData, int musicId)
		{
			for(int i = 0; i < viewPlayerData.NBIGLBMHEDC.Count; i++)
			{
				if(viewPlayerData.NBIGLBMHEDC[i].IPJMPBANBPP)
				{
					KDOMGMCGHDC.ODIAFJCPIFO(musicId, viewPlayerData.NBIGLBMHEDC[i].AHHJLDLAPAN_DivaId, CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave, viewPlayerData.NBIGLBMHEDC[i].PKLPGBKKFOL[musicId - 1]);
					if (viewPlayerData.NBIGLBMHEDC[i].HMBECPGHPOE[musicId - 1] > 0)
						return true;
				}
			}
			return false;
		}

		//// RVA: 0xE23F40 Offset: 0xE23F40 VA: 0xE23F40
		//private void OnClickDetailButton() { }
	}
}
