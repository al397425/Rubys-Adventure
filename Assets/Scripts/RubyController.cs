using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
<<<<<<< Updated upstream
   Rigidbody2D rigidbody2d;
=======
    public float speed = 3.0f;
    
    public int maxHealth = 5;
   
    
    public int health {  get { return currentHealth; }}
    int currentHealth;
    
    public float timeInvincible = 2.0f;
    bool isInvincible;
    float invincibleTimer;
    
    
    Rigidbody2D rigidbody2d;
>>>>>>> Stashed changes
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
<<<<<<< Updated upstream
=======

        currentHealth = maxHealth;
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector2 position = rigidbody2d.position;
        position.x = position.x + 3.0f* horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }
<<<<<<< Updated upstream
=======

    public void ChangeHealth(int amount)
    {
        if (amount < 0)
        {
            if (isInvincible)
                return;
            
            isInvincible = true;
            invincibleTimer = timeInvincible;
        }
        
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        
        Debug.Log(currentHealth + "/" + maxHealth);
    }
>>>>>>> Stashed changes
}
