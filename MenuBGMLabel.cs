using System;

namespace YgomGame.Utility
{
	// Token: 0x02000734 RID: 1844
	public partial class SoundUtil
	{
		// Token: 0x0600366E RID: 13934
		public static string MenuBGMLabel()
		{
			Random rnd = new Random();
			string[] bgm = new string[]
			{
				"BGM_EV_ISLAND_MAIN",
				"BGM_EV_SGRK_MAIN",
				"BGM_EV_SGRK_TREASURE_STAGE",
				"BGM_EV_01",
				"BGM_EV_06",
				"BGM_EV_07",
				"BGM_MENU_GX",
				"BGM_MENU_MAIN",
				"BGM_IJGN_MENU"
			};
			int bgm_num = rnd.Next(0, bgm.Length);
			string result = bgm[bgm_num];
			string currentSeries = CharaUtil.currentSeries;
			if (currentSeries != null && currentSeries == "GX")
			{
				result = bgm[bgm_num];
			}
			return result;
		}
	}
}