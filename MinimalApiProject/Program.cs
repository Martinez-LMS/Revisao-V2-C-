using MinimalApiProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Security.Cryptography;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDataContext>();
var app = builder.Build();

app.MapGet("/", ()=> "Revisao");

app.MapPost("/api/funcionario/cadastrar", ([FromBody] Funcionario funcioanrio, [FromServices] AppDataContext ctx) =>
{
    ctx.Funcionarios.Add(funcioanrio);
    ctx.SaveChanges();
    return Results.Created($"/produto/{funcioanrio.Id}", funcioanrio);
});

app.MapGet("/api/funcionario/listar", ([FromServices] AppDataContext ctx) => {

    return Results.Ok(ctx.Funcionarios.ToList());
});

app.MapPost("/api/folha/cadastrar",([FromBody] Folha folha, [FromServices] AppDataContext ctx) =>
{
    Funcionario? funcionario = ctx.Funcionarios.Find(folha.FuncionarioId);

    if (funcionario is null)
    {
        return Results.NotFound("Funcionario nao encontrado");   
    }
    folha.Funcionario = funcionario; 

    //calcular salario bruto
    folha.SalarioBruto = folha.Quantidade * folha.Valor;

    if(folha.SalarioBruto <= 1903.98){
    folha.ImpostoIRRF = 0;
} else if (folha.SalarioBruto >= 1903.99 && folha.SalarioBruto <= 2826.65) {
    folha.ImpostoIRRF = (folha.SalarioBruto * 0.075) - 142.80;
} else if (folha.SalarioBruto >= 2826.66 && folha.SalarioBruto <= 3751.05) {
    folha.ImpostoIRRF = (folha.SalarioBruto * 0.15) - 354.80;
} else if (folha.SalarioBruto >= 3751.06 && folha.SalarioBruto <= 4664.68) {
    folha.ImpostoIRRF = (folha.SalarioBruto * 0.225) - 636.13;
} else if (folha.SalarioBruto > 4664.68) {
    folha.ImpostoIRRF = (folha.SalarioBruto * 0.275) - 869.36;
}

 // calcular o INSS

 // Calculando o desconto do INSS
if (folha.SalarioBruto <= 1693.72) {
    folha.ImpostoINSS = folha.SalarioBruto * 0.08;  // 8% de desconto para salários até 1693.72 em 2024
} else if (folha.SalarioBruto <= 1100.00) {
    folha.ImpostoINSS = folha.SalarioBruto * 0.075;
} else if (folha.SalarioBruto <= 2203.48) {
    folha.ImpostoINSS = folha.SalarioBruto * 0.09;
} else if (folha.SalarioBruto <= 3305.22) {
    folha.ImpostoINSS = folha.SalarioBruto * 0.12;
} else if (folha.SalarioBruto <= 6433.57) {
    folha.ImpostoINSS = folha.SalarioBruto * 0.14;
} else {
    folha.ImpostoINSS = 6433.57 * 0.14;  // Para salários acima do teto do INSS em 2024
}

// calcular fgts

    folha.ImpostoFGTS = folha.ImpostoFGTS * .08;

    //calcular salario liquido
    folha.SalarioLiquido = folha.SalarioBruto - folha.ImpostoIRRF - folha.ImpostoINSS;


    ctx.Folhas.Add(folha);
    ctx.SaveChanges();
    return Results.Created($"/folha/{folha.Id}", folha);
});

app.MapGet("/api/folha/listar", ([FromServices] AppDataContext ctx) => {

    return Results.Ok(ctx.Folhas.Include(x => x.Funcionario).ToList());
});

app.MapGet("/api/folha/buscar/{mes}/{ano}", ([FromServices] AppDataContext ctx,[FromRoute] int mes, [FromRoute] int ano) => 
{
    Folha? folha = ctx.Folhas.Include(x => x.Funcionario).FirstOrDefault(f => f.Funcionario.Id == id && f.Mes == mes && f.Ano == ano);

    if (folha is null)
    {
        return Results.NotFound();
    }
    return Results.Ok(folha);
});
app.Run();


