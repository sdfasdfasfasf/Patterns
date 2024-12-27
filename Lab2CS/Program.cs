using Lab2CS.Graph;

AbstractGOFactory gof = new ColorGOFactory();
gof.createRoot();
gof.createPoint(null).setColor("red");
gof.createPoint(null).setColor("green");

Scene.instance.add(null, new FillDecorator(new Circle(0, 0, 50, "blue"), "aquamarin"));

gof.createTriangle(null).setColor("pink");

Scene.instance.draw();

Console.WriteLine("********* FACADE ************");

List<String> figures = new List<string> { "point 100 200", "circle 20 30 45" };

Scene.instance.showScene(figures);