import io.cucumber.java.en.And;
import io.cucumber.java.en.Given;
import io.cucumber.java.en.Then;
import io.cucumber.java.en.When;
import org.openqa.selenium.Alert;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.firefox.FirefoxDriver;
import org.openqa.selenium.support.ui.Select;

import java.util.concurrent.TimeUnit;

public class MyStepdefs {
    WebDriver driver;
    @Given("Users launch firefox browser")
    public void usersLaunchFirefoxBrowser() {
        System.setProperty("webdriver.gecko.driver", "C:\\Users\\Pavel" +
                "\\Downloads\\geckodriver-v0.32.2-win64\\geckodriver.exe");
        driver = new FirefoxDriver();
    }

    @When("Users open form webpage")
    public void usersOpenFormWebpage() {
        driver.get("https://automationexplore.com/selenium-automation-practice-page/");
        driver.manage().timeouts().pageLoadTimeout(40, TimeUnit.SECONDS);
        driver.manage().timeouts().implicitlyWait(4, TimeUnit.SECONDS);
    }

    @Then("Users enter user name")
    public void usersEnterUserName() {
        driver.findElement(By.id("firstname")).sendKeys("Pavel");
        driver.findElement(By.id("lastname")).sendKeys("Golovan");
    }

    @And("Users enter email")
    public void  usersEnterEmail() {
        driver.findElement(By.id("email")).sendKeys("golovan@ut.ee");
    }

    @And("Users choose Gender and Profession")
    public void usersChooseGenderAndProfession() {
        driver.findElement(By.xpath("//input[@value='male']")).click();
        driver.findElement(By.xpath("//input[@value='Student']")).click();
    }

    @And("Users Enter country and skill")
    public void usersEntercountryAndskill() {
        Select country = new Select(driver.findElement(By.name("country")));
        country.selectByVisibleText("USA");
        Select skill = new Select(driver.findElement(By.id("skillsmultiple")));
        skill.selectByVisibleText("Automation Testing");
    }

    @And("Users click the button")
    public void usersClickTheButton() {
        driver.findElement(By.id("alertbutton")).click();
        Alert alertObj = driver.switchTo().alert();
        alertObj.accept();
    }
}