let listaDePecas = ["Filtro de Ar", "Motor", "Disco de Freio"]

if (listaDePecas.length < 10)
{
    console.log("É possível cadastrar mais peças!!!")
}
else{
    console.log("Capacidade insuficiente, não é possível cadastrar")
}

let peso = 50

if(peso < 100)
{
    console.log("A peça deve pesar no mínimo 100g")
}
else
{
    console.log("A peça possui o peso adequado")
}

let nomePeca = "Disco de Freio"

/*
if(nomePeca.length >= 3)
{
console.log("Nome da peça adequado para o cadastro.")
}
else if(nomePeca.length ==0)
{
console.log("Nome da peça não pode ser vazio")
}
else
{
    console.log("O nome deve ter ao menos 3 caracteres para ser cadastrado.")
}
*/

switch (nomePeca.length) {
    case 0:
        console.log("Nome da peça não pode ser vazio")
        break;
    case 1:
    case 2:
        console.log("O nome deve ter ao menos 3 caracteres para ser cadastrado.")
        break;
        default:
        console.log("Nome da peça adequado para o cadastro.")
        break;
}