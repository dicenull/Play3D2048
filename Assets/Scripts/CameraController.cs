using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	[SerializeField]
	private GameObject lookingObj;

	[SerializeField]
	private float speed = 3.0f;

	private void Update()
	{
		var x = Input.GetAxis("Mouse X");
		var y = Input.GetAxis("Mouse Y");

		transform.RotateAround(lookingObj.transform.position, Vector3.up, x);
		transform.RotateAround(lookingObj.transform.position, Vector3.right, y);
	}
}
