using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling
{
    [TestFixture]
    public class TestBowling
    {
        [Test]
        public void AllZero()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                g.SetPins(0);
            }
            Assert.That(g.GetFinalScore(), Is.EqualTo(0));
        }
        [Test]
        public void ASpair()
        {
           Game g = new Game();
            g.SetPins(5);
            g.SetPins(5);
            g.SetPins(5);
            for (int i = 0; i < 17; i++)
            {
                g.SetPins(0);
            }
            Assert.That(g.GetFinalScore(), Is.EqualTo(20));
        }
        [Test]
        public void AStrike()
        {
            Game g = new Game();
            g.SetPins(10);
     
            g.SetPins(3);
            g.SetPins(4);
            for (int i = 0; i < 16; i++)
            {
                g.SetPins(0);
            }
            Assert.That(g.GetFinalScore(), Is.EqualTo(24));
        }
        [Test]
        public void StrikeSpair()
        {
            Game g = new Game();
            g.SetPins(10);

            g.SetPins(3);
            g.SetPins(7);
            g.SetPins(5);
            g.SetPins(0);
            for (int i = 0; i < 14; i++)
            {
                g.SetPins(0);
            }
            Assert.That(g.GetFinalScore(), Is.EqualTo(40));
        }
        [Test]
        public void FinalSpairCase()
        {
            Game g = new Game();
            for(int i=0;i<18;i+=1)
            {
                g.SetPins(0);
            }
            g.SetPins(0);
            g.SetPins(10);
            g.SetPins(5);
            Assert.That(g.GetFinalScore(), Is.EqualTo(15));
        }
        [Test]
        public void Ptt()
        {
            Game g = new Game();
            g.SetPins(1);
            g.SetPins(4);
            g.SetPins(4);
            g.SetPins(5);
            g.SetPins(6);
            g.SetPins(4);
            g.SetPins(5);
            g.SetPins(5);
            g.SetPins(10);
            g.SetPins(0);
            g.SetPins(1);
            g.SetPins(7);
            g.SetPins(3); 
            g.SetPins(6);
            g.SetPins(4);
            g.SetPins(10);
            g.SetPins(2);
            g.SetPins(8);
            g.SetPins(6);
            Assert.That(g.GetFinalScore(), Is.EqualTo(133));

        }








    }
}
