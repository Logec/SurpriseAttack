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
    class Fire : MovingObject
    {
        public Fire(Texture2D texture, Vector2 position, int height, int width, Color color, float speed) : base(texture, position, height, width, color, speed)
        {

        }

        public override void Update()
        {
            position.Y -= speed;
        }
    }
}
