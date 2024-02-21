namespace Api.Domain.Responses;

public static class CostumerResponses
{
    // Respostas de Login
    public const string Connected = "Logado com sucesso.";
    public const string ConnectFail = "Por conta de um erro interno no servidor, não foi possivel fazer login.";
    public const string CostumerNotFound = "Combinação de úsuario e senha não encontrada.";
    
    // Respostas de Registro
    public const string Registered = "Registrado com sucesso.";
    public const string RegisterFail = "Por conta de um erro interno no servidor, não foi possivel fazer o cadastro do usuário.";

    // Respostas Lista de Usuarios
    public const string Read = "Não existe nenhum usuário cadastrada.";
    public const string ReadFilterNotFound = "Não foi encontrada nenhuma ação, tente substituir os filtros.";
    public const string ReadDontExistsAny = "Não existe nenhum usuário cadastrada.";
    
    // Erro na requisição 
    public const string BadRequest = "Há algo de errado na requisição.";
    public const string AlreadyExistsWithCostumerName = "Já existe usuário com este nome de usuário.";
    public const string AlreadyExistsWithEmail = "Já existe usuário com este nome de usuário.";

}