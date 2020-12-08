using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float screenWidthInUnits = 16f;
    [SerializeField] private float minXPosition = 1f;
    [SerializeField] private float maxXPosition = 15f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var mouseXPositionInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePosition = new Vector2( transform.position.x, transform.position.y );
        paddlePosition.x = Mathf.Clamp( mouseXPositionInUnits, minXPosition, maxXPosition );
        transform.position = paddlePosition;
    }
}
