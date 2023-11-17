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
        //protected override void Initialize()
        //{
        //    // TODO: Add your initialization logic here
        //    gameState = Black;
        //    backColour = Color.Black;

        //    base.Initialize();
        //}

        public override void update(GameTime gameTime)
        {
            keyboard = Keyboard.GetState();

            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                //left
                position.X -= 3;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                //right
                position.X += 3;
            }
            if (keyboard.IsKeyDown(Keys.H) && prevkeyboard.IsKeyUp(Keys.H))
            {
                if (gameState == Black)
                {
                    gameState = Green;
                    backColour = Color.LightGreen;
                }
                else if (gameState == Green)
                {
                    gameState = Blue;
                    backColour = Color.DarkBlue;
                }
                else
                {
                    gameState = Black;
                    backColour = Color.Black;
                }


            }
            prevkeyboard = keyboard;
        }

        public int Lives
        {
            get { return lives; }
            set { lives = value; }

        }


    }
}
