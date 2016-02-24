using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

    private int h;

	// Use this for initialization
	void Start () {
        Creature c = new Creature();
        h = c.Health;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
