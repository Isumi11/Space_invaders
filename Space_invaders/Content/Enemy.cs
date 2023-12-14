using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Space_invaders.Content;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Space_invaders.Content
{
    internal class Enemy : Sprite
    {
        private Texture2D _enemyTexture;
        protected Vector2 _enemyposition;
        protected Rectangle _enemyBox;
        protected Color _enemyColour;
        
       

        public bool IsDrawn { get; internal set; }

        public Enemy()
        { }

        public Enemy(Texture2D enemyTexture, Vector2 enemyposition, Rectangle boundingBox, Color enemyColour)
        {
            _enemyposition = enemyposition;
            _enemyBox = boundingBox;
            _enemyColour = enemyColour;
            _enemyTexture = enemyTexture;
             
        }

        public Enemy(Vector2 spritePosition, Rectangle boundingBox, Color spriteColour) : base(spritePosition, boundingBox, spriteColour)
        {
        }

        public class enemyColour
        {
            public static readonly enemyColour Black = new(0, 0, 0);
            public static readonly enemyColour White = new(255, 255, 255);
            public static readonly enemyColour Red = new(255, 0, 0);
            public static readonly enemyColour Green = new(0, 255, 0);
            public static readonly enemyColour Blue = new(6, 5, 255);

            public byte R;
            public byte G;
            public byte B;

            public enemyColour(byte r, byte g, byte b)
            {
                R = r;
                G = g;
                B = b;
            }
        }
        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(_enemyTexture, _enemyposition, _enemyColour);
        }
         

    }
}
