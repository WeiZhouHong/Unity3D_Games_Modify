using System;

namespace YgomGame.Utility
{
	// Token: 0x02000582 RID: 1410
	public partial class SoundUtil
	{
		// Token: 0x06003421 RID: 13345
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
			string currentSeries = CharaUtil.currentSeries;
			return bgm[bgm_num];
		}
	}
}
