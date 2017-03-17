using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour {

	void OntriggerExit(Collider other)
	{
		Destroy (other.gameObject);
	}
}
