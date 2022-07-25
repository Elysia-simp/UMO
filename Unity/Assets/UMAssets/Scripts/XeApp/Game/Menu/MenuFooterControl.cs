using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using XeApp.Game.Common;
using XeSys.Gfx;

namespace XeApp.Game.Menu
{
	public class MenuFooterControl
	{
		private GameObject m_root; // 0x8
		private GameObject m_instance; // 0xC
		private MenuBarPrefab m_menuBar; // 0x10
		private ActionButton[] m_actionButtons; // 0x14
		private LayoutUGUIHitOnly[] m_buttons; // 0x18
		private int[] m_buttonBlockCount; // 0x1C
		// private HGOAIGFPCBC m_QuestbadgeData = new HGOAIGFPCBC(); // 0x20
		// private IIMBAOGHCIG m_HomebadgeData = new IIMBAOGHCIG(); // 0x24
		private List<TransitionUniqueId> m_disableMenuBarUniqueScene = new List<TransitionUniqueId>() {
			TransitionUniqueId.MUSICSELECT_FRIENDSELECT_TEAMSELECT_DIVASELECTLIST_SCENESELECT,
			TransitionUniqueId.MUSICSELECT_FRIENDSELECT_TEAMSELECT_SCENESELECT,
			TransitionUniqueId.STORYSELECT_TEAMSELECT_DIVASELECTLIST_SCENESELECT,
			TransitionUniqueId.STORYSELECT_TEAMSELECT_SCENESELECT,
			TransitionUniqueId.EVENTMUSICSELECT_FRIENDSELECT_TEAMSELECT_DIVASELECTLIST_SCENESELECT,
			TransitionUniqueId.EVENTMUSICSELECT_FRIENDSELECT_TEAMSELECT_SCENESELECT,
			TransitionUniqueId.EVENTQUEST_FRIENDSELECT_TEAMSELECT_DIVASELECTLIST_SCENESELECT,
			TransitionUniqueId.EVENTQUEST_FRIENDSELECT_TEAMSELECT_SCENESELECT,
			TransitionUniqueId.EVENTBATTLE_TEAMSELECT_DIVASELECTLIST_SCENESELECT,
			TransitionUniqueId.EVENTBATTLE_TEAMSELECT_SCENESELECT,
			TransitionUniqueId.DECO_DECOVISITLIST_PROFIL,
			TransitionUniqueId.HOME_RAID_RAIDACTSELECT_FRIENDSELECT_TEAMSELECT_DIVASELECTLIST_SCENESELECT,
			TransitionUniqueId.HOME_RAID_RAIDACTSELECT_FRIENDSELECT_TEAMSELECT_SCENESELECT,
			TransitionUniqueId.HOME_LOBBYMAIN_RAID_RAIDACTSELECT_FRIENDSELECT_TEAMSELECT_DIVASELECTLIST_SCENESELECT,
			TransitionUniqueId.HOME_LOBBYMAIN_RAID_RAIDACTSELECT_FRIENDSELECT_TEAMSELECT_SCENESELECT,
			TransitionUniqueId.MUSICSELECT_RAID_RAIDACTSELECT_FRIENDSELECT_TEAMSELECT_DIVASELECTLIST_SCENESELECT,
			TransitionUniqueId.MUSICSELECT_RAID_RAIDACTSELECT_FRIENDSELECT_TEAMSELECT_SCENESELECT,
			TransitionUniqueId.HOME_LOBBYMAIN_LOBBYMEMBER_PROFIL,
			TransitionUniqueId.HOME_LOBBYGROUPSELECT_LOBBYGROUPSEARCH_PROFIL,
			TransitionUniqueId.HOME_LOBBYMAIN_PROFIL,
			TransitionUniqueId.DECO_SHOPPRODUCT,
			TransitionUniqueId.DECO_DECOVISIT,
			TransitionUniqueId.DECO_DECOVISIT_DECOVISITLIST_PROFIL,
			TransitionUniqueId.DECO_DECOCHAT,
			TransitionUniqueId.DECO_DECOVISIT_DECOCHAT,
			TransitionUniqueId.DECO_DECOCHAT_PROFIL,
			TransitionUniqueId.DECO_DECOVISIT_DECOCHAT_PROFIL,
			TransitionUniqueId.HOME_RAID_RAIDACTSELECT_FRIENDSELECT,
			TransitionUniqueId.HOME_LOBBYMAIN_RAID_RAIDACTSELECT_FRIENDSELECT,
			TransitionUniqueId.MUSICSELECT_RAID_RAIDACTSELECT_FRIENDSELECT,
			TransitionUniqueId.DECO_DECOCHAT_PROFIL_LOBBYMAIN_PROFIL,
			TransitionUniqueId.DECO_DECOVISIT_DECOVISITLIST_PROFIL_LOBBYMAIN_PROFIL,
			TransitionUniqueId.DECO_DECOVISIT_DECOCHAT_PROFIL_LOBBYMAIN,
			TransitionUniqueId.DECO_DECOVISITLIST_PROFIL_LOBBYMAIN_PROFIL,
			TransitionUniqueId.DECO_DECOVISITLIST_PROFIL_LOBBYMAIN,
			TransitionUniqueId.DECO_DECOVISIT_DECOCHAT_PROFIL_LOBBYMAIN_PROFIL,
			TransitionUniqueId.HOME_HOMEBGSELECT,
			TransitionUniqueId.HOME_RAID_PROFIL,
			TransitionUniqueId.HOME_RAID_EVENTRANKING_PROFIL,
			TransitionUniqueId.HOME_RAID_RAIDACTSELECT_RAIDMVP_PROFIL,
			TransitionUniqueId.HOME_LOBBYMAIN_RAID_PROFIL,
			TransitionUniqueId.HOME_LOBBYMAIN_RAID_EVENTRANKING_PROFIL,
			TransitionUniqueId.HOME_LOBBYMAIN_RAID_RAIDACTSELECT_RAIDMVP_PROFIL,
			TransitionUniqueId.MUSICSELECT_RAID_PROFIL,
			TransitionUniqueId.MUSICSELECT_RAID_EVENTRANKING_PROFIL,
			TransitionUniqueId.MUSICSELECT_RAID_RAIDACTSELECT_RAIDMVP_PROFIL,
			TransitionUniqueId.HOME_RAID_RAIDREWARD_RAIDMVP_PROFIL,
			TransitionUniqueId.HOME_LOBBYMAIN_RAID_RAIDREWARD_RAIDMVP,
			TransitionUniqueId.HOME_LOBBYMAIN_RAID_RAIDREWARD_RAIDMVP_PROFIL,
			TransitionUniqueId.MUSICSELECT_RAID_RAIDREWARD_RAIDMVP,
			TransitionUniqueId.MUSICSELECT_RAID_RAIDREWARD_RAIDMVP_PROFIL,
			TransitionUniqueId.RESULT_RAIDMVP_PROFIL,
			TransitionUniqueId.DECO_FRIENDSEARCH,
			TransitionUniqueId.DECO_FRIENDSEARCH_PROFIL,
			TransitionUniqueId.MUSICSELECT_LOBBYGROUPSELECT_LOBBYGROUPSEARCH_PROFIL,
			TransitionUniqueId.DECO_LOBBYGROUPSELECT_LOBBYGROUPSEARCH_PROFIL,
			TransitionUniqueId.DECO_FRIENDSEARCH_PROFIL_LOBBYMAIN_PROFIL,
			TransitionUniqueId.EVENTGODIVA_GODIVATEAMSELECT_SCENESELECT

		}; // 0x28
		private List<TransitionList.Type> m_disableMenuBarScene = new List<TransitionList.Type>() {
			TransitionList.Type.TITLE,
			TransitionList.Type.LOGIN_BONUS,
			TransitionList.Type.RESULT,
			TransitionList.Type.SCENE_GROWTH,
			TransitionList.Type.SAVE_UNIT_DETAIL,
			TransitionList.Type.MODEL_VIEW_MODE,
			TransitionList.Type.COSTUME_SELECT,
			TransitionList.Type.VALKYRIE_SELECT,
			TransitionList.Type.COSTUME_VIEW_MODE,
			TransitionList.Type.UNLOCK_DIVA,
			TransitionList.Type.UNLOCK_COSTUME,
			TransitionList.Type.UNLOCK_VALKYRIE,
			TransitionList.Type.SIMULATIONLIVE_RESULT,
			TransitionList.Type.CAMPAIGN_ROULETTE,
			TransitionList.Type.GACHA_CHECK_NEW_COSTUME,
			TransitionList.Type.GACHA_CHECK_NEW_VALKYRIE,
			TransitionList.Type.EPISODE_APPEAL,
			TransitionList.Type.OFFER_FORMATION,
			TransitionList.Type.OFFER_TRANSFORMATION,
			TransitionList.Type.OFFER_VALKYRIESELECT,
			TransitionList.Type.OFFER_RESULT,
			TransitionList.Type.BINGO_SELECT,
			TransitionList.Type.BINGO_MISSION,
			TransitionList.Type.TEAM_SELECT,
			TransitionList.Type.SIMULATIONLIVE_SETTING,
			TransitionList.Type.LOBBY_MAIN,
			TransitionList.Type.LOBBY_MISSION,
			TransitionList.Type.LOBBY_GROUP_SELECT,
			TransitionList.Type.LOBBY_GROUP_SEARCH,
			TransitionList.Type.DECO,
			TransitionList.Type.DECO_BAST,
			TransitionList.Type.DECO_STAMP,
			TransitionList.Type.DECO_VISIT_LIST,
			TransitionList.Type.DECO_XAOS_STORE,
			TransitionList.Type.DECO_BAST_STORAGE,
			TransitionList.Type.RAID,
			TransitionList.Type.RAID_REWARD,
			TransitionList.Type.RAID_ACT_SELECT,
			TransitionList.Type.RAID_MCRS_CANNON,
			TransitionList.Type.VALKYRIE_TUNEUP,
			TransitionList.Type.LOBBY_MEMBER,
			TransitionList.Type.RAID_MVP,
			TransitionList.Type.HOME_BG_SELECT,
			TransitionList.Type.GODIVA_TEAM_SELECT,
			TransitionList.Type.GODIVA_SAVE_UNIT_DETAIL,
			TransitionList.Type.GAKUYA,
			TransitionList.Type.GAKUYA_DIVA_VIEW
		}; // 0x2C
		// private static readonly MenuButtonAnim.ButtonType[] ToButtonType = new MenuButtonAnim.ButtonType[7] { 6, 5, 4, 3, 2, 1, 0 }; // 0x0

		public MenuBarPrefab MenuBar { get { return m_menuBar; } } //0xED0D08

		// RVA: 0xED0D10 Offset: 0xED0D10 VA: 0xED0D10
		public MenuFooterControl(GameObject root)
		{
			m_root = root;
		}

		// // RVA: 0xED1F34 Offset: 0xED1F34 VA: 0xED1F34
		// public bool CheckDisableFooter(TransitionInfo info) { }

		// // RVA: 0xED20EC Offset: 0xED20EC VA: 0xED20EC
		public void Show(TransitionList.Type transitionName, TransitionUniqueId uniqueId, MenuButtonAnim.ButtonType selectedButton, bool isFading)
		{
			if(m_menuBar == null)
				return;
			
			int idx = m_disableMenuBarScene.FindIndex((TransitionList.Type x) => {
				//0xB2699C
				return x == transitionName;
			});
			if(idx < 0)
			{
				idx = m_disableMenuBarUniqueScene.FindIndex((TransitionUniqueId x) => {
					//0xB269B0
					return uniqueId == x;
				});
			}
			if(idx > -1)
			{
				m_menuBar.Leave(isFading);
				return;
			}
			m_menuBar.gameObject.SetActive(true);
			m_menuBar.transform.SetAsLastSibling();
			m_menuBar.Enter(isFading, selectedButton);

			UnityEngine.Debug.LogError("TODO footer Show");
		}

		// // RVA: 0xED2390 Offset: 0xED2390 VA: 0xED2390
		// public void Enter(bool isFading = False) { }

		// // RVA: 0xED2448 Offset: 0xED2448 VA: 0xED2448
		// public void Leave(bool isFading = False) { }

		// [IteratorStateMachineAttribute] // RVA: 0x6C75D4 Offset: 0x6C75D4 VA: 0x6C75D4
		// RVA: 0xED2500 Offset: 0xED2500 VA: 0xED2500
		public IEnumerator Load(Font font, UnityAction action)
		{
			//0xB269E8
			yield return MenuBarPrefab.Load(m_root.transform, font, (MenuBarPrefab instance) => {
				//0xED3528
				m_menuBar = instance;
			});
			m_buttons = m_menuBar.GetComponentsInChildren<LayoutUGUIHitOnly>(true);
			m_actionButtons = m_menuBar.GetComponentsInChildren<ActionButton>(true);
			m_menuBar.gameObject.SetActive(false);
			m_buttonBlockCount = new int[m_buttons.Length];
			if(action != null)
				action();
		}

		// // RVA: 0xED25BC Offset: 0xED25BC VA: 0xED25BC
		public void Initialize()
		{
			m_menuBar.Initialize();
		}

		// // RVA: 0xED25E4 Offset: 0xED25E4 VA: 0xED25E4
		// public void Release() { }

		// // RVA: 0xED25F8 Offset: 0xED25F8 VA: 0xED25F8
		// public bool IsPlaying() { }

		// // RVA: 0xED2620 Offset: 0xED2620 VA: 0xED2620
		public void SelectedButton(MenuButtonAnim.ButtonType buttonType)
		{
			m_menuBar.ChangeButtonSelect(buttonType);
		}

		// // RVA: 0xED2650 Offset: 0xED2650 VA: 0xED2650
		public void NotSelectButtonAll()
		{
			m_menuBar.ChangeNotSelectBaseButtonAll();
		}

		// // RVA: 0xED2678 Offset: 0xED2678 VA: 0xED2678
		// public void SetButtonDisable(MenuFooterControl.Button bit) { }

		// // RVA: 0xED2768 Offset: 0xED2768 VA: 0xED2768
		// public void SetButtonEnable(MenuFooterControl.Button bit) { }

		// // RVA: 0xED28D4 Offset: 0xED28D4 VA: 0xED28D4
		// public ButtonBase FindButton(MenuFooterControl.Button bit) { }

		// // RVA: 0xED29D4 Offset: 0xED29D4 VA: 0xED29D4
		// public void SetButtonNew(MenuFooterControl.Button bit, bool isNew) { }

		// // RVA: 0xED3160 Offset: 0xED3160 VA: 0xED3160
		// public void SetOfferUnlockRank() { }

		// // RVA: 0xED33D4 Offset: 0xED33D4 VA: 0xED33D4
		// public bool IsShow() { }
	}
}