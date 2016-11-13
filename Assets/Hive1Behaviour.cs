using UnityEngine;
using System.Collections;

public class Hive1Behaviour : MonoBehaviour {
	public beeScore bee1;

	public int value;
	// Use this for initialization
	void Start () {
		value = 0;
		bee1 = GameObject.FindGameObjectWithTag("Bee1").GetComponent<beeScore>();
	}

	// Update is called once per frame
	void Update () {



	}
	void OnTriggerStay(Collider other){
		if (other == GameObject.FindGameObjectWithTag("Bee1").GetComponent<SphereCollider>()) 
		{
			if (bee1.value > 0)
			{
				if (!bee1.isEmpty)
				{
					value++;
					bee1.value--;
					Debug.Log(value);
				}
			}

		}

	}
}
