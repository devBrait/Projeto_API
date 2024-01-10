const menorValor = 1
const maiorValor = 100
const numeroSorteado = gerarNumero()
const elementoMenorValor = document.getElementById('menor-valor')
const elementoMaiorValor = document.getElementById('maior-valor')


function gerarNumero(){
    return parseInt(Math.random() * maiorValor + 1)
}

console.log(numeroSorteado)

elementoMenorValor.innerHTML = menorValor
elementoMaiorValor.innerHTML = maiorValor
