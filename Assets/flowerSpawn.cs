using UnityEngine;
using System.Collections;

public class flowerSpawn : MonoBehaviour {
    public int spawnType;
    public GameObject flower1;
    public GameObject flower2;
    public GameObject flower3;
    public int dFlower;
    // Use this for initialization
    void Start () {
        for (int i = 0; i < 5; i++) {
            Vector3 b = new Vector3(Random.Range(-4.0F, 4.0F)*i, 0.0F, Random.Range(-5.0F, 3.0F)*i);
            float a = Random.Range(0.0F,1.0F);
            Debug.Log(a);
            GameObject flower;
            if (a < 0.3)
            {
                flower = Instantiate(flower1, b, Quaternion.identity) as GameObject;
                
            }
            else if (a < 0.8)
            {
                flower = Instantiate(flower2, b, Quaternion.identity) as GameObject;
            }
            else {
                flower = Instantiate(flower3, b, Quaternion.identity) as GameObject;
                
            }
        }
        dFlower = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
        if (dFlower > 0) {
            Vector3 b = new Vector3(Random.Range(-4.0F, 4.0F) *2, 0.0F, Random.Range(-5.0F, 3.0F) * 3);
            float a = Random.Range(0.0F, 1.0F);
            Debug.Log(a);
            GameObject flower;
            if (a < 0.3)
            {
                flower = Instantiate(flower1, b, Quaternion.identity) as GameObject;

            }
            else if (a < 0.8)
            {
                flower = Instantiate(flower2, b, Quaternion.identity) as GameObject;
            }
            else
            {
                flower = Instantiate(flower3, b, Quaternion.identity) as GameObject;

            }
            dFlower--;

        }
	}
}
