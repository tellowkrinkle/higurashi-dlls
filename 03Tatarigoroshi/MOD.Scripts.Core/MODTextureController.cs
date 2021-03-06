using Assets.Scripts.Core;
using Assets.Scripts.Core.AssetManagement;
using Assets.Scripts.Core.Buriko;
using Assets.Scripts.Core.Scene;
using System.Collections.Generic;

namespace MOD.Scripts.Core
{
	public class MODTextureController
	{
		private IDictionary<int, string> _layerTexture;

		public MODTextureController()
		{
			Initialize();
		}

		public void Initialize()
		{
			_layerTexture = new Dictionary<int, string>();
		}

		public void StoreLayerTexture(int layer, string texture)
		{
			_layerTexture[layer] = texture;
		}

		public void RestoreTextures()
		{
			foreach (int key in _layerTexture.Keys)
			{
				string text = _layerTexture[key];
				Layer layer = GameSystem.Instance.SceneController.GetLayer(key);
				if (!string.IsNullOrEmpty(layer.PrimaryName))
				{
					if (BurikoMemory.Instance.GetGlobalFlag("GArtStyle").IntValue() == 0 && BurikoMemory.Instance.GetGlobalFlag("GLipSync").IntValue() == 1)
					{
						text = text.Substring(0, text.Length - 1) + "0";
					}
					layer.PrimaryName = text;
				}
			}
		}

		public void ToggleArtStyle()
		{
			AssetManager.Instance.UseNewArt = !AssetManager.Instance.UseNewArt;
			BurikoMemory.Instance.SetGlobalFlag("GArtStyle", AssetManager.Instance.UseNewArt ? 1 : 0);
			RestoreTextures();
			GameSystem.Instance.SceneController.ReloadAllImages();
		}
	}
}
