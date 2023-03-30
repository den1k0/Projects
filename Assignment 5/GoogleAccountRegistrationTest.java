import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

public class GoogleAccountRegistrationTest {
    private WebDriver driver;

    @Before
    public void setUp() {
        // Set the path of the ChromeDriver executable
        System.setProperty("webdriver.chrome.driver", "/path");

        // Create a new instance of the ChromeDriver
        driver = new ChromeDriver();
    }

    @Test
    public void testGoogleAccountRegistration() {
        // Navigate to the Google account registration page
        driver.get("https://accounts.google.com/signup");

        // Fill in the registration form fields
        WebElement firstNameField = driver.findElement(By.id("firstName"));
        firstNameField.sendKeys("John");

        WebElement lastNameField = driver.findElement(By.id("lastName"));
        lastNameField.sendKeys("Doe");

        WebElement usernameField = driver.findElement(By.id("username"));
        usernameField.sendKeys("johndoe");

        WebElement passwordField = driver.findElement(By.name("Passwd"));
        passwordField.sendKeys("password123");

        WebElement confirmPasswordField = driver.findElement(By.name("ConfirmPasswd"));
        confirmPasswordField.sendKeys("password123");

        // Click the next button to proceed to the next step
        WebElement nextButton = driver.findElement(By.id("accountDetailsNext"));
        nextButton.click();

        // Wait for the page to load
        try {
            Thread.sleep(5000);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }

        // Verify that the account creation was successful
        String expectedTitle = "Welcome - Google Account";
        String actualTitle = driver.getTitle();
        assertEquals(expectedTitle, actualTitle);
    }

    @After
    public void tearDown() {
        // Close the browser window
        driver.quit();
    }
}
