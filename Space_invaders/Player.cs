using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Space_invaders
{
    public class Player : Sprite
    {
        private int lives = 3;
        Vector2 position;
        Vector2 velocity;
        private int spriteXvalue;
        const int Black = 1, Blue = 2, Green = 3;
        int gameState;
        KeyboardState keyboard, prevkeyboard;
        Color backColour;

        public Player() : base()
        {

        }
        public Player(Vector2 spritePosition, Rectangle spriteBox, Color spriteColour)
            : base(spritePosition, spriteBox, spriteColour)
        {
            _spriteBox = spriteBox;
            _spriteColour = spriteColour;
            _spritePosition = spritePosition;
        }
        public void FireBullet()
        {

        }

        public override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                //left
                Position = new Vector2(Position.X - 3, Position.Y);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                //right
                Position = new Vector2(Position.X + 3, Position.Y);
            }

        }
      

    

        public int Lives
        {
            get { return lives; }
            set { lives = value; }

        }


    }
}
