using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XeApp.Game.Common;

namespace XeApp.Game.Menu
{
	public class PopPassController : MonoBehaviour
	{
		public enum Result
		{
			None = 0,
			Buy = 1,
			Close = 2,
			Error = 3,
		}
		
		public Result m_result; // 0xC
		public bool m_open_window; // 0x10
		public NHPDPKHMFEP.GGNEBJEIFCP m_plan; // 0x14
		public PopPassListWin m_layout_window; // 0x18
		public PopPassPurchaseConfirmationPopup m_layout_popup; // 0x1C
		private List<ActionButton> m_list_btn = new List<ActionButton>(); // 0x20
		private List<ScrollRect> m_list_scroll = new List<ScrollRect>(); // 0x24

		// RVA: 0xDE6FF8 Offset: 0xDE6FF8 VA: 0xDE6FF8
		public void OnDestroy()
		{
			DestroyLayout();
		}

		//[IteratorStateMachineAttribute] // RVA: 0x6FFA2C Offset: 0x6FFA2C VA: 0x6FFA2C
		//// RVA: 0xDE71A0 Offset: 0xDE71A0 VA: 0xDE71A0
		//public IEnumerator CoroutineOpen() { }

		// RVA: 0xDE6FFC Offset: 0xDE6FFC VA: 0xDE6FFC
		public void DestroyLayout()
		{
			if(m_layout_popup != null)
			{
				Destroy(m_layout_popup.gameObject);
				m_layout_popup = null;
			}
			if(m_layout_window != null)
			{
				Destroy(m_layout_window.gameObject);
				m_layout_window = null;
			}
		}

		//[IteratorStateMachineAttribute] // RVA: 0x6FFAA4 Offset: 0x6FFAA4 VA: 0x6FFAA4
		//// RVA: 0xDE724C Offset: 0xDE724C VA: 0xDE724C
		//private IEnumerator Co_LoadLayout(Transform a_transform) { }

		//[IteratorStateMachineAttribute] // RVA: 0x6FFB1C Offset: 0x6FFB1C VA: 0x6FFB1C
		//// RVA: 0xDE7314 Offset: 0xDE7314 VA: 0xDE7314
		//private IEnumerator Co_CheckBuyPopupOpen(Action a_buy, Action a_error, Action a_close, Action a_cancelClose) { }

		//[IteratorStateMachineAttribute] // RVA: 0x6FFB94 Offset: 0x6FFB94 VA: 0x6FFB94
		//// RVA: 0xDE7428 Offset: 0xDE7428 VA: 0xDE7428
		//private IEnumerator Co_GotoHomePopupOpen() { }

		//[IteratorStateMachineAttribute] // RVA: 0x6FFC0C Offset: 0x6FFC0C VA: 0x6FFC0C
		//// RVA: 0xDE74BC Offset: 0xDE74BC VA: 0xDE74BC
		//private IEnumerator Co_StoreErrorPopupOpen() { }

		//// RVA: 0xDE7550 Offset: 0xDE7550 VA: 0xDE7550
		//private void EnableButton(bool a_enable) { }

		//// RVA: 0xDE76D4 Offset: 0xDE76D4 VA: 0xDE76D4
		//private void CB_Law1() { }

		//// RVA: 0xDE7848 Offset: 0xDE7848 VA: 0xDE7848
		//private void CB_Law2() { }

		//// RVA: 0xDE79BC Offset: 0xDE79BC VA: 0xDE79BC
		//private void CB_Close() { }

		//// RVA: 0xDE7A20 Offset: 0xDE7A20 VA: 0xDE7A20
		//private void CB_CheckBuy() { }

		//// RVA: 0xDE7BB0 Offset: 0xDE7BB0 VA: 0xDE7BB0
		//private void CB_Agre() { }

		//// RVA: 0xDE7D3C Offset: 0xDE7D3C VA: 0xDE7D3C
		//private void CB_Bonus(bool forceAvailableTopplan) { }

		//// RVA: 0xDE7EAC Offset: 0xDE7EAC VA: 0xDE7EAC
		//private void CB_Detail() { }

		//// RVA: 0xDE806C Offset: 0xDE806C VA: 0xDE806C
		//private void CB_Contract() { }

		//// RVA: 0xDE81E0 Offset: 0xDE81E0 VA: 0xDE81E0
		//private void CB_Privacy() { }

		//[CompilerGeneratedAttribute] // RVA: 0x6FFC84 Offset: 0x6FFC84 VA: 0x6FFC84
		//// RVA: 0xDE8414 Offset: 0xDE8414 VA: 0xDE8414
		//private void <CB_Law1>b__16_0() { }

		//[CompilerGeneratedAttribute] // RVA: 0x6FFC94 Offset: 0x6FFC94 VA: 0x6FFC94
		//// RVA: 0xDE841C Offset: 0xDE841C VA: 0xDE841C
		//private void <CB_Law1>b__16_1() { }

		//[CompilerGeneratedAttribute] // RVA: 0x6FFCA4 Offset: 0x6FFCA4 VA: 0x6FFCA4
		//// RVA: 0xDE8428 Offset: 0xDE8428 VA: 0xDE8428
		//private void <CB_Law2>b__17_0() { }

		//[CompilerGeneratedAttribute] // RVA: 0x6FFCB4 Offset: 0x6FFCB4 VA: 0x6FFCB4
		//// RVA: 0xDE8430 Offset: 0xDE8430 VA: 0xDE8430
		//private void <CB_Law2>b__17_1() { }

		//[CompilerGeneratedAttribute] // RVA: 0x6FFCC4 Offset: 0x6FFCC4 VA: 0x6FFCC4
		//// RVA: 0xDE843C Offset: 0xDE843C VA: 0xDE843C
		//private void <CB_CheckBuy>b__19_0() { }

		//[CompilerGeneratedAttribute] // RVA: 0x6FFCD4 Offset: 0x6FFCD4 VA: 0x6FFCD4
		//// RVA: 0xDE8448 Offset: 0xDE8448 VA: 0xDE8448
		//private void <CB_CheckBuy>b__19_1() { }

		//[CompilerGeneratedAttribute] // RVA: 0x6FFCE4 Offset: 0x6FFCE4 VA: 0x6FFCE4
		//// RVA: 0xDE8454 Offset: 0xDE8454 VA: 0xDE8454
		//private void <CB_CheckBuy>b__19_2() { }

		//[CompilerGeneratedAttribute] // RVA: 0x6FFCF4 Offset: 0x6FFCF4 VA: 0x6FFCF4
		//// RVA: 0xDE845C Offset: 0xDE845C VA: 0xDE845C
		//private void <CB_CheckBuy>b__19_3() { }

		//[CompilerGeneratedAttribute] // RVA: 0x6FFD04 Offset: 0x6FFD04 VA: 0x6FFD04
		//// RVA: 0xDE8468 Offset: 0xDE8468 VA: 0xDE8468
		//private void <CB_Agre>b__20_0() { }

		//[CompilerGeneratedAttribute] // RVA: 0x6FFD14 Offset: 0x6FFD14 VA: 0x6FFD14
		//// RVA: 0xDE8470 Offset: 0xDE8470 VA: 0xDE8470
		//private void <CB_Agre>b__20_1() { }

		//[CompilerGeneratedAttribute] // RVA: 0x6FFD24 Offset: 0x6FFD24 VA: 0x6FFD24
		//// RVA: 0xDE847C Offset: 0xDE847C VA: 0xDE847C
		//private void <CB_Bonus>b__21_0(bool received) { }

		//[CompilerGeneratedAttribute] // RVA: 0x6FFD34 Offset: 0x6FFD34 VA: 0x6FFD34
		//// RVA: 0xDE8484 Offset: 0xDE8484 VA: 0xDE8484
		//private void <CB_Detail>b__22_0() { }

		//[CompilerGeneratedAttribute] // RVA: 0x6FFD44 Offset: 0x6FFD44 VA: 0x6FFD44
		//// RVA: 0xDE848C Offset: 0xDE848C VA: 0xDE848C
		//private void <CB_Contract>b__23_0() { }

		//[CompilerGeneratedAttribute] // RVA: 0x6FFD54 Offset: 0x6FFD54 VA: 0x6FFD54
		//// RVA: 0xDE8494 Offset: 0xDE8494 VA: 0xDE8494
		//private void <CB_Contract>b__23_1() { }

		//[CompilerGeneratedAttribute] // RVA: 0x6FFD64 Offset: 0x6FFD64 VA: 0x6FFD64
		//// RVA: 0xDE84A0 Offset: 0xDE84A0 VA: 0xDE84A0
		//private void <CB_Privacy>b__24_0() { }

		//[CompilerGeneratedAttribute] // RVA: 0x6FFD74 Offset: 0x6FFD74 VA: 0x6FFD74
		//// RVA: 0xDE84A8 Offset: 0xDE84A8 VA: 0xDE84A8
		//private void <CB_Privacy>b__24_1() { }
	}
}
