using ChapterFS11.Controllers;
using ChapterFS11.Models;
using ChapterFS11.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.IdentityModel.Tokens.Jwt;
using static ChapterFS11.Interfaces.Interface;

namespace TesteIntegracao
{
    public class LoginControllerCECM
    {
        [Fact]
        public void LoginController_Retornar_Usuario_Invalido()
        {
            //Prepara��o - Arrange
            var repositoryEspelhado = new Mock<IUsuarioRepository>();

            repositoryEspelhado.Setup(x => x.Login(It.IsAny<string>(),It.IsAny<string>())).Returns((Usuario)null!);

            var controller = new LoginController(repositoryEspelhado.Object);

            
            LoginViewModel dadosUsuario = new LoginViewModel();
            dadosUsuario.email = "carlos@test.com";
            dadosUsuario.senha = "carlosteste";

            //A��o - Act
            var resultado = controller.Login(dadosUsuario);

            //Verifica��o - Assert
            Assert.IsType<UnauthorizedObjectResult>(resultado);
        }

        [Fact]

        public void LoginController_Retornar_Token()
        {
            //Prepara��o - arrange

            Usuario usuarioRetornado = new Usuario();
            usuarioRetornado.Email = "email@email.com";
            usuarioRetornado.Senha = "1234";
            usuarioRetornado.Tipo = "0";
            usuarioRetornado.id = 1;

            var repositoryEspelhado = new Mock<IUsuarioRepository>();

            repositoryEspelhado.Setup(x => x.Login(It.IsAny<string>(), It.IsAny<string>())).Returns(usuarioRetornado);

            LoginViewModel dadosUsuario = new LoginViewModel();
            dadosUsuario.email = "carlos@testeok.com";
            dadosUsuario.senha = "carlosok";

            var controller = new LoginController(repositoryEspelhado.Object);
            string issuerValido = "chapter.webapi";


            //A��o - Act

            OkObjectResult resultado = (OkObjectResult)controller.Login(dadosUsuario);

            string tokenString = resultado.Value!.ToString()!.Split(' ')[3];

            var jwtHandler = new JwtSecurityTokenHandler();

            var tokenJwt = jwtHandler.ReadJwtToken(tokenString);


            //Verifica��o - Assert
            Assert.Equal(issuerValido, tokenJwt.Issuer);
        }
    }
}