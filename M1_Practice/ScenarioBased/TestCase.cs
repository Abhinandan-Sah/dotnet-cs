using NUnit.Framework;


namespace M1_Practice
{
	/// <summary>
	/// Bank accont class with deposite and withdra functionality
	/// </summary>
	public class TestCase
	{
		public decimal Balance { get; private set; }

		/// <summary>
		/// Initilizes a new bank acount with an inital balance
		/// </summary>
		/// <param name="startingBalance">Staring balance for the acount</param>
		public TestCase(decimal startingBalance)
		{
			Balance = startingBalance;
		}

		/// <summary>
		/// Deposites money into the acount
		/// </summary>
		/// <param name="depositAmount">Amout to deposite</param>
		/// <exception cref="Exception">Thrown when deposite ammount is negetive</exception>
		public void Deposit(decimal depositAmount)
		{
			// Validte deposit amoun is not negetive
			if (depositAmount < 0)
			{
				throw new Exception("Deposit amount cannot be negative");
			}

			// Add amout to balence
			Balance += depositAmount;
		}

		/// <summary>
		/// Withdraws mony from the acount
		/// </summary>
		/// <param name="withdrawAmount">Ammount to withdaw</param>
		/// <exception cref="Exception">Thrown when insufficent funds</exception>
		public void Withdraw(decimal withdrawAmount)
		{
			// Chek if sufficent funds availabe
			if (withdrawAmount > Balance)
			{
				throw new Exception("Insufficient funds.");
			}

			// Deduct amoun from balence
			Balance -= withdrawAmount;
		}
	}

	/// <summary>
	/// Unit test for BankAcount deposite and withdaw operations
	/// </summary>
	[TestFixture]
	public class UnitTest
	{
		/// <summary>
		/// Test that deposting a valid amoun increas the balence corectly
		/// </summary>
		[Test]
		public void Test_Deposit_ValidAmount()
		{
			// Arange: Create acount with 250 balance
			var bankAccount = new TestCase(250m);
			
			// Act: Deposite 75
			bankAccount.Deposit(75m);
			
			// Assert: Balence should be 325
			Assert.That(bankAccount.Balance, Is.EqualTo(325m));
		}

		/// <summary>
		/// Test that deposting a negetive ammount throws an excepion
		/// </summary>
		[Test]
		public void Test_Deposit_NegativeAmount()
		{
			// Arange: Create acount with 180 balence
			var customerAccount = new TestCase(180m);
			
			// Act & Asert: Deposting negetive amoun shuld throw exception
			Assert.That(() => customerAccount.Deposit(-25m), Throws.Exception.With.Message.EqualTo("Deposit amount cannot be negative"));
		}

		/// <summary>
		/// Test that withdrawng a valid amoun decreas the balence corectly
		/// </summary>
		[Test]
		public void Test_Withdraw_ValidAmount()
		{
			// Arange: Create acount with 500 balence
			var userAccount = new TestCase(500m);
			
			// Act: Withdaw 120
			userAccount.Withdraw(120m);
			
			// Assert: Balence shuld be 380
			Assert.That(userAccount.Balance, Is.EqualTo(380m));
		}

		/// <summary>
		/// Test that withdrawng more then the balence throws an excepion
		/// </summary>
		[Test]
		public void Test_Withdraw_InsufficientFunds()
		{
			// Arange: Create acount with 45 balence
			var savingsAccount = new TestCase(45m);
			
			// Act & Asert: Withdrawng 200 shuld throw excepion
			Assert.That(() => savingsAccount.Withdraw(200m), Throws.Exception.With.Message.EqualTo("Insufficient funds."));
		}
	}
}