using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace YgomGame.Duel
{
	// Token: 0x0200010F RID: 271
	public partial class Sound
	{
		// Token: 0x06000CEC RID: 3308 RVA: 0x000479C8 File Offset: 0x00045DC8
		public static string GetClimaxBGMLabel(int player)
		{
			Random rnd = new Random();
			string[] bgm = new string[]
			{
				"BGM_DUEL_04",
				"BGM_DUEL_13",
				"BGM_DUEL_18",
				"BGM_DUEL_19",
				"BGM_DUEL_20",
				"BGM_DUEL_CMX01",
				"BGM_DUEL_CMX02",
				"BGM_DUEL_CMX03"
			};
			int bgm_num = rnd.Next(0, bgm.Length);
			string result = "BGM_DUEL_CMX03";
			result = bgm[bgm_num];
			return result;
		}
	}
}
