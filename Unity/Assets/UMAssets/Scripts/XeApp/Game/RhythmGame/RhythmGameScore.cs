using System.Collections.Generic;
using XeApp.Game.Common;

namespace XeApp.Game.RhythmGame
{
	public class RhythmGameScore
	{
		private float musicLevelBonusRate; // 0x8
		private List<float> noteResultBonusRateList = new List<float>(); // 0xC
		private List<JANMKFAKHIC_ComboBonus> comboBonusDataList = new List<JANMKFAKHIC_ComboBonus>(); // 0x10
		private CEBFFLDKAEC_SecureInt totalComboCount_ = new CEBFFLDKAEC_SecureInt(); // 0x14
		private DDBNGDNJJHN_SecureFloat baseNoteScore_ = new DDBNGDNJJHN_SecureFloat(); // 0x18
		private LINJMMGGDKL_SecureInt2 currentScore_ = new LINJMMGGDKL_SecureInt2(); // 0x1C
		private LINJMMGGDKL_SecureInt2 nonExcellentScore_ = new LINJMMGGDKL_SecureInt2(); // 0x20
		private DDBNGDNJJHN_SecureFloat scoreNotesValue_ = new DDBNGDNJJHN_SecureFloat(); // 0x2C

		public int totalComboCount { get { return totalComboCount_.DNJEJEANJGL_Value; } private set { totalComboCount_.DNJEJEANJGL_Value = value; } } //0xBFDF2C 0xBFDF58
		public float baseNoteScore { get { return baseNoteScore_.DNJEJEANJGL_Value; } private set { baseNoteScore_.DNJEJEANJGL_Value = value; } } //0xBFDF8C 0xBFDFB8
		public int currentScore { get { return currentScore_.DNJEJEANJGL_Value; } private set { currentScore_.DNJEJEANJGL_Value = value; } } //0xBFDFEC 0xBFE018
		public int nonExcellentScore { get { return nonExcellentScore_.DNJEJEANJGL_Value; } private set { nonExcellentScore_.DNJEJEANJGL_Value = value; } } //0xBFE04C 0xBFE078
		public int musicLevel { get; private set; } // 0x24
		public ADDHLABEFKH musicLevelData { get; private set; } // 0x28
		public float scoreNotesValue { get { return scoreNotesValue_.DNJEJEANJGL_Value; } private set { scoreNotesValue_.DNJEJEANJGL_Value = value; } } //0xBFE0CC 0xBFE0F8

		//// RVA: 0xBFE12C Offset: 0xBFE12C VA: 0xBFE12C
		//public FENCAJJBLBH CheckFalisification() { }

		//// RVA: 0xBFE1B8 Offset: 0xBFE1B8 VA: 0xBFE1B8
		public void Initialize(MusicData musicData, int teamScoreBonusValue)
		{
			OKGLGHCBCJP_Database db = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database;
			GameSetupData setup = Database.Instance.gameSetup;
			short wavId = musicData.musicBase.KKPAHLMJKIH_WavId; // ENODDPDBIPA
			short variationId = musicData.musicBase.BKJGCEOEPFB_VariationId; // FNEBPBJBIIP
			Difficulty.Type diff = setup.musicInfo.difficultyType;
			bool line6 = setup.musicInfo.IsLine6Mode;
			if(setup.musicInfo.isStoryMode)
			{
				musicLevelData = db.IBPAFKKEKNK_Music.FLMLJIKBIMJ_GetStoryMusicData(setup.musicInfo.storyMusicId).COGKJBAFBKN[(int)diff];
			}
			else
			{
				musicLevelData = db.IBPAFKKEKNK_Music.NOBCLJIAMLC_GetFreeMusicData(setup.musicInfo.freeMusicId).EMJCHPDJHEI(line6, (int)diff);
			}
			totalComboCount = musicData.musicScoreData.CalcComboLimit();
			musicLevel = db.IBPAFKKEKNK_Music.ALJFMLEJEHH(wavId, variationId, (int)diff, line6, true).ANAJIAENLNB_F_pt;
			musicLevelBonusRate = db.HNMMJINNHII_Game.ADBELGIDIEN(musicLevel, line6) / 1000.0f;
			baseNoteScore = musicLevelBonusRate * teamScoreBonusValue / totalComboCount;
			scoreNotesValue = musicLevelBonusRate * teamScoreBonusValue / db.HNMMJINNHII_Game.GAHIBKLEDBF((int)diff, line6);
			currentScore = 0;
			nonExcellentScore = 0;
			noteResultBonusRateList.Clear();
			for(int i = 0; i < db.HNMMJINNHII_Game.PDNEMDIEGFB_JudgeCoef.Count; i++)
			{
				noteResultBonusRateList.Add(db.HNMMJINNHII_Game.PDNEMDIEGFB_JudgeCoef[i] / 100.0f);
			}
			comboBonusDataList = new List<JANMKFAKHIC_ComboBonus>(db.HNMMJINNHII_Game.KGHLOJNCFDO_ComboBonus);
		}

		//// RVA: 0xBFE9D4 Offset: 0xBFE9D4 VA: 0xBFE9D4
		public void Reset()
		{
			currentScore = 0;
			nonExcellentScore = 0;
		}

		//// RVA: 0xBFE9F8 Offset: 0xBFE9F8 VA: 0xBFE9F8
		//public void IncreaseScore(RhythmGameConsts.NoteResultEx a_result_ex, int combo, float bonusRate, int bonusValue, RhythmGameConsts.SpecialNoteType spType, float a_excellent_score_rate, bool a_enable_combo_bonus = True) { }

		//// RVA: 0xBFED3C Offset: 0xBFED3C VA: 0xBFED3C
		//public ResultScoreRank.Type CalcCurrentRank() { }

		//// RVA: 0xBFED74 Offset: 0xBFED74 VA: 0xBFED74
		//public float CalcRatioBetweenUpToNextRank() { }

		//// RVA: 0xBFED94 Offset: 0xBFED94 VA: 0xBFED94
		//public float CalcRatioBetweenUpToNextRank(ResultScoreRank.Type currentRank) { }
	}
}
