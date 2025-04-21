
import javafx.animation.TranslateTransition;
import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;
import javafx.stage.Stage;
import javafx.util.Duration;

public class MoveCircleApp extends Application {
    public void start(Stage stage) {
        Circle circle = new Circle(50, 100, 30, Color.GREEN);

        TranslateTransition tt = new TranslateTransition(Duration.seconds(3), circle);
        tt.setFromX(0);
        tt.setToX(200);
        tt.setCycleCount(TranslateTransition.INDEFINITE);
        tt.setAutoReverse(true);
        tt.play();

        Pane pane = new Pane(circle);
        Scene scene = new Scene(pane, 400, 200);
        stage.setTitle("Moving Circle");
        stage.setScene(scene);
        stage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }
}
