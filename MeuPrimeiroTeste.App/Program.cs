Console.WriteLine("Hello, World!");

public class HelloWorldService
{
	public string GerarSaudacao(string? nome)
	{
		if (string.IsNullOrEmpty(nome))
		{
			return "Olá, Mundo!";
		}

		return $"Olá, {nome}!";
	}
}
