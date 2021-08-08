using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PJM_assignment_Project_Monogame
{
    public abstract class CircleBehaviour
    {
        public Texture2D sprite;

        public Vector2 position;
        public float rotation;

        public string sprName;

        public CircleBehaviour(string _sprName)
        {
            sprName = _sprName;

            position = Vector2.Zero;
            rotation = 0.0f;
        }

        public virtual void CircleInit() { }
        public virtual void CircleLoadContent(Game game) 
        {
            sprite = game.Content.Load<Texture2D>(sprName);
        }
        public virtual void CircleUpdate() { }
        public virtual void CircleDraw(SpriteBatch _spriteBatch) { }
    }
}
