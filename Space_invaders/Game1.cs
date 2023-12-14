using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Space_invaders.Content;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Space_invaders
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private SpriteFont myFont;

        private Player firstPlayer;
        Enemy[,] enemyArray;
        private Bullet firstBullet;
        private Texture2D enemyTexture;
        private Enemy firstEnemy;
        bool Isdrawn;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _graphics.PreferredBackBufferWidth = 600;
            _graphics.PreferredBackBufferHeight = 900;
        }

        protected override void Initialize()
        {

            firstPlayer = new Player(new Vector2(_graphics.PreferredBackBufferWidth / 2, _graphics.PreferredBackBufferHeight - 90),
                new Rectangle(), Color.White);
            firstBullet = new Bullet(firstPlayer.Position, new Rectangle(), Color.Red, true, firstPlayer);
            firstEnemy = new Enemy(new Vector2(_graphics.PreferredBackBufferWidth / 2, _graphics.PreferredBackBufferHeight - 70),
                new Rectangle(), Color.Blue);
            DrawAllEnemys(enemyTexture, _graphics.PreferredBackBufferWidth);




            base.Initialize();
        }
       

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            firstPlayer.LoadContent(Content, "Placeholder");
            firstBullet.LoadContent(Content, "Bulletplaceholder");
            myFont = Content.Load<SpriteFont>("File");
            firstEnemy.LoadContent(Content, "enemy911");
            
           // DrawAllEnemys(enemyTexture, _graphics.PreferredBackBufferWidth);

            // TODO: use this.Content to load your game content here
            //firstBullet.PositionBullet();
        }
        public void DrawAllEnemys(Texture2D enemyTexture, int screenWidth)
        {
            enemyArray = new Enemy[screenWidth / enemyTexture.Width, 5];

            for (int i = 0; i < enemyArray.GetLength(0); i++)
            {
                for (int j = 0; j < enemyArray.GetLength(1); j++)
                {
                    enemyArray[i, j] = new Enemy(enemyTexture, new Vector2(i * enemyTexture.Width, j * enemyTexture.Height),
                        new Rectangle(i * enemyTexture.Width, j * enemyTexture.Height, enemyTexture.Width, enemyTexture.Height), Color.White);
                }

            }

        }

        protected override void Update(GameTime gameTime)
        {
           firstPlayer.Update(gameTime, true,_graphics.PreferredBackBufferWidth);
            firstBullet.Position = firstPlayer.Position;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            _spriteBatch.Begin();
            firstPlayer.Draw(_spriteBatch);
            firstBullet.Draw(_spriteBatch);
            _spriteBatch.DrawString(myFont, $"X: {firstBullet.Position.X}, Y: {firstBullet.Position.Y}", new Vector2(10, 10), Color.White);
            foreach (Enemy enemy in enemyArray)
            {
                if (enemy.IsDrawn)
                {
                    enemy.Draw(_spriteBatch);
                }
            }

            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }       
    }
}
