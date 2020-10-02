using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacBehavior : MonoBehaviour {

	public Rigidbody2D rb;
	public float vitesse;
	public float maxJump;
	public bool isGrounded = false;
	public bool Fell = false;
    private int state = 0;
    public Animator animator;
	public GameObject canvas;

	// Use this for initialization
	void Start () {
		SetVelocity(vitesse, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space") && isGrounded){
			Jump();
		}
		if (state == 2)
		{
			canvas.GetComponent<CanvasManager>().GameOver();
		}
	}

	void Jump() {
		rb.velocity += new Vector2(0, maxJump);
		isGrounded = false;
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.CompareTag("Ground")){
			isGrounded = true;
		}
	}

	void SetVelocity(float xVelocity, float yVelocity)
	{
		rb.velocity = new Vector2(0, 0);
		rb.velocity = new Vector2(xVelocity, yVelocity);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.CompareTag("Obstacle"))
		{
			StartCoroutine(ObstacleFind());
		}
	}

	IEnumerator ObstacleFind()
	{
		yield return new WaitForSeconds (0.1f);
		SetVelocity(vitesse/2, 0);
		state++;
		animator.SetInteger("State", state);
		yield return new WaitForSeconds (0.5f);
		state--;
		animator.SetInteger("State", state);
		SetVelocity(vitesse, 0);
	}
}
