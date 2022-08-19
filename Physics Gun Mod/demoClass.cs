using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using GTA.Math;
using GTA.Native;
using GTA.NaturalMotion;
using System.Windows.Forms;
using System.Drawing;

namespace Demo_Project
{
    public class demoClass : Script
    {  
        public demoClass()
        {
            this.Tick += onTick;
            this.KeyUp += onKeyUp;
            this.KeyDown += onKeyDown;
        }
        private void onTick(object sender, EventArgs e)
        {
        }
        private void onKeyUp(object sender, KeyEventArgs e)
        {
        }
        private void onKeyDown(object sender, KeyEventArgs e)
        {
            
            
            if (e.KeyCode == Keys.O & GTA.Game.Player.IsAiming)
            {
                Entity ent = GTA.World.GetCrosshairCoordinates().HitEntity;
                if (ent != null)
                {
                    ent.ApplyForce(Game.Player.Character.ForwardVector * 10);
                }
            }
        }
    }
}
