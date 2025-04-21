
import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.control.*;
import javafx.scene.layout.VBox;
import javafx.stage.Stage;

public class StudentDataApp extends Application {
    public void start(Stage stage) {
        TextField nameField = new TextField();
        nameField.setPromptText("Enter Student Name");
        TextField marksField = new TextField();
        marksField.setPromptText("Enter Marks");

        Button submit = new Button("Submit");
        Label output = new Label();

        submit.setOnAction(e -> {
            String name = nameField.getText();
            String marks = marksField.getText();
            output.setText("Name: " + name + ", Marks: " + marks);
        });

        VBox root = new VBox(10, nameField, marksField, submit, output);
        Scene scene = new Scene(root, 300, 200);
        stage.setScene(scene);
        stage.setTitle("Student Data Input");
        stage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }
}
