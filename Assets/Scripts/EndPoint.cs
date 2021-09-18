using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
	private void Update()
	{
		float deltaDegree = 60 * Time.deltaTime;
		transform.Rotate(0, deltaDegree, 0, Space.World);
	}
}
