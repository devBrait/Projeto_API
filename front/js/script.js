const menorValor = 1
const maiorValor = 1000
const numeroSorteado = gerarNumero()


function gerarNumero(){
    return parseInt(Math.random() * maiorValor + 1)
}

console.log(numeroSorteado)

const elementoMenorValor = document.getElementById('menor-valor')
elementoMenorValor.innerHTML = menorValor
const elementoMaiorValor = document.getElementById('maior-valor')
elementoMaiorValor.innerHTML = maiorValor
