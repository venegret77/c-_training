using C.Training;

var player = new Player("You");
var computer = new Player("Computer");
var game = new Game(player, computer, 5);

game.Play();
