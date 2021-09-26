using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class AnimatedSprite : MonoBehaviour
{

    public SpriteRenderer spriteRenderer { get; private set; } //Possible to reference other sprites
    public Sprite[] sprites; //Array of sprites

    public float animationTime = 0.25f; //Time between each sprite

    public int animationFrame { get; private set;  } //Index of time

    public bool loop = true;

    private void Awake()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(Advance), this.animationTime, this.animationTime);
    }

    private void Advance()
    {
        if (!this.spriteRenderer.enabled)
        {
            return;
        }
        this.animationFrame++;

        if (this.animationFrame >= this.sprites.Length && this.loop) {
            this.animationFrame = 0;
        }

        if(this.animationFrame >= 0 && this.animationFrame < this.sprites.Length) {
            this.spriteRenderer.sprite = this.sprites[this.animationFrame];
        }
    }

    public void Restart() //Restarting the animation
    {
        this.animationFrame = -1;

        Advance();
    }
}

