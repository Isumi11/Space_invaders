using Microsoft.Xna.Framework.Content;
using SharpDX.Direct3D11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_invaders.Content
{
    internal class Enemy
    {
        private Texture2D _enemyTexture;
        protected Vector2 _enemyposition;
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
        public void LoadContent(ContentManager mycontent, string textureName)
        {
            mycontent.RootDirectory = "Content";
            SpriteTexture = mycontent.Load<Texture2D>(textureName);

        }
    }
}
