using UnityEngine;
using System.Collections;

public class Hive1Behaviour : MonoBehaviour {
	public beeScore bee;

	public int value;
	// Use this for initialization
	void Start () {
		value = 0;
		bee = GameObject.FindGameObjectWithTag("Bee1").GetComponent<beeScore>();
	}

	// Update is called once per frame
	void Update () {



	}
	void OnTriggerStay(Collider other){
		if (other == GameObject.FindGameObjectWithTag("Bee1").GetComponent<SphereCollider>()) ;
		{
			if (bee.value > 0)
			{
				if (!bee.isEmpty)
				{
					value++;
					bee.value--;
					Debug.Log(value);
				}
			}

		}

	}
}
