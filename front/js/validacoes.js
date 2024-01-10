function verificaSeOChutePossuiUmValorValido(chute){
    const numero = +chute

    if(VerificaValor(numero)){
        elementoChute.innerHTML += '<div>Valor inválido</div>'
        return
    }
    if(numeroForMaiorOuMenorQueOPermitido(numero)){
        elementoChute.innerHTML += "valor inválido: número precisa ser entre ${menorValor} e ${maiorValor}"
        return
    }
    if(numero == numeroSorteado){
        document.body.innerHTML = `
                                    <h2>Você Acertou!</h2>
                                    <h3>O número era ${numeroSorteado}, parabéns!</h3>
                                    <button id="btn-jogar" class="btn-jogar">Jogar novamente</button>
        `
    }else if(numeroSorteado == "Game Over"){
        document.body.innerHTML = `<h2>Fim de Jogo!</h2>
        <h3>Obrigado por jogar!</h3>
        <button id="btn-jogar" class="btn-jogar">Jogar novamente</button>
`
    }
    else if(numero > numeroSorteado){
        elementoChute.innerHTML += `<div>O número secreto é menor <i class="fa-solid fa-arrow-down-wide-short"></i></div>`
    }else{
        elementoChute.innerHTML += `<div>O número secreto é maior <i class="fa-solid fa-arrow-up-wide-short"></i></div>`
    }
}

function numeroForMaiorOuMenorQueOPermitido(numero) {
    return numero > maiorValor || numero < menorValor
}

function VerificaValor(numero) {
    return Number.isNaN(numero)
}

document.body.addEventListener('click', e => {
    if(e.target.id == 'btn-jogar'){
        window.location.reload()
    }
})

