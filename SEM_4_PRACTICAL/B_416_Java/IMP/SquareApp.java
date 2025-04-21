
import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Rectangle;
import javafx.stage.Stage;

public class SquareApp extends Application {
    public void start(Stage stage) {
        Rectangle square = new Rectangle(100, 100, 100, 100);
        square.setFill(Color.RED);
        Pane pane = new Pane(square);
        Scene scene = new Scene(pane, 300, 250);
        stage.setTitle("Square Display");
        stage.setScene(scene);
        stage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }
}
