using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromAtoB : MonoBehaviour
{
    public GameObject A;
    public GameObject B;
    public GameObject Enemy;
    private Vector3 velocity;
    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Enemy.transform.position = A.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = B.transform.position - Enemy.transform.position;
        float magnitude = direction.magnitude;
        Vector3 norm_direction = direction.normalized;
        velocity = norm_direction * speed;
        Enemy.transform.position += velocity * Time.deltaTime;
        if (magnitude < velocity.magnitude * Time.deltaTime)
        {
            Enemy.transform.position = A.transform.position;
        }
        float angle = Mathf.Atan2(velocity.y, velocity.x);
        Enemy.transform.localEulerAngles = new Vector3(0, 0, angle * Mathf.Rad2Deg);
    }
}
