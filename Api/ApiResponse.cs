// using Api.Domain.Entities;

// namespace Api;

// public interface IApiResponse
// {
//     string? Message { get; }
// }

// // Create: Acoes
// public class StockCreationResponse : IApiResponse
// {
//     public string Message { get; } = "Ação cadastrada com sucesso.";
// }

// public class FailStockCreationResponse : IApiResponse
// {
//     public string Message { get; } = "Não foi possível cadastrar a ação devido a uma falha.";
// }

// // Read: Acoes
// public class StockListResponse : IApiResponse
// {
//     public string? Message { get; } = null;
//     public IList<Stock> Result { get; set; }
// }

// public class StockListIsEmpytResponse : IApiResponse
// {
//     public string Message { get; } = "Ainda não foi cadastrada nenhuma ação, use a rota '/CadastrarAcao' para cadastrar uma ação.";
// }

// public class FailStockListResponse : IApiResponse
// {
//     public string Message { get; } = "Houve um erro na exibição das Ações";
// }

// // Update: Acoes
// public class StockUpdatedResponse : IApiResponse
// {
//     public string Message { get; } = "Ação atualizada com sucesso.";
// }

// public class FailStockUpdateResponse : IApiResponse
// {
//     public string Message { get; } = "Houve um erro na atualização das Ações";
// }

// // Delete: Acoes
// public class StockDeletionResponse : IApiResponse
// {
//     public string Message { get; } = "Ação deletado com sucesso.";
// }

// public class FailStockDeletionResponse : IApiResponse
// {
//     public string Message { get; } = "Ação deletado com sucesso.";
// }
