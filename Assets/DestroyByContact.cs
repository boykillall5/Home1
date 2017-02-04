using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {
	public GameObject explosion;// ตัวแปรที่เก็บแสงระเบิด
	public GameObject playerExplosion;//ผลของแสกระเบิดของผู้เล่น
	//use this for initalization

		
	void OntriggerEnter(Collider other)
	{
		if (other.tag == "Boundary") 
		{
			return;
		Instantiate (explosion, transform.position, transform.rotation);


			if(other.tag == "Player")
			{
				Instantiate (playerExplosion,other.transform.position,other.transform.rotation);
			}
		}
		Destroy (gameObject);//ลบตัวเอง
		Destroy (other.gameObject);// ลบของที่ชน
	}
}
