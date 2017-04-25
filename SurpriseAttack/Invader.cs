using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SurpriseAttack
{
    class Invader : MovingObject
    {
        protected int lives;
        //List<Fire> fire;
        //Texture2D fireTexture;
        //double timeSinceLastFire = 0;

        //Use this to keep track of previous keyboardstates to create grid based movement
        KeyboardState previouslyPressed;

        public Invader(Texture2D sprite, Vector2 position, int height, int width, Color color, float speed) : base(sprite, position, height, width, color, speed)
        {
            this.lives = lives;
        }

        public void Update(GameWindow gW, GameTime gT)
        {

            KeyboardState keyboardState = Keyboard.GetState();


            //Note that the condition detects whether or not the key has already been pressed.
            //Preventing the object from moving when holding the key, giving the object a grid based movement.

            //Up and down
            if (keyboardState.IsKeyDown(Keys.W) && previouslyPressed.IsKeyUp(Keys.W))
            { 
                //These conditions ensures that the object does not move outside the desired area
                if(position.Y > 200)
                position.Y -= speed;
            }

            if (keyboardState.IsKeyDown(Keys.S) && previouslyPressed.IsKeyUp(Keys.S))
            {
                if(position.Y < 360)
                position.Y += speed;
            }

            //Left and right
            if(keyboardState.IsKeyDown(Keys.A) && previouslyPressed.IsKeyUp(Keys.A))
            {
                if(position.X > 300)
                position.X -= speed;
            }

            if (keyboardState.IsKeyDown(Keys.D) && previouslyPressed.IsKeyUp(Keys.D))
            {
                if(position.X < 460)
                position.X += speed;
            }

            //This updates every time the game updates. So if the key is pressed during the previous updates, it won't move until the key is released
            previouslyPressed = keyboardState;

            //if(keyboardState.IsKeyDown(Keys.Space))
            //{
            //    if(gT.TotalGameTime.TotalMilliseconds > timeSinceLastFire + 200)
            //    {
            //        Fire temp = new Fire(fireTexture, new Vector2 (position.X + sprite.Width / 2, position.Y), 40, 40, Color.Yellow, 5);

            //        fire.Add(temp);

            //        timeSinceLastFire = gT.TotalGameTime.TotalMilliseconds;
            //    }
            //}

            //foreach(Fire f in fire.ToList())
            //{
            //    f.Update();
           
            //}

            base.Update();
        }

        public override void Draw(SpriteBatch sB)
        {
            base.Draw(sB);
        }
    }
}
