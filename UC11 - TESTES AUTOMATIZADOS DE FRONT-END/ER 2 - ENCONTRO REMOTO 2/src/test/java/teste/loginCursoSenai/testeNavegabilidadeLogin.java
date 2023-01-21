package teste.loginCursoSenai;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

import java.time.Duration;

public class testeNavegabilidadeLogin {

	private WebDriver driver;
	
	@Before
	public void preTeste()
	{
		System.setProperty("webdriver.chrome.driver", "C:\\Program Files\\chromedriver\\chromedriver.exe");
		driver = new ChromeDriver();
		driver.manage().window().maximize();	
	}
	
	
	
	
	
	@Test
	public void testeNavegacao() throws InterruptedException
	{
		this.driver.get("http://localhost:4200/");

		String[] listaUsuarios = {"carlos", "carloseduardo!", "carloseduardodecarvalho", "carloseduardo", "carloseduardo", "carloseduardo", "miranda"};
		String[] listaSenhas = {"", "123", "12345678910111213141516", "123456789CE", "123456789CE!", "123456789CE!","miranda"};
	
		for(int i = 0; i < listaSenhas.length; i++)
		{
			WebElement inputUsuario = this.driver.findElement(By.id("usuario")); 
			WebElement inputSenha = this.driver.findElement(By.id("senha"));
			WebElement entrarBtn = this.driver.findElement(By.id("entrarBtn"));
			inputUsuario.sendKeys(listaUsuarios[i]);
			inputSenha.sendKeys(listaSenhas[i]);
			entrarBtn.click();
			Thread.sleep(1000);
			String message = this.driver.findElement(By.tagName("simple-snack-bar")).getText();
			System.out.println(
					"Cenario "+(i+1)+" Usuario: "+listaUsuarios[i]+" Senha: "+listaSenhas[i]+
					" Resultado: "+
					message);
			if(!(message.substring(0, 7).equals("Sucesso")))
			{
				this.driver.get("http://localhost:4200/cadastro");
				WebElement inputUsuarioCadastro = this.driver.findElement(By.id("usuario")); 
				WebElement inputSenhaCadastro = this.driver.findElement(By.id("senha"));
				WebElement cadastroBtn = this.driver.findElement(By.id("cadastroBtn"));
				inputUsuarioCadastro.sendKeys(listaUsuarios[i]);
				inputSenhaCadastro.sendKeys(listaSenhas[i]);
				cadastroBtn.click();
				Thread.sleep(1000);
				System.out.println(
						"Tentativa de criacao:"+
						"Resultado: "+
						this.driver.findElement(By.tagName("simple-snack-bar")).getText());
				this.driver.get("http://localhost:4200/");
			}
			else {
				this.driver.get("http://localhost:4200/");
			}
			
		
			
			Thread.sleep(5000);
		}

	}
	
//	@After
//	public void TesteNavegacao() {
//		this.driver.quit();
//	}
}


