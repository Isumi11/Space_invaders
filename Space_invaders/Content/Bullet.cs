using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Space_invaders.Content
{
    internal class Bullet : Sprite
    {
        Vector2 _bulletPosition;
        Rectangle _bulletBox;
        private Sprite _ownerSprite;
        private bool _isDrawn;

        public Bullet() : base()
        {

        }
        
        public Bullet(Vector2 inPosition, Rectangle boundingBox, Color Colour, bool isDrawn, Sprite ownerSprite)
            : base(inPosition, boundingBox, Colour)
        {
            _bulletPosition = inPosition;
            _bulletBox = boundingBox;
            _ownerSprite = ownerSprite;
            _isDrawn = isDrawn;
            _spriteColour = Colour;
        }

        public void PositionBullet()
        {
            int halfway = _ownerSprite.SpriteTexture.Width / 2;
            int topOfSprite = _ownerSprite.SpriteTexture.Height;

           // Position = new Vector2(_ownerSprite.Position.X / 2, SpriteTexture.Width / 2, _ownerSprite.Position.Y);

            Position = new Vector2(_ownerSprite.Position.X / 2 + SpriteTexture.Width / 2,_ownerSprite.Position.Y);
        }

    }
    
}
