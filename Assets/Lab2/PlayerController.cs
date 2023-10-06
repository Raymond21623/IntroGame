using System . Collections ;
using System . Collections . Generic ;
using UnityEngine ;
using UnityEngine . InputSystem ;

public class PlayerController : MonoBehaviour {

	public Vector2 moveValue;
	public float speed;

	void OnMove ( InputValue value ) {
		moveValue = value.Get<Vector2>() ;
		//Debug.Log("Moved" + movement);
	}

	void FixedUpdate () {
		Vector3 movement = new Vector3 ( moveValue.x , 0.0f , moveValue.y ) ;
		Debug.Log("Moved" + movement);
		GetComponent<Rigidbody>().AddForce ( movement * speed * Time.fixedDeltaTime ) ;
	}
}
