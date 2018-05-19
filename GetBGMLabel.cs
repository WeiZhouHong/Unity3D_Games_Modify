using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace YgomGame.Duel
{
	// Token: 0x0200016C RID: 364
	public partial class Sound
	{
		// Token: 0x06000D45 RID: 3397 RVA: 0x00068500 File Offset: 0x00066700
		public static string GetBGMLabel()
		{
			Random rnd = new Random();
			string[] bgm = new string[]
			{
				"BGM_DUEL_04",
				"BGM_DUEL_05",
				"BGM_DUEL_06",
				"BGM_DUEL_07",
				"BGM_DUEL_08",
				"BGM_DUEL_09",
				"BGM_DUEL_10",
				"BGM_DUEL_13",
				"BGM_DUEL_19",
				"BGM_DUEL_TAG",
				"BGM_EV_ISLAND_MAIN"
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