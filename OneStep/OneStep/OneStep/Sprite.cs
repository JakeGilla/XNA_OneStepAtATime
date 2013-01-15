using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OneStep
{
    class Sprite
    {
        // Properties
        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; }

        // Constructors
        public Sprite() { }

        public Sprite(Texture2D texture, Vector2 position)
        {
            Texture = texture;
            Position = position;
        }

        // Methods
        public void Draw(SpriteBatch spriteBatch)
        {
            if (Texture != null)
                spriteBatch.Draw(Texture, Position, Color.White);
        }

    }
}
