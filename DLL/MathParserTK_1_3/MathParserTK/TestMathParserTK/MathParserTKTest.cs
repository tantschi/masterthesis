using MathParserTK;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMathParserTK
{
    /// <summary>
    ///This is a test class for MathParserTKTest and is intended
    ///to contain all MathParserTKTest Unit Tests
    ///</summary>
	[TestClass()]
	public class MathParserTKTest
	{
		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		// 
		//You can use the following additional attributes as you write your tests:
		//
		//Use ClassInitialize to run code before running the first test in the class
		//[ClassInitialize()]
		//public static void MyClassInitialize(TestContext testContext)
		//{
		//}
		//
		//Use ClassCleanup to run code after all tests in a class have run
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//Use TestInitialize to run code before running each test
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion

		/// <summary>
		///A test for Parse
		///</summary>
		[TestMethod()]
		[DeploymentItem("MathParserTK.exe")]
		public void ParseTest1()
		{
			// Arrange

			MathParser target = new MathParser();
			string input = "5*5+5*3-5*5-5*3";
			bool radians = false;
			double expected = 0D; 
			double actual;

			// Act
			actual = target.Parse(input, radians);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		///A test for Parse
		///</summary>
		[TestMethod()]
		[DeploymentItem("MathParserTK.exe")]
		public void ParseTest2()
		{
			// Arrange

			MathParser target = new MathParser();
			string input = "-5*(+5)+5*(-3)-5*(+5)-5*(-3)";
			bool radians = false;
			double expected = -50D;
			double actual;

			// Act
			actual = target.Parse(input, radians);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		///A test for Parse
		///</summary>
		[TestMethod()]
		[DeploymentItem("MathParserTK.exe")]
		public void ParseTest3()
		{
			// Arrange

			MathParser target = new MathParser();
			string input = "pi*1+e*2+.95";
			bool radians = false;
			double expected = 9.5281563105078888;
			double actual;

			// Act
			actual = target.Parse(input, radians);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		///A test for Parse
		///</summary>
		[TestMethod()]
		[DeploymentItem("MathParserTK.exe")]
		public void ParseTest4()
		{
			// Arrange

			MathParser target = new MathParser();
			string input = "sqrt(625)-25*(-(50*(-1)-49/(-1)))";
			bool radians = false;
			double expected = 0D;
			double actual;

			// Act
			actual = target.Parse(input, radians);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		///A test for Parse
		///</summary>
		[TestMethod()]
		[DeploymentItem("MathParserTK.exe")]
		public void ParseTest5()
		{
			// Arrange

			MathParser target = new MathParser();
			string input = "-(-1)";
			bool radians = false;
			double expected = 1D;
			double actual;

			// Act
			actual = target.Parse(input, radians);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		///A test for Parse
		///</summary>
		[TestMethod()]
		[DeploymentItem("MathParserTK.exe")]
		public void ParseTest6()
		{
			// Arrange

			MathParser target = new MathParser();
			string input = "-1^2";
			bool radians = false;
			double expected = -1D;
			double actual;

			// Act
			actual = target.Parse(input, radians);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		///A test for Parse
		///</summary>
		[TestMethod()]
		[DeploymentItem("MathParserTK.exe")]
		public void ParseTest7()
		{
			// Arrange

			MathParser target = new MathParser();
			string input = "(-1)^2";
			bool radians = false;
			double expected = 1D;
			double actual;

			// Act
			actual = target.Parse(input, radians);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		///A test for Parse
		///</summary>
		[TestMethod()]
		[DeploymentItem("MathParserTK.exe")]
		public void ParseTest8()
		{
			// Arrange

			MathParser target = new MathParser();
			string input = "sin(cos(tg(sh(ch(th(100)))))) ";
			bool radians = false;
			double expected = 0.017452402397444194D;
			double actual;

			// Act
			actual = target.Parse(input, radians);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		///A test for Parse
		///</summary>
		[TestMethod()]
		[DeploymentItem("MathParserTK.exe")]
		public void ParseTest9()
		{
			// Arrange

			MathParser target = new MathParser();
			string input = "th(ch(sh(tg(cos(sin(100))))))";
			bool radians = false;
			double expected = 0.76165811649275783D;
			double actual;

			// Act
			actual = target.Parse(input, radians);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		///A test for Parse
		///</summary>
		[TestMethod()]
		[DeploymentItem("MathParserTK.exe")]
		public void ParseTest10()
		{
			// Arrange

			MathParser target = new MathParser();
			string input = "5*5+   5*3-5*5-5*3";
			bool radians = false;
			double expected = 0D;
			double actual;

			// Act
			actual = target.Parse(input, radians);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		///A test for Parse
		///</summary>
		[TestMethod()]
		[DeploymentItem("MathParserTK.exe")]
		public void ParseTest11()
		{
			// Arrange

			MathParser target = new MathParser();
			string input = "-1  *  (-   (+ (5*(+5)+5*(+3)-5*(+5)-5*(-3))))";
			bool radians = false;
			double expected = 30D;
			double actual;

			// Act
			actual = target.Parse(input, radians);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
