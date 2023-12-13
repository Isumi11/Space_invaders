using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Space_invaders.Content;
namespace Space_invaders.Content
{
    internal class Enemy : Sprite
    {
        private Texture2D _enemyTexture;
        protected Vector2 _enemyposition;
        protected Rectangle _enemyBox;
        protected Color _enemyColour;
        public Enemy()
        { }

        public Enemy(Vector2 enemyposition, Rectangle boundingBox, Color enemyColour)
        {
            _enemyposition = enemyposition;
            _enemyBox = boundingBox;
            _enemyColour = enemyColour;
        }
       
    }
}
