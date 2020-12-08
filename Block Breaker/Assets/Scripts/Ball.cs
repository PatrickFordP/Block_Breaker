using UnityEngine;

public class Ball : MonoBehaviour
{
    // config params
    [SerializeField] private Paddle paddle1;
    [SerializeField] private float xVelocity = 2f;
    [SerializeField] private float yVelocity = 15f;

    // state
    private Vector2 paddleToBallVector;
    private bool hasStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = transform.position - paddle1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if ( !hasStarted )
        {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
    }

    private void LaunchOnMouseClick()
    {
        if( Input.GetMouseButtonDown( 0 ) )
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2( xVelocity, yVelocity );
            hasStarted = true;
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePosition = new Vector2( paddle1.transform.position.x, paddle1.transform.position.y );
        transform.position = paddlePosition + paddleToBallVector;
    }
}
