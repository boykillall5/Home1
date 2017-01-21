using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Boundary
{
	public float xMin,xMax,zMin,zMax;	
}	

public class playerController : MonoBehaviour {
	private Rigidbody rb;
	public float speed;
	public float titl;//องศาการเอียงยาน

	public GameObject shot;//แทนกระสุน
	public Transform shotSpawn;//แทนตำแหน่ง

	public float fireRate;//รั้งเวลาการยิง
	private float nextFire;//เวลาที่ยิ่งครั้งต่อไปได้

	public Boundary _boundary;



	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		float MoveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (MoveHorizontal,0.0f, moveVertical);
		rb.velocity = movement * speed;


		//กำหนดจุดแกน x y z  ที่สามารถเป็นได้ 
		rb.position = new Vector3 (
			Mathf.Clamp(rb.position.x,_boundary.xMin,_boundary.xMax),//x 
			0.0f,//y
			Mathf.Clamp(rb.position.z,_boundary.zMin,_boundary.zMax)//z
		);

		rb.rotation = Quaternion.Euler(0.0f,0.0f,rb.velocity.x*-titl);


	}
	void Updete()
	{
		if (Input.GetButton ("Fire1")&& Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		}
	}

}
