using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Space_invaders
{
    public class Player : Sprite
    {
        private int lives = 3;

        public Player() : base()
        {
        }
        public Player(Texture2D spritetexture, Vector2 spritePosition, Rectangle spriteBox, Color spriteColour)
            : base(spritetexture, spritePosition, spriteBox, spriteColour)
        {
             _spriteBox = spriteBox;
            _spriteColour = spriteColour;
            _spritePosition = spritePosition;
            _spritetexture = spritetexture;
        }
        public void FireBullet()
        {
            
        }
        public override void update(GameTime gameTime)
        {

        }

        public int Lives
        {
            get { return lives; }
            set { lives = value; }
            
        }

    }
}
