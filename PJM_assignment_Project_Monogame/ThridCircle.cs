using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PJM_assignment_Project_Monogame
{
    class ThridCircle : CircleBehaviour
    {
        public bool isRightRot = true;
        public ThridCircle(string sprName) : base(sprName) { }

        public override void CircleInit()
        {
            position = new Vector2(250f, 300f);
            base.CircleInit();
        }

        public override void CircleLoadContent(Game game)
        {
            base.CircleLoadContent(game);
        }

        public override void CircleUpdate()
        {
            if (isRightRot)
            {
                rotation += MathHelper.ToRadians(5f);

                if (rotation > 6.25f)
                {
                    isRightRot = false;
                }
            }
            else
            {
                rotation -= MathHelper.ToRadians(5f);

                if(rotation < 1f)
                {
                    isRightRot = true;
                }
            }
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

            base.CircleDraw(_spriteBatch);
        }
    }
}
