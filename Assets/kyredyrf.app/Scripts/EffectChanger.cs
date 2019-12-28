using UnityEngine;

public class EffectChanger : MonoBehaviour
{
	[SerializeField] Camera _camera;
	[SerializeField] RenderTexture[] _effects;

	int _count = 0;

	void LateUpdate()
	{
		var index = _count++ % _effects.Length;
		_camera.targetTexture = _effects[index];
	}
}
