using BankAccountLibrary;
using System;
using Xunit;

namespace BankingTests
{
    public class BasicTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }
        [Fact]
        public void Test2() => Assert.True(true);

        [Fact]
        public void Test3() => Assert.Equal(1,1);


    }
    public class AdvancedTests
    {
        [Fact]
        public void Test_OutOfRange()
        {
           
            Assert.Throws<ArgumentOutOfRangeException>(

                () => new BankAccount("Peti", -1000)

                );

            
        }
        [Fact]
        public void Test_Overdrawn()
        {
            var account = new BankAccount("Peti", 1000);

            Assert.Throws<InvalidOperationException>(

                () => account.MakeWithdrawal(2000,DateTime.Now,"Attempt to overdrawn")

                );


        }

    }


}
