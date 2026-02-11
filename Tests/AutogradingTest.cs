namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{

    [Fact]
    public void Should_Contain_A_Method_Named_ConvertImplicitly_Which_Takes_An_Int_And_Returns_The_Converted_Decimal_Value(){
      var converter = new Converter();
      var result = converter.ConvertImplicitly(50);

      Assert.Equal(50.0M, result);
    }

    [Fact]
    public void Should_Contain_A_Method_Named_ConvertExplicitly_Which_Takes_A_Decimal_And_Returns_The_Converted_Int_Value(){
      var converter = new Converter();
      var result = converter.ConvertExplicitly(50.75M);

      Assert.Equal(50, result);
    }
}