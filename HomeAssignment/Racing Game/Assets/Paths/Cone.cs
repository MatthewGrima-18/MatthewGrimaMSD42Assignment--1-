using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cone : MonoBehaviour
{
	public List<Cone> neighbours;

	public Cone previous
	{
		get;
		set;
	}

	public float distance
	{
		get;
		set;
	}
