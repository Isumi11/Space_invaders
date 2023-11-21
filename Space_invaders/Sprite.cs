using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
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

        public Sprite(Vector2 spritePosition, Rectangle boundingBox, Color spriteColour)
        {
            _spritePosition = spritePosition;
            _spriteBox = boundingBox;
            _spriteColour = spriteColour;
        }
        public void LoadContent(ContentManager mycontent)
        {
            mycontent.RootDirectory = "Content";
            _spritetexture = mycontent.Load<Texture2D>("Placeholder");

        }
        public virtual void Update(GameTime gameTime)
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

