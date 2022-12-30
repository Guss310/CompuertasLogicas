using NUnit.Framework;

namespace Library
{
    
    [TestFixture]
    public class TestGate_not
    {  

        [Test]
        public void TrueGate_not()
        {
            LogicInput True = new LogicInput(true);

            Gate_not not2 = new Gate_not("Not-1");

            not2.AddInput(True);

            Assert.False(not2.Calculate());
        }

        [Test]
        public void FalseGate_not()
        {
            LogicInput False = new LogicInput(false);

            Gate_not not2 = new Gate_not("Not-1");

            not2.AddInput(False);

            Assert.True(not2.Calculate());
        }

    }
}