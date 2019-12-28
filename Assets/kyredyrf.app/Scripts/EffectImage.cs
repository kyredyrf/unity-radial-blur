using UnityEngine;
using UnityEngine.UI;

public class EffectImage : RawImage
{
	[SerializeField] Texture[] _textures;

	int _count = 0;

	void LateUpdate()
	{
		texture = _textures[_count++ % _textures.Length];
	}
}
