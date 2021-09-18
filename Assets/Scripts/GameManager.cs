using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public ItemBox[] itemBoxes;
	public bool isGameOver = false;
	public GameObject gameOverUI;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			SceneManager.LoadScene("MainScene");
		}

		if (isGameOver)
		{
			gameOverUI.SetActive(true);
		}

		int overlapedCount = 0;

		for (int i = 0; i < itemBoxes.Length; ++i)
		{
			if (itemBoxes[i].isOverlaped)
			{
				++overlapedCount;
			}
		}

		if (overlapedCount == itemBoxes.Length)
		{
			isGameOver = true;
		}
	}
}
