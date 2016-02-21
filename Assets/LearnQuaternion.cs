using UnityEngine;
using System.Collections;

public class LearnQuaternion : MonoBehaviour {
    public Transform target;


    public Transform from;
    public Transform to;
    public float speed = 0.1f;
    public Quaternion qrotation = Quaternion.Euler(0, 30, 0);
	// Update is called once per frame
	void Update () {
        //Vector3 relativePos = target.position - transform.position;
        //Quaternion rotation = Quaternion.LookRotation(relativePos);
        //transform.rotation = rotation;

        //tra ve gia tri rotation chenh lech giua 2 vat the
        //float angle = Quaternion.Angle(transform.rotation, target.rotation);
        //Debug.Log("Angle = " + angle);

        // xoay vat the theo 1 goc dat truoc
        //transform.rotation = qrotation;

        //quay vat the tu goc' from --> goc' to  voi' toc' do. dat truoc
        //transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, speed * Time.time);

        //deo hieu
        //transform.rotation = Quaternion.FromToRotation(transform.up, transform.right);

        //dieu chinh rotation ve default 0 0 0
        //transform.rotation = Quaternion.identity;
        //Debug.Log("Quaternion identity = " + Quaternion.identity);

        
	}
}
