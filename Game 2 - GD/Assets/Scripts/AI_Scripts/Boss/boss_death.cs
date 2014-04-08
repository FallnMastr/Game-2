using UnityEngine;
using System.Collections;

public class boss_death : MonoBehaviour {

	public IEnumerator explode(Vector3 origin){
		Debug.Log ("BOOOOOOOM");
		Instantiate(Resources.Load("expl 3"), new Vector3(origin.x-1,origin.y-0,origin.z-0), gameObject.transform.rotation);
		Instantiate(Resources.Load("expl 3"), new Vector3(origin.x-3,origin.y+2,origin.z-0), gameObject.transform.rotation);
		Instantiate(Resources.Load("expl 3"), new Vector3(origin.x+2,origin.y-2,origin.z-0), gameObject.transform.rotation);
		Instantiate(Resources.Load("expl 3"), new Vector3(origin.x+4,origin.y-1,origin.z-0), gameObject.transform.rotation);
		yield return new WaitForSeconds (1);
		Instantiate(Resources.Load("expl 3"), new Vector3(origin.x-0,origin.y+3,origin.z-0), gameObject.transform.rotation);
		Instantiate(Resources.Load("expl 3"), new Vector3(origin.x-4,origin.y-0,origin.z-0), gameObject.transform.rotation);
		Instantiate(Resources.Load("expl 3"), new Vector3(origin.x+3,origin.y-1,origin.z-0), gameObject.transform.rotation);
		Instantiate(Resources.Load("expl 3"), new Vector3(origin.x-0,origin.y-2,origin.z-0), gameObject.transform.rotation);
		yield return new WaitForSeconds (1);
		Instantiate(Resources.Load("expl 3"), new Vector3(origin.x+2,origin.y+1,origin.z-0), gameObject.transform.rotation);
		Instantiate(Resources.Load("expl 3"), new Vector3(origin.x-1,origin.y-3,origin.z-0), gameObject.transform.rotation);
		Instantiate(Resources.Load("expl 3"), new Vector3(origin.x+4,origin.y+3,origin.z-0), gameObject.transform.rotation);
		Instantiate(Resources.Load("expl 3"), new Vector3(origin.x-3,origin.y-2,origin.z-0), gameObject.transform.rotation);


	}

}
