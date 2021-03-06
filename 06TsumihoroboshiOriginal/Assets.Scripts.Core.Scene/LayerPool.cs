using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Core.Scene
{
	public class LayerPool : MonoBehaviour
	{
		public int PoolSize;

		public SceneController SceneController;

		private Stack<GameObject> layerList = new Stack<GameObject>();

		private List<GameObject> layerObjList = new List<GameObject>();

		private bool isInitialized;

		public Layer ActivateLayer()
		{
			if (!isInitialized)
			{
				Initialize();
			}
			GameObject gameObject = layerList.Pop();
			GameObject activePanel = SceneController.GetActivePanel();
			gameObject.transform.parent = activePanel.transform;
			gameObject.transform.localPosition = new Vector3(0f, 0f, 0f);
			gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			Layer component = gameObject.GetComponent<Layer>();
			gameObject.SetActive(value: true);
			layerObjList.Remove(gameObject);
			return component;
		}

		public void ReturnLayer(Layer layer)
		{
			GameObject gameObject = layer.gameObject;
			gameObject.transform.parent = base.transform;
			gameObject.layer = LayerMask.NameToLayer("NotRendered");
			gameObject.SetActive(value: false);
			layerList.Push(gameObject);
			layerObjList.Add(gameObject);
		}

		public bool IsInPool(GameObject layer)
		{
			return layerObjList.Exists((GameObject a) => a == layer);
		}

		private void Initialize()
		{
			GameObject original = Resources.Load<GameObject>("Layer");
			int num = 0;
			while (true)
			{
				if (num >= PoolSize)
				{
					return;
				}
				GameObject gameObject = UnityEngine.Object.Instantiate(original);
				if (gameObject == null)
				{
					break;
				}
				gameObject.transform.parent = base.transform;
				gameObject.SetActive(value: false);
				layerList.Push(gameObject);
				layerObjList.Add(gameObject);
				num++;
			}
			throw new Exception("Failed to instantiate Layer prefab!");
		}
	}
}
