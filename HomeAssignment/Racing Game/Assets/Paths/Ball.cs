using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public List<Ball> neighbours;

	public Ball previous
	{
		get;
		set;
	}

	public float distance
	{
		get;
		set;
	}
