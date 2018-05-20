using System;
using System.Collections.Generic;

namespace YgomSystem.Utility
{
	// Token: 0x02000986 RID: 2438
	public partial class Locale
	{
		// Token: 0x060048CB RID: 18635 RVA: 0x001AFC20 File Offset: 0x001ADE20
		public static void setup()
		{
			if (Locale.supportedLanguages == null)
			{
				List<object> listByJsonPath = ClientWork.getListByJsonPath("Server.langs", null);
				List<object> listByJsonPath2 = ClientWork.getListByJsonPath("Server.voices", null);
				if (listByJsonPath != null)
				{
					Locale.supportedLanguages = new List<string>{"ja-JP"};;
					Locale.supportedReadableLanguages = new List<string>
					{
						"日語介面卡圖(Japanese)"
					};
					Locale.setupLang(listByJsonPath, Locale.supportedLanguages, Locale.supportedReadableLanguages);
				}
				if (listByJsonPath2 != null)
				{
					Locale.supportedVoices = new List<string>{"ja-JP"};
					Locale.supportedReadableVoices = new List<string>
					{
						"日本語音(Japanese)"
					};
					Locale.setupLang(listByJsonPath2, Locale.supportedVoices, Locale.supportedReadableVoices);
				}
				if (Locale.supportedLanguages == null || Locale.supportedLanguages.Count == 0)
				{
					Locale.supportedLanguages = new List<string>
					{
						"en-US"
					};
					Locale.supportedReadableLanguages = new List<string>
					{
						"English"
					};
				}
				if (Locale.supportedVoices == null || Locale.supportedVoices.Count == 0)
				{
					Locale.supportedVoices = new List<string>
					{
						string.Empty
					};
					Locale.supportedReadableVoices = new List<string>
					{
						"----"
					};
				}
			}
		}
	}
}
