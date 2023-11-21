using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX;

namespace Space_invaders.Content
{
    internal class Bullet
    {
        Vector2 _bulletPosition;
        Rectangle _bulletBox;
        Color _bulletColour;
        Texture2D _bulletTexture;

        public Bullet()
        { }

        public Bullet(Vector2 bulletPosition, Rectangle boundingBox, Color bulletColour, Texture2D bullettexture)
        {
            _bulletPosition = bulletPosition;
            _bulletBox = boundingBox;
            _bulletColour = bulletColour;
            _bulletTexture = bullettexture;
        }
        public void LoadContent(ContentManager mycontent)
        {

            bullettexture = mycontent.Load<Texture2D>("Bulletplaceholder");

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(bullettexture, Position, boundingBox, _bulletColour);
        }
        public Vector2 Position
        {
            get { return _bulletPosition; }
            set { _bulletPosition = value; }
        }
        public Rectangle BoundingBox
        {
            get { return _bulletBox; }
            set { _bulletBox = value; }

        }
    }
    
}
