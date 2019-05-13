using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Variable für den Spielerblock
	public Rigidbody rb;

	public float forwardForce = 2000f;	
	public float sidewaysForce = 300f;  

	// FixedUpdate, da man die Physics beeinflusst
	void FixedUpdate ()
	{
			// Bewegung nach vorne
			rb.AddForce(0, 0, forwardForce * Time.deltaTime);
		

		if (Input.GetKey("d"))	
		{
			//  Bewegung nach rechts
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey("a")) 
		{
			// Bewegung nach links
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (rb.position.y < -1f)
		{
			FindObjectOfType<GameManager>().EndGame();
			
		}
	}
}

