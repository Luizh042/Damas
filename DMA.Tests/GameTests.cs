using System;
using Damas;

namespace Damas.Tests { 

// Classe de teste
    public class GameTests
    {
        ReadTerminal _readTerminal;
        Game _game;
        [SetUp]
        public void SetUp()
        {
            _game = new Game();
            _readTerminal = new ReadTerminal();
        }

        [Test]
        public void TestStartGame()
        {
            _game.Start();
            Assert.AreEqual(true, _game.turnOn);
        }
        [Test]
        public void TestEndingGame()
        {
            _game.Ending();
            Assert.AreEqual(false, _game.turnOn);
        }
        [Test]
        public void TestReadTerminalStartGame()
        {
            ICommand startGameCommand = new StartGameCommand(_game);
            _readTerminal.SetCommand(startGameCommand);
            _readTerminal.PressButton();
            Assert.AreEqual(true, _game.turnOn);
        }

        [Test]
        public void TestReadTerminalEndingGame()
        {
            ICommand endingGameCommand = new EndingGameCommand(_game);
            _readTerminal.SetCommand(endingGameCommand);
            _readTerminal.PressButton();
            Assert.AreEqual(false, _game.turnOn);
        }
    }
 }
