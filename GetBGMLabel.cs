using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace YgomGame.Duel
{
	// Token: 0x0200010F RID: 271
	public partial class Sound
	{
		// Token: 0x06000CEB RID: 3307
		public static string GetBGMLabel()
		{
			Random rnd = new Random();
			string[] bgm = new string[]
			{
				"BGM_DUEL_01a",
				"BGM_DUEL_02",
				"BGM_DUEL_03",
				"BGM_DUEL_04",
				"BGM_DUEL_05",
				"BGM_DUEL_06",
				"BGM_DUEL_07",
				"BGM_DUEL_08",
				"BGM_DUEL_09",
				"BGM_DUEL_10",
				"BGM_DUEL_11",
				"BGM_DUEL_12",
				"BGM_DUEL_13",
				"BGM_DUEL_14",
				"BGM_DUEL_16",
				"BGM_DUEL_17",
				"BGM_DUEL_18",
				"BGM_DUEL_19",
				"BGM_DUEL_20",
				"BGM_DUEL_TAG"
			};
			if (Util.GetTutorialNO() == 1)
			{
				return null;
			}
			int bgm_num = rnd.Next(0, bgm.Length);
			string result = bgm[bgm_num];
			if (Sound.s_work != null)
			{
				result = bgm[bgm_num];
			}
			return result;
		}
	}
}
