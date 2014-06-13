using FluentAssert;

using NUnit.Framework;

using PgnFileTools;

namespace PgnFileToolsTests.Constants
{
    public class FileTests
    {
        [TestFixture]
        public class When_asked_for_its_Index
        {
            [Test]
            public void Given__File_A__should_return__1()
            {
                var result = File.A.Index;
                result.ShouldBeEqualTo(1);
            }

            [Test]
            public void Given__File_B__should_return__2()
            {
                var result = File.B.Index;
                result.ShouldBeEqualTo(2);
            }

            [Test]
            public void Given__File_C__should_return__3()
            {
                var result = File.C.Index;
                result.ShouldBeEqualTo(3);
            }

            [Test]
            public void Given__File_D__should_return__4()
            {
                var result = File.D.Index;
                result.ShouldBeEqualTo(4);
            }

            [Test]
            public void Given__File_E__should_return__5()
            {
                var result = File.E.Index;
                result.ShouldBeEqualTo(5);
            }

            [Test]
            public void Given__File_F__should_return__6()
            {
                var result = File.F.Index;
                result.ShouldBeEqualTo(6);
            }

            [Test]
            public void Given__File_G__should_return__7()
            {
                var result = File.G.Index;
                result.ShouldBeEqualTo(7);
            }

            [Test]
            public void Given__File_H__should_return__8()
            {
                var result = File.H.Index;
                result.ShouldBeEqualTo(8);
            }
        }

        [TestFixture]
        public class When_asked_for_its_Symbol
        {
            [Test]
            public void Given__File_A__should_return__a()
            {
                var result = File.A.Symbol;
                result.ShouldBeEqualTo("a");
            }

            [Test]
            public void Given__File_B__should_return__b()
            {
                var result = File.B.Symbol;
                result.ShouldBeEqualTo("b");
            }

            [Test]
            public void Given__File_C__should_return__c()
            {
                var result = File.C.Symbol;
                result.ShouldBeEqualTo("c");
            }

            [Test]
            public void Given__File_D__should_return__d()
            {
                var result = File.D.Symbol;
                result.ShouldBeEqualTo("d");
            }

            [Test]
            public void Given__File_E__should_return__e()
            {
                var result = File.E.Symbol;
                result.ShouldBeEqualTo("e");
            }

            [Test]
            public void Given__File_F__should_return__f()
            {
                var result = File.F.Symbol;
                result.ShouldBeEqualTo("f");
            }

            [Test]
            public void Given__File_G__should_return__g()
            {
                var result = File.G.Symbol;
                result.ShouldBeEqualTo("g");
            }

            [Test]
            public void Given__File_H__should_return__h()
            {
                var result = File.H.Symbol;
                result.ShouldBeEqualTo("h");
            }
        }

        [TestFixture]
        public class When_asked_to_GetFor
        {
            [Test]
            public void Given__A__should_get__null()
            {
                var result = File.GetFor('A');
                result.ShouldBeNull();
            }

            [Test]
            public void Given__B__should_get__null()
            {
                var result = File.GetFor('B');
                result.ShouldBeNull();
            }

            [Test]
            public void Given__C__should_get__null()
            {
                var result = File.GetFor('C');
                result.ShouldBeNull();
            }

            [Test]
            public void Given__D__should_get__null()
            {
                var result = File.GetFor('D');
                result.ShouldBeNull();
            }

            [Test]
            public void Given__E__should_get__null()
            {
                var result = File.GetFor('E');
                result.ShouldBeNull();
            }

            [Test]
            public void Given__F__should_get__null()
            {
                var result = File.GetFor('F');
                result.ShouldBeNull();
            }

            [Test]
            public void Given__G__should_get__null()
            {
                var result = File.GetFor('G');
                result.ShouldBeNull();
            }

            [Test]
            public void Given__H__should_get__null()
            {
                var result = File.GetFor('H');
                result.ShouldBeNull();
            }

            [Test]
            public void Given__a__should_get__File_A()
            {
                var result = File.GetFor('a');
                result.ShouldBeEqualTo(File.A);
            }

            [Test]
            public void Given__b__should_get__File_B()
            {
                var result = File.GetFor('b');
                result.ShouldBeEqualTo(File.B);
            }

            [Test]
            public void Given__c__should_get__File_C()
            {
                var result = File.GetFor('c');
                result.ShouldBeEqualTo(File.C);
            }

            [Test]
            public void Given__d__should_get__File_D()
            {
                var result = File.GetFor('d');
                result.ShouldBeEqualTo(File.D);
            }

            [Test]
            public void Given__e__should_get__File_E()
            {
                var result = File.GetFor('e');
                result.ShouldBeEqualTo(File.E);
            }

            [Test]
            public void Given__f__should_get__File_F()
            {
                var result = File.GetFor('f');
                result.ShouldBeEqualTo(File.F);
            }

            [Test]
            public void Given__g__should_get__File_G()
            {
                var result = File.GetFor('g');
                result.ShouldBeEqualTo(File.G);
            }

            [Test]
            public void Given__h__should_get__File_H()
            {
                var result = File.GetFor('h');
                result.ShouldBeEqualTo(File.H);
            }
        }
    }
}