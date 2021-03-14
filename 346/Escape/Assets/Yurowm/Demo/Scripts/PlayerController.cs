using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour
{

	public Transform rightGunBone;
	public Transform leftGunBone;
	public List<Arsenal> arsenal;

	private Animator animator;

	void Awake()
	{
		animator = GetComponent<Animator>();
		if (arsenal.Count > 0)
			SetArsenal(arsenal[0].name);
	}

	public void SetArsenal(string name)
	{

		var weapon = arsenal.Find(w => w.name == name);

		if (weapon.name != name)
			return;

		//Destory the old weapon
		if (rightGunBone.childCount > 0)
			Destroy(rightGunBone.GetChild(0).gameObject);

		//create a new one
		if (weapon.rightGun != null)
		{
			GameObject newRightGun = (GameObject)Instantiate(weapon.rightGun);
			newRightGun.transform.parent = rightGunBone;
			newRightGun.transform.localPosition = Vector3.zero;
			newRightGun.transform.localRotation = Quaternion.Euler(90, 0, 0);
		}

		//set animator
		animator.runtimeAnimatorController = weapon.controller;
	}

	[System.Serializable]
	public struct Arsenal
	{
		public string name;
		public GameObject rightGun;
		public GameObject leftGun;
		public RuntimeAnimatorController controller;
	}
}
