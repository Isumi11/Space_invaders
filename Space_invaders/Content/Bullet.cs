﻿
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Space_invaders.Content
{
    public class Bullet : Sprite
    {
        Vector2 _bulletPosition;
        Rectangle _bulletBox;
        private Sprite _ownerSprite;
        private bool _isDrawn;
        private bool bulletFired;

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

        public void ResetToOwner(Sprite ownerSprite)
        {
            Position = new Vector2(ownerSprite.Position.X + ownerSprite.SpriteTexture.Width / 2 - SpriteTexture.Width / 2,
                ownerSprite.Position.Y);
        }

        // public void ResetToOwner(Sprite owner)
        public override void Update(GameTime gameTime, bool gamestarted, int rightedge)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {

                bulletFired = true;
            }
            if (Position.Y <= 0)
            {
                bulletFired = false;
                ResetToOwner(Owner);
            }
            if (Position.Y > 0 && bulletFired) 
            {
                Position=new Vector2(Position.X,Position.Y-2);
            }
            if(Position.Y > 0 && !bulletFired)
            {
                Position = new Vector2(
                    Owner.Position.X + (Owner.SpriteTexture.Width / 2 - SpriteTexture.Width/2), Position.Y);
            }

            base.Update(gameTime, gamestarted, rightedge);
        }
        public Sprite Owner
        {
            get { return _ownerSprite; }
            set { _ownerSprite = value; }
        }


        //public void PositionBullet()
        //{
        //    int halfway = _ownerSprite.SpriteTexture.Width / 2;
        //    int topOfSprite = _ownerSprite.SpriteTexture.Height;

        //    Position = new Vector2(_ownerSprite.Position.X / 2, SpriteTexture.Width / 2, _ownerSprite.Position.Y);

        //    Position = new Vector2(_ownerSprite.Position.X / 2 + SpriteTexture.Width / 2,_ownerSprite.Position.Y);
        //}

    }

}
