using UnityEngine;

public class ObjectBehaviour : MonoBehaviour
{
	void Update()
	{
		transform.rotation *= Quaternion.Euler(0.97f/2, 1.99f/2, 2.93f/2);
	}
}
