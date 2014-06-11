using FluentAssert;

using NUnit.Framework;

using PgnFileTools;

namespace PgnFileToolsTests.Constants
{
    public class PieceTypeTests
    {
        [TestFixture]
        public class When_asked_for_its_Symbol
        {
            [Test]
            public void Given__PieceType_Bishop__should_return__B()
            {
                var result = PieceType.Bishop.Symbol;
                result.ShouldBeEqualTo("B");
            }

            [Test]
            public void Given__PieceType_King__should_return__K()
            {
                var result = PieceType.King.Symbol;
                result.ShouldBeEqualTo("K");
            }

            [Test]
            public void Given__PieceType_Knight__should_return__N()
            {
                var result = PieceType.Knight.Symbol;
                result.ShouldBeEqualTo("N");
            }

            [Test]
            public void Given__PieceType_Pawn__should_return__P()
            {
                var result = PieceType.Pawn.Symbol;
                result.ShouldBeEqualTo("P");
            }

            [Test]
            public void Given__PieceType_Queen__should_return__Q()
            {
                var result = PieceType.Queen.Symbol;
                result.ShouldBeEqualTo("Q");
            }

            [Test]
            public void Given__PieceType_Rook__should_return__R()
            {
                var result = PieceType.Rook.Symbol;
                result.ShouldBeEqualTo("R");
            }
        }

        [TestFixture]
        public class When_asked_to_GetFor
        {
            [Test]
            public void Given__B__should_get__PieceType_Bishop()
            {
                var result = PieceType.GetFor('B');
                result.ShouldBeEqualTo(PieceType.Bishop);
            }

            [Test]
            public void Given__K__should_get__PieceType_King()
            {
                var result = PieceType.GetFor('K');
                result.ShouldBeEqualTo(PieceType.King);
            }

            [Test]
            public void Given__N__should_get__PieceType_Knight()
            {
                var result = PieceType.GetFor('N');
                result.ShouldBeEqualTo(PieceType.Knight);
            }

            [Test]
            public void Given__P__should_get__null()
            {
                var result = PieceType.GetFor('P');
                result.ShouldBeNull();
            }

            [Test]
            public void Given__Q__should_get__PieceType_Queen()
            {
                var result = PieceType.GetFor('Q');
                result.ShouldBeEqualTo(PieceType.Queen);
            }

            [Test]
            public void Given__R__should_get__PieceType_Rook()
            {
                var result = PieceType.GetFor('R');
                result.ShouldBeEqualTo(PieceType.Rook);
            }
        }
    }
}