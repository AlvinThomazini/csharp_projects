using System.Reflection;
using System.Text;
using System.Text.Unicode;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController] //anotation que indica que é uma controller de API
[Route("[controller]")] //Rota base ex.: http://localhost:500/Dados
public class DadosController : ControllerBase //Herda de ControllerBase
{
    //EXEMPLO!!
    private static List<Usuario> _usuarios = new();

    //Métodos HTTP
    [HttpGet("get")] //Rota -> http://localhost:500/Dados/teste
    public string GetDados()
    {
        return "Pede dados (ex: ver uma lista de produtos)";
    }

    /* 
     *  Tarefa: Voltar a estudar HTTP => Entender o Body, Header
     *          Entender form-data vs JSON Body
     *          
     *          - O que é um JSON? Para que é utilizado? Como escrever um JSON?
     *          
     *          - Entender como receber uma informação (parâmetros) na request HTTP 
     *              - Body JSON => Criação de um objeto (UserDto)
     *              - Request vs Response
     *              
     *  Exercício: Fazer uma controller nova, ("CarController")
     *                  - Deve ter: 
     *                      - Endpoint para cadastrar um carro.
     *                      - Endpoint para buscar um carro.
     *                      - Endpoint para atualizar a informação de um carro.
     *                      - Endpoint para deletar um carro.
     *                      
     *                      * Para armazenar as informações dos carros, utilize uma propriedade dentro da controller do tipo "public static List<...>"
     */

    //Suponha que é um cadastro de usuário
    [HttpPost("User")] //http://localhost:500/dados/user
    public ActionResult<UsuarioDto> EnviarDados([FromBody] UsuarioDto userDto) //Parâmetro de entrada
    {
        Usuario user = new Usuario(userDto.Name, userDto.Age, userDto.Password);

        //ESTOU ADICIONANDO NA MINHA LISTA O USUARIO, OU SEJA, A INFORMAÇÃO ESTÁ EM MEMÓRIA
        //AO REINICIAR A APLICAÇÂO A MEMÓRIA UTILIZADA SERÁ DISPOSED
        //OU SEJA, A LISTA SERÁ REINICIADA (LIMPA)
        _usuarios.Add(user);

        //Saída, ou seja, a resposta que iremos retornar no fim do fluxo
        return new UsuarioDto()
        {
            Name = user.Name,
            Age = user.Age,
            Password = user.GetPassword()
        };
    }

    [HttpDelete("delete")]
    public string DeleteDados()
    {
        return " Apaga um recurso";
    }

    [HttpPut("put")]
    public string PutDados()
    {
        return "Atualiza dados existentes";
    }

    [HttpPatch("patch")]
    public string PatchDados()
    {
        return "Atualiza parcialmente um recurso";
    }

    //DTO => Data Transfer Object
    public class UsuarioDto
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public int Age { get; set; }
    }

    //Modelo
    public class Usuario
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        private string _password;

        public string GetPassword()
        {
            byte[] bytes = Encoding.UTF8.GetBytes(_password);
            return Convert.ToBase64String(bytes);
        }

        public Usuario(string name, int age, string password)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Age = age;
            _password = password;
        }
    }
}