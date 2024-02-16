namespace Api.Domain.Responses;

public static class StockResponse
{
    // Respostas de criação. 
    public const string CreateAlreadyExistsWithCode = "Já existe ação cadastrada com este código.";
    public const string CreateDontExistsWithCode = "Não existe ação cadastrada com este código.";
    public const string Created = "Ação cadastrada com sucesso.";
    public const string CreateFail = "Por conta de um erro interno no servidor, não foi possivel cadastrar a ação.";
    
    // Respostas de consulta.
    public const string ReadDontExistsWithCode = "Não existe ação cadastrada com este código.";
    public const string ReadFilterNotFound = "Não foi encontrada nenhuma ação, tente substituir os filtros.";
    public const string Read = "Ação/Ações consultada(s) com sucesso.";
    public const string ReadFail = "Por conta de um erro interno no servidor, não foi possivel acessar as ações cadastradas.";
    public const string ReadDontExistsAny = "Não existe nenhuma ação cadastrada.";
    
    // Respostas de alteração.
    public const string AlterDifferentBodyId = "Os ids de parametro e corpo da requisição devem ser os mesmos.";
    public const string AlterFail = "Por conta de um erro interno no servidor, não foi possivel alterar a ação.";
    public const string Altered = "Alterado com sucesso.";
    
    // Respostas de remoção.
    public const string Deleted = "Ação deletada com sucesso.";
    public const string DeleteFail = "Por conta de um erro interno no servidor, não foi possivel deletar a ação.";
    public const string DeleteDontExists = "Não é possivel deletar uma ação não cadastrada.";
    
    // Erro na requisição 
    public const string BadRequest = "Há algo de errado na requisição.";
}