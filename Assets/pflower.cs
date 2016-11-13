using UnityEngine;
using System.Collections;

public class pflower : MonoBehaviour {
	public beeScore bee;
	public beeScore bee1;
	public int value;
	public bool dead;
	public flowerSpawn df;
	// Use this for initialization
	void Start () {
		value = 40;
		bee = GameObject.FindGameObjectWithTag("Bee").GetComponent<beeScore>();
		bee1 = GameObject.FindGameObjectWithTag("Bee1").GetComponent<beeScore>();
		df = GameObject.FindGameObjectWithTag("Spawner").GetComponent<flowerSpawn>();
		dead = false;
	}

	// Update is called once per frame
	void Update () {
		if (value <= 0) {
			dead = true;
		}
		if (dead) {
			df.dFlower++;
			Destroy(this.gameObject);
		}


	}
	void OnTriggerStay(Collider other)
	{
		if (other == GameObject.FindGameObjectWithTag("Bee").GetComponent<SphereCollider>()) 
		{
			if (bee.value < 50) {
				if (!bee.isFull) {
					value--;
					bee.value++;
				}
			}
		}
		if (other == GameObject.FindGameObjectWithTag("Bee1").GetComponent<SphereCollider>()) 
		{
			if (bee1.value < 50) {
				if (!bee1.isFull) {
					value--;
					bee1.value++;
				}
			}
		}

    }
}
