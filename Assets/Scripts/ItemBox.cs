using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
	private MeshRenderer renderer;
	public bool isOverlaped = false;
	private Color originalColor;
	public Color changedColor = Color.white;

	private void Start()
	{
		renderer = GetComponent<MeshRenderer>();
		originalColor = renderer.material.color;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "EndPoint")
		{
			isOverlaped = true;
			renderer.material.color = changedColor;
		}
	}

	private void OnTriggerStay(Collider other)
	{
		if (other.tag == "EndPoint")
		{
			isOverlaped = true;
			renderer.material.color = changedColor;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "EndPoint")
		{
			isOverlaped = false;
			renderer.material.color = originalColor;
		}
	}
}
