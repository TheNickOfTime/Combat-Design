﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroy : MonoBehaviour
{
	public float timer = 0;

	private void Start()
	{
		Destroy(gameObject, timer);
	}
}
