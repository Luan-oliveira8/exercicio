
Produto[] produtos = new Produto[999];

menu(produtos);

static void menu(Produto[] produtos)
{
    int SelecaoMenu;
    Console.WriteLine("___________________________________");
    Console.WriteLine("| Digite 1 para cadastrar produto |");
    Console.WriteLine("| Digite 2 para Consultar produto |");
    Console.WriteLine("| Digite 3 para alterar produto   |");
    Console.WriteLine("| Digite 4 para excluir produto   |");
    Console.WriteLine("|_________________________________|");
    SelecaoMenu = Convert.ToInt32(Console.ReadLine());
    if (SelecaoMenu == 1)
    {
        CadastraProduto(produtos);
    }
    if (SelecaoMenu == 2)
    {
        ConssultaProduto(produtos);
    }
    if (SelecaoMenu == 3)
    {
        AlteraProdutos(produtos);
    }
    if (SelecaoMenu == 4)
    {
        ExcluirProduto(produtos);
    }
    else
    {
        Console.WriteLine("Numero inserido incorreto");
        menu(produtos);
    }
}
static void CadastraProduto(Produto[] produtos)
{
    int select = 9;
    select = VerificaIndice(produtos, select);
    produtos[select] = new Produto();
    Console.WriteLine("Insira nome do produto");
    produtos[select].Nome = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Insira ID do produto");
    produtos[select].Id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Insira valor do produto");
    produtos[select].Valor = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Insira nome do fornecedor");
    produtos[select].Fornecedor = Convert.ToString(Console.ReadLine());
    Console.WriteLine(" Nome do produto {0}. \n ID do produto {1}. \n Valor do produto{2}. \n Forcenecor do produto {3}. \n", produtos[select].Nome, produtos[select].Id, produtos[select].Valor, produtos[select].Fornecedor);
    menu(produtos);
}
static int VerificaIndice(Produto[] produtos, int select)
{

    for (int i = 0; i < produtos.Length; i++)
    {
        if (produtos[i] == null)
        {
            select = i;
            break;
        }
        else
        {
            Console.WriteLine("Estoque cheio");
            menu(produtos);
        }
    }
    return select;
}
static void ConssultaProduto(Produto[] produtos)
{
    int ProcuraId;
    Console.WriteLine(" Nome do produto {0}.", produtos[0].Nome);
    Console.WriteLine("Digite ID do produto que seja consultar");
    ProcuraId = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < produtos.Length; i++)
    {
        Console.WriteLine(produtos[i].Id);
        if (produtos[i].Id == ProcuraId)
        {
            Console.WriteLine(" Nome do produto {0}. \n ID do produto {1}. \n Valor do produto{2}. \n Forcenecor do produto {3}. \n", produtos[i].Nome, produtos[i].Id, produtos[i].Valor, produtos[i].Fornecedor);
            menu(produtos);
        }
    }
}
static void AlteraProdutos(Produto[] produtos)
{
    int SalvaId = -1;
    for (int i = 0; i < produtos.Length; i++)
    {
        if (SalvaId == produtos[i].Id)
        {
            SalvaId = i;
            break;
        }
    }
    if (SalvaId == -1)
    {
        Console.WriteLine("ID inserido e invalido");
        menu(produtos);
    }
    int SelecaoAlteraProduto;
    Console.WriteLine("___________________________________________");
    Console.WriteLine("|Digite 1 para alterar nome produto       |");
    Console.WriteLine("|Digite 2 para alterar ID produto         |");
    Console.WriteLine("|Digite 3 para alterar valor produto      |");
    Console.WriteLine("|Digite 4 para alterar fornecedor produto |");
    Console.WriteLine("|_________________________________________|");
    SelecaoAlteraProduto = Convert.ToInt32(Console.ReadLine());
    if (SelecaoAlteraProduto == 1)
    {
        AlteraNomeProduto(produtos, SalvaId);
    }
    if (SelecaoAlteraProduto == 2)
    {
        AlteraIdProduto(produtos, SalvaId);
    }
    if (SelecaoAlteraProduto == 3)
    {
        AlteraValorProduto(produtos, SalvaId);
    }
    if (SelecaoAlteraProduto == 4)
    {
        AlteraFornecedorProduto(produtos, SalvaId);
    }
    else
    {
        Console.WriteLine("Numero inserido incorreto");
        menu(produtos);
    }
}
static void AlteraNomeProduto(Produto[] produtos, int SalvaId)
{
    string NomeTemporario;
    Console.WriteLine("Nome do produto que voce deseja alterar e : {0}", produtos[SalvaId].Nome);
    Console.WriteLine("Digite o novo nome do produto");
    NomeTemporario = Convert.ToString(Console.ReadLine());
    produtos[SalvaId].Nome = NomeTemporario;
    menu(produtos);
}
static void AlteraIdProduto(Produto[] produtos, int SalvaId)
{
    int IDTemp;
    Console.WriteLine("ID do produto que voce deseja alterar e : {0}", produtos[SalvaId].Id);
    Console.WriteLine("Digite o novo ID do produto");
    IDTemp = Convert.ToInt32(Console.ReadLine());
    produtos[SalvaId].Id = IDTemp;
    menu(produtos);
}
static void AlteraValorProduto(Produto[] produtos, int SalvaId)
{
    double ValorTemp;
    Console.WriteLine("Valor do produto que voce deseja alterar e : {0}", produtos[SalvaId].Valor);
    Console.WriteLine("Digite o novo ID do produto");
    ValorTemp = Convert.ToDouble(Console.ReadLine());
    produtos[SalvaId].Valor = ValorTemp;
    menu(produtos);
}
static void AlteraFornecedorProduto(Produto[] produtos, int SalvaId)
{
    string FornecedorTemp;
    Console.WriteLine("Valor do produto que voce deseja alterar e : {0}", produtos[SalvaId].Fornecedor);
    Console.WriteLine("Digite o novo ID do produto");
    FornecedorTemp = Convert.ToString(Console.ReadLine());
    produtos[SalvaId].Fornecedor = FornecedorTemp;
    menu(produtos);
}
static void ExcluirProduto(Produto[] produtos)
{
    int IndiceRemovedor = -1;
    int ConfirmaRemocao;
    Console.WriteLine("insira Id do produto que deseja remover");
    for (int i = 0; i < produtos.Length; i++)
    {
        if (produtos[i].Id == IndiceRemovedor)
        {
            IndiceRemovedor = i;
            break;
        }
    }
    if(IndiceRemovedor == -1)
    {
        Console.WriteLine("Id do produto a ser removido está incorreto");
        menu(produtos);
    }
    Console.WriteLine(" Nome do produto  que deseja remover é: {0}. \n ID do produto a ser removido {1}. \n Valor do produto a ser removido{2}. \n Forcenecor do produto a ser removido {3}. \n", produtos[IndiceRemovedor].Nome, produtos[IndiceRemovedor].Id, produtos[IndiceRemovedor].Valor, produtos[IndiceRemovedor].Fornecedor);
    Console.WriteLine("deseja realmente remover o produto digite 1 para sim e 2 para nao");
    ConfirmaRemocao = Convert.ToInt32(Console.ReadLine());
    if( ConfirmaRemocao == 1 )
    {
        produtos[IndiceRemovedor] = null;
    }
    else
    {
        menu(produtos);
    }
    menu(produtos);
}





