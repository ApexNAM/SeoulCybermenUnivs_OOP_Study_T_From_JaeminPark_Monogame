using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PJM_assignment_Project_Monogame
{
    class FirstCircle : CircleBehaviour
    {
        public bool isRightPos = true;

        public FirstCircle(string sprName) : base(sprName) { }

        public override void CircleInit()
        {
            base.CircleInit();
        }

        public override void CircleLoadContent(Game game)
        {
            base.CircleLoadContent(game);
        }

        public override void CircleUpdate()
        {
            if (isRightPos)
            {
                position += Vector2.UnitX;

                if (position.X > 100f)
                {
                    isRightPos = false;
                }
            }
            else
            {
                position -= Vector2.UnitX;

                if(position.X < 0.5f)
                {
                    isRightPos = true;
                }
            }

            base.CircleUpdate();
        }

        public override void CircleDraw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(sprite, position, Color.White);
            base.CircleDraw(_spriteBatch);
        }
    }
}
