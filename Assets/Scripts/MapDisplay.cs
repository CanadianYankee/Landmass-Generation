﻿using UnityEngine;
using System.Collections;

public class MapDisplay : MonoBehaviour {

	public Renderer textureRenderer;

	public void DrawTexture(Texture2D texture)
	{
		int width = texture.width;
		int height = texture.height;

		textureRenderer.sharedMaterial.mainTexture = texture;
		textureRenderer.transform.localScale = new Vector3(width, 1, height);
	}
}