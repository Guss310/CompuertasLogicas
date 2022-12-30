using NUnit.Framework;

namespace Library
{
    
    [TestFixture]
    public class TestGate_or
    {  

        [Test]
        public void TrueGate_or()
        {

            LogicInput True = new LogicInput(true);

            Gate_or or1 = new Gate_or ("OR-1");

            or1.AddInput(True);
            or1.AddInput(True);
            
            Assert.True(or1.Calculate());

            LogicInput False = new LogicInput(false);
        }

        [Test]
        public void FalseGate_or()
        {

            LogicInput False = new LogicInput(false);
            LogicInput True = new LogicInput(true);

            Gate_or or1 = new Gate_or ("OR-1");
            
            or1.AddInput(False);
            or1.AddInput(True);
            
            Assert.True(or1.Calculate());
        }

    }
}