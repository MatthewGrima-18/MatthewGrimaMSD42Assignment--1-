using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSplat : MonoBehaviour
{
	public List<WaterSplat> neighbours;

	public WaterSplat previous
	{
		get;
		set;
	}

	public float distance
	{
		get;
		set;
	}