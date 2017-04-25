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
    class GameObject
    {
        protected Texture2D sprite;
        protected Vector2 position;
        protected int height;
        protected int width;
        protected Rectangle hitbox;
        protected Color color;

        protected GameObject(Texture2D sprite, Vector2 position, int height, int width, Color color)
        {
            this.sprite = sprite;
            this.position = position;
            this.width = width;
            this.height = height;
            this.color = color;

        }

        public virtual void Update()
        {
            hitbox = new Rectangle((int)position.X, (int)position.Y, width, height);
        }

        public virtual void Draw(SpriteBatch sB)
        {
            sB.Draw(sprite, new Rectangle((int)position.X, (int)position.Y, width, height), color);
            
        }
    }
}
