using UnityEngine;
using System.Collections;

public class MoveBall : MonoBehaviour {

    private Rigidbody rigid;
    public float moveSpeed;
    Animator anim;
	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
	}


	
	// Update is called once per frame
	void Update()
    {
        AnimationControl();
    }    
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rigid.AddForce(movement*moveSpeed);
        Debug.Log("Move!");
    }

    void AnimationControl()
    {
        Debug.Log("Anim!");
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Rotate(new Vector3(0f, 0f, 0f));
        }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Rotate(new Vector3(0f, -90, 0f));
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Rotate(new Vector3(0f, 90, 0f));
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Rotate(new Vector3(0f, 180, 0f));
        }

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isMove", true);
        }
        anim.SetBool("isMove", false);
    }
}
