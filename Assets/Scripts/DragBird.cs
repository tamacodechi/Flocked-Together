using UnityEngine;

public class DragBird : MonoBehaviour
{
    public GameObject birdObject;
    public bool isDraggingAllowed = true;
    public AudioSource birdSound;
    private bool dragging = false;
    private bool hasCollided = false;
    private Vector3 offset;
    private Vector3 startPosition;

    // Cache the starting position in case the user loses the bird out of bounds while dragging
    void Start()
    {
        startPosition = transform.position;
    }

    // If the time not paused, and dragging is allowed (i.e: While no other screen is on top)
    // the bird's position will be updated to where the mouse currently is
    void Update()
    {
        if (Time.timeScale == 0)
        {
            isDraggingAllowed = false;
            dragging = false;
        }
        else
        {
            isDraggingAllowed = true;
        }

        if (!isDraggingAllowed)
            return;

        if (dragging)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
    }

    // If the bird touches a wall, cache the 'hasCollided' flag
    void OnCollisionEnter2D(Collision2D collision)
    {
        var collisionTag = collision.gameObject.tag;

        if (collisionTag == "Wall")
        {
            hasCollided = true;
        }
    }

    // If, while the user is still dragging, the bird stops touching a wall, turn the 'hasCollided' flag off
    void OnCollisionExit2D(Collision2D collision)
    {
        var collisionTag = collision.gameObject.tag;

        if (collisionTag == "Wall")
        {
            hasCollided = false;
        }
    }

    // Drag the bird with the mouse and play a chirp noise
    private void OnMouseDown()
    {
        if (isDraggingAllowed)
        {
            birdSound.PlayOneShot(birdSound.clip);
            offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            dragging = true;
        }
    }

    // If the user has stopped dragging the bird and they recently touched a wall,
    // the bird will be considered stuck and it will reset to its starting position
    private void OnMouseUp()
    {
        if (hasCollided && isDraggingAllowed)
        {
            transform.position = startPosition;
            hasCollided = false;
        }
        dragging = false;
    }
}
