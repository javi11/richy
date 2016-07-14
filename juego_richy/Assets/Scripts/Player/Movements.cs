using UnityEngine;
using System.Collections;

public class Movements : MonoBehaviour
{

    public Transform foot; //pie
    public Transform head; //cabeza
    public LayerMask floor; //piso
    public LayerMask water;

    public bool isDuck = false;
    public bool inFloor = false;
    public bool isSwimming = false;

    private const float FOOT_RADIOUS = 0.08f;
    private const float HEAD_RADIOUS = 0.2f;
    private const float SPEED_X = 5;
    private const float JUMP_POWER = 18f;
    private const float SWIMMING_POWER = 30f;

    private int jumpCounter = 5;
    private int swimCounter = 5;

    private Vector2 initialColliderOffset;

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;
        initialColliderOffset = gameObject.GetComponent<BoxCollider2D>().offset;
    }

    void duck()
    {
        bool ground = Physics2D.OverlapCircle(foot.position, FOOT_RADIOUS, floor);
        bool roof = Physics2D.OverlapCircle(head.position, HEAD_RADIOUS, floor);


        if (!isSwimming && Input.GetKey("down"))
        {
            if (!isDuck)
            {
                gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(-0.023f, 0.27f);
                isDuck = true;
            }
        }
        else if ((!ground && !roof) || (ground && !roof))
        {
            gameObject.GetComponent<BoxCollider2D>().offset = initialColliderOffset;
            isDuck = false;

        }
    }

    void moveX()
    {
        float inputX = Input.GetAxis("Horizontal");
        float mySpeed = gameObject.GetComponent<Rigidbody2D>().velocity.y;

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(inputX * SPEED_X, mySpeed, 0);
    }

    void jump()
    {
        inFloor = Physics2D.OverlapCircle(foot.position, FOOT_RADIOUS, floor);
        bool falling = (inFloor == false && jumpCounter > 0 && gameObject.GetComponent<Rigidbody2D>().velocity.y > 0);

        if (Input.GetKey("up"))
        {
            if (inFloor)
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, 0);
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, JUMP_POWER * jumpCounter));
            }
            else if (falling)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, JUMP_POWER * jumpCounter));
                jumpCounter = jumpCounter - 1;
            }

        }
        else if (inFloor)
        {
            jumpCounter = 5;
        }
    }

    void swimming()
    {
        bool inWater = Physics2D.OverlapCircle(foot.position, FOOT_RADIOUS, water);
        if (inWater)
        {
            isSwimming = true;
            if (Input.GetKey("up"))
            {
                //instrucciones
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, 0);
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, SWIMMING_POWER * swimCounter));
            }
        }
        else
        {
            swimCounter = 5;
            isSwimming = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        this.swimming();
        this.duck();
        this.jump();
        this.moveX();

    }
}
