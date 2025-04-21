
import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;
import javafx.stage.Stage;

public class CircleApp extends Application {
    public void start(Stage stage) {
        Circle circle = new Circle(100, 100, 50);
        circle.setFill(Color.BLUE);
        Pane pane = new Pane(circle);
        Scene scene = new Scene(pane, 300, 200);
        stage.setTitle("Circle Display");
        stage.setScene(scene);
        stage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }
}
