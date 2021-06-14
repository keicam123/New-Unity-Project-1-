using UnityEngine;
using UnityEngine.Events;

public class CharacterController2D : MonoBehaviour
{
	[SerializeField] private float JumpForce = 400f;                          
	[Range(0, 1)] [SerializeField] private float CrouchSpeed = .36f;          
	[Range(0, .3f)] [SerializeField] private float MovementSmoothing = .05f;  
	[SerializeField] private bool AirControl = false;                         
	[SerializeField] private LayerMask Ground;                          
	[SerializeField] private Transform GroundCheck;                           
	[SerializeField] private Transform CeilingCheck;                          
	[SerializeField] private Collider2D CrouchDisable;                

	const float GroundedRadius = .2f; 
	private bool Grounded;            
	const float CeilingRadius = .2f; 
	private Rigidbody2D rb2D;
	private bool mRight = true;  
	private Vector3 Velocity = Vector3.zero;

	[Header("Events")]
	[Space]

	public UnityEvent OnLandEvent;

	[System.Serializable]
	public class BoolEvent : UnityEvent<bool> { }

	public BoolEvent OnCrouchEvent;
	private bool wasCrouching = false;

	private void Awake()
	{
		rb2D = GetComponent<Rigidbody2D>();

		if (OnLandEvent == null)
			OnLandEvent = new UnityEvent();

		if (OnCrouchEvent == null)
			OnCrouchEvent = new BoolEvent();
	}

	private void FixedUpdate()
	{
		bool wasGrounded = Grounded;
		Grounded = false;
		Collider2D[] colliders = Physics2D.OverlapCircleAll(GroundCheck.position, GroundedRadius, Ground);
		for (int i = 0; i < colliders.Length; i++)
		{
			if (colliders[i].gameObject != gameObject)
			{
				Grounded = true;
				if (!wasGrounded)
					OnLandEvent.Invoke();
			}
		}
	}
	public void Move(float move, bool crouch, bool jump)
	{
		if (!crouch)
		{
			if (Physics2D.OverlapCircle(CeilingCheck.position, CeilingRadius, Ground))
			{
				crouch = true;
			}
		}
		if (Grounded || AirControl)
		{
			if (crouch)
			{
				if (!wasCrouching)
				{
					wasCrouching = true;
					OnCrouchEvent.Invoke(true);
				}
				move *= CrouchSpeed;

				if (CrouchDisable != null)
					CrouchDisable.enabled = false;
			}
			else
			{
				if (CrouchDisable != null)
					CrouchDisable.enabled = true;

				if (wasCrouching)
				{
					wasCrouching = false;
					OnCrouchEvent.Invoke(false);
				}
			}
			Vector3 targetVelocity = new Vector2(move * 10f, rb2D.velocity.y);
			rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, targetVelocity, ref Velocity, MovementSmoothing);

			if (move > 0 && !mRight)
			{
				Flip();
			}
			else if (move < 0 && mRight)
			{
				Flip();
			}
		}
		if (Grounded && jump)
		{
			Grounded = false;
			rb2D.AddForce(new Vector2(0f, JumpForce));
		}
	}
	private void Flip()
	{
		mRight = !mRight;

		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
