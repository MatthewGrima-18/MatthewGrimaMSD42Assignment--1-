using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
	public List<Rock> neighbours;

	public Rock previous
	{
		get;
		set;
	}

	public float distance
	{
		get;
		set;
	}
