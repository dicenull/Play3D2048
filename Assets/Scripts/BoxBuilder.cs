using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBuilder : MonoBehaviour
{

	private void Start()
	{
		var box = Resources.Load<GameObject>("Box");
		var areaBox = Resources.Load<GameObject>("AreaBox");
		

		var vec = new[] { -1, 0, 1 };
		var scale = 2f;

		var length = vec.Length + (scale / 2) * (vec.Length - 1);
		var areaBoxObj = Instantiate(areaBox, Vector3.zero, Quaternion.identity, transform);

		areaBoxObj.transform.localScale = Vector3.one * length;

		foreach(var x in vec)
		{
			foreach(var y in vec)
			{
				foreach(var z in vec)
				{
					var pos = new Vector3(x, y, z) * scale;

					Instantiate(box, pos, Quaternion.identity, transform);
				}
			}
		}
	}
	
}