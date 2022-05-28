/*
Criar uma lista de cadastro de alunos

Percorrrer a lista e:
    - se o número for par, escreva par e o número correspondente
    - se o número for ímpar, escreva ímpar e o número correspondente
    - se o número for 0, escreva zero
*/

// Boa referência https://www.geeksforgeeks.org/ways-iterating-array-javascript/

let alunos = [
    "Carlos",
    "Eduardo",
    "Miranda"
]

// console.log("Iteração usando For")
// for ( let index = 0; index < alunos.length; index++)
// {       
//     if (index==0)
//     {
//         console.log(`O número atual é ${index}`)
//     }
//     else if (index%2!=0){
//         console.log(`O número é ${index} é ímpar`)
//     }
//     else
//     {
//         console.log(`O número é ${index} é par`)
//     }
// }

// console.log("Iteração usando While")
// let index = 0
// while (index < alunos.length)
// {  
//     if (index==0)
//     {
//         console.log(`O número atual é ${index}`)
//     }
//     else if (index%2!=0){
//         console.log(`O número é ${index} é ímpar`)
//     }
//     else
//     {
//         console.log(`O número é ${index} é par`)
//     }
//     index++;
// }


// console.log("Iteração usando Do While")
// let index = 0
// do
// {  
//     if (index==0)
//     {
//         console.log(`O número atual é ${index}`)
//     }
//     else if (index%2!=0){
//         console.log(`O número é ${index} é ímpar`)
//     }
//     else
//     {
//         console.log(`O número é ${index} é par`)
//     }
//     index++;
// }
// while (index < alunos.length)

// console.log("Iteração usando For of")
// for (const aluno of alunos) {
//     index = alunos.indexOf(aluno)
//     console.log(`Esta pessoa se chama ${aluno}`)
//     if (index==0)
//     {
//         console.log(`O número atual é ${index}`)
//     }
//     else if (index%2!=0){
//         console.log(`O número é ${index} é ímpar`)
//     }
//     else
//     {
//         console.log(`O número é ${index} é par`)
//     }
// }

// console.log("Iteração usando For Each")
// alunos.forEach(aluno => {
//     index = alunos.indexOf(aluno)
//     console.log(`Esta pessoa se chama ${aluno}`)
//     if (index==0)
//     {
//         console.log(`O número atual é ${index}`)
//     }
//     else if (index%2!=0){
//         console.log(`O número é ${index} é ímpar`)
//     }
//     else
//     {
//         console.log(`O número é ${index} é par`)
//     }
// });
