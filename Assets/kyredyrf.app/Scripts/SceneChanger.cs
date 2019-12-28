using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	Coroutine _coroutine;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0)
		{
			if (_coroutine == null)
				_coroutine = StartCoroutine(ChangeSceneIterator());
		}
	}

	IEnumerator ChangeSceneIterator()
	{
        // 連続切り替え防止
		yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1) % SceneManager.sceneCount);
	}
}
