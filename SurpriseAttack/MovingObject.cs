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
    abstract class MovingObject : GameObject
    {
        protected float speed;
        
        public MovingObject(Texture2D sprite, Vector2 position, int height, int width, Color color, float speed): base(sprite, position, height, width, color)
        {
            this.speed = speed;
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
