using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
	public List<Wheel> neighbours;

	public Wheel previous
	{
		get;
		set;
	}

	public float distance
	{
		get;
		set;
	}

