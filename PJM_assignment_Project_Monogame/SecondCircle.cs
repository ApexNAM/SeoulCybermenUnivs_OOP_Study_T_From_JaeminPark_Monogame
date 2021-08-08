using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PJM_assignment_Project_Monogame
{
    class SecondCircle : CircleBehaviour
    {
        public bool isStop = false;
        public SecondCircle(string sprName) : base(sprName) { }

        public override void CircleInit()
        {
            position = new Vector2(100f, 100f);
            rotation = 10f;
            base.CircleInit();
        }

        public override void CircleLoadContent(Game game)
        {
            base.CircleLoadContent(game);
        }

        public override void CircleUpdate()
        {
            rotation += MathHelper.ToRadians(5f);

            rotation = MathHelper.Clamp(rotation, 0f, 16.5f);
            base.CircleUpdate();
        }

        public override void CircleDraw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(sprite, 
            position, 
            null,
            Color.White,
            rotation,
            Vector2.Zero, 1.0f,
            SpriteEffects.None, 0);
        }
    }
}
