using Diamond_Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiamondKataTest
{
    [TestClass]
    public class DiamondKataTest
    {
        private DiamondKata _diamondKata;
        public DiamondKataTest()
        {
            _diamondKata = new DiamondKata();
        }

        [TestMethod]
        public void Result_a_single_layer_sequence()
        {
            var output = "A";
            var result = _diamondKata.CreateSequence('a');
            Assert.AreEqual(output, result);
        }

        [TestMethod]
        public void Result_two_layer_sequence()
        {
            var output = "AB";
            var result = _diamondKata.CreateSequence('b');
            Assert.AreEqual(output, result);

        }

        [TestMethod]
        public void Result_first_half_diamond_for_a_given_char_sequence_A()
        {
            var output = " A\r\n";
            var result = _diamondKata.CreateFirstHalfDiamond(1, new[] { 'A'});
            Assert.AreEqual(output, result);

        }

        [TestMethod]
        public void Result_first_half_diamond_for_a_given_char_sequence_AB()
        {
            var output = "_ A _ \r\nB _  B\r\n";
            var result = _diamondKata.CreateFirstHalfDiamond(2, new[] { 'A', 'B' });
            Assert.AreEqual(output, result);

        }

        [TestMethod]
        public void Result_first_half_diamond_for_a_given_char_sequence_ABC()
        {
            var output = "_ _ A _ _ \r\n_ B _ B _ \r\nC _ _ _ C\r\n";
            var result = _diamondKata.CreateFirstHalfDiamond(3,new[] { 'A', 'B', 'C' });
            Assert.AreEqual(output, result);

        }

        [TestMethod]
        public void Result_second_half_diamond_for_a_given_char_sequence_AB()
        {
            var output = "_ A _ \r\n";
            var result = _diamondKata.CreateSecondtHalfDiamond(2, new[] { 'A', 'B'});
            Assert.AreEqual(output, result);

        }

        [TestMethod]
        public void Result_second_half_diamond_for_a_given_char_sequence_ABC()
        {
            var output = "_ B _ B _ \r\n_ _ A _ _ \r\n";
            var result = _diamondKata.CreateSecondtHalfDiamond(3, new[] { 'A', 'B', 'C' });
            Assert.AreEqual(output, result);

        }

        [TestMethod]
        public void Result_diamond_as_output_for_given_char_a()
        {
            var output = " A\r\n";
            var result = _diamondKata.CreateDiamond('a');
            Assert.AreEqual(output, result);
        }

        [TestMethod]
        public void Result_diamond_as_output_for_given_char_b()
        {
            var output = "_ A _ \r\nB _  B\r\n_ A _ \r\n";
            var result = _diamondKata.CreateDiamond('b');
            Assert.AreEqual(output, result);
        }

        [TestMethod]
        public void Result_diamond_as_output_for_given_char_c()
        {
            var output = "_ _ A _ _ \r\n_ B _ B _ \r\nC _ _ _ C\r\n_ B _ B _ \r\n_ _ A _ _ \r\n";
            var result = _diamondKata.CreateDiamond('c');
            Assert.AreEqual(output, result);
        }


        [TestMethod]
        public void Result_Error_as_output_for_given_invalid_input_1()
        {
            var output = "Please input valid character.";
            var result = _diamondKata.CreateDiamond('1');
            Assert.AreEqual(output, result);
        }
    }
}
