using UnityEngine;
using UnityEngine.UI;

public class ChestScripts : MonoBehaviour
{
    public PotionScript Potion;
    public Sprite SpriteButton;
    public CoinScript Coin;

    private void Start()
    {
        
    }
    private void Update()
    {
        //UseChest();
        
    }

    private void UseChest()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Potion.Potion += Random.Range(5, 9);
            Coin.Coin += Random.Range(5, 15);
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        
        if(other.gameObject.tag == "Player")
        {
            
            UseChest();
        }
    }
}
