using Assets.Scripts.Core.Buriko;
using MOD.Scripts.Core;
using UnityEngine;

namespace Assets.Scripts.Core.State
{
	internal class StateNormal : IGameState
	{
		private GameSystem gameSystem;

		public StateNormal()
		{
			gameSystem = GameSystem.Instance;
		}

		public void RequestLeaveImmediate()
		{
		}

		public void RequestLeave()
		{
		}

		public void OnLeaveState()
		{
		}

		public void OnRestoreState()
		{
		}

		public bool InputHandler()
		{
			if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
			{
				if (!gameSystem.CanSkip)
				{
					return true;
				}
				gameSystem.IsSkipping = true;
				gameSystem.IsForceSkip = true;
				if (gameSystem.WaitList.Count > 0)
				{
					return true;
				}
				return true;
			}
			if (gameSystem.IsForceSkip)
			{
				gameSystem.IsSkipping = false;
				gameSystem.IsForceSkip = false;
			}
			if (Input.GetKeyDown(KeyCode.Space))
			{
				if (!gameSystem.MessageBoxVisible && gameSystem.GameState == GameState.Normal)
				{
					return false;
				}
				gameSystem.SwitchToViewMode();
				return false;
			}
			if (Input.GetAxis("Mouse ScrollWheel") > 0f || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.PageUp))
			{
				if (!gameSystem.MessageBoxVisible && gameSystem.GameState == GameState.Normal)
				{
					return false;
				}
				gameSystem.SwitchToHistoryScreen();
				return false;
			}
			if (Input.GetMouseButtonDown(0) || Input.GetAxis("Mouse ScrollWheel") < 0f || Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.PageDown) || Input.GetKeyDown(KeyCode.KeypadEnter))
			{
				if (gameSystem.IsSkipping)
				{
					gameSystem.IsSkipping = false;
				}
				if (gameSystem.IsAuto && !gameSystem.ClickDuringAuto)
				{
					gameSystem.IsAuto = false;
					if (gameSystem.WaitList.Exists((Wait a) => a.Type == WaitTypes.WaitForAuto))
					{
						gameSystem.AddWait(new Wait(0f, WaitTypes.WaitForInput, null));
					}
					return false;
				}
				if (UICamera.hoveredObject == gameSystem.SceneController.SceneCameras || UICamera.hoveredObject == null)
				{
					gameSystem.ClearWait();
				}
				return false;
			}
			if (!Input.GetMouseButtonDown(1) && !Input.GetKeyDown(KeyCode.Escape))
			{
				if (Input.GetKey(KeyCode.LeftShift))
				{
					if (Input.GetKeyDown(KeyCode.F10))
					{
						if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
						{
							return false;
						}
						if (!gameSystem.HasWaitOfType(WaitTypes.WaitForInput))
						{
							return false;
						}
						if (BurikoMemory.Instance.GetGlobalFlag("GMOD_DEBUG_MODE").IntValue() == 0)
						{
							return false;
						}
						if (BurikoMemory.Instance.GetGlobalFlag("GMOD_DEBUG_MODE").IntValue() == 1)
						{
							BurikoMemory.Instance.SetGlobalFlag("GMOD_DEBUG_MODE", 2);
							GameSystem.Instance.AudioController.PlaySystemSound("switchsound/enable.ogg");
							return true;
						}
						BurikoMemory.Instance.SetGlobalFlag("GMOD_DEBUG_MODE", 1);
						GameSystem.Instance.AudioController.PlaySystemSound("switchsound/disable.ogg");
						return true;
					}
					if (Input.GetKeyDown(KeyCode.F9))
					{
						if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
						{
							return false;
						}
						if (!gameSystem.HasWaitOfType(WaitTypes.WaitForInput))
						{
							return false;
						}
						int num = BurikoMemory.Instance.GetGlobalFlag("GMOD_SETTING_LOADER").IntValue();
						if (num < 3 && num >= 0)
						{
							num++;
							string str = num.ToString();
							string str2 = ".ogg";
							string filename = "switchsound/" + str + str2;
							GameSystem.Instance.AudioController.PlaySystemSound(filename);
							BurikoMemory.Instance.SetGlobalFlag("GMOD_SETTING_LOADER", num);
							return true;
						}
						num = 0;
						BurikoMemory.Instance.SetGlobalFlag("GMOD_SETTING_LOADER", num);
						GameSystem.Instance.AudioController.PlaySystemSound("switchsound/0.ogg");
					}
					if (Input.GetKeyDown(KeyCode.M))
					{
						if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
						{
							return false;
						}
						if (!gameSystem.HasWaitOfType(WaitTypes.WaitForInput))
						{
							return false;
						}
						int num2 = BurikoMemory.Instance.GetGlobalFlag("GVoiceVolume").IntValue();
						if (num2 == 100)
						{
							return true;
						}
						num2 = 100;
						float voiceVolume = (float)num2 / 100f;
						BurikoMemory.Instance.SetGlobalFlag("GVoiceVolume", num2);
						GameSystem.Instance.AudioController.VoiceVolume = voiceVolume;
						GameSystem.Instance.AudioController.RefreshLayerVolumes();
						return true;
					}
					if (Input.GetKeyDown(KeyCode.N))
					{
						if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
						{
							return false;
						}
						if (!gameSystem.HasWaitOfType(WaitTypes.WaitForInput))
						{
							return false;
						}
						if (BurikoMemory.Instance.GetGlobalFlag("GVoiceVolume").IntValue() == 0)
						{
							return true;
						}
						int num3 = 0;
						float voiceVolume2 = (float)num3 / 100f;
						BurikoMemory.Instance.SetGlobalFlag("GVoiceVolume", num3);
						GameSystem.Instance.AudioController.VoiceVolume = voiceVolume2;
						GameSystem.Instance.AudioController.RefreshLayerVolumes();
						return true;
					}
				}
				if (Input.GetKeyDown(KeyCode.F1))
				{
					if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
					{
						return false;
					}
					if (!gameSystem.HasWaitOfType(WaitTypes.WaitForInput))
					{
						return false;
					}
					if (BurikoMemory.Instance.GetFlag("NVL_in_ADV").IntValue() == 1)
					{
						return false;
					}
					GameSystem.Instance.MainUIController.MODResetLayerBackground();
				}
				if (Input.GetKeyDown(KeyCode.F2))
				{
					if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
					{
						return false;
					}
					if (!gameSystem.HasWaitOfType(WaitTypes.WaitForInput))
					{
						return false;
					}
					if (BurikoMemory.Instance.GetFlag("DisableModHotkey").IntValue() == 1)
					{
						return false;
					}
					int num4 = BurikoMemory.Instance.GetGlobalFlag("GCensor").IntValue();
					int num5 = BurikoMemory.Instance.GetGlobalFlag("GCensorMaxNum").IntValue();
					if (num4 < num5 && num4 >= 0)
					{
						num4++;
						string str3 = num4.ToString();
						string str4 = ".ogg";
						string filename2 = "switchsound/" + str3 + str4;
						GameSystem.Instance.AudioController.PlaySystemSound(filename2);
						BurikoMemory.Instance.SetGlobalFlag("GCensor", num4);
						return true;
					}
					num4 = 0;
					BurikoMemory.Instance.SetGlobalFlag("GCensor", num4);
					GameSystem.Instance.AudioController.PlaySystemSound("switchsound/0.ogg");
				}
				if (Input.GetKeyDown(KeyCode.F3))
				{
					if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
					{
						return false;
					}
					if (!gameSystem.HasWaitOfType(WaitTypes.WaitForInput))
					{
						return false;
					}
					if (BurikoMemory.Instance.GetFlag("DisableModHotkey").IntValue() == 1)
					{
						return false;
					}
					int num6 = BurikoMemory.Instance.GetGlobalFlag("GEffectExtend").IntValue();
					int num7 = BurikoMemory.Instance.GetGlobalFlag("GEffectExtendMaxNum").IntValue();
					if (num6 < num7 && num6 >= 0)
					{
						num6++;
						string str5 = num6.ToString();
						string str6 = ".ogg";
						string filename3 = "switchsound/" + str5 + str6;
						GameSystem.Instance.AudioController.PlaySystemSound(filename3);
						BurikoMemory.Instance.SetGlobalFlag("GEffectExtend", num6);
						return true;
					}
					num6 = 0;
					BurikoMemory.Instance.SetGlobalFlag("GEffectExtend", num6);
					GameSystem.Instance.AudioController.PlaySystemSound("switchsound/0.ogg");
				}
				if (Input.GetKeyDown(KeyCode.F5))
				{
					if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
					{
						return false;
					}
					if (!gameSystem.HasWaitOfType(WaitTypes.WaitForInput))
					{
						return false;
					}
					if (!gameSystem.CanSave)
					{
						return false;
					}
					BurikoScriptSystem.Instance.SaveQuickSave();
					GameSystem.Instance.AudioController.PlaySystemSound("switchsound/enable.ogg");
				}
				if (Input.GetKeyDown(KeyCode.F7))
				{
					if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
					{
						return false;
					}
					if (!gameSystem.HasWaitOfType(WaitTypes.WaitForInput))
					{
						return false;
					}
					if (!gameSystem.CanLoad)
					{
						return false;
					}
					BurikoScriptSystem.Instance.LoadQuickSave();
				}
				if (Input.GetKeyDown(KeyCode.F10))
				{
					if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
					{
						return false;
					}
					if (!gameSystem.HasWaitOfType(WaitTypes.WaitForInput))
					{
						return false;
					}
					if (BurikoMemory.Instance.GetGlobalFlag("GMOD_DEBUG_MODE").IntValue() != 1 && BurikoMemory.Instance.GetGlobalFlag("GMOD_DEBUG_MODE").IntValue() != 2)
					{
						if (BurikoMemory.Instance.GetGlobalFlag("GFlagMonitor").IntValue() == 0)
						{
							BurikoMemory.Instance.SetGlobalFlag("GFlagMonitor", 1);
							return true;
						}
						if (BurikoMemory.Instance.GetGlobalFlag("GFlagMonitor").IntValue() == 1)
						{
							BurikoMemory.Instance.SetGlobalFlag("GFlagMonitor", 2);
							return true;
						}
						BurikoMemory.Instance.SetGlobalFlag("GFlagMonitor", 0);
						return true;
					}
					int num8 = BurikoMemory.Instance.GetGlobalFlag("GFlagMonitor").IntValue();
					if (num8 < 4)
					{
						num8++;
						BurikoMemory.Instance.SetGlobalFlag("GFlagMonitor", num8);
						return true;
					}
					if (num8 >= 4 || num8 < 0)
					{
						BurikoMemory.Instance.SetGlobalFlag("GFlagMonitor", 0);
						return true;
					}
				}
				if (Input.GetKeyDown(KeyCode.Alpha0))
				{
					if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
					{
						return false;
					}
					if (!gameSystem.HasWaitOfType(WaitTypes.WaitForInput))
					{
						return false;
					}
					if (BurikoMemory.Instance.GetGlobalFlag("GMOD_DEBUG_MODE").IntValue() == 1 || BurikoMemory.Instance.GetGlobalFlag("GMOD_DEBUG_MODE").IntValue() == 2)
					{
						GameSystem.Instance.MainUIController.MODDebugFontSizeChanger();
					}
				}
				if (Input.GetKeyDown(KeyCode.Alpha1))
				{
					if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
					{
						return false;
					}
					if (!gameSystem.HasWaitOfType(WaitTypes.WaitForInput))
					{
						return false;
					}
					if (BurikoMemory.Instance.GetFlag("DisableModHotkey").IntValue() == 1)
					{
						return false;
					}
					if (BurikoMemory.Instance.GetGlobalFlag("GAltBGM").IntValue() == 1)
					{
						BurikoMemory.Instance.SetGlobalFlag("GAltBGM", 0);
						GameSystem.Instance.AudioController.PlaySystemSound("switchsound/disable.ogg");
						return true;
					}
					BurikoMemory.Instance.SetGlobalFlag("GAltBGM", 1);
					GameSystem.Instance.AudioController.PlaySystemSound("switchsound/enable.ogg");
				}
				if (Input.GetKeyDown(KeyCode.Alpha2))
				{
					if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
					{
						return false;
					}
					if (!gameSystem.HasWaitOfType(WaitTypes.WaitForInput))
					{
						return false;
					}
					if (BurikoMemory.Instance.GetFlag("DisableModHotkey").IntValue() == 1)
					{
						return false;
					}
					int num9 = BurikoMemory.Instance.GetGlobalFlag("GAltBGMflow").IntValue();
					int num10 = BurikoMemory.Instance.GetGlobalFlag("GAltBGMflowMaxNum").IntValue();
					if (num9 < num10 && num9 >= 0)
					{
						num9++;
						string str7 = num9.ToString();
						string str8 = ".ogg";
						string filename4 = "switchsound/" + str7 + str8;
						GameSystem.Instance.AudioController.PlaySystemSound(filename4);
						BurikoMemory.Instance.SetGlobalFlag("GAltBGMflow", num9);
						return true;
					}
					num9 = 0;
					BurikoMemory.Instance.SetGlobalFlag("GAltBGMflow", num9);
					GameSystem.Instance.AudioController.PlaySystemSound("switchsound/0.ogg");
				}
				if (Input.GetKeyDown(KeyCode.Alpha3))
				{
					if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
					{
						return false;
					}
					if (!gameSystem.HasWaitOfType(WaitTypes.WaitForInput))
					{
						return false;
					}
					if (BurikoMemory.Instance.GetFlag("DisableModHotkey").IntValue() == 1)
					{
						return false;
					}
					if (BurikoMemory.Instance.GetGlobalFlag("GAltSE").IntValue() == 1)
					{
						BurikoMemory.Instance.SetGlobalFlag("GAltSE", 0);
						GameSystem.Instance.AudioController.PlaySystemSound("switchsound/disable.ogg");
						return true;
					}
					BurikoMemory.Instance.SetGlobalFlag("GAltSE", 1);
					GameSystem.Instance.AudioController.PlaySystemSound("switchsound/enable.ogg");
				}
				if (Input.GetKeyDown(KeyCode.Alpha4))
				{
					if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
					{
						return false;
					}
					if (!gameSystem.HasWaitOfType(WaitTypes.WaitForInput))
					{
						return false;
					}
					if (BurikoMemory.Instance.GetFlag("DisableModHotkey").IntValue() == 1)
					{
						return false;
					}
					int num11 = BurikoMemory.Instance.GetGlobalFlag("GAltSEflow").IntValue();
					int num12 = BurikoMemory.Instance.GetGlobalFlag("GAltSEflowMaxNum").IntValue();
					if (num11 < num12 && num11 >= 0)
					{
						num11++;
						string str9 = num11.ToString();
						string str10 = ".ogg";
						string filename5 = "switchsound/" + str9 + str10;
						GameSystem.Instance.AudioController.PlaySystemSound(filename5);
						BurikoMemory.Instance.SetGlobalFlag("GAltSEflow", num11);
						return true;
					}
					num11 = 0;
					BurikoMemory.Instance.SetGlobalFlag("GAltSEflow", num11);
					GameSystem.Instance.AudioController.PlaySystemSound("switchsound/0.ogg");
				}
				if (Input.GetKeyDown(KeyCode.Alpha5))
				{
					if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
					{
						return false;
					}
					if (!gameSystem.HasWaitOfType(WaitTypes.WaitForInput))
					{
						return false;
					}
					if (BurikoMemory.Instance.GetFlag("DisableModHotkey").IntValue() == 1)
					{
						return false;
					}
					if (BurikoMemory.Instance.GetGlobalFlag("GAltVoice").IntValue() == 1)
					{
						BurikoMemory.Instance.SetGlobalFlag("GAltVoice", 0);
						GameSystem.Instance.AudioController.PlaySystemSound("switchsound/disable.ogg");
						return true;
					}
					BurikoMemory.Instance.SetGlobalFlag("GAltVoice", 1);
					GameSystem.Instance.AudioController.PlaySystemSound("switchsound/enable.ogg");
				}
				if (Input.GetKeyDown(KeyCode.Alpha6))
				{
					if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
					{
						return false;
					}
					if (!gameSystem.HasWaitOfType(WaitTypes.WaitForInput))
					{
						return false;
					}
					if (BurikoMemory.Instance.GetFlag("DisableModHotkey").IntValue() == 1)
					{
						return false;
					}
					if (BurikoMemory.Instance.GetGlobalFlag("GAltVoicePriority").IntValue() == 1)
					{
						BurikoMemory.Instance.SetGlobalFlag("GAltVoicePriority", 0);
						GameSystem.Instance.AudioController.PlaySystemSound("switchsound/disable.ogg");
						return true;
					}
					BurikoMemory.Instance.SetGlobalFlag("GAltVoicePriority", 1);
					GameSystem.Instance.AudioController.PlaySystemSound("switchsound/enable.ogg");
				}
				if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
				{
					if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
					{
						return false;
					}
					if (!gameSystem.HasWaitOfType(WaitTypes.WaitForInput))
					{
						return false;
					}
					if (BurikoMemory.Instance.GetFlag("DisableModHotkey").IntValue() == 1)
					{
						return false;
					}
					if (BurikoMemory.Instance.GetGlobalFlag("GLipSync").IntValue() == 1)
					{
						BurikoMemory.Instance.SetGlobalFlag("GLipSync", 0);
						GameSystem.Instance.AudioController.PlaySystemSound("switchsound/disable.ogg");
						return true;
					}
					BurikoMemory.Instance.SetGlobalFlag("GLipSync", 1);
					GameSystem.Instance.AudioController.PlaySystemSound("switchsound/enable.ogg");
					return false;
				}
				if (Input.GetKeyDown(KeyCode.M))
				{
					if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
					{
						return false;
					}
					if (!gameSystem.HasWaitOfType(WaitTypes.WaitForInput))
					{
						return false;
					}
					int num13 = BurikoMemory.Instance.GetGlobalFlag("GVoiceVolume").IntValue();
					if (num13 == 100)
					{
						return true;
					}
					num13 = ((num13 > 95 || num13 < 0) ? 50 : (num13 + 5));
					float voiceVolume3 = (float)num13 / 100f;
					BurikoMemory.Instance.SetGlobalFlag("GVoiceVolume", num13);
					GameSystem.Instance.AudioController.VoiceVolume = voiceVolume3;
					GameSystem.Instance.AudioController.RefreshLayerVolumes();
					return true;
				}
				if (!Input.GetKeyDown(KeyCode.N))
				{
					if (Input.GetKeyDown(KeyCode.A))
					{
						gameSystem.IsAuto = !gameSystem.IsAuto;
						if (gameSystem.IsAuto)
						{
							return true;
						}
						if (gameSystem.WaitList.Exists((Wait a) => a.Type == WaitTypes.WaitForAuto))
						{
							gameSystem.AddWait(new Wait(0f, WaitTypes.WaitForInput, null));
						}
					}
					if (Input.GetKeyDown(KeyCode.S))
					{
						gameSystem.IsSkipping = !gameSystem.IsSkipping;
					}
					if (Input.GetKeyDown(KeyCode.F))
					{
						if (Screen.fullScreen)
						{
							int num14 = PlayerPrefs.GetInt("width");
							int num15 = PlayerPrefs.GetInt("height");
							if (num14 == 0 || num15 == 0)
							{
								num14 = 640;
								num15 = 480;
							}
							Screen.SetResolution(num14, num15, fullscreen: false);
						}
						else
						{
							GameSystem.Instance.GoFullscreen();
						}
					}
					if (Input.GetKeyDown(KeyCode.L))
					{
						if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
						{
							return false;
						}
						if (!gameSystem.HasWaitOfType(WaitTypes.WaitForText))
						{
							GameSystem.Instance.UseEnglishText = !GameSystem.Instance.UseEnglishText;
							int val = 0;
							if (gameSystem.UseEnglishText)
							{
								val = 1;
							}
							gameSystem.TextController.SwapLanguages();
							BurikoMemory.Instance.SetGlobalFlag("GLanguage", val);
						}
					}
					if (Input.GetKeyDown(KeyCode.P))
					{
						if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
						{
							return false;
						}
						if (!gameSystem.HasWaitOfType(WaitTypes.WaitForInput))
						{
							return false;
						}
						MODSystem.instance.modTextureController.ToggleArtStyle();
					}
					return true;
				}
				if (!gameSystem.MessageBoxVisible || gameSystem.IsAuto || gameSystem.IsSkipping || gameSystem.IsForceSkip)
				{
					return false;
				}
				if (!gameSystem.HasWaitOfType(WaitTypes.WaitForInput))
				{
					return false;
				}
				int num16 = BurikoMemory.Instance.GetGlobalFlag("GVoiceVolume").IntValue();
				if (num16 == 0)
				{
					return true;
				}
				num16 = ((num16 < 5 || num16 > 100) ? 50 : (num16 - 5));
				float voiceVolume4 = (float)num16 / 100f;
				BurikoMemory.Instance.SetGlobalFlag("GVoiceVolume", num16);
				GameSystem.Instance.AudioController.VoiceVolume = voiceVolume4;
				GameSystem.Instance.AudioController.RefreshLayerVolumes();
				return true;
			}
			if (!gameSystem.MessageBoxVisible && gameSystem.GameState == GameState.Normal)
			{
				return false;
			}
			if (gameSystem.IsAuto && gameSystem.ClickDuringAuto)
			{
				gameSystem.IsAuto = false;
				if (gameSystem.WaitList.Exists((Wait a) => a.Type == WaitTypes.WaitForAuto))
				{
					gameSystem.AddWait(new Wait(0f, WaitTypes.WaitForInput, null));
				}
				return false;
			}
			if (gameSystem.RightClickMenu)
			{
				gameSystem.SwitchToRightClickMenu();
			}
			else
			{
				gameSystem.SwitchToHiddenWindow2();
			}
			return false;
		}

		public GameState GetStateType()
		{
			return GameState.Normal;
		}
	}
}
