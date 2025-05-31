using MercadoConsole_POO.Services;

ProdutoService service = new ProdutoService();
bool continuar = true;

while (continuar)
{
    Console.Clear();
    Console.WriteLine("=== Sistema de Mercado ===");
    Console.WriteLine("1. Listar Produtos");
    Console.WriteLine("2. Adicionar Produto");
    Console.WriteLine("3. Atualizar Produto");
    Console.WriteLine("4. Excluir Produto");
    Console.WriteLine("5. Sair");
    Console.WriteLine("Opção: ");

    string opcao  = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            service.ListarProdutos();
            break;
        case "2":
            service.AdcionarProduto();
            break;
        case "3":
            service.AtualizarProduto();
            break;
        case "4":
            service.ExcluirProduto();
            break;
        case "5":
            continuar = false;
            break;
        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }
}