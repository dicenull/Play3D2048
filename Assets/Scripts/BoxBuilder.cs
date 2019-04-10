using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBuilder : MonoBehaviour
{
	private GameObject box;

	private void Start()
	{
		box = Resources.Load<GameObject>("Box");

		var vec = new[] { -1, 0, 1 };
		foreach(var x in vec)
		{
			foreach(var y in vec)
			{
				foreach(var z in vec)
				{
					var pos = new Vector3(x, y, z) * 2;

					Instantiate(box, pos, Quaternion.identity, transform);
				}
			}
		}
	}
	
}