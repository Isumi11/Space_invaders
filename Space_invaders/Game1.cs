using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Space_invaders.Content;

namespace Space_invaders
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private SpriteFont myFont;

        private Player firstPlayer;
        private Bullet firstBullet;

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


            base.Initialize();
        }


        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            firstPlayer.LoadContent(Content, "Placeholder");
            firstBullet.LoadContent(Content, "Bulletplaceholder");
            myFont = Content.Load<SpriteFont>("File");

            // TODO: use this.Content to load your game content here
           //firstBullet.PositionBullet();
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
            
            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }       
    }
}
