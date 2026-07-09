public class Logger {

    // Stores the single Logger object
    private static Logger instance;

    // Private constructor
    private Logger() {
        System.out.println("Logger Object Created");
    }

    // Returns the same Logger object every time
    public static Logger getInstance() {

        if (instance == null) {
            instance = new Logger();
        }

        return instance;
    }

    // Method to print log messages
    public void log(String message) {
        System.out.println("LOG : " + message);
    }
}