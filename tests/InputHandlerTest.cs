// namespace tests;

// [TestClass]
// public class InputHandlerTest : code.InputHandler
// {
//     [TestMethod]
//     public void ReadInputListTest()
//     {
//         string input =
//         @"Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
// Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue";
//         // List<List<int>> expected =  { { 4, 6, 2 }, { 1, 4, 3 } };
//         List<List<int>> expected = new List<List<int>>()
//         {
//             new List<int>() { 4, 6, 2 },
//             new List<int>() { 1, 4, 3 }
//         };

//          List<List<int>> actual = code.InputHandler.ReadInputList(input);
//         CollectionAssert.AreEqual(expected, actual);
//     }
// }
