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
    class Shield : MovingObject
    {
        float cooldown;
        Vector2 direction;
        bool keyPressed;

        public Shield(Texture2D sprite, Vector2 position, int height, int width, Color color, float speed) : base(sprite, position, height, width, color, speed)
        {

        }

        public void Update(GameWindow gW)
        {
            KeyboardState keyboardState = Keyboard.GetState();


            //Note that the shield uses the same controls as the invader and is completely intentional
            if (keyboardState.IsKeyDown(Keys.W))
            {
                direction.Y -= 1;
                keyPressed = true;
            }

            if (keyboardState.IsKeyDown(Keys.S))
            {
                direction.Y += 1;
                keyPressed = true;
            }


            if (keyboardState.IsKeyDown(Keys.A))
            {
                direction.X -= 1;
                keyPressed = true;
            }

            if (keyboardState.IsKeyDown(Keys.D))
            {
                direction.X += 1;
                keyPressed = true;
            }



            //This might seem very confusing since it uses the term "speed" instead of terms like "range" or "distance"
            //But this makes the shield to travel in a circular motion
            if (keyPressed == true)
            {
                if (direction != Vector2.Zero)
                {
                    direction.Normalize();
                }

                position.Y = direction.Y * speed + 280;
                position.X = direction.X * speed + 380;
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
