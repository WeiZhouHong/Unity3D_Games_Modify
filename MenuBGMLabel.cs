using System;

namespace YgomGame.Utility
{
	// Token: 0x02000546 RID: 1350
	public partial class SoundUtil
	{
		// Token: 0x06003054 RID: 12372 RVA: 0x0014BDBC File Offset: 0x0014A1BC
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
			string result = "BGM_MENU_MAIN";
			string currentSeries = CharaUtil.currentSeries;
			result = bgm[bgm_num];
			if (currentSeries != null)
			{
				if (currentSeries == "GX")
				{
					result = bgm[bgm_num];
				}
			}
			return result;
		}
	}
}
