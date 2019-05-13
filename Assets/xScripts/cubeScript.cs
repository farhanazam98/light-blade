using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour {

	public float speed = 1.0f;
	public Vector3 target;
    public AudioSource aSource;
    public AudioClip aClip;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		float step =  speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target, step);
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);

		if (Vector3.Distance(transform.position, target) < 0.001f)
		{
            // remove object
            Destroy(gameObject);
		}
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("lightblade"))
        {
            aSource.PlayOneShot(aClip);
            Destroy(gameObject);
        }
    }
}
