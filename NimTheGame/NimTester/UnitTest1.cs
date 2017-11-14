using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NimTheGame;

namespace NimTester
{
    [TestClass]
    public class UnitTest1
    {
        //All of menu test should be in a doc

        #region BoardTests
        //Elena

        #region AddHeap Tests
        [TestMethod]
        public void AddHeap_AcceptsAValidHeap()
        {
            Board board = new Board();
            board.addHeap(3, 3);

            Assert.IsTrue(board.getHeapSize().Equals(1) && board.getMaxNumber(0).Equals(3));
        }
        #endregion

        #region BoardCtor Tests
        [TestMethod]
        public void Board_ClearsHeaps()
        {
            Board board = new Board();
            board.addHeap(3, 3);
            board.addHeap(2, 2);

            Board board2 = new Board();

            Assert.Equals(board2.getHeapSize(), 0);
        }
        #endregion

        #region CheckWin Tests
        [TestMethod]
        public void CheckWin_NoMatchesLeft()
        {
            Board board = new Board();
            board.addHeap(3, 3);
            board.addHeap(2, 2);

            board.removeMatchesFrom(0, 3);
            board.removeMatchesFrom(1, 2);

            Assert.IsTrue(board.checkWin());
        }
        [TestMethod]
        public void CheckWin_MatchesInOneHeap()
        {
            Board board = new Board();
            board.addHeap(3, 3);
            board.addHeap(2, 2);

            board.removeMatchesFrom(0, 3);

            Assert.IsFalse(board.checkWin());
        }
        #endregion

        #region getHeapSize Tests
        [TestMethod]
        public void getHeapSize_ReturnsCorrectSize()
        {
            Board board = new Board();
            board.addHeap(2, 2);

            Assert.Equals(board.getHeapSize(), 1);
        }
        [TestMethod]
        public void handlesEmptyHeaps()
        {
            Board board = new Board();

            Assert.Equals(board.getHeapSize(), 0);
        }
        #endregion

        #region getMaxNumber Tests
        [TestMethod]
        public void ReturnsValidNumber()
        {
            Board board = new Board();
            board.addHeap(3, 3);

            Assert.Equals(board.getMaxNumber(0), 3);
        }
        [TestMethod]
        public void DealsWithEmptyHeaps()
        {
            Board board = new Board();
            board.addHeap(0, 0);

            Assert.Equals(board.getMaxNumber(0), 0);
        }
        #endregion

        #region removeMatchesFrom Tests
        [TestMethod]
        public void RemovesCorrectly()
        {
            Board board = new Board();
            board.addHeap(3, 3);
            board.removeMatchesFrom(0, 2);

            Assert.Equals(board.getMaxNumber(0), 1);
        }
        [TestMethod]
        public void HandlesNegatives()
        {
            Board board = new Board();
            board.addHeap(3, 3);
            board.removeMatchesFrom(0, -2);
            board.removeMatchesFrom(0, 2);

            Assert.Equals(board.getMaxNumber(0), 1);
        }
        #endregion
        
        #endregion

        #region GameTests

        //Austin

        #endregion

        #region DriverTests

        //Austin
        //I'm not sure if we need this but just in case

        #endregion

        #region PlayerTests

        //Tre

        #endregion

        #region HeapTests

        //Tre

        #endregion


    }
}
