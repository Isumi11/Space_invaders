using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Space_invaders
{
    public class Sprite
    {
        protected Texture2D _spritetexture;
        protected Vector2 _spritePosition;
        protected Rectangle _spriteBox;
        protected Color _spriteColour;

        public Sprite()
        { }

        public Sprite(Texture2D spritetexture, Vector2 spritePosition, Rectangle spriteBox, Color spriteColour)
        {
            _spritetexture = spritetexture;
            _spritePosition = spritePosition;
            _spriteBox = BoundingBox;
            _spriteColour = spriteColour;
        }
        public virtual void update(GameTime gameTime)
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_spritetexture, Position, _spriteColour);
        }
        public Vector2 Position
        {
            get { return _spritePosition; }
            set { _spritePosition = value; }
        }
        public Rectangle BoundingBox
        {
            get { return _spriteBox; }
            set { _spriteBox = value; }

        }
    }
}

