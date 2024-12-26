using Lab1CS.Graph;

ColorGOFactory gof = new ColorGOFactory();
gof.createPoint().setColor("red");
gof.createPoint().setColor("green");
gof.createLine().setColor("orange");
gof.createCircle().setColor("blue");

Scene.instance.draw();