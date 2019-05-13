using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

	public GameObject cubePrefab;

	public Vector3 center;
	public Vector3 size;

    private float startTime;
    private float EPSILON = 0.1f;

	// Use this for initialization
	void Start () {
        startTime = Time.time;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(System.Math.Abs(Time.time - startTime - 1) < EPSILON)
        {

            SpawnCube();
            startTime = Time.time;
        }
	}

	public void SpawnCube()
	{
		Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x/2), Random.Range(-size.y / 2, size.y/2), 
			Random.Range(-size.z / 2, size.z/2));
		Instantiate (cubePrefab, pos, Quaternion.identity);
	}
		
	void onDrawGizmosSelected()
	{
		Gizmos.color = new Color (1, 0, 0);
		Gizmos.DrawCube (center, size);
	}

}
