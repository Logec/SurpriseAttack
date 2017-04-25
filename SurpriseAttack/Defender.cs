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
    class Defender : MovingObject 
    {
        protected bool holding;
        protected bool canIgnite;

        //This bool is necessary as it will let the program know when to normalize the direction vector
        //If this isn't used, the defender will lose its vector/position
        bool keyPressed;
        Vector2 direction; 

        public Defender(Texture2D sprite, Vector2 position, int height, int width, Color color, float speed, bool holding, bool canIgnite) : base(sprite, position, height, width, color, speed)
        {
            this.holding = holding;
            this.canIgnite = canIgnite;
        }

        public void Update(GameWindow gW)
        {
            //Note to self: Do not remove this, otherwise the defender will slide around in a weird motion
            direction = new Vector2();

            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.Up))
            {
                direction.Y -= 1;
                keyPressed = true;
            }

            if(keyboardState.IsKeyDown(Keys.Down))
            {
                direction.Y += 1;
                keyPressed = true;
            }


            if(keyboardState.IsKeyDown(Keys.Left))
            {
                direction.X -= 1;
                keyPressed = true;
            }

            if(keyboardState.IsKeyDown(Keys.Right))
            {
                direction.X += 1;
                keyPressed = true;
            }

            //Normalizing and using the direction vector this way will ensure that the defender will move at the same speed in all directions
            if(keyPressed == true)
            {
                if (direction != Vector2.Zero)
                {
                    direction.Normalize();
                }

                position.Y += direction.Y * speed;
                position.X += direction.X * speed;
            }

            keyPressed = false;
            base.Update();
        }

        public override void Draw(SpriteBatch sB)
        {
            base.Draw(sB);
        }
    }
}
