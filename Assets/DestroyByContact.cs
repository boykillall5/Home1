using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

	//use this for initalization
	void Start() {
		
	}
	void OntriggerEnter(Collider other)
	{
		if (other.tag == "Boundary") {
			return;}
		Destroy (gameObject);//ลบตัวเอง
		Destroy (other.gameObject);// ลบของที่ชน
	}
}
