using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpossumAI : MonoBehaviour
{
    public float speed;
    public float circleRadius;
    public int maxHealth;
    int currentHealth;
    private Rigidbody2D EnemyRB;
    public GameObject groundCheck;
    public LayerMask groundLayer;
    public bool facingRight;
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        EnemyRB = GetComponent<Rigidbody2D>();
        currentHealth=maxHealth;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        EnemyRB.velocity = Vector2.right * speed * Time.deltaTime;
        isGrounded = Physics2D.OverlapCircle(groundCheck.transform.position, circleRadius, groundLayer);
        if(!isGrounded && facingRight)
        {
            Flip();
        }
        else if(!isGrounded && !facingRight)
        {
            Flip();
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(new Vector3(0,180,0));
        speed = -speed;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(groundCheck.transform.position, circleRadius);
    }

    public void TakeDamage(int damage)
    {
        this.currentHealth -= damage;

        //Play hurt animation
        //animator.SetTrigger("Hurt");

        if (currentHealth <= 0)
        {
          //  Die();
        }
    }

    void Die()
    {
        //Die animation
        //animator.SetBool("IsDead", true);
        
        //GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        Destroy(this.gameObject);
        //this.enabled = false;
        //GetComponent<Enemy>().enabled = false;
    }


}
