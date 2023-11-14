using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Drawing;

namespace Space_invaders
{
    public class Player : Sprite
    {
        private int lives = 3;
        private KeyboardState myKeyBoard;
        private bool gamePlaying;

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
        protected override void Initialize()
        {
            base.Initialize();
            position = new Vector2(graphics.GraphicsDevice.Viewport.
            Width / 2 - 64,
                                    graphics.GraphicsDevice.Viewport.
                                    Height / 2 - 64);
        }
        public override void update(GameTime gameTime)
        {
            //do movement using the keyboard
            KeyboardState state = Keyboard.GetState();

            if (state.IsKeyDown(Keys.Escape))
                Exit();
            if (state.IsKeyDown(Keys.Right))
                spritePosition.X += 10;
            if (state.IsKeyDown(Keys.Left))
                spritePosition.X -= 10;
            if (state.IsKeyDown(Keys.Up))
                PlayerP.Y -= 10;
            if (state.IsKeyDown(Keys.Down))
                spritePosition.Y += 10; 
            
            base.update(gameTime);




        }

        public int Lives
        {
            get { return lives; }
            set { lives = value; }
            
        }

    }
}
