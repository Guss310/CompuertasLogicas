using NUnit.Framework;

namespace Library
{
    [TestFixture]
    public class TestGate_and
    {  
        [Test]

        public void TrueGate_and()
        {
            LogicInput True = new LogicInput(true);
            
            Gate_and and1 = new Gate_and ("And-1");
            
            and1.AddInput(True);
            and1.AddInput(True);
            
            Assert.True(and1.Calculate());
        }
        [Test]

        public void FalseGate_and()
        {
    
            LogicInput False = new LogicInput(false);
            LogicInput True = new LogicInput(true);

            Gate_and and1 = new Gate_and ("And-1");
            
            and1.AddInput(False);
            and1.AddInput(True);
            
            Assert.False(and1.Calculate());
        }

    }
}