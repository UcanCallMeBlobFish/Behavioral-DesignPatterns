using ConsoleApp1.ChainOfResponsibility;
using ConsoleApp1.Command.FR;
using ConsoleApp1.Command.UI;
using ConsoleApp1.Iterator;
using ConsoleApp1.Observer;

var twenty = new TwentyHandler(null);
var ten = new TenHandler(twenty);
var five = new FiveHandler(ten);

five.DoHandler(0);