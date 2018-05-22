using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace YgomGame.Duel
{
	// Token: 0x0200016C RID: 364
	public partial class Sound
	{
		// Token: 0x06000D46 RID: 3398 RVA: 0x00068538 File Offset: 0x00066738
		public static string GetClimaxBGMLabel(int player)
		{
			Random rnd = new Random();
			string[] bgm = new string[]
			{
				"BGM_DUEL_13",
				"BGM_DUEL_18",
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
